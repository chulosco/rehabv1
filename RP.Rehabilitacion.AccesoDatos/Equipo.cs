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
    
    public partial class Equipo
    {
        public Equipo()
        {
            this.Cronograma_Servicio = new HashSet<Cronograma_Servicio>();
        }
    
        public int id { get; set; }
        public Nullable<int> Nro_Serie { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string observacion { get; set; }
    
        public virtual ICollection<Cronograma_Servicio> Cronograma_Servicio { get; set; }
    }
}
