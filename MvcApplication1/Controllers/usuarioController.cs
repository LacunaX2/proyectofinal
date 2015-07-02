using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class usuarioController : Controller
    {
        //
        // GET: /usuario/
        bdagendaEntities db = new bdagendaEntities();
        public ActionResult Index()
        {
            return View();
        }


    }
}
