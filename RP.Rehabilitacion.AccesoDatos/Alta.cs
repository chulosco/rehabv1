//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
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
