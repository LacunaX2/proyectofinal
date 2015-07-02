using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class personaController : Controller
    {
        //
        // GET: /persona/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Crear()
        {
            return View();
        }

        bdagendaEntities db = new bdagendaEntities();
        [HttpPost]
        public ActionResult Crear(tbpersona nuevo)
        {

            ViewBag.salida = 0;
            if (ModelState.IsValid)
            {
                nuevo.fecha_creacion = DateTime.Now;

                db.tbpersona.Add(nuevo);
                int x;
                if ((x = db.SaveChanges()) > 0)
                {
                    ViewBag.salida = x;
                    Redirect("index");
                }
            }


            return View(nuevo);
        }
    }
}
