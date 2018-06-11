﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class SharedContent
    {
        public static TurismoWebService.VoosWebServiceClient servicoVoos = new TurismoWebService.VoosWebServiceClient();
        public static HospedagemWebService.HospedagemWebServiceClient servicoHospedagem = new HospedagemWebService.HospedagemWebServiceClient();
        public static List<Voo> ultimaListaVoos;
        public static List<Voo> ultimaListaVoosVolta;
        public static List<Hosp> ultimaListaHosp;
        public static Boolean idaVolta = false;
        public static decimal menores = 0;
        public static decimal maiores = 0;
        public static List<Voo> GerarListaVoos(string[] voos)
        {
            List<Voo> listaVoos = new List<Voo>();
            if (voos == null)
                return null;
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
        public static List<Voo> GerarListaVoosVolta(string[] voos)
        {
            List<Voo> listaVoos = new List<Voo>();
            if (voos == null)
                return null;
            foreach (string v in voos)
            {
                string[] dados = v.Split('-');
                string[] dataSp = dados[3].Split('/');
                DateTime data = new DateTime(Convert.ToInt32(dataSp[2].Trim()), Convert.ToInt32(dataSp[1].Trim()), Convert.ToInt32(dataSp[0].Trim()));

                Voo novo = new Voo(Convert.ToInt32(dados[0].Trim()), dados[1].Trim(), dados[2].Trim(), data, Convert.ToDouble(dados[4].Replace('.', ',').Trim()), Convert.ToInt32(dados[5].Trim()));
                listaVoos.Add(novo);
            }
            ultimaListaVoosVolta = listaVoos;
            return listaVoos;
        }
        public static List<Hosp> GerarListaHoteis(string[] hoteis)
        {
            List<Hosp> listaHosp = new List<Hosp>();
            if (hoteis == null)
                return null;
            foreach (string h in hoteis)
            {
                string[] dados = h.Split('-');

                Hosp novo = new Hosp(Convert.ToInt32(dados[0]), dados[1], dados[2], Convert.ToDouble(dados[3]));
                listaHosp.Add(novo);
            }
            ultimaListaHosp = listaHosp;

            return listaHosp;
        }
    }
    

    public class Hosp
    {
        private int id;
        private String local;
        private String hotel;
        private double valor;

        public String Hotel { get => hotel; set => hotel = value; }
        public String Local { get => local; set => local = value; }
        public int Id { get => id; set => id = value; }
        public double Valor { get => valor; set => valor = value; }

        

        public Hosp(int id, String local, String hotel, double valor)
        {
            this.Id = id;
            this.Local = local;
            this.hotel = hotel;
            this.Valor = valor;
        }

        public override string ToString()
        {
            return id + " - " + local + " - " + hotel + " - " + valor;
        }
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
