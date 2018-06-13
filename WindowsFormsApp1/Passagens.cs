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
        //solicita conforme parametros do form a lista de voos ao servidor, o numero de passageiros deve ser maior que 0.
        //se for ida e volta chama uma função gera voos para voo ida, outra que gera os de volta e marca o boolean para que o form seguinte seja corretamente configurado
        //se for só ida apenas chama uma função gera voos para voo ida e desmarca o boolean para que o form seguinte seja corretamente configurado
        private void BtnConfirma_Click(object sender, EventArgs e)
        {
            if (EditMaiores.Value+EditMenores.Value<=0)
            {
                MessageBox.Show("O numero de passageiros deve ser maior que 0");
                return;
            }
            if (SelIdaVolta.Checked)
            {
                SharedContent.idaVolta = true;
                if (SharedContent.GerarListaVoos(SharedContent.servicoVoos.consultarVoos(EditOrigem.Text, EditDestino.Text, EditDtIda.Value.ToShortDateString(), Convert.ToInt32(EditMaiores.Value), Convert.ToInt32(EditMenores.Value))) != null)
                {
                    if (SharedContent.GerarListaVoosVolta(SharedContent.servicoVoos.consultarVoos(EditOrigem.Text, EditDestino.Text, EditDtVolta.Value.ToShortDateString(), Convert.ToInt32(EditMaiores.Value), Convert.ToInt32(EditMenores.Value))) != null)
                    {
                        SharedContent.maiores = EditMaiores.Value;
                        SharedContent.menores = EditMenores.Value;

                        ReservaVoo _f;
                        _f = new ReservaVoo();
                        _f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Voo de volta sem vagas ou inexistente");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Voo de ida sem vagas ou inexistente");
                }
            }
            else
            {
                SharedContent.idaVolta = false;
                if (SharedContent.GerarListaVoos(SharedContent.servicoVoos.consultarVoos(EditOrigem.Text, EditDestino.Text, EditDtIda.Value.ToShortDateString(), Convert.ToInt32(EditMaiores.Value), Convert.ToInt32(EditMenores.Value))) != null)
                {
                    SharedContent.maiores = EditMaiores.Value;
                    SharedContent.menores = EditMenores.Value;
                    ReservaVoo _f;
                    _f = new ReservaVoo();
                    _f.Show();
                }
                else
                {
                    MessageBox.Show("Nenhum voo com vagas localizado");
                }
            } 
            
        }
        //fecha o formulário, o evento onclose faz a chamada do form princial.
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
        //pede a lista de todos os voos disponveis ao servidor, chama o formulário seguinte configurado como voos de ida apenas, para melhor visualização e possibilidade de escolha de trechos multiplos
        private void BtnListarVoos_Click(object sender, EventArgs e)
        {
            SharedContent.GerarListaVoos(SharedContent.servicoVoos.obterVoos());
            SharedContent.idaVolta = false;
            SharedContent.maiores = EditMaiores.Value;
            SharedContent.menores = EditMenores.Value;
            ReservaVoo _f;
            _f = new ReservaVoo();
            _f.Show();
        }
        //altera a datasouce da combo box e a label conforme informado pela radio box, ou cidades ou hotéis
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
        //chama o form principal em caso de fechamento do form
        private void Passagens_FormClosed(object sender, FormClosedEventArgs e)
        {
            Entrada _f;
            _f = new Entrada();
            _f.Show();
        }
    }
}
