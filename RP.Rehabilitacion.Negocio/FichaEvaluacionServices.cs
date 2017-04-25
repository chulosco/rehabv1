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


        public Paciente buscarPaciente(string nroDoc)
        {
           return context.Paciente.FirstOrDefault(x => x.Doc_Identidad == nroDoc);
        }

        public spUPCtp2_DatosDiagnostico_Result ObtenerDiagnosticoPacientePorDNI(string dni)
        {
            var datosDiagnostico = context.spUPCtp2_DatosDiagnostico(dni).FirstOrDefault();
            return datosDiagnostico;
        }


        public IEnumerable<string> ObtenerHorasDisponiblesPorFecha(DateTime fecha)
        {
            var horasDisponibles = context.spUPCtp2_HorasXFecha(fecha);
            return horasDisponibles;
        }

        public IEnumerable<spUPCtp2_TerapistaXFechaYHora_Result> ObtenerProfesionalesDisponibles(DateTime fecha, int tipProfesional)
        {
            return context.spUPCtp2_TerapistaXFechaYHora(fecha, tipProfesional);
        }

    }
}
