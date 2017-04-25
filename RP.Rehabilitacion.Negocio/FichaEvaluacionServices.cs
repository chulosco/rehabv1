using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RP.Rehabilitacion.AccesoDatos;

namespace RP.Rehabilitacion.Negocio
{
    public class FichaEvaluacionServices
    {
        RPEntities2 context = new RPEntities2();

        public spUPCtp2_DatosDiagnostico_Result ObtenerDiagnosticoPacientePorDNI(string dni)
        {
            var datosDiagnostico = context.spUPCtp2_DatosDiagnostico(dni).FirstOrDefault();
            return datosDiagnostico;
        }

    }
}
