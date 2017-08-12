using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RP.Rehabilitacion.AccesoDatos;

namespace RP.Rehabilitacion.Negocio
{
    public class DiagnosticoServices
    {
        RPEntities context = new RPEntities();

        public IEnumerable<spUPCtp2_DIagnosticosPaciente_Result> obtenerDiagnosticosPacientes(int idPaciente)
        {
            return context.spUPCtp2_DIagnosticosPaciente(idPaciente);
        }


        public string GrabarDiagnostico(string fecha, int nroSesiones, int periodo, string diagnostico, string tratamiento, string observaciones, int idPaciente, int idEspecialista)
        {
            try
            {
                var grabar = context.spUPCtp2_ActualizarDiagnostico(fecha, diagnostico,periodo, tratamiento, nroSesiones,observaciones, idPaciente, idEspecialista);
                if (grabar == 0)
                    return "No hay disponibilidad para esta fecha";
                else
                    return "La sesión ha sido programada";
            }
            catch (Exception e)
            {
                return "No se pudo grabar, Error " + e.ToString();
            }
        }
    }
}
