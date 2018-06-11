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
    public partial class ReservaHosp : Form
    {
        public ReservaHosp()
        {
            InitializeComponent();
            ListHoteis.DataSource = SharedContent.ultimaListaHosp;
            EditMenores.Value = SharedContent.menores;
            EditMaiores.Value = SharedContent.maiores;
            EditDataEntrada.Value = SharedContent.dataEntrada;
            EditDataSaida.Value = SharedContent.dataSaida;
        }

        private void BtnReservar_Click(object sender, EventArgs e)
        {
            Hosp item = (Hosp)ListHoteis.SelectedItem;
            if (SharedContent.servicoHospedagem.reserva(item.Id, Convert.ToInt32(EditMenores.Value + EditMaiores.Value), EditDataEntrada.Value.ToShortDateString(), EditDataSaida.Value.ToShortDateString(), Convert.ToInt32(EditCartao.Text), Convert.ToInt32(EditParcelamento.Value)))
            {
                MessageBox.Show("Reserva efetuada com sucesso");
            }
            else
            {
                MessageBox.Show("Erro na reserva");
            }
        }
    }
}
