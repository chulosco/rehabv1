using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RP.Rehabilitacion.AccesoDatos;

namespace RP.Rehabilitacion.Negocio
{
    public class LoginServices
    {
        RPRehabilitacionEntities context = new RPRehabilitacionEntities();

        public IEnumerable<Profesional> ListadoProfesional(string apellido) {
            var lista = context.Profesionals.ToList();
            lista.Where(c => c.Ape_Materno.Contains(apellido));
            var result = (from c in lista where c.Ape_Paterno == apellido
                        select new Profesional() {

                        });
            return lista;
        }


        public static Paciente obtenerPaciente(string numDoc)
        {
            RPRehabilitacionEntities context = new RPRehabilitacionEntities();
            return context.Pacientes.FirstOrDefault(x => x.Doc_Identidad == numDoc);
        }


    }
}
