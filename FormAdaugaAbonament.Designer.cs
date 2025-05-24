namespace Proiect_Practica
{
    partial class FormAdaugaAbonament
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.comboBoxTipAbonament = new System.Windows.Forms.ComboBox();
            this.comboBoxPachet = new System.Windows.Forms.ComboBox();
            this.textBoxRevista = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.textBoxOrderId = new System.Windows.Forms.TextBox();
            this.dateTimePickerDataOrder = new System.Windows.Forms.DateTimePicker();
            this.comboBoxImport = new System.Windows.Forms.ComboBox();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(500, 550);
            this.Text = "Adaugă Abonament";

            int labelX = 30, inputX = 160, y = 30, spacing = 40;

            string[] etichete = {
                "Tip Abonament", "Tip Pachet", "Revista", "Status",
                "Data Start", "Data Sfârșit", "Order ID", "Data Order",
                "Din Import", "User ID"
            };

            for (int i = 0; i < etichete.Length; i++)
            {
                var lbl = new System.Windows.Forms.Label();
                lbl.Text = etichete[i] + ":";
                lbl.Location = new System.Drawing.Point(labelX, y + i * spacing);
                lbl.AutoSize = true;
                this.Controls.Add(lbl);
            }

            this.comboBoxTipAbonament.Location = new System.Drawing.Point(inputX, y + 0 * spacing);
            this.comboBoxPachet.Location = new System.Drawing.Point(inputX, y + 1 * spacing);
            this.textBoxRevista.Location = new System.Drawing.Point(inputX, y + 2 * spacing);
            this.comboBoxStatus.Location = new System.Drawing.Point(inputX, y + 3 * spacing);
            this.dateTimePickerStart.Location = new System.Drawing.Point(inputX, y + 4 * spacing);
            this.dateTimePickerEnd.Location = new System.Drawing.Point(inputX, y + 5 * spacing);
            this.textBoxOrderId.Location = new System.Drawing.Point(inputX, y + 6 * spacing);
            this.dateTimePickerDataOrder.Location = new System.Drawing.Point(inputX, y + 7 * spacing);
            this.comboBoxImport.Location = new System.Drawing.Point(inputX, y + 8 * spacing);
            this.textBoxUserId.Location = new System.Drawing.Point(inputX, y + 9 * spacing);

            System.Windows.Forms.Control[] inputs = {
                comboBoxTipAbonament, comboBoxPachet, textBoxRevista, comboBoxStatus,
                dateTimePickerStart, dateTimePickerEnd, textBoxOrderId,
                dateTimePickerDataOrder, comboBoxImport, textBoxUserId
            };

            foreach (var ctrl in inputs)
            {
                ctrl.Size = new System.Drawing.Size(250, 23);
                this.Controls.Add(ctrl);
            }

            this.comboBoxTipAbonament.Items.AddRange(new object[] { "Trial", "Standard", "Premium" });
            this.comboBoxPachet.Items.AddRange(new object[] { "Săptămânal", "Lunar", "Anual" });
            this.comboBoxStatus.Items.AddRange(new object[] { "Activ", "Inactiv" });
            this.comboBoxImport.Items.AddRange(new object[] { "Da", "Nu" });

            this.buttonOK.Text = "Confirmare";
            this.buttonCancel.Text = "Anulare";

            this.buttonOK.Location = new System.Drawing.Point(120, y + 10 * spacing + 10);
            this.buttonCancel.Location = new System.Drawing.Point(260, y + 10 * spacing + 10);
            this.buttonOK.Size = this.buttonCancel.Size = new System.Drawing.Size(100, 35);

            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);

            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTipAbonament;
        private System.Windows.Forms.ComboBox comboBoxPachet;
        private System.Windows.Forms.TextBox textBoxRevista;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.TextBox textBoxOrderId;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataOrder;
        private System.Windows.Forms.ComboBox comboBoxImport;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}