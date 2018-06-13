using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 *
 * @author Wagner Pereira e Allan Skau
 */

namespace WindowsFormsApp1
{
    //criador classe recebe informações passada via classe statica comum do do namespace para inicializar o form conforme contexto.
    public partial class ReservaVoo : Form
    {
        public ReservaVoo()
        {
            InitializeComponent();
            ListIda.DataSource=SharedContent.ultimaListaVoos;
            EditMaiores.Value = SharedContent.maiores;
            EditMenores.Value = SharedContent.menores;
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
        //evento responsavel pela reserva das passagens no servidor, é chamado o serviço e verificado se o retorno é verdadeiro para confirmar a reserva, se for ida e volta só é validado com as 2 reservas e são feitas.
        private void BtnReservar_Click(object sender, EventArgs e)
        {
            if (EditCartao.Text.Equals(""))
            {
                MessageBox.Show("Preencha o numero do cartão");
            }
            else
            {
                Voo itemIda = (Voo)ListIda.SelectedItem;
                if (SharedContent.idaVolta)
                {
                    Voo itemVolta = (Voo)ListVolta.SelectedItem;
                    if ((SharedContent.servicoVoos.reservarPassagem(itemIda.Id, Convert.ToInt32(EditMaiores.Text) + Convert.ToInt32(EditMenores.Text), Convert.ToInt32(EditCartao.Text), Convert.ToInt32(EditParcelamento.Value))) && (SharedContent.servicoVoos.reservarPassagem(itemVolta.Id, Convert.ToInt32(EditMaiores.Text) + Convert.ToInt32(EditMenores.Text), Convert.ToInt32(EditCartao.Text), Convert.ToInt32(EditParcelamento.Value))))
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
                    //não fecha o formulário para possibilitar reserva de trechos multiplos
                    if (SharedContent.servicoVoos.reservarPassagem(itemIda.Id, Convert.ToInt32(EditMaiores.Text) + Convert.ToInt32(EditMenores.Text), Convert.ToInt32(EditCartao.Text), Convert.ToInt32(EditParcelamento.Value)))
                    {
                        MessageBox.Show("Reserva realizada com sucesso, faça nova reserva ou feche o formulário");
                    }
                    else
                    {
                        MessageBox.Show("Vagas insuficientes");
                    }
                }
            }
            
        }

        private void EditCartao_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
