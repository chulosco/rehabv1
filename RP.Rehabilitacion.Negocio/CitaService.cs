using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RP.Rehabilitacion.AccesoDatos;

namespace RP.Rehabilitacion.Negocio
{
    public class CitaService
    {
        SIGH_RPEntities context = new SIGH_RPEntities();


        public IEnumerable<USP_ListarCitas_Result> listarCitas(int idPaciente)
        {
            return context.USP_ListarCitas(idPaciente);
        }

        public void grabarCita(int nPacienteId, int nProfesionalId, DateTime dFecha, string dHora, int nDetPlanServicioId)
        {
            context.USP_GrabarCita(nPacienteId, nProfesionalId, dFecha, dHora, nDetPlanServicioId);
        }
        

    }
}
