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
            var item = serv.buscarPaciente(nroDoc);
            return Ok(item);
        }

        [HttpGet]
        [Route("buscarDiagnostico/{nroDoc}")]
        public IHttpActionResult buscarDiagnostico(string nroDoc)
        {
            FichaEvaluacionServices serv = new FichaEvaluacionServices ();
            var item = serv.ObtenerDiagnosticoPacientePorDNI(nroDoc);
            return Ok(item);
        }


        [HttpGet]
        [Route("horasDisponiblesFecha/{fecha}")]
        public List<string> ListarPasajeroPorReserva(DateTime fecha)
        {
            FichaEvaluacionServices serv = new FichaEvaluacionServices();
            return serv.ObtenerHorasDisponiblesPorFecha(fecha).ToList();
        }



        [HttpGet]
        [Route("profesionalesDisponiblesFecha/{fecha}/{tipProfesional}")]
        public IHttpActionResult ListarProfesionalesDisponibles(DateTime fecha, int tipProfesional)
        {
            FichaEvaluacionServices serv = new FichaEvaluacionServices();
            return Ok(serv.ObtenerProfesionalesDisponibles(fecha,tipProfesional).ToList());
        }


    }
}
