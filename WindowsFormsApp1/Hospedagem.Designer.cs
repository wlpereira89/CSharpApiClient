namespace WindowsFormsApp1
{
    partial class Hospedagem
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
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.BtnConfirma = new System.Windows.Forms.Button();
            this.EditDataSaida = new System.Windows.Forms.DateTimePicker();
            this.EditDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.EditMenores = new System.Windows.Forms.NumericUpDown();
            this.EditMaiores = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelParametro = new System.Windows.Forms.Label();
            this.SelSoIda = new System.Windows.Forms.RadioButton();
            this.SelCdd = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnListar = new System.Windows.Forms.Button();
            this.EditParametro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.EditMenores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditMaiores)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(318, 158);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(75, 23);
            this.BtnVoltar.TabIndex = 10;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // BtnConfirma
            // 
            this.BtnConfirma.Location = new System.Drawing.Point(69, 158);
            this.BtnConfirma.Name = "BtnConfirma";
            this.BtnConfirma.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirma.TabIndex = 9;
            this.BtnConfirma.Text = "Ok";
            this.BtnConfirma.UseVisualStyleBackColor = true;
            this.BtnConfirma.Click += new System.EventHandler(this.BtnConfirma_Click);
            // 
            // EditDataSaida
            // 
            this.EditDataSaida.Location = new System.Drawing.Point(69, 90);
            this.EditDataSaida.Name = "EditDataSaida";
            this.EditDataSaida.Size = new System.Drawing.Size(324, 20);
            this.EditDataSaida.TabIndex = 6;
            // 
            // EditDataEntrada
            // 
            this.EditDataEntrada.Location = new System.Drawing.Point(69, 58);
            this.EditDataEntrada.Name = "EditDataEntrada";
            this.EditDataEntrada.Size = new System.Drawing.Size(324, 20);
            this.EditDataEntrada.TabIndex = 5;
            // 
            // EditMenores
            // 
            this.EditMenores.Location = new System.Drawing.Point(257, 118);
            this.EditMenores.Name = "EditMenores";
            this.EditMenores.Size = new System.Drawing.Size(39, 20);
            this.EditMenores.TabIndex = 8;
            // 
            // EditMaiores
            // 
            this.EditMaiores.Location = new System.Drawing.Point(97, 118);
            this.EditMaiores.Name = "EditMaiores";
            this.EditMaiores.Size = new System.Drawing.Size(47, 20);
            this.EditMaiores.TabIndex = 7;
            this.EditMaiores.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Menores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Maiores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Saida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Entrada";
            // 
            // labelParametro
            // 
            this.labelParametro.AutoSize = true;
            this.labelParametro.Location = new System.Drawing.Point(192, 15);
            this.labelParametro.Name = "labelParametro";
            this.labelParametro.Size = new System.Drawing.Size(55, 13);
            this.labelParametro.TabIndex = 0;
            this.labelParametro.Text = "Parâmetro";
            // 
            // SelSoIda
            // 
            this.SelSoIda.AutoSize = true;
            this.SelSoIda.Location = new System.Drawing.Point(89, 23);
            this.SelSoIda.Name = "SelSoIda";
            this.SelSoIda.Size = new System.Drawing.Size(81, 17);
            this.SelSoIda.TabIndex = 2;
            this.SelSoIda.Text = "Nome Hotel";
            this.SelSoIda.UseVisualStyleBackColor = true;
            // 
            // SelCdd
            // 
            this.SelCdd.AutoSize = true;
            this.SelCdd.Checked = true;
            this.SelCdd.Location = new System.Drawing.Point(25, 23);
            this.SelCdd.Name = "SelCdd";
            this.SelCdd.Size = new System.Drawing.Size(58, 17);
            this.SelCdd.TabIndex = 1;
            this.SelCdd.TabStop = true;
            this.SelCdd.Text = "Cidade";
            this.SelCdd.UseVisualStyleBackColor = true;
            this.SelCdd.CheckedChanged += new System.EventHandler(this.SelCdd_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Pesquisar por";
            // 
            // BtnListar
            // 
            this.BtnListar.Location = new System.Drawing.Point(195, 158);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(75, 23);
            this.BtnListar.TabIndex = 19;
            this.BtnListar.Text = "Listar Hoteis";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // EditParametro
            // 
            this.EditParametro.FormattingEnabled = true;
            this.EditParametro.Location = new System.Drawing.Point(257, 12);
            this.EditParametro.Name = "EditParametro";
            this.EditParametro.Size = new System.Drawing.Size(136, 21);
            this.EditParametro.TabIndex = 20;
            // 
            // Hospedagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 193);
            this.Controls.Add(this.EditParametro);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnConfirma);
            this.Controls.Add(this.EditDataSaida);
            this.Controls.Add(this.SelSoIda);
            this.Controls.Add(this.SelCdd);
            this.Controls.Add(this.EditDataEntrada);
            this.Controls.Add(this.EditMenores);
            this.Controls.Add(this.EditMaiores);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelParametro);
            this.Name = "Hospedagem";
            this.Text = "Hospedagem";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Hospedagem_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.EditMenores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditMaiores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button BtnConfirma;
        private System.Windows.Forms.DateTimePicker EditDataSaida;
        private System.Windows.Forms.DateTimePicker EditDataEntrada;
        private System.Windows.Forms.NumericUpDown EditMenores;
        private System.Windows.Forms.NumericUpDown EditMaiores;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelParametro;
        private System.Windows.Forms.RadioButton SelSoIda;
        private System.Windows.Forms.RadioButton SelCdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.ComboBox EditParametro;
    }
}