using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RP.WebApi.Models
{
    public class DiagnosticoDTO
    {
        public int idCita { get; set; }
        public String detDiagnostico { get; set; }
        public int idDiagnostico { get; set; }
 
        public int nroSesiones { get; set; }
        public int vecesXsemana { get; set; }
        public DateTime fechaInicio { get; set; }





    }
}