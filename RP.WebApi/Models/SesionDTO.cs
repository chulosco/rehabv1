using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RP.WebApi.Models
{
    public class SesionDTO
    {
        public int idCita { get; set; }
        public int idDetallePlanTratamiento { get; set; }
        public int idDetallePlanServicio { get; set; }
        public int puntaje { get; set; }
        public string observaciones { get; set; }
        public string recomendaciones { get; set; }

    }
}