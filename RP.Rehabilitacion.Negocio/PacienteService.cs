using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RP.Rehabilitacion.AccesoDatos;

namespace RP.Rehabilitacion.Negocio
{
    public class PacienteService
    {

        SIGH_RPEntities context = new SIGH_RPEntities();

        public USP_ObtenerPaciente_Result buscarPaciente(int tipoDocumento, string nNroDocumento)
        {
            return context.USP_ObtenerPaciente(tipoDocumento, nNroDocumento).FirstOrDefault();
        }


        public IEnumerable<USP_ListarMedicosRecomendados_Result> listarMedicosRecomendados(int idPaciente)
        {
            return context.USP_ListarMedicosRecomendados(idPaciente);
        }


        public USP_ObtenerUltimoDiagnostico_Result obtenerUltimoDiagnostico(int idPaciente)
        {
            return context.USP_ObtenerUltimoDiagnostico(idPaciente).FirstOrDefault();
        }

        public IEnumerable<USP_ObtenerProfesionalesFechaTurno_Result> buscarProfesionalesDisponibles(DateTime fecha,int turno, string hora,int tipo)
        {
            return context.USP_ObtenerProfesionalesFechaTurno(fecha, turno, hora,tipo);
        }

    }
}
