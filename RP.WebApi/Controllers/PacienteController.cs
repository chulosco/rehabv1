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
        [Route("tiposDocumento")]
        public IHttpActionResult ListarTiposDocumento()
        {
            PacienteServices serv = new PacienteServices();
            var lista = serv.listarTiposDocumento();
            return Ok(lista);
        }


        [HttpGet]
        [Route("buscarPaciente/{tipoDocumento}/{nroDocumento}")]
        public IHttpActionResult buscarPaciente(int tipoDocumento, string nroDocumento)
        {
            PacienteServices serv = new PacienteServices();
            var lista = serv.buscarPaciente(tipoDocumento,nroDocumento);
            return Ok(lista);
        }
    }
}
