//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RP.Rehabilitacion.AccesoDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Paciente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Paciente()
        {
            this.Diagnoticoes = new HashSet<Diagnotico>();
            this.Historia_Clinica = new HashSet<Historia_Clinica>();
        }
    
        public int id { get; set; }
        public Nullable<int> Doc_Identidad { get; set; }
        public Nullable<int> Tipo_Doc_Identidad { get; set; }
        public string Nombre { get; set; }
        public string Ape_Materno { get; set; }
        public string Ape_Paterno { get; set; }
        public Nullable<System.DateTime> Fecha_Nacimiento { get; set; }
        public Nullable<int> Edad { get; set; }
        public string Sexo { get; set; }
        public Nullable<int> Telefono { get; set; }
        public string Direccion { get; set; }
        public string Grupo_Sanguineo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diagnotico> Diagnoticoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Historia_Clinica> Historia_Clinica { get; set; }
    }
}
