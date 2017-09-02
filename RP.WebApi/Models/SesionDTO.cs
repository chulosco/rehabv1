using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RP.WebApi.Models
{
    public class ParametrosConsultaMedico
    {
        public string fecha { get; set; }
        public int turno { get; set; }
        public string hora { get; set; }
   
    }
}