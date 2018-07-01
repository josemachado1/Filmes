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
    public class ParticipantesController : Controller
    {
        // cria um novo objeto que representa a BD
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Participantes
        public ActionResult Index()
        {
            return View(db.Participantes.ToList());
        }

        // GET: Participantes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Participantes participantes = db.Participantes.Find(id);
            if (participantes == null)
            {
                return HttpNotFound();
            }
            return View(participantes);
        }

        // GET: Participantes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Participantes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NomeParticipante,IdadeParticipante")] Participantes participantes)
        {
            if (ModelState.IsValid)
            {
                db.Participantes.Add(participantes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(participantes);
        }

        // GET: Participantes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Participantes participantes = db.Participantes.Find(id);
            if (participantes == null)
            {
                return HttpNotFound();
            }
            return View(participantes);
        }

        // POST: Participantes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NomeParticipante,IdadeParticipante")] Participantes participantes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(participantes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(participantes);
        }

        // GET: Participantes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Participantes participantes = db.Participantes.Find(id);
            if (participantes == null)
            {
                return HttpNotFound();
            }
            return View(participantes);
        }

        // POST: Participantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Participantes participantes = db.Participantes.Find(id);
            db.Participantes.Remove(participantes);
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
