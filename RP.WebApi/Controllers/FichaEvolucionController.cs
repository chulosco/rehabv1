using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RP.WebApi.Controllers
{
    [RoutePrefix("api/fichaEvolucion")]
    public class FichaEvolucionController : ApiController
    {
        public string Get()
        {
            return "Hello World";
        }

    }
}
