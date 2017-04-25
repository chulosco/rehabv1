using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RP.Rehabilitacion.Negocio;


namespace RP.WebApi.Controllers
{
    [RoutePrefix("api/fichaEvolucion")]
    public class FichaEvolucionController : ApiController
    {


        [HttpGet]
        [Route("buscarPaciente/{nroDoc}")]
        public IHttpActionResult buscarPaciente(string nroDoc)
        {
            FichaEvaluacionServices serv = new FichaEvaluacionServices();
            var item = serv.obtenerPaciente(nroDoc);
            return Ok(item);
        }

        [HttpGet]
        [Route("buscarDiagnostico/{nroDoc}")]
        public IHttpActionResult buscarDiagnostico(string nroDoc)
        {
            FichaEvaluacionServices serv = new FichaEvaluacionServices ();
            var item = serv.ObtenerDiagnosticoPaciente(nroDoc);
            return Ok(item);
        }


        [HttpGet]
        [Route("horasDisponiblesFecha/{fecha}")]
        public IHttpActionResult ListarPasajeroPorReserva(DateTime fecha)
        {
            FichaEvaluacionServices serv = new FichaEvaluacionServices();
            return Ok(serv.ObtenerHorasDisponiblesPorFecha(fecha).ToList());
        }


        /*
        [HttpPost]
        [Route("profesionalesDisponiblesFecha")]
        public IHttpActionResult ListarProfesionalesDisponibles(FiltroProfesionalModel filtroProfesional)
        {
            FichaEvaluacionServices serv = new FichaEvaluacionServices();
            filtroProfesional.get
            return Ok(serv.ObtenerProfesionalesDisponibles(fecha,hora,tipProfesional).ToList());
        }
        */

    }
}
