using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP.Rehabilitacion.AccesoDatos.Interfaces
{
    class PacienteData
    {
        public static Paciente Obtener(string nroDoc)
        {
            RPRehabilitacionEntities db = new RPRehabilitacionEntities();
            return db.Pacientes.FirstOrDefault(x => x.Doc_Identidad == nroDoc);
        }
       
    }
}
