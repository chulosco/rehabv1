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