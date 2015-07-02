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
    public class ArchivoController : Controller
    {
        private bdagendaEntities db = new bdagendaEntities();

        //
        // GET: /Archivo/

        public ActionResult Index()
        {
            var tbarchivo = db.tbarchivo.Include(t => t.tbnotas);
            return View(tbarchivo.ToList());
        }

        //
        // GET: /Archivo/Details/5

        public ActionResult Details(int id = 0)
        {
            tbarchivo tbarchivo = db.tbarchivo.Find(id);
            if (tbarchivo == null)
            {
                return HttpNotFound();
            }
            return View(tbarchivo);
        }

        //
        // GET: /Archivo/Create

        public ActionResult Create()
        {
            ViewBag.cod_notas = new SelectList(db.tbnotas, "cod_notas", "titulo");
            return View();
        }

        //
        // POST: /Archivo/Create

        [HttpPost]
        public ActionResult Create(tbarchivo tbarchivo)
        {
            if (ModelState.IsValid)
            {
                db.tbarchivo.Add(tbarchivo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.cod_notas = new SelectList(db.tbnotas, "cod_notas", "titulo", tbarchivo.cod_notas);
            return View(tbarchivo);
        }

        //
        // GET: /Archivo/Edit/5

        public ActionResult Edit(int id = 0)
        {
            tbarchivo tbarchivo = db.tbarchivo.Find(id);
            if (tbarchivo == null)
            {
                return HttpNotFound();
            }
            ViewBag.cod_notas = new SelectList(db.tbnotas, "cod_notas", "titulo", tbarchivo.cod_notas);
            return View(tbarchivo);
        }

        //
        // POST: /Archivo/Edit/5

        [HttpPost]
        public ActionResult Edit(tbarchivo tbarchivo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbarchivo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.cod_notas = new SelectList(db.tbnotas, "cod_notas", "titulo", tbarchivo.cod_notas);
            return View(tbarchivo);
        }

        //
        // GET: /Archivo/Delete/5

        public ActionResult Delete(int id = 0)
        {
            tbarchivo tbarchivo = db.tbarchivo.Find(id);
            if (tbarchivo == null)
            {
                return HttpNotFound();
            }
            return View(tbarchivo);
        }

        //
        // POST: /Archivo/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            tbarchivo tbarchivo = db.tbarchivo.Find(id);
            db.tbarchivo.Remove(tbarchivo);
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