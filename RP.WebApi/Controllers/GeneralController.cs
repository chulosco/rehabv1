using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RP.Rehabilitacion.Negocio;
using RP.WebApi.Models;

namespace RP.WebApi.Controllers
{
    [RoutePrefix("api/general")]
    public class GeneralController : ApiController
    {
        [HttpGet]
        [Route("obtenerMaestro/{maestroDesc}")]
        public IHttpActionResult obtenerMaestro(string maestroDesc)
        {
            GeneralService serv = new GeneralService();
            var lista = serv.obtenerMaestro(maestroDesc);
            return Ok(lista);
        }


        [HttpGet]
        [Route("profesionales/{fecha}/{turno}/{hora}")]
        public IHttpActionResult buscarProfesionalesDisponibles(DateTime fecha, int turno, string hora)
        {
            PacienteService serv = new PacienteService();
            string horaFinal = hora.Substring(0, 2) + ":" + hora.Substring(2, 2);
            var lista = serv.buscarProfesionalesDisponibles(fecha, turno, horaFinal);
            return Ok(lista);
        }
    }
}
