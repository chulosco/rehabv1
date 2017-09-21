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

        [HttpGet]
        [Route("diagnostico/{idDiagnostico}")]
        public IHttpActionResult obtenerDiagnostico(int idDiagnostico)
        {
            DiagnosticoService serv = new DiagnosticoService();
            var lista = serv.obtenerDiagnostico(idDiagnostico);
            return Ok(lista);
        }


        [HttpGet]
        [Route("buscarDiagnosticos/{idPaciente}")]
        public IHttpActionResult buscarDiagnosticos(int idPaciente)
        {
            DiagnosticoService serv = new DiagnosticoService();
            var lista = serv.buscarDiagnosticos(idPaciente);
            return Ok(lista);
        }


        [HttpGet]
        [Route("citas/{idPaciente}")]
        public IHttpActionResult listarCitas(int idPaciente)
        {
            CitaService serv = new CitaService();
            var lista = serv.listarCitas(idPaciente);
            return Ok(lista);
        }


        [HttpGet]
        [Route("citasTratamiento/{idPaciente}/{idDiagnostico}")]
        public IHttpActionResult listarCitasTratamiento(int idPaciente, int idDiagnostico)
        {
            CitaService serv = new CitaService();
            var lista = serv.listarCitasTratamiento(idPaciente, idDiagnostico);
            return Ok(lista);
        }


        [HttpPost]
        [Route("grabarCita")]
        public IHttpActionResult grabarCita(CitaDTO param)
        {
            CitaService serv = new CitaService();
            serv.grabarCita(param.idPaciente, param.idProfesional, param.fechaCita, param.horaCita, param.idDetPlanServicio);
            return Ok();
        }


        [HttpPost]
        [Route("grabarCitaSesion")]
        public IHttpActionResult grabarCitaSesion(CitaDTO param)
        {
            CitaService serv = new CitaService();
            serv.grabarCitaSesion(param.idPaciente, param.idProfesional, param.fechaCita, param.horaCita, param.idDetPlanServicio, param.idDiagnostico);
            return Ok();
        }

        [HttpPost]
        [Route("grabarDiagnostico")]
        public IHttpActionResult grabarDiagnostico(DiagnosticoDTO param)
        {
            DiagnosticoService serv = new DiagnosticoService();
            string s = serv.grabarDiagnostico(param.idCita, param.detDiagnostico, param.idDiagnostico,param.nroSesiones,param.vecesXsemana,param.fechaInicio);
            return Ok();
        }



        [HttpPost]
        [Route("enviarRecordatorio")]
        public IHttpActionResult enviarRecordatorio(RecordatorioDTO param)
        {
            GeneralService serv = new GeneralService();
            serv.enviarRecordatorioTerapiaSms(param.nroTelefono,param.fecha, param.terapista, param.sala);
            //serv.enviarRecordatorioTerapiaEmail();
            return Ok();
        }


        [HttpPost]
        [Route("actualizarPlanTratamiento")]
        public IHttpActionResult actualizarPlanTratamiento(SesionDTO param)
        {
            CitaService serv = new CitaService();
            serv.actualizarPlanTratamiento(param.idCita,param.idDetallePlanTratamiento,param.puntaje,param.observaciones,param.recomendaciones);
            return Ok();
        }


        [HttpGet]
        [Route("consolidadoPlanTratamiento/{idDiagnostico}")]
        public IHttpActionResult obtenerConsolidadoPlanTratamiento(int idDiagnostico)
        {
            DiagnosticoService serv = new DiagnosticoService();
            var lista = serv.obtenerConsolidadoPlanTratamiento(idDiagnostico);
            return Ok(lista);
        }


        [HttpPost]
        [Route("grabarAmpliacionPlanTratamiento")]
        public IHttpActionResult grabarAmpliacionPlanTratamiento(PlanTratamientoDTO param)
        {
            DiagnosticoService serv = new DiagnosticoService();
            serv.grabarAmpliacionTratamiento(param.idPlanTratamiento,param.nroSesiones);
            return Ok();
        }
    }
}
