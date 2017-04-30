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
    [RoutePrefix("api/diagnostico")]
    public class DiagnosticoController : ApiController
    {


        [HttpGet]
        [Route("buscarDiagnosticos/{idPaciente}")]
        public IHttpActionResult ListarDiagnostico(int idPaciente)
        {
            DiagnosticoServices serv = new DiagnosticoServices();
            var lista = serv.obtenerDiagnosticosPacientes(idPaciente);
            return Ok(lista);
        }



        [HttpPost]
        [Route("grabarDiagnostico")]
        public IHttpActionResult GrabarDiagnostico(DiagnosticoDTO param)
        {
            DiagnosticoServices serv = new DiagnosticoServices();
            var result = serv.GrabarDiagnostico(param.fecha, param.nroSesiones,param.periodo,param.diagnostico, param.tratamiento, param.observaciones, param.idPaciente, param.idEspecialista);
            return Ok(result);
        }

    }
}