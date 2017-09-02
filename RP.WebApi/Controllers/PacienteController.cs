using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RP.Rehabilitacion.Negocio;

namespace RP.WebApi.Controllers
{
    [RoutePrefix("api/paciente")]
    public class PacienteController : ApiController
    {

        [HttpGet]
        [Route("buscar/{tipoDocumento}/{nroDocumento}")]
        public IHttpActionResult buscarPaciente(int tipoDocumento, string nroDocumento)
        {
            PacienteService serv = new PacienteService();
            var lista = serv.buscarPaciente(tipoDocumento,nroDocumento);
            return Ok(lista);
        }

    }
}
