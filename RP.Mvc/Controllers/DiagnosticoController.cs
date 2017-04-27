using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RP.Mvc.Controllers
{
    public class DiagnosticoController : Controller
    {
        // GET: Diagnostico
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Diagnostico()
        {
            ViewBag.Message = "Diagnóstico";

            return View();
        }

    }
}