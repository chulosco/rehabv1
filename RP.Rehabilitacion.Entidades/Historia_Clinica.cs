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
    
    public partial class Historia_Clinica
    {
        public int id { get; set; }
        public Nullable<System.DateTime> Fecha_creacion { get; set; }
        public Nullable<System.DateTime> Fecha_Actualizacion { get; set; }
        public string Historia { get; set; }
        public string Especialidad { get; set; }
        public int Pacienteid { get; set; }
    
        public virtual Paciente Paciente { get; set; }
    }
}
