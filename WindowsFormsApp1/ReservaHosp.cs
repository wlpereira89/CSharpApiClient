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
    //criador classe recebe informações passada via classe statica comum do do namespace para inicializar o form conforme contexto.
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
        //evento responsavel pela reserva do hotel no servidor, é chamado o serviço e verificado se o retorno é verdadeiro para confirmar a reserva
        private void BtnReservar_Click(object sender, EventArgs e)
        {
            Hosp item = (Hosp)ListHoteis.SelectedItem;
            if (EditCartao.Text.Equals(""))
            {
                MessageBox.Show("Preencha o numero do cartão");
            }
            else
            {
                if (SharedContent.servicoHospedagem.reserva(item.Id, Convert.ToInt32(EditMenores.Value + EditMaiores.Value), EditDataEntrada.Value.ToShortDateString(), EditDataSaida.Value.ToShortDateString(), Convert.ToInt32(EditCartao.Text), Convert.ToInt32(EditParcelamento.Value)))
                {
                    Close();
                    MessageBox.Show("Reserva efetuada com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro na reserva");
                }
            }
            
        }
    }
}
