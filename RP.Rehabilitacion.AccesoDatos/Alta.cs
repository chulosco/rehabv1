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
    
    public partial class Alta
    {
        public int id { get; set; }
        public string alimentacion { get; set; }
        public string Higiene { get; set; }
        public string Ejercicio { get; set; }
        public string observacion { get; set; }
        public int Diagnosticoid { get; set; }
    
        public virtual Diagnostico Diagnostico { get; set; }
    }
}
