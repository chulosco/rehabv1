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
    
    public partial class Turno
    {
        public Turno()
        {
            this.Detalle_Plan_Servicio = new HashSet<Detalle_Plan_Servicio>();
        }
    
        public int nTurnoId { get; set; }
        public string cTurnoNombre { get; set; }
        public Nullable<System.TimeSpan> dHoraInicio { get; set; }
        public Nullable<System.TimeSpan> dHoraFin { get; set; }
    
        public virtual ICollection<Detalle_Plan_Servicio> Detalle_Plan_Servicio { get; set; }
    }
}
