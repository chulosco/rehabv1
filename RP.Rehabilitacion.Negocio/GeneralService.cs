using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RP.Rehabilitacion.AccesoDatos;


namespace RP.Rehabilitacion.Negocio
{
    public class GeneralService
    {

        SIGH_RPEntities context = new SIGH_RPEntities();

        public IEnumerable<USP_ObtenerMaestro_Result> obtenerMaestro(string maestroDesc)
        {
            return context.USP_ObtenerMaestro(maestroDesc);
        }

    }
}
