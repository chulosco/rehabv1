using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RP.Rehabilitacion.AccesoDatos;

namespace RP.Rehabilitacion.Negocio
{
    public class CitaService
    {
        SIGH_RPEntities context = new SIGH_RPEntities();


        public IEnumerable<USP_ListarCitas_Result> listarCitas(int idPaciente)
        {
            return context.USP_ListarCitas(idPaciente);
        }


        public IEnumerable<USP_ListarCitasTratamiento_Result> listarCitasTratamiento(int idPaciente, int idDiagnostico)
        {
            return context.USP_ListarCitasTratamiento(idPaciente, idDiagnostico);
        }


        public void grabarCita(int nPacienteId, int nProfesionalId, DateTime dFecha, string dHora, int nDetPlanServicioId)
        {
            context.USP_GrabarCita(nPacienteId, nProfesionalId, dFecha, dHora, nDetPlanServicioId);
        }


        public void grabarCitaSesion(int nPacienteId, int nProfesionalId, DateTime dFecha, string dHora, int nDetPlanServicioId, int nDiagnosticoId)
        {
            context.USP_GrabarCitaSesion(nPacienteId, nProfesionalId, dFecha, dHora, nDetPlanServicioId,nDiagnosticoId);
        }


        public void actualizarPlanTratamiento(int idCita, int idDetallePlanTratamiento, int puntaje, string observaciones, string recomendaciones)
        {
            context.USP_ActualizarDetPlanTratamiento(idCita,idDetallePlanTratamiento,puntaje,observaciones,recomendaciones);
        }
    }
}
