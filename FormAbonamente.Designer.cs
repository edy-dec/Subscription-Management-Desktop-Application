namespace Proiect_Practica
{
    partial class FormAbonamente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxCautare = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonIncarcaFisier = new System.Windows.Forms.Button();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSterge = new System.Windows.Forms.Button();
            this.chartStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartReviste = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxSortare = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartReviste)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(227, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(815, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxCautare
            // 
            this.textBoxCautare.Location = new System.Drawing.Point(49, 48);
            this.textBoxCautare.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCautare.Name = "textBoxCautare";
            this.textBoxCautare.Size = new System.Drawing.Size(160, 22);
            this.textBoxCautare.TabIndex = 1;
            this.textBoxCautare.TextChanged += new System.EventHandler(this.textBoxCautare_TextChanged);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(49, 179);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(160, 24);
            this.comboBoxStatus.TabIndex = 2;
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.ForeColor = System.Drawing.Color.White;
            this.buttonExport.Location = new System.Drawing.Point(49, 229);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(160, 28);
            this.buttonExport.TabIndex = 3;
            this.buttonExport.Text = "Export CSV";
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonIncarcaFisier
            // 
            this.buttonIncarcaFisier.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonIncarcaFisier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIncarcaFisier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIncarcaFisier.ForeColor = System.Drawing.Color.White;
            this.buttonIncarcaFisier.Location = new System.Drawing.Point(49, 292);
            this.buttonIncarcaFisier.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIncarcaFisier.Name = "buttonIncarcaFisier";
            this.buttonIncarcaFisier.Size = new System.Drawing.Size(161, 28);
            this.buttonIncarcaFisier.TabIndex = 4;
            this.buttonIncarcaFisier.Text = "Incarca Fisier";
            this.buttonIncarcaFisier.UseVisualStyleBackColor = false;
            this.buttonIncarcaFisier.Click += new System.EventHandler(this.buttonIncarcaFisier_Click);
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonAdauga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdauga.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdauga.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonAdauga.Location = new System.Drawing.Point(49, 349);
            this.buttonAdauga.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(161, 28);
            this.buttonAdauga.TabIndex = 5;
            this.buttonAdauga.Text = "Adauga Abonament";
            this.buttonAdauga.UseVisualStyleBackColor = false;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cautare revista:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonSterge
            // 
            this.buttonSterge.BackColor = System.Drawing.Color.Firebrick;
            this.buttonSterge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSterge.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.buttonSterge.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonSterge.Location = new System.Drawing.Point(49, 396);
            this.buttonSterge.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(123, 28);
            this.buttonSterge.TabIndex = 8;
            this.buttonSterge.Text = "Sterge Abonament";
            this.buttonSterge.UseVisualStyleBackColor = false;
            this.buttonSterge.Click += new System.EventHandler(this.buttonSterge_Click);
            // 
            // chartStatus
            // 
            chartArea3.Name = "ChartArea1";
            this.chartStatus.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartStatus.Legends.Add(legend3);
            this.chartStatus.Location = new System.Drawing.Point(227, 229);
            this.chartStatus.Name = "chartStatus";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartStatus.Series.Add(series3);
            this.chartStatus.Size = new System.Drawing.Size(289, 286);
            this.chartStatus.TabIndex = 9;
            this.chartStatus.Text = "chart1";
            this.chartStatus.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chartReviste
            // 
            chartArea4.Name = "ChartArea1";
            this.chartReviste.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartReviste.Legends.Add(legend4);
            this.chartReviste.Location = new System.Drawing.Point(546, 229);
            this.chartReviste.Name = "chartReviste";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartReviste.Series.Add(series4);
            this.chartReviste.Size = new System.Drawing.Size(496, 286);
            this.chartReviste.TabIndex = 10;
            this.chartReviste.Text = "chart1";
            this.chartReviste.Click += new System.EventHandler(this.chartReviste_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(166, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "↩️";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxSortare
            // 
            this.comboBoxSortare.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBoxSortare.BackColor = System.Drawing.Color.AliceBlue;
            this.comboBoxSortare.Enabled = false;
            this.comboBoxSortare.ForeColor = System.Drawing.Color.AliceBlue;
            this.comboBoxSortare.FormattingEnabled = true;
            this.comboBoxSortare.Location = new System.Drawing.Point(1049, 28);
            this.comboBoxSortare.Name = "comboBoxSortare";
            this.comboBoxSortare.Size = new System.Drawing.Size(10, 24);
            this.comboBoxSortare.TabIndex = 12;
            this.comboBoxSortare.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortare_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Filtre:";
            // 
            // FormAbonamente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1122, 553);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSortare);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chartReviste);
            this.Controls.Add(this.chartStatus);
            this.Controls.Add(this.buttonSterge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdauga);
            this.Controls.Add(this.buttonIncarcaFisier);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.textBoxCautare);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAbonamente";
            this.Text = "MEDICHUB Gestionare";
            this.Load += new System.EventHandler(this.FormAbonamente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartReviste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxCautare;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonIncarcaFisier;
        private System.Windows.Forms.Button buttonAdauga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSterge;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatus;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReviste;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxSortare;
        private System.Windows.Forms.Label label3;
    }
}