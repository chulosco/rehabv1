//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RP.Rehabilitacion.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cronograma_Profesional
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cronograma_Profesional()
        {
            this.Cronograma_ProfesionalDetalle = new HashSet<Cronograma_ProfesionalDetalle>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> Nro_Sesiones { get; set; }
        public string estado { get; set; }
        public string observacion { get; set; }
        public int Profesionalid { get; set; }
        public int Cronograma_ProfesionalDetalleid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cronograma_ProfesionalDetalle> Cronograma_ProfesionalDetalle { get; set; }
        public virtual Profesional Profesional { get; set; }
    }
}
