using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index([Bind(Include = "SelVoo,Origem,Destino,DataIda,DataVolta,Maiores,Menores")] DadosConsulta dados)
        {
            ViewBag.Message = "Your application description page.";
            string retorno = VoosController.consultarVoos(dados.Origem, dados.Destino, dados.DataIda, dados.maiores, dados.menores);
            return View(retorno);
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}