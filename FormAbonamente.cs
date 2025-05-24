using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proiect_Practica
{
    public partial class FormAbonamente : Form
    {
        private List<Abonament> abonamente = new List<Abonament>();
        private Stack<Abonament> stergeri = new Stack<Abonament>();

        public FormAbonamente()
        {
            InitializeComponent();
            this.Icon = new Icon("medichub-tab.ico");
            this.Text = "MEDICHUB Gestionare";

            comboBoxStatus.Items.AddRange(new string[] { "Toate", "Activ", "Inactiv" });
            comboBoxStatus.SelectedIndex = 0;

            textBoxCautare.TextChanged += (s, e) => Filtrare();
            comboBoxStatus.SelectedIndexChanged += (s, e) => Filtrare();

            this.comboBoxSortare = new System.Windows.Forms.ComboBox();
            this.comboBoxSortare.Items.AddRange(new object[] {
                "Cele mai noi",
                 "Cele mai vechi",
                "Data de început (descrescător)",
                 "Data de sfârșit (crescător)",
                 "Status: Activ",
                 "Status: Inactiv"
            });
            this.comboBoxSortare.SelectedIndex = 0;
            this.comboBoxSortare.Location = new System.Drawing.Point(36, 90); // Ajustează în funcție de layout
            this.comboBoxSortare.Size = new System.Drawing.Size(122, 24);
            this.comboBoxSortare.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxSortare.SelectedIndexChanged += (s, e) => AplicaFiltrareAvansata();
            this.Controls.Add(this.comboBoxSortare);
        }

        public void AdaugaAbonamentDirect(Abonament abonament)
        {
            abonamente.Add(abonament);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = abonamente;
            FormateazaHeaderTabel();
            ActualizeazaGrafic();
            ActualizeazaGraficReviste();
        }

        private void SalveazaDate()
        {
            AbonamentService.SalveazaInCSV("abonamente.csv", abonamente);
        }

        private void Filtrare()
        {
            string cauta = textBoxCautare.Text.ToLower();
            string status = comboBoxStatus.SelectedItem.ToString();

            var filtrate = abonamente.Where(a =>
                (status == "Toate" || a.Status.Equals(status, StringComparison.OrdinalIgnoreCase)) &&
                a.Revista.ToLower().Contains(cauta)).ToList();

            dataGridView1.DataSource = filtrate;
            FormateazaHeaderTabel();
        }

        private void ExportCSV()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Fișiere CSV (*.csv)|*.csv";
            sfd.Title = "Salvează abonamentele ca fișier CSV";
            sfd.FileName = "abonamente_export.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    sw.WriteLine("TipAbonament,TipPachet,Revista,Status,DataStart,DataEnd,OrderId,DataOrder,DinImport,UserId");
                    foreach (var a in abonamente)
                    {
                        sw.WriteLine($"{a.TipAbonament},{a.TipPachet},{a.Revista},{a.Status},{a.DataStart:yyyy-MM-dd},{a.DataEnd:yyyy-MM-dd},{a.OrderId},{a.DataOrder:yyyy-MM-dd HH:mm:ss},{a.DinImport},{a.UserId}");
                    }
                }
                MessageBox.Show("Fișierul CSV a fost salvat cu succes.", "Export reușit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonIncarcaFisier_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fișiere CSV (*.csv)|*.csv";
            ofd.Title = "Selectează fișierul CSV de abonamente";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string caleFisier = ofd.FileName;
                abonamente = AbonamentService.IncarcaDinCSV(caleFisier);
                dataGridView1.DataSource = abonamente;
                FormateazaHeaderTabel();
                ActualizeazaGrafic();
                ActualizeazaGraficReviste();

                MessageBox.Show($"S-au încărcat {abonamente.Count} abonamente din fișierul selectat.");
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            ExportCSV();
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            var f = new FormAdaugaAbonament();
            f.Owner = this;
            f.ShowDialog();
        }

        private void buttonSterge_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Abonament selectat = dataGridView1.CurrentRow.DataBoundItem as Abonament;
                if (selectat != null)
                {
                    stergeri.Push(selectat);
                    abonamente.Remove(selectat);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = abonamente;
                    FormateazaHeaderTabel();
                    ActualizeazaGrafic();
                    ActualizeazaGraficReviste();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stergeri.Count > 0)
            {
                var abonament = stergeri.Pop();
                abonamente.Add(abonament);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = abonamente;
                FormateazaHeaderTabel();
                ActualizeazaGrafic();
                ActualizeazaGraficReviste();
            }
            else
            {
                MessageBox.Show("Nu mai există acțiuni de Undo.");
            }
        }

        private void ActualizeazaGrafic()
        {
            int activ = abonamente.Count(a => a.Status == "Activ");
            int inactiv = abonamente.Count(a => a.Status == "Inactiv");

            chartStatus.Series.Clear();
            chartStatus.ChartAreas.Clear();
            chartStatus.Titles.Clear();

            chartStatus.Titles.Add("Distribuția abonamentelor pe status");

            ChartArea area = new ChartArea();
            chartStatus.ChartAreas.Add(area);

            Series serie = new Series("Status");
            serie.ChartType = SeriesChartType.Pie;
            serie.IsValueShownAsLabel = true;
            serie.Label = "#PERCENT{P1}";
            serie.LegendText = "#VALX";

            serie.Points.AddXY("Activ", activ);
            serie.Points.AddXY("Inactiv", inactiv);

            chartStatus.Series.Add(serie);
        }

        private void ActualizeazaGraficReviste()
        {
            var grupare = abonamente
                .GroupBy(a => a.Revista)
                .Select(g => new { Revista = g.Key, Nr = g.Count() })
                .OrderByDescending(x => x.Nr)
                .ToList();

            chartReviste.Series.Clear();
            chartReviste.ChartAreas.Clear();
            chartReviste.Titles.Clear();

            chartReviste.Titles.Add("Număr de abonamente pe revistă");

            ChartArea zona = new ChartArea();
            chartReviste.ChartAreas.Add(zona);

            Series s = new Series("Abonamente");
            s.ChartType = SeriesChartType.Column;
            s.IsValueShownAsLabel = true;
            s.Font = new Font("Segoe UI", 8F, FontStyle.Bold);

            foreach (var item in grupare)
            {
                s.Points.AddXY(item.Revista, item.Nr);
            }

            chartReviste.Series.Add(s);
        }

        private void FormateazaHeaderTabel()
        {
            if (dataGridView1.Columns.Count == 0) return;

            dataGridView1.Columns["TipAbonament"].HeaderText = "Tip Abonament";
            dataGridView1.Columns["TipPachet"].HeaderText = "Tip Pachet";
            dataGridView1.Columns["Revista"].HeaderText = "Revistă";
            dataGridView1.Columns["Status"].HeaderText = "Status";
            dataGridView1.Columns["DataStart"].HeaderText = "Data Început";
            dataGridView1.Columns["DataEnd"].HeaderText = "Data Sfârșit";
            dataGridView1.Columns["OrderId"].HeaderText = "Order ID";
            dataGridView1.Columns["DataOrder"].HeaderText = "Data Comandă";
            dataGridView1.Columns["DinImport"].HeaderText = "Importat";
            dataGridView1.Columns["UserId"].HeaderText = "User ID";
        }

        private void AplicaFiltrareAvansata()
        {
            IEnumerable<Abonament> filtrate = abonamente;

            string sortare = comboBoxSortare.SelectedItem.ToString();
            switch (sortare)
            {
                case "Cele mai noi":
                    filtrate = filtrate.OrderByDescending(a => a.DataOrder);
                    break;
                case "Cele mai vechi":
                    filtrate = filtrate.OrderBy(a => a.DataOrder);
                    break;
                case "Data de început (descrescător)":
                    filtrate = filtrate.OrderByDescending(a => a.DataStart);
                    break;
                case "Data de sfârșit (crescător)":
                    filtrate = filtrate.OrderBy(a => a.DataEnd);
                    break;
                case "Status: Activ":
                    filtrate = filtrate.Where(a => a.Status == "Activ");
                    break;
                case "Status: Inactiv":
                    filtrate = filtrate.Where(a => a.Status == "Inactiv");
                    break;
            }

            dataGridView1.DataSource = filtrate.ToList();
            FormateazaHeaderTabel();
        }


        private void FormAbonamente_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void textBoxCautare_TextChanged(object sender, EventArgs e) { }
        private void chart1_Click(object sender, EventArgs e) { }
        private void chartReviste_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSortare_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}