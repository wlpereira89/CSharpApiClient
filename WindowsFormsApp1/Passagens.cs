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
    public partial class Passagens : Form
    {
        public Passagens()
        {
            InitializeComponent();
        }

        private void BtnConfirma_Click(object sender, EventArgs e)
        {
            var servicoVoos = new TurismoWebService.VoosWebServiceClient();
            EditOrigem.Text, EditDestino.Text, EditDtIda.Value.ToShortDateString(), Convert.ToInt32(EditMaiores.Value), Convert.ToInt32(EditMenores.Value)));
        }
    }
}
