using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Proiect_Practica
{
    public partial class FormPrincipal : Form
    {
        private Button buttonEnter;

        public FormPrincipal()
        {
            InitializeComponent();
            this.Icon = new Icon("medichub-tab.ico");
            this.BackColor = Color.LightSteelBlue;
            this.ClientSize = new Size(600, 400);

            // Etichetă titlu
            Label lblTitlu = new Label();
            lblTitlu.Text = "Gestionare Abonamente";
            lblTitlu.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitlu.ForeColor = Color.Navy;
            lblTitlu.AutoSize = true;
            lblTitlu.Location = new Point((this.ClientSize.Width - 300) / 2, 20);
            lblTitlu.Anchor = AnchorStyles.Top;
            this.Controls.Add(lblTitlu);

            // Imagine logo
            PictureBox pictureBoxLogo = new PictureBox();
            pictureBoxLogo.Image = Image.FromFile("logo.jpeg"); // Asigură-te că fișierul există în folderul .exe
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.Size = new Size(200, 100);
            pictureBoxLogo.Location = new Point((this.ClientSize.Width - 200) / 2, 60);
            pictureBoxLogo.Anchor = AnchorStyles.Top;
            this.Controls.Add(pictureBoxLogo);

            // Buton "Enter"
            buttonEnter = new Button();
            buttonEnter.Text = "ENTER";
            buttonEnter.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonEnter.BackColor = Color.SteelBlue;
            buttonEnter.ForeColor = Color.White;
            buttonEnter.FlatStyle = FlatStyle.Flat;
            buttonEnter.FlatAppearance.BorderSize = 0;
            buttonEnter.Size = new Size(200, 45);
            buttonEnter.Location = new Point((this.ClientSize.Width - 200) / 2, this.ClientSize.Height - 90);
            buttonEnter.Anchor = AnchorStyles.Bottom;

            // Efect hover
            buttonEnter.MouseEnter += (s, e) => buttonEnter.BackColor = Color.DodgerBlue;
            buttonEnter.MouseLeave += (s, e) => buttonEnter.BackColor = Color.SteelBlue;

            // Efect colțuri rotunjite
            buttonEnter.Paint += (s, e) =>
            {
                GraphicsPath path = new GraphicsPath();
                int radius = 20;
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(buttonEnter.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(buttonEnter.Width - radius, buttonEnter.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, buttonEnter.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();
                buttonEnter.Region = new Region(path);
            };

            buttonEnter.Click += btnAbonamente_Click; // leagă butonul de handlerul existent

            this.Controls.Add(buttonEnter);
        }

        private void btnAbonamente_Click(object sender, EventArgs e)
        {
            FormAbonamente f = new FormAbonamente();
            f.Show();
            this.Hide(); // 🔹 ascunde FormPrincipal
            f.FormClosed += (s, args) => this.Close(); // 🔸 închide complet când se închide FormAbonamente
        }


        private void FormPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
