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
        List<String> cidades;
        List<String> hoteis;
        public Hospedagem()
        {
            cidades = new List<String>();
            hoteis = new List<String>();
            String[] Shoteis = SharedContent.servicoHospedagem.ListarHospedagem();
            foreach (String h in Shoteis)
            {
                Boolean flag = false;
                String[] hp = h.Split('-');
                foreach (string c in cidades)
                {
                    if (c.Equals(hp[2].Trim()))
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    cidades.Add(hp[2].Trim());
                }
                flag = false;
                foreach (string c in hoteis)
                {
                    if (c.Equals(hp[1].Trim()))
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    hoteis.Add(hp[1].Trim());
                }
            }
            
            InitializeComponent();
            EditParametro.DataSource = cidades;
            labelParametro.Text = "Cidades";
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnConfirma_Click(object sender, EventArgs e)
        {
            if (SelCdd.Checked)
                SharedContent.GerarListaHoteis(SharedContent.servicoHospedagem.consultaPorCidade(EditParametro.Text.Trim(), EditDataEntrada.Value.ToShortDateString(), EditDataSaida.Value.ToShortDateString(), Convert.ToInt32(EditMaiores.Value+EditMenores.Value)));
            else
                SharedContent.GerarListaHoteis(SharedContent.servicoHospedagem.consultaPorHotel(EditParametro.Text.Trim(), EditDataEntrada.Value.ToShortDateString(), EditDataSaida.Value.ToShortDateString(), Convert.ToInt32(EditMaiores.Value + EditMenores.Value)));
            chamarFormReserva();
        }

        private void Hospedagem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Entrada _f;
            _f = new Entrada();
            _f.Show();
        }

        private void SelCdd_CheckedChanged(object sender, EventArgs e)
        {
            if (SelCdd.Checked)
            {
                labelParametro.Text = "Cidades";
                EditParametro.DataSource = cidades;
            }
            else
            {
                labelParametro.Text = "Hoteis";
                EditParametro.DataSource = hoteis;
            }
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            SharedContent.GerarListaHoteis(SharedContent.servicoHospedagem.ListarHospedagem());
            chamarFormReserva();
        }
        private void chamarFormReserva()
        {
            SharedContent.maiores = EditMaiores.Value;
            SharedContent.menores = EditMenores.Value;
            SharedContent.dataEntrada = EditDataEntrada.Value;
            SharedContent.dataSaida = EditDataSaida.Value;
            ReservaHosp _f;
            _f = new ReservaHosp();
            _f.Show();
        }
    }
}
