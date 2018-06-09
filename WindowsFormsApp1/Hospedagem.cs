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
            Entrada _f;
            _f = new Entrada();
            _f.Show();
        }

        private void BtnConfirma_Click(object sender, EventArgs e)
        {
            var servicoVoos = new TurismoWebService.VoosWebServiceClient();
        }
    }
}
