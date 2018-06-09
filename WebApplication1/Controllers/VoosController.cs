using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class VoosController : ApiController
    {
        public static String consultarVoos(string origem, string destino, DateTime data, int menores, int maiores)
        {
            var servico = new WebReference.ServicoTurismo();
            string dataConcat = data.Day + "/" + data.Month + "/" + data.Year;
            return servico.consultarVoos(origem, destino, dataConcat, menores, maiores);
        }
    }
}
