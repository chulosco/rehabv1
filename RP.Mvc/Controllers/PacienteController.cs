using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using RP.Mvc.Models;
using RP.Rehabilitacion.Negocio;
namespace RP.Mvc.Controllers
{
    public class PacienteController : Controller
    {

        public ActionResult Paciente()
        {
            ViewBag.Message = "Paciente";

            return View();
        }

        public ActionResult GestionarPaciente()
        {
            ViewBag.Message = "GestionarPaciente";

            return View();
        }
    }

    

}