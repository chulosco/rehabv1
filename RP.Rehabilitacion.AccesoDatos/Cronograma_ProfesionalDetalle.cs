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
    
    public partial class Cronograma_ProfesionalDetalle
    {
        public int id { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<System.DateTime> Hora_Inicio { get; set; }
        public string estado { get; set; }
        public string observacion { get; set; }
        public int Cronograma_Profesionalid { get; set; }
    
        public virtual Cronograma_Profesional Cronograma_Profesional { get; set; }
    }
}
