using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RP.WebApi.Models
{
    public class RecordatorioDTO
    {

        public string nroTelefono { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
        public string terapista { get; set; }
        public string sala { get; set; }

    }
}