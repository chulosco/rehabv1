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


       
        [HttpGet]
        [Route("profesionales/{fecha}/{hora}")]
        public IHttpActionResult ListarProfesionalesDisponibles(string  fecha, string hora)
        {
            var tipProfesional = 1;
            hora = hora.Replace('-', ':');
            FichaEvaluacionServices serv = new FichaEvaluacionServices();
            var lista = serv.ObtenerProfesionalesDisponibles(fecha, hora, tipProfesional);
            return Ok(lista);
        }

        [HttpPost]
        [Route("grabarSesion")]
        public IHttpActionResult Grabarsession(GrabarSession param)
        {
             
            FichaEvaluacionServices serv = new FichaEvaluacionServices();
            var result = serv.GrabarSession(param.idPac, param.idEsp, param.fec, param.hor, param.idSes, param.obs);
            return Ok(result);
        }

        public class GrabarSession { 
            public string idPac { get; set; }
            public string idEsp { get; set; }
            public int idSes { get; set; }
            public string fec { get; set; }
            public string hor { get; set; }
            public string obs { get; set; }
            
        }
    }
}
