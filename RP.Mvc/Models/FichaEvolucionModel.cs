using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RP.Mvc.Models
{
    public class SearchModel
    {

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [MaxLength(13)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Nro. Documento must be numeric")]
        [Display(Name = "NroDoc")]
        public string NroDoc { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {3} characters long.", MinimumLength = 3)]
        [MaxLength(50, ErrorMessage = "The {0} must be max {2} characters long.")]
        [DataType(DataType.Text)]
        [Display(Name = "Nombres")]
        public string Nombres { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {3} characters long.", MinimumLength = 3)]
        [MaxLength(50, ErrorMessage = "The {0} must be max {2} characters long.")]
        [DataType(DataType.Text)]
        [Display(Name = "Apellidos")]
        public string Apellidos { get; set; }
    }
}