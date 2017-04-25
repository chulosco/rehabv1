using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

    }
}
