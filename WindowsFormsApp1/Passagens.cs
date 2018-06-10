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
            if (SelIdaVolta.Checked)
            {
                SharedContent.idaVolta = true;
                if ((SharedContent.GerarListaVoos(SharedContent.servicoVoos.consultarVoos(EditOrigem.Text, EditDestino.Text, EditDtIda.Value.ToShortDateString(), Convert.ToInt32(EditMaiores.Value), Convert.ToInt32(EditMenores.Value))) != null) && (SharedContent.GerarListaVoosVolta(SharedContent.servicoVoos.consultarVoos(EditOrigem.Text, EditDestino.Text, EditDtVolta.Value.ToShortDateString(), Convert.ToInt32(EditMaiores.Value), Convert.ToInt32(EditMenores.Value))) != null))
                {
                    ReservaVoo _f;
                    _f = new ReservaVoo();
                    _f.Show();
                }
                else
                {
                    MessageBox.Show("Nenhum voo localizado");
                }
            }
            else
            {
                SharedContent.idaVolta = false;
                if (SharedContent.GerarListaVoos(SharedContent.servicoVoos.consultarVoos(EditOrigem.Text, EditDestino.Text, EditDtIda.Value.ToShortDateString(), Convert.ToInt32(EditMaiores.Value), Convert.ToInt32(EditMenores.Value))) != null)
                {
                    ReservaVoo _f;
                    _f = new ReservaVoo();
                    _f.Show();
                }
                else
                {
                    MessageBox.Show("Nenhum voo localizado");
                }
            } 
            
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
            Entrada _f;
            _f = new Entrada();
            _f.Show();
        }

        private void BtnListarVoos_Click(object sender, EventArgs e)
        {
            SharedContent.GerarListaVoos(SharedContent.servicoVoos.obterVoos());
            SharedContent.idaVolta = false;
            ReservaVoo _f;
            _f = new ReservaVoo();
            _f.Show();
        }

        private void SelSoIda_CheckedChanged(object sender, EventArgs e)
        {
            if (SelSoIda.Checked)
            {
                EditDtVolta.Visible = false;
                Volta.Visible = false;
            }
            else
            {
                EditDtVolta.Visible = true;
                Volta.Visible = true;
            }
        }
    }
}
