using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RP.Rehabilitacion.Negocio;
using RP.Rehabilitacion.AccesoDatos;
using System.Net.Http;
using RP.Mvc.Models;

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


        public ActionResult ObtenerPaciente(string nroDoc)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53229");
            return View();
        }



        public JsonResult ObtenerDiagnosticoPaciente(string nroDoc)
        {

            var datos = fichaServices.ObtenerDiagnosticoPaciente(nroDoc);
            return Json(datos);
        }

        [HttpGet]
        public PartialViewResult PartialSesionesDinamicas(int numSes) {
            var model = new SessionPacienteModel();
            var listaPaciente = new List<SessionPaciente>();
            for (int i = 0; i < numSes; i++)
            {
                listaPaciente.Add(new SessionPaciente());
            }

            model.listaSesiones = listaPaciente;
            return PartialView("_Sessiones", model);
        }
    }
}
