using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class SharedContent
    {
        public static TurismoWebService.VoosWebServiceClient servicoVoos = new TurismoWebService.VoosWebServiceClient();
        public static List<Voo> ultimaListaVoos;
        public static List<Hosp> ultimaListaHosp;
        public static List<Voo> GerarListaVoos()
        {
            List<Voo> listaVoos = new List<Voo>();
            
            string[] voos = servicoVoos.obterVoos();
            foreach (string v in voos)
            {
                string[] dados = v.Split('-');
                string[] dataSp = dados[3].Split('/');
                DateTime data = new DateTime(Convert.ToInt32(dataSp[2].Trim()), Convert.ToInt32(dataSp[1].Trim()), Convert.ToInt32(dataSp[0].Trim()));
                
                Voo novo = new Voo(Convert.ToInt32(dados[0].Trim()), dados[1].Trim(), dados[2].Trim(), data, Convert.ToDouble(dados[4].Replace('.', ',').Trim()), Convert.ToInt32(dados[5].Trim()));
                listaVoos.Add(novo);
            }
            ultimaListaVoos = listaVoos;
            return listaVoos;
        }
    }
    

    public class Hosp
    {
        private int id;
        private string local;
        private string hotel;
    }

    public class Voo
    {
        private int id;
        public int Id {get=>id;}
        private string origem;
        public string Origem { get => origem; }
        private string destino;
        public string Destino { get => destino; }
        private DateTime data;
        public DateTime Data { get => data; }
        private int vagas;
        private double valor;
        public double Valor { get => valor; }
        public int Vagas { get => vagas; }
        public Voo(int id, string origem, string destino, DateTime data, double valor, int vagas)
        {
            this.id = id;
            this.origem = origem;
            this.destino = destino;
            this.data = data;
            this.valor = valor;
            this.vagas = vagas;            
        }
        public override string ToString()
        {
            return id + " - " + origem + " - " + destino + " - " + data.ToShortDateString() + " - " + valor + " - " + vagas;
        }
    }
}
