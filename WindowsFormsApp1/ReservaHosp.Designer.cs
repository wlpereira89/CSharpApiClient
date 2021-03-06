﻿namespace WindowsFormsApp1
{
    partial class ReservaHosp
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
            this.ListHoteis = new System.Windows.Forms.ListBox();
            this.EditDataSaida = new System.Windows.Forms.DateTimePicker();
            this.EditDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.EditMenores = new System.Windows.Forms.NumericUpDown();
            this.EditMaiores = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EditParcelamento = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.EditCartao = new System.Windows.Forms.TextBox();
            this.cartao = new System.Windows.Forms.Label();
            this.BtnReservar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EditMenores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditMaiores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditParcelamento)).BeginInit();
            this.SuspendLayout();
            // 
            // ListHoteis
            // 
            this.ListHoteis.FormattingEnabled = true;
            this.ListHoteis.Location = new System.Drawing.Point(12, 12);
            this.ListHoteis.Name = "ListHoteis";
            this.ListHoteis.Size = new System.Drawing.Size(442, 225);
            this.ListHoteis.TabIndex = 0;
            // 
            // EditDataSaida
            // 
            this.EditDataSaida.Location = new System.Drawing.Point(60, 274);
            this.EditDataSaida.Name = "EditDataSaida";
            this.EditDataSaida.Size = new System.Drawing.Size(259, 20);
            this.EditDataSaida.TabIndex = 14;
            // 
            // EditDataEntrada
            // 
            this.EditDataEntrada.Location = new System.Drawing.Point(60, 243);
            this.EditDataEntrada.Name = "EditDataEntrada";
            this.EditDataEntrada.Size = new System.Drawing.Size(259, 20);
            this.EditDataEntrada.TabIndex = 13;
            // 
            // EditMenores
            // 
            this.EditMenores.Location = new System.Drawing.Point(407, 274);
            this.EditMenores.Name = "EditMenores";
            this.EditMenores.Size = new System.Drawing.Size(47, 20);
            this.EditMenores.TabIndex = 16;
            // 
            // EditMaiores
            // 
            this.EditMaiores.Location = new System.Drawing.Point(407, 243);
            this.EditMaiores.Name = "EditMaiores";
            this.EditMaiores.Size = new System.Drawing.Size(47, 20);
            this.EditMaiores.TabIndex = 15;
            this.EditMaiores.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Menores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Maiores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Saida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Entrada";
            // 
            // EditParcelamento
            // 
            this.EditParcelamento.Location = new System.Drawing.Point(407, 304);
            this.EditParcelamento.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.EditParcelamento.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EditParcelamento.Name = "EditParcelamento";
            this.EditParcelamento.Size = new System.Drawing.Size(47, 20);
            this.EditParcelamento.TabIndex = 20;
            this.EditParcelamento.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Parcelamento";
            // 
            // EditCartao
            // 
            this.EditCartao.Location = new System.Drawing.Point(60, 304);
            this.EditCartao.Name = "EditCartao";
            this.EditCartao.Size = new System.Drawing.Size(259, 20);
            this.EditCartao.TabIndex = 18;
            // 
            // cartao
            // 
            this.cartao.AutoSize = true;
            this.cartao.Location = new System.Drawing.Point(14, 307);
            this.cartao.Name = "cartao";
            this.cartao.Size = new System.Drawing.Size(38, 13);
            this.cartao.TabIndex = 17;
            this.cartao.Text = "Cartão";
            // 
            // BtnReservar
            // 
            this.BtnReservar.Location = new System.Drawing.Point(332, 336);
            this.BtnReservar.Name = "BtnReservar";
            this.BtnReservar.Size = new System.Drawing.Size(122, 38);
            this.BtnReservar.TabIndex = 21;
            this.BtnReservar.Text = "Reservar";
            this.BtnReservar.UseVisualStyleBackColor = true;
            this.BtnReservar.Click += new System.EventHandler(this.BtnReservar_Click);
            // 
            // ReservaHosp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 376);
            this.Controls.Add(this.BtnReservar);
            this.Controls.Add(this.EditParcelamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditCartao);
            this.Controls.Add(this.cartao);
            this.Controls.Add(this.EditDataSaida);
            this.Controls.Add(this.EditDataEntrada);
            this.Controls.Add(this.EditMenores);
            this.Controls.Add(this.EditMaiores);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListHoteis);
            this.Name = "ReservaHosp";
            this.Text = "ReservaHosp";
            ((System.ComponentModel.ISupportInitialize)(this.EditMenores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditMaiores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditParcelamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListHoteis;
        private System.Windows.Forms.DateTimePicker EditDataSaida;
        private System.Windows.Forms.DateTimePicker EditDataEntrada;
        private System.Windows.Forms.NumericUpDown EditMenores;
        private System.Windows.Forms.NumericUpDown EditMaiores;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown EditParcelamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EditCartao;
        private System.Windows.Forms.Label cartao;
        private System.Windows.Forms.Button BtnReservar;
    }
}