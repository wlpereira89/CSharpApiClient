namespace WindowsFormsApp1
{
    partial class Passagens
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Volta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EditMaiores = new System.Windows.Forms.NumericUpDown();
            this.EditMenores = new System.Windows.Forms.NumericUpDown();
            this.EditDtIda = new System.Windows.Forms.DateTimePicker();
            this.SelIdaVolta = new System.Windows.Forms.RadioButton();
            this.SelSoIda = new System.Windows.Forms.RadioButton();
            this.EditDtVolta = new System.Windows.Forms.DateTimePicker();
            this.EditOrigem = new System.Windows.Forms.TextBox();
            this.EditDestino = new System.Windows.Forms.TextBox();
            this.BtnConfirma = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.BtnListarVoos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EditMaiores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditMenores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Origem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ida";
            // 
            // Volta
            // 
            this.Volta.AutoSize = true;
            this.Volta.Location = new System.Drawing.Point(7, 106);
            this.Volta.Name = "Volta";
            this.Volta.Size = new System.Drawing.Size(31, 13);
            this.Volta.TabIndex = 3;
            this.Volta.Text = "Volta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Maiores";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Menores";
            // 
            // EditMaiores
            // 
            this.EditMaiores.Location = new System.Drawing.Point(81, 128);
            this.EditMaiores.Name = "EditMaiores";
            this.EditMaiores.Size = new System.Drawing.Size(47, 20);
            this.EditMaiores.TabIndex = 6;
            // 
            // EditMenores
            // 
            this.EditMenores.Location = new System.Drawing.Point(241, 128);
            this.EditMenores.Name = "EditMenores";
            this.EditMenores.Size = new System.Drawing.Size(39, 20);
            this.EditMenores.TabIndex = 7;
            // 
            // EditDtIda
            // 
            this.EditDtIda.Location = new System.Drawing.Point(53, 68);
            this.EditDtIda.Name = "EditDtIda";
            this.EditDtIda.Size = new System.Drawing.Size(324, 20);
            this.EditDtIda.TabIndex = 8;
            // 
            // SelIdaVolta
            // 
            this.SelIdaVolta.AutoSize = true;
            this.SelIdaVolta.Checked = true;
            this.SelIdaVolta.Location = new System.Drawing.Point(81, 12);
            this.SelIdaVolta.Name = "SelIdaVolta";
            this.SelIdaVolta.Size = new System.Drawing.Size(76, 17);
            this.SelIdaVolta.TabIndex = 9;
            this.SelIdaVolta.TabStop = true;
            this.SelIdaVolta.Text = "Ida e Volta";
            this.SelIdaVolta.UseVisualStyleBackColor = true;
            // 
            // SelSoIda
            // 
            this.SelSoIda.AutoSize = true;
            this.SelSoIda.Location = new System.Drawing.Point(241, 12);
            this.SelSoIda.Name = "SelSoIda";
            this.SelSoIda.Size = new System.Drawing.Size(56, 17);
            this.SelSoIda.TabIndex = 10;
            this.SelSoIda.Text = "Só Ida";
            this.SelSoIda.UseVisualStyleBackColor = true;
            this.SelSoIda.CheckedChanged += new System.EventHandler(this.SelSoIda_CheckedChanged);
            // 
            // EditDtVolta
            // 
            this.EditDtVolta.Location = new System.Drawing.Point(53, 100);
            this.EditDtVolta.Name = "EditDtVolta";
            this.EditDtVolta.Size = new System.Drawing.Size(324, 20);
            this.EditDtVolta.TabIndex = 11;
            // 
            // EditOrigem
            // 
            this.EditOrigem.Location = new System.Drawing.Point(53, 42);
            this.EditOrigem.Name = "EditOrigem";
            this.EditOrigem.Size = new System.Drawing.Size(112, 20);
            this.EditOrigem.TabIndex = 12;
            // 
            // EditDestino
            // 
            this.EditDestino.Location = new System.Drawing.Point(226, 42);
            this.EditDestino.Name = "EditDestino";
            this.EditDestino.Size = new System.Drawing.Size(151, 20);
            this.EditDestino.TabIndex = 13;
            // 
            // BtnConfirma
            // 
            this.BtnConfirma.Location = new System.Drawing.Point(53, 154);
            this.BtnConfirma.Name = "BtnConfirma";
            this.BtnConfirma.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirma.TabIndex = 14;
            this.BtnConfirma.Text = "Ok";
            this.BtnConfirma.UseVisualStyleBackColor = true;
            this.BtnConfirma.Click += new System.EventHandler(this.BtnConfirma_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(302, 154);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(75, 23);
            this.BtnVoltar.TabIndex = 15;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // BtnListarVoos
            // 
            this.BtnListarVoos.Location = new System.Drawing.Point(171, 154);
            this.BtnListarVoos.Name = "BtnListarVoos";
            this.BtnListarVoos.Size = new System.Drawing.Size(75, 23);
            this.BtnListarVoos.TabIndex = 16;
            this.BtnListarVoos.Text = "Listar Voos";
            this.BtnListarVoos.UseVisualStyleBackColor = true;
            this.BtnListarVoos.Click += new System.EventHandler(this.BtnListarVoos_Click);
            // 
            // Passagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 194);
            this.Controls.Add(this.BtnListarVoos);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnConfirma);
            this.Controls.Add(this.EditDestino);
            this.Controls.Add(this.EditOrigem);
            this.Controls.Add(this.EditDtVolta);
            this.Controls.Add(this.SelSoIda);
            this.Controls.Add(this.SelIdaVolta);
            this.Controls.Add(this.EditDtIda);
            this.Controls.Add(this.EditMenores);
            this.Controls.Add(this.EditMaiores);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Volta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Passagens";
            this.Text = "Passagens";
            ((System.ComponentModel.ISupportInitialize)(this.EditMaiores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditMenores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Volta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown EditMaiores;
        private System.Windows.Forms.NumericUpDown EditMenores;
        private System.Windows.Forms.DateTimePicker EditDtIda;
        private System.Windows.Forms.RadioButton SelIdaVolta;
        private System.Windows.Forms.RadioButton SelSoIda;
        private System.Windows.Forms.DateTimePicker EditDtVolta;
        private System.Windows.Forms.TextBox EditOrigem;
        private System.Windows.Forms.TextBox EditDestino;
        private System.Windows.Forms.Button BtnConfirma;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button BtnListarVoos;
    }
}