using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TurismoClient.Views.Home
{
    [Produces("application/json")]
    [Route("api/Voos")]
    public class VoosController : Controller
    {
        // POST: eventos/Create
        [HttpPost]
        public IActionResult BuscarVoo([Bind(include: "SelVoo,Origem,Destino,DataIda,DataVolta,Maiores,Menores")] string dados)
        {
            

            return View(dados);
        }
    }
}