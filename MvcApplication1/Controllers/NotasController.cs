using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class NotasController : Controller
    {
        private bdagendaEntities db = new bdagendaEntities();

        //
        // GET: /Notas/

        public ActionResult Index()
        {
            var tbnotas = db.tbnotas.Include(t => t.tbagenda);
            return View(tbnotas.ToList());
        }

        //
        // GET: /Notas/Details/5

        public ActionResult Details(int id = 0)
        {
            tbnotas tbnotas = db.tbnotas.Find(id);
            if (tbnotas == null)
            {
                return HttpNotFound();
            }
            return View(tbnotas);
        }

        //
        // GET: /Notas/Create

        public ActionResult Create()
        {
            ViewBag.cod_agenda = new SelectList(db.tbagenda, "cod_agenda", "cod_agenda");
            return View();
        }

        //
        // POST: /Notas/Create

        [HttpPost]
        public ActionResult Create(tbnotas tbnotas)
        {
            if (ModelState.IsValid)
            {
                db.tbnotas.Add(tbnotas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.cod_agenda = new SelectList(db.tbagenda, "cod_agenda", "cod_agenda", tbnotas.cod_agenda);
            return View(tbnotas);
        }

        //
        // GET: /Notas/Edit/5

        public ActionResult Edit(int id = 0)
        {
            tbnotas tbnotas = db.tbnotas.Find(id);
            if (tbnotas == null)
            {
                return HttpNotFound();
            }
            ViewBag.cod_agenda = new SelectList(db.tbagenda, "cod_agenda", "cod_agenda", tbnotas.cod_agenda);
            return View(tbnotas);
        }

        //
        // POST: /Notas/Edit/5

        [HttpPost]
        public ActionResult Edit(tbnotas tbnotas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbnotas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.cod_agenda = new SelectList(db.tbagenda, "cod_agenda", "cod_agenda", tbnotas.cod_agenda);
            return View(tbnotas);
        }

        //
        // GET: /Notas/Delete/5

        public ActionResult Delete(int id = 0)
        {
            tbnotas tbnotas = db.tbnotas.Find(id);
            if (tbnotas == null)
            {
                return HttpNotFound();
            }
            return View(tbnotas);
        }

        //
        // POST: /Notas/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            tbnotas tbnotas = db.tbnotas.Find(id);
            db.tbnotas.Remove(tbnotas);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}