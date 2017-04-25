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

        public string login() {
            var result = context.usp_login();
            return result.ToString();
        }

        public IEnumerable<Profesional> ListadoProfesional(string apellido) {
            var lista = context.Profesionals.ToList();
            lista.Where(c => c.Ape_Materno.Contains(apellido));
            var result = (from c in lista where c.Ape_Paterno == apellido
                        select new Profesional() {

                        });
            return lista;
        }
    }
}
