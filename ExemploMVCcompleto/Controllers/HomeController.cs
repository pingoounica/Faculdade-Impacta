using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCExemplo.Models;

namespace ExemploMVCcompleto.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult FornecedorIncluir()
        {
            return View();
        }
        [HttpPost]
        public ViewResult FornecedorIncluir(FornecedorViewModel fornecedor)
        {
            if (fornecedor.Nome ==  "")
            {
                // tratamento
            }
            return View();
        }

        public ViewResult Servicos()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}