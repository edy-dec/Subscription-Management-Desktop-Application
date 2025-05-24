using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proiect_Practica
{
    public partial class FormAdaugaAbonament : Form
    {
        public FormAdaugaAbonament()
        {
            InitializeComponent();
            this.Icon = new Icon("medichub-tab.ico");

            comboBoxStatus.SelectedIndex = 0;
            comboBoxTipAbonament.SelectedIndex = 0;
            comboBoxPachet.SelectedIndex = 0;
            comboBoxImport.SelectedIndex = 0;
        }

        public Abonament AbonamentNou { get; private set; }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTipAbonament.SelectedIndex < 0 ||
                    comboBoxPachet.SelectedIndex < 0 ||
                    string.IsNullOrWhiteSpace(textBoxRevista.Text) ||
                    comboBoxStatus.SelectedIndex < 0 ||
                    string.IsNullOrWhiteSpace(textBoxOrderId.Text) ||
                    comboBoxImport.SelectedIndex < 0 ||
                    string.IsNullOrWhiteSpace(textBoxUserId.Text))
                {
                    MessageBox.Show("Te rugăm să completezi toate câmpurile.");
                    return;
                }

                if (!int.TryParse(textBoxOrderId.Text, out int orderId) ||
                    !int.TryParse(textBoxUserId.Text, out int userId))
                {
                    MessageBox.Show("Order ID și User ID trebuie să fie numere întregi.");
                    return;
                }

                if (dateTimePickerEnd.Value < dateTimePickerStart.Value)
                {
                    MessageBox.Show("Data de sfârșit nu poate fi înaintea datei de început.");
                    return;
                }

                AbonamentNou = new Abonament
                {
                    TipAbonament = comboBoxTipAbonament.SelectedItem.ToString(),
                    TipPachet = comboBoxPachet.SelectedItem.ToString(),
                    Revista = textBoxRevista.Text,
                    Status = comboBoxStatus.SelectedItem.ToString(),
                    DataStart = dateTimePickerStart.Value,
                    DataEnd = dateTimePickerEnd.Value,
                    OrderId = orderId,
                    DataOrder = dateTimePickerDataOrder.Value,
                    DinImport = comboBoxImport.SelectedItem.ToString(),
                    UserId = userId
                };

                ((FormAbonamente)this.Owner).AdaugaAbonamentDirect(AbonamentNou);
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare neașteptată: " + ex.Message);
            }
        }

        private void ResetForm()
        {
            comboBoxTipAbonament.SelectedIndex = 0;
            comboBoxPachet.SelectedIndex = 0;
            textBoxRevista.Clear();
            comboBoxStatus.SelectedIndex = 0;
            dateTimePickerStart.Value = DateTime.Today;
            dateTimePickerEnd.Value = DateTime.Today;
            textBoxOrderId.Clear();
            dateTimePickerDataOrder.Value = DateTime.Now;
            comboBoxImport.SelectedIndex = 0;
            textBoxUserId.Clear();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}