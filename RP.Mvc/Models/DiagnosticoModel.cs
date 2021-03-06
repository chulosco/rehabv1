﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RP.Mvc.Models
{
    public class DiagnosticoViewModel
    {

        public string FechaDiagnostico { get; set; }
        public string Medico { get; set; }
        public string CodDiagnostico { get; set; }
        public DateTime Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string Observaciones { get; set; }
        public string Periodo { get; set; }
        public string NroSesiones { get; set; }

    }
}