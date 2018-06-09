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
            ListDados.DataSource=SharedContent.ultimaListaVoos;
        }

        private void BtnReservar_Click(object sender, EventArgs e)
        {
            Voo item = (Voo) ListDados.SelectedItem;
            if (SharedContent.servicoVoos.reservarPassagem(item.Id, Convert.ToInt32(EditMaiores.Text) + Convert.ToInt32(EditMenores.Text)))
            {
                Close();
                MessageBox.Show("Reserva realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Vagas insuficientes");
            }
        }
    }
}
