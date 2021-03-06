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
    
    public partial class Diagnotico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Diagnotico()
        {
            this.Ficha_Evolucion = new HashSet<Ficha_Evolucion>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Diagnostico { get; set; }
        public Nullable<int> Periodo { get; set; }
        public string Tratamiento { get; set; }
        public Nullable<int> Nro_Sesiones { get; set; }
        public string observacion { get; set; }
        public int Profesionalid { get; set; }
        public int Pacienteid { get; set; }
        public int Altaid { get; set; }
    
        public virtual Alta Alta { get; set; }
        public virtual Paciente Paciente { get; set; }
        public virtual Profesional Profesional { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ficha_Evolucion> Ficha_Evolucion { get; set; }
    }
}
