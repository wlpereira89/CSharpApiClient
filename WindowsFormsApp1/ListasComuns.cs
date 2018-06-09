using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class Shared
    {
        public static List<Voo> listaVoos = new List<Voo>();
        public static List<Hosp> listaHosp = new List<Hosp>();

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
        public int Vagas { get => vagas; }
        public Voo(int id, string origem, string destino, DateTime data, int vagas)
        {
            this.id = id;
            this.origem = origem;
            this.destino = destino;
            this.data = data;
            this.vagas = vagas;            
        }        
    }
}
