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
    }
}
