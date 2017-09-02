using System;
using System.Collections.Generic;
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
        

    }
}
