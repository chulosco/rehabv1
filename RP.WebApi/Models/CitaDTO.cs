using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RP.WebApi.Models
{
    public class CitaDTO
    {
       public int idPaciente { get; set; }
        public int idProfesional { get; set; } 
        public string horaCita{ get; set; }
        public DateTime fechaCita { get; set; }
        public int idDetPlanServicio { get; set; }
    }
}