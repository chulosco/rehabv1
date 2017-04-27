using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace RP.Mvc.Models
{


    public class FichaEvolucionModel
    {

    }


    public class PacienteViewModel
    {

        [Required(ErrorMessage ="Ingrese el número de documento")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [MaxLength(13)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Nro. Documento must be numeric")]
        [Display(Name = "Nro. Documento")]
        public string NroDoc { get; set; }

        [Editable(false)]
        [Display(Name = "Nombres")]
        public string Nombres { get; set; }

        [Editable(false)]
        [Display(Name = "Apellidos")]
        public string Apellidos { get; set; }

        public string ReturnUrl { get; set; }

         [Display(Name = "Med. Especialista")]
        public string MedEspecialista { get; set; }
        /*
         [Display(Name = "Med. Terapista")]
         public string MedTerapista { get; set; }*/

         [Display(Name = "Observaciones")]
         public string Observaciones { get; set; }

        [Display(Name = "Diagnostico")]
        public string Diagnostico { get; set; }

    }

    public class SessionPaciente {
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public IEnumerable<SelectListItem> ListaTerapista  { get; set; }

        public SessionPaciente()
        {
            this.ListaTerapista = new List<SelectListItem>();
        }
    }

    public class SessionPacienteModel
    {
         
        public IEnumerable<SessionPaciente> listaSesiones { get; set; }

        public SessionPacienteModel()
        {
            this.listaSesiones = new List<SessionPaciente>();
        }
    }

}
