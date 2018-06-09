namespace WindowsFormsApp1
{
    partial class Entrada
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnPassagens = new System.Windows.Forms.Button();
            this.Hospedagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPassagens
            // 
            this.BtnPassagens.Location = new System.Drawing.Point(147, 31);
            this.BtnPassagens.Name = "BtnPassagens";
            this.BtnPassagens.Size = new System.Drawing.Size(92, 41);
            this.BtnPassagens.TabIndex = 0;
            this.BtnPassagens.Text = "Passagens";
            this.BtnPassagens.UseVisualStyleBackColor = true;
            this.BtnPassagens.Click += new System.EventHandler(this.BtnPassagens_Click);
            // 
            // Hospedagem
            // 
            this.Hospedagem.Location = new System.Drawing.Point(147, 78);
            this.Hospedagem.Name = "Hospedagem";
            this.Hospedagem.Size = new System.Drawing.Size(92, 41);
            this.Hospedagem.TabIndex = 1;
            this.Hospedagem.Text = "Hospedagem";
            this.Hospedagem.UseVisualStyleBackColor = true;
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 160);
            this.Controls.Add(this.Hospedagem);
            this.Controls.Add(this.BtnPassagens);
            this.Name = "Entrada";
            this.Padding = new System.Windows.Forms.Padding(300);
            this.Text = "Entrada";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPassagens;
        private System.Windows.Forms.Button Hospedagem;
    }
}

