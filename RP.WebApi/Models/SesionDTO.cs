using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RP.WebApi.Models
{
    public class SesionDTO
    {
        public string idPac { get; set; }
        public string idEsp { get; set; }
        public int idSes { get; set; }
        public string fec { get; set; }
        public string hor { get; set; }
        public string obs { get; set; }
    }
}