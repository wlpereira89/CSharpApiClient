namespace WindowsFormsApp1
{
    partial class ReservaVoo
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
            this.ListIda = new System.Windows.Forms.ListBox();
            this.BtnReservar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EditMaiores = new System.Windows.Forms.NumericUpDown();
            this.EditMenores = new System.Windows.Forms.NumericUpDown();
            this.Ida = new System.Windows.Forms.Label();
            this.ListVolta = new System.Windows.Forms.ListBox();
            this.Volta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EditMaiores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditMenores)).BeginInit();
            this.SuspendLayout();
            // 
            // ListIda
            // 
            this.ListIda.FormattingEnabled = true;
            this.ListIda.Location = new System.Drawing.Point(12, 25);
            this.ListIda.Name = "ListIda";
            this.ListIda.Size = new System.Drawing.Size(485, 147);
            this.ListIda.TabIndex = 0;
            // 
            // BtnReservar
            // 
            this.BtnReservar.Location = new System.Drawing.Point(379, 353);
            this.BtnReservar.Name = "BtnReservar";
            this.BtnReservar.Size = new System.Drawing.Size(118, 23);
            this.BtnReservar.TabIndex = 1;
            this.BtnReservar.Text = "Reservar";
            this.BtnReservar.UseVisualStyleBackColor = true;
            this.BtnReservar.Click += new System.EventHandler(this.BtnReservar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Maiores";
            // 
            // EditMaiores
            // 
            this.EditMaiores.Location = new System.Drawing.Point(59, 356);
            this.EditMaiores.Name = "EditMaiores";
            this.EditMaiores.Size = new System.Drawing.Size(120, 20);
            this.EditMaiores.TabIndex = 6;
            // 
            // EditMenores
            // 
            this.EditMenores.Location = new System.Drawing.Point(242, 356);
            this.EditMenores.Name = "EditMenores";
            this.EditMenores.Size = new System.Drawing.Size(120, 20);
            this.EditMenores.TabIndex = 7;
            // 
            // Ida
            // 
            this.Ida.AutoSize = true;
            this.Ida.Location = new System.Drawing.Point(239, 9);
            this.Ida.Name = "Ida";
            this.Ida.Size = new System.Drawing.Size(22, 13);
            this.Ida.TabIndex = 8;
            this.Ida.Text = "Ida";
            // 
            // ListVolta
            // 
            this.ListVolta.FormattingEnabled = true;
            this.ListVolta.Location = new System.Drawing.Point(12, 200);
            this.ListVolta.Name = "ListVolta";
            this.ListVolta.Size = new System.Drawing.Size(485, 147);
            this.ListVolta.TabIndex = 9;
            // 
            // Volta
            // 
            this.Volta.AutoSize = true;
            this.Volta.Location = new System.Drawing.Point(237, 185);
            this.Volta.Name = "Volta";
            this.Volta.Size = new System.Drawing.Size(31, 13);
            this.Volta.TabIndex = 10;
            this.Volta.Text = "Volta";
            // 
            // ReservaVoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 382);
            this.Controls.Add(this.Volta);
            this.Controls.Add(this.ListVolta);
            this.Controls.Add(this.Ida);
            this.Controls.Add(this.EditMenores);
            this.Controls.Add(this.EditMaiores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnReservar);
            this.Controls.Add(this.ListIda);
            this.Name = "ReservaVoo";
            this.Text = "ReservaVoo";
            ((System.ComponentModel.ISupportInitialize)(this.EditMaiores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditMenores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListIda;
        private System.Windows.Forms.Button BtnReservar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown EditMaiores;
        private System.Windows.Forms.NumericUpDown EditMenores;
        private System.Windows.Forms.Label Ida;
        private System.Windows.Forms.ListBox ListVolta;
        private System.Windows.Forms.Label Volta;
    }
}