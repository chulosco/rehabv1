﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RP.Rehabilitacion.Negocio;

namespace RP.WebApi.Controllers
{
    [RoutePrefix("api/gestionpaciente")]
    public class GestionPacienteController : ApiController
    {

        [HttpGet]
        [Route("medicosFrecuentes/{idPaciente}")]
        public IHttpActionResult listarMedicosFrecuentes(int idPaciente)
        {
            PacienteService serv = new PacienteService();
            var lista = serv.listarMedicosRecomendados(idPaciente);
            return Ok(lista);
        }

        [HttpGet]
        [Route("ultimoDiagnostico/{idPaciente}")]
        public IHttpActionResult obtenerUltimoDiagnostico(int idPaciente)
        {
            DiagnosticoService serv = new DiagnosticoService();
            var lista = serv.obtenerUltimoDiagnostico(idPaciente);
            return Ok(lista);
        }

    }
}
