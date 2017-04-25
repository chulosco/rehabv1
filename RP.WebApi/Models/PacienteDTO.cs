using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RP.WebApi.Models
{
    public class PacienteDTO
    {
        public int id { get; set; }
        public int Doc_Identidad { get; set; }
        public int Tipo_Doc_Identidad { get; set; }
        public string Nombre { get; set; }
        public string Ape_Materno { get; set; }
        public string Ape_Paterno { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public string Grupo_Sanguineo { get; set; }
    }
}