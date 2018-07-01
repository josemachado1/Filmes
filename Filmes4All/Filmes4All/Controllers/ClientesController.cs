using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Filmes4All.Models;

namespace Filmes4All.Controllers
{
    public class ClientesController : Controller
    {
        // cria um novo objeto que representa a BD
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Clientes
        public ActionResult Index(string ordenar, string pesquisar)
        {

            var clientes = db.Cliente;

            if (User.IsInRole("Admin")){

               
                ViewBag.OrdNome = ordenar == "nomeAsc" ? "nomeDesc" : "nomeAsc";

                // permite efetuar a pesquisa de um cliente pelo nome
                if (!String.IsNullOrEmpty(pesquisar))
                {
                    return View(clientes.Where(c => c.Nome.ToUpper().Contains(pesquisar.ToUpper())));
                }

                // ordena a lista de clientes de forma ascendente ou descendente, por nome
                switch (ordenar)
                {
                    case "nomeDesc":
                        return View(clientes.OrderByDescending(c => c.Nome).ToList());
                    case "nomeAsc":
                        return View(clientes.OrderBy(c => c.Nome).ToList());
                    default:
                        return View(clientes.OrderBy(c => c.ID).ToList());
                }
            }

            // lista apenas os dados do cliente que se autenticou
            return View(db.Cliente.Where(c => c.UserName.Equals(User.Identity.Name)).ToList());

            // return View(db.Cliente.ToList());
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = db.Cliente.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nome,Telemovel,DataNascimento,Morada,CodPostal,UserName")] Cliente cliente)
        {


            // determinar o ID do novo Cliente
            int novoID = 0;
            //***********************************************
            //proteger a geraçao de um novo ID
            //***********************************************
            //determinar o nº de Clientes na tabela
            if (db.Cliente.Count() == 0)
            {
                novoID = 1;
            }
            else
            {
                novoID = db.Cliente.Max(a => a.ID) + 1;

            }

            // atribuir o ID ao novo filme
            cliente.ID = novoID;


            try
            {
                if (ModelState.IsValid)
                    {
                        db.Cliente.Add(cliente);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }

            }
            catch (Exception)
            {

                //gerar uma mensagem de erro para o utilizador 
                ModelState.AddModelError("", "Ocorreu um erro nao determinado na criaçao do novo Cliente...");
            }

            
            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = db.Cliente.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nome,Telemovel,DataNascimento,Morada,CodPostal,UserName")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cliente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = db.Cliente.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cliente cliente = db.Cliente.Find(id);
            db.Cliente.Remove(cliente);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
