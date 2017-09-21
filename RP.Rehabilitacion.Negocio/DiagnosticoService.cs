using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RP.Rehabilitacion.AccesoDatos;

namespace RP.Rehabilitacion.Negocio
{
    public class DiagnosticoService
    {

        SIGH_RPEntities context = new SIGH_RPEntities();

        public USP_ObtenerUltimoDiagnostico_Result obtenerUltimoDiagnostico(int idPaciente)
        {
            return context.USP_ObtenerUltimoDiagnostico(idPaciente).FirstOrDefault();
        }
        public IEnumerable<USP_BuscarDiagnosticos_Result> buscarDiagnosticos(int idPaciente)
        {
            return context.USP_BuscarDiagnosticos(idPaciente);
        }

        public IEnumerable<USP_BuscarDiagnosticos_Result> listarDiagnosticos(int idPaciente)
        {
            return context.USP_BuscarDiagnosticos(idPaciente);
        }
        public USP_ObtenerDiagnostico_Result obtenerDiagnostico(int idDiagnostico)
        {
            return context.USP_ObtenerDiagnostico(idDiagnostico).FirstOrDefault();
        }

        public string grabarDiagnostico(int idCita, string detDiagnostico, int codDiagnostico,int nroTerapias, int nroVeces, DateTime fecha )
        {
            return context.USP_GrabarDiagnostico(idCita, detDiagnostico, codDiagnostico,nroTerapias, nroVeces,fecha).ToString();
        }

        public IEnumerable<USP_ObtenerConsolidadoPlanTratamiento_Result> obtenerConsolidadoPlanTratamiento(int idDiagnostico)
        {
            return context.USP_ObtenerConsolidadoPlanTratamiento(idDiagnostico);
        }
        public string grabarAmpliacionTratamiento(int idPlanTratamiento,  int nroTerapias)
        {
            return context.USP_GrabarAmpliacionPlanTratamiento(idPlanTratamiento,nroTerapias).ToString();
        }

        public int grabarAlta(int idDiagnostico, string cRecomendacion)
        {
            return context.USP_GrabarAlta(idDiagnostico, cRecomendacion);
        }
    }
}
