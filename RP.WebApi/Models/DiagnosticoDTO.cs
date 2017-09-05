using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RP.WebApi.Models
{
    public class DiagnosticoDTO
    {
        public int idCita { get; set; }
        public int nroSesiones { get; set; }
        public int periodo { get; set; }
        public int idDiagnostico { get; set; }
        public String detDiagnostico { get; set; }

        public String tratamiento { get; set; }
        
        public int idPaciente { get; set; }
        public int idEspecialista { get; set; }
        public DateTime fechaInicio { get; set; }





    }
}