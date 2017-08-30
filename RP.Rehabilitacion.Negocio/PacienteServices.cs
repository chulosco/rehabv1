using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RP.Rehabilitacion.AccesoDatos;

namespace RP.Rehabilitacion.Negocio
{
    public class PacienteServices
    {

        SIGH_RPEntities context = new SIGH_RPEntities();

        public IEnumerable<USP_ListarTiposDocumento_Result> listarTiposDocumento()
        {
            return context.USP_ListarTiposDocumento();
        }


        public USP_BuscarPaciente_Result buscarPaciente(int tipoDocumento, string nNroDocumento)
        {
            return context.USP_BuscarPaciente(tipoDocumento, nNroDocumento).FirstOrDefault();
        }
    }
}
