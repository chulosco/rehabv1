using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RP.Rehabilitacion.Negocio;
using RP.Rehabilitacion.AccesoDatos;
namespace RP.Mvc.Controllers
{
    public class FichaEvolucionController : Controller
    {

        FichaEvaluacionServices fichaServices = new FichaEvaluacionServices();

        // GET: FichaEvolucion
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FichaEvolucion()
        {
            ViewBag.Message = "Ficha de evolución.";

            return View();
        }

        public JsonResult ObtenerHistoriaPaciente(string dni) {
            var datos = fichaServices.ObtenerDiagnosticoPacientePorDNI(dni);
            return Json(datos);
        }
    }
}