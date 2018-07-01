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
    public class CarrinhoesController : Controller
    {
        // cria um novo objeto que representa a BD
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Carrinhoes
        public ActionResult Index()
        {


            var carrinho = db.Carrinho.Include(c => c.Cliente);
            // return View(carrinho.ToList());
            return View(db.Carrinho.Where(c => c.Cliente.UserName.Equals(User.Identity.Name)).ToList());
        }

        // GET: Carrinhoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Carrinho carrinho = db.Carrinho.Find(id);
            if (carrinho == null)
            {
                return HttpNotFound();
            }
            return View(carrinho);
        }

        // GET: Carrinhoes/Create
        public ActionResult Create()
        {
            ViewBag.ClienteFK = new SelectList(db.Cliente, "ID", "Nome");
            return View();
        }

        // POST: Carrinhoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Quantidade,PrecoCompra,ClienteFK")] Carrinho carrinho)
        {
            if (ModelState.IsValid)
            {
                db.Carrinho.Add(carrinho);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ClienteFK = new SelectList(db.Cliente, "ID", "Nome", carrinho.ClienteFK);
            return View(carrinho);
        }

        // GET: Carrinhoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Carrinho carrinho = db.Carrinho.Find(id);
            if (carrinho == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClienteFK = new SelectList(db.Cliente, "ID", "Nome", carrinho.ClienteFK);
            return View(carrinho);
        }

        // POST: Carrinhoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Quantidade,PrecoCompra,ClienteFK")] Carrinho carrinho)
        {
            if (ModelState.IsValid)
            {
                db.Entry(carrinho).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClienteFK = new SelectList(db.Cliente, "ID", "Nome", carrinho.ClienteFK);
            return View(carrinho);
        }

        // GET: Carrinhoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Carrinho carrinho = db.Carrinho.Find(id);
            if (carrinho == null)
            {
                return HttpNotFound();
            }
            return View(carrinho);
        }

        // POST: Carrinhoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Carrinho carrinho = db.Carrinho.Find(id);
            db.Carrinho.Remove(carrinho);
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
