using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RP.Rehabilitacion.Negocio;

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
    }
}
