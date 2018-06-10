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
    public partial class ReservaVoo : Form
    {
        public ReservaVoo()
        {
            InitializeComponent();
            ListIda.DataSource=SharedContent.ultimaListaVoos;
            if (!SharedContent.idaVolta)
            {
                ListVolta.Visible = false;
                Volta.Visible = false;
                ListIda.Height = 316;
            }
            else
            {
                ListVolta.DataSource = SharedContent.ultimaListaVoosVolta;
                
            }
            
        }

        private void BtnReservar_Click(object sender, EventArgs e)
        {
            Voo itemIda = (Voo) ListIda.SelectedItem;
            if (SharedContent.idaVolta)
            {
                Voo itemVolta = (Voo)ListVolta.SelectedItem;
                if ((SharedContent.servicoVoos.reservarPassagem(itemIda.Id, Convert.ToInt32(EditMaiores.Text) + Convert.ToInt32(EditMenores.Text))) && (SharedContent.servicoVoos.reservarPassagem(itemVolta.Id, Convert.ToInt32(EditMaiores.Text) + Convert.ToInt32(EditMenores.Text))))
                {
                    Close();
                    MessageBox.Show("Reserva realizada com sucesso");
                }
                else
                {
                    MessageBox.Show("Vagas insuficientes");
                }
            }
            else
            {
                if (SharedContent.servicoVoos.reservarPassagem(itemIda.Id, Convert.ToInt32(EditMaiores.Text) + Convert.ToInt32(EditMenores.Text)))
                {
                    Close();
                    MessageBox.Show("Reserva realizada com sucesso");
                }
                else
                {
                    MessageBox.Show("Vagas insuficientes");
                }
            }
            
        }
    }
}
