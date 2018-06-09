using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class DadosConsulta
    {
        //SelVoo,Origem,Destino,DataIda,DataVolta,Maiores,Menores
        public string SelVoo;
        public string Origem;
        public string Destino;
        public DateTime DataIda;
        public DateTime DataVolta;
        public int maiores;
        public int menores;
    }
}