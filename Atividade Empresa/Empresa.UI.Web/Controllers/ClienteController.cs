using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Empresa.Db;
using Empresa.Models;

namespace Empresa.UI.Web.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            var db = new ClienteDb();
            var lista = db.Listar();

            return View(lista);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            var db = new ClienteDb();
            var cliente = db.ObterPorId(id);

            return View(cliente);
        }

        // GET: Create/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Create/Create
        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            try
            {
                var db = new ClienteDb();
                db.Incluir(cliente);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(cliente);
            }
        }

        // GET: Create/Edit/5
        public ActionResult Edit(int id)
        {
            var db = new ClienteDb();
            var cliente = db.ObterPorId(id);

            return View(cliente);
        }

        // POST: Create/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Cliente cliente)
        {
            try
            {
                var db = new ClienteDb();
                db.Alterar(cliente);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(cliente);
            }
        }

        // GET: Create/Delete/5
        public ActionResult Delete(int id)
        {
            var db = new ClienteDb();
            var cliente  = db.ObterPorId(id);

            return View(cliente);
        }

        // POST: Create/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var db = new ClienteDb();
                db.Excluir(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
