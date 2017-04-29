using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RP.WebApi.Models
{
    public class DiagnosticoDTO
    {
        public DateTime fecha { get; set; }
        public int nroSesiones { get; set; }
        public int periodo { get; set; }
        public String diagnostico { get; set; }
        public String tratamiento { get; set; }
        public String observaciones { get; set; }
        public int idPaciente { get; set; }
        public int idMedico { get; set; }
        public DateTime fechaInicio { get; set; }





    }
}