using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCExemplo.Models;

namespace WebMVCExemplo.Controllers
{
    public class TesteController : Controller
    {
       public string Exemplo01()
        {
            return "Isto é um metodo";
        }

        public ViewResult Exemplo02()
        {
            return View();
        }

        public ViewResult Exemplo03()
            {
            var fornecedor = new FornecedorViewModel();
            fornecedor.Nome = "Papelaria ASP.NET";
            fornecedor.Email = "papel@asp.net";
            fornecedor.Telefone = "55 11 5555-4444";

            return View(fornecedor);
        }
    }
}