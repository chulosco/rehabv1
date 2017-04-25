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
        RPEntities context = new RPEntities();


        public spUPCtp2_DatosPaciente_Result obtenerPaciente(string nroDoc)
        {
            var paciente = context.spUPCtp2_DatosPaciente(nroDoc).FirstOrDefault();
            return paciente;
        }

        public spUPCtp2_DatosDiagnostico_Result ObtenerDiagnosticoPaciente(string dni)
        {
            var datosDiagnostico = context.spUPCtp2_DatosDiagnostico(dni).FirstOrDefault();
            return datosDiagnostico;
        }


        public IEnumerable<string> ObtenerHorasDisponiblesPorFecha(DateTime fecha)
        {
            var horasDisponibles = context.spUPCtp2_HorasXFechaTerapista(fecha);
            return horasDisponibles;
        }

        public IEnumerable<spUPCtp2_ProfesionalXFechaYHora_Result> ObtenerProfesionalesDisponibles(string fecha,string hora ,int tipProfesional)
        {
            return context.spUPCtp2_ProfesionalXFechaYHora(fecha,hora ,tipProfesional);
        }

    }
}
