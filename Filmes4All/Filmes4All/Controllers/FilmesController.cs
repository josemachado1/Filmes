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


    [Authorize(Roles = "Clientes,Admin")]

    

    public class FilmesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        [AllowAnonymous] //apesar de haver restriçoes de acesso
                         //um user anonimo pode executar este metodo

        // GET: Filmes
        public ActionResult Index()
        {
            return View(db.Filmes.ToList());
        }

        // GET: Filmes/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Filmes filme = db.Filmes.Find(id);
            if (filme == null)
            {
                return HttpNotFound();
            }
            return View(filme);
        }

        // GET: Filmes/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Filmes/Create
        [Authorize(Roles = "Admin")]
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Titulo,Ano,Capa,Descricao,PrecoVenda,Pontuacao")] Filmes filmes)
        {
            if (ModelState.IsValid)
            {
                db.Filmes.Add(filmes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(filmes);
        }

        // GET: Filmes/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Filmes filmes = db.Filmes.Find(id);
            if (filmes == null)
            {
                return HttpNotFound();
            }
            return View(filmes);
        }

        // POST: Filmes/Edit/5
        [Authorize(Roles = "Admin")]
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Titulo,Ano,Capa,Descricao,PrecoVenda,Pontuacao")] Filmes filmes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(filmes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(filmes);
        }

        // GET: Filmes/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Filmes filmes = db.Filmes.Find(id);
            if (filmes == null)
            {
                return HttpNotFound();
            }
            return View(filmes);
        }

        // POST: Filmes/Delete/5
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Filmes filme = db.Filmes.Find(id);
            db.Filmes.Remove(filme);
            try
            {
                // remover da memória
                db.Filmes.Remove(filme);
                // commit na BD
                db.SaveChanges();
                //redirecionar para a pagina inicial 
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                //gerar uma mensagem de erro, a ser apresentada ao utilizar
                ModelState.AddModelError("", string.Format("Nao foi possivel remover o Filme '{0}', porque existem {1} encomendas associadas a ele. ", filme.Titulo, filme.ListaDeEncomendasFilmes.Count));
            }
            //reenviar os dados para a View

            return View(filme);
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
