//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RP.Rehabilitacion.AccesoDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ambiente_Profesional
    {
        public int nAmbProfesionalId { get; set; }
        public Nullable<int> nAmbienteId { get; set; }
        public Nullable<int> nProfesionalId { get; set; }
    
        public virtual Ambiente Ambiente { get; set; }
        public virtual Profesional Profesional { get; set; }
    }
}
