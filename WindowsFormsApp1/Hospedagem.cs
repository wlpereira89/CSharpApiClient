using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Hospedagem : Form
    {
        public Hospedagem()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnConfirma_Click(object sender, EventArgs e)
        {
            var servicoVoos = new TurismoWebService.VoosWebServiceClient();
        }

        private void Hospedagem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Entrada _f;
            _f = new Entrada();
            _f.Show();
        }

        private void Hospedagem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Entrada _f;
            _f = new Entrada();
            _f.Show();
        }
    }
}
