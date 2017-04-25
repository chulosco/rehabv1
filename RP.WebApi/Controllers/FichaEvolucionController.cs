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
        public IHttpActionResult getPaciente(string nroDoc)
        {
            var item = LoginServices.obtenerPaciente(nroDoc);
            return Ok(item);
        }

    }
}
