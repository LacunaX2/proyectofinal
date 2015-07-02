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
    public class AgendaController : Controller
    {
        private bdagendaEntities db = new bdagendaEntities();

        //
        // GET: /Agenda/

        public ActionResult Index()
        {
            var tbagenda = db.tbagenda.Include(t => t.tbusuario);
            return View(tbagenda.ToList());
        }

        //
        // GET: /Agenda/Details/5

        public ActionResult Details(int id = 0)
        {
            tbagenda tbagenda = db.tbagenda.Find(id);
            if (tbagenda == null)
            {
                return HttpNotFound();
            }
            return View(tbagenda);
        }

        //
        // GET: /Agenda/Create

        public ActionResult Create()
        {
            ViewBag.cod_usuario = new SelectList(db.tbusuario, "cod_usuario", "login");
            return View();
        }

        //
        // POST: /Agenda/Create

        [HttpPost]
        public ActionResult Create(tbagenda tbagenda)
        {
            if (ModelState.IsValid)
            {
                db.tbagenda.Add(tbagenda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.cod_usuario = new SelectList(db.tbusuario, "cod_usuario", "login", tbagenda.cod_usuario);
            return View(tbagenda);
        }

        //
        // GET: /Agenda/Edit/5

        public ActionResult Edit(int id = 0)
        {
            tbagenda tbagenda = db.tbagenda.Find(id);
            if (tbagenda == null)
            {
                return HttpNotFound();
            }
            ViewBag.cod_usuario = new SelectList(db.tbusuario, "cod_usuario", "login", tbagenda.cod_usuario);
            return View(tbagenda);
        }

        //
        // POST: /Agenda/Edit/5

        [HttpPost]
        public ActionResult Edit(tbagenda tbagenda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbagenda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.cod_usuario = new SelectList(db.tbusuario, "cod_usuario", "login", tbagenda.cod_usuario);
            return View(tbagenda);
        }

        //
        // GET: /Agenda/Delete/5

        public ActionResult Delete(int id = 0)
        {
            tbagenda tbagenda = db.tbagenda.Find(id);
            if (tbagenda == null)
            {
                return HttpNotFound();
            }
            return View(tbagenda);
        }

        //
        // POST: /Agenda/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            tbagenda tbagenda = db.tbagenda.Find(id);
            db.tbagenda.Remove(tbagenda);
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