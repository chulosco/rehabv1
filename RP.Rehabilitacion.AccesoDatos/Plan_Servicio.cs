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
    
    public partial class Plan_Servicio
    {
        public Plan_Servicio()
        {
            this.Detalle_Plan_Servicio = new HashSet<Detalle_Plan_Servicio>();
        }
    
        public int nPlanServicioId { get; set; }
        public Nullable<int> nAno { get; set; }
        public Nullable<int> nMes { get; set; }
        public Nullable<int> nNroDiagnosticos { get; set; }
        public Nullable<int> nNroSesiones { get; set; }
        public Nullable<int> nNroPaciente { get; set; }
        public Nullable<int> nEstadoId { get; set; }
    
        public virtual ICollection<Detalle_Plan_Servicio> Detalle_Plan_Servicio { get; set; }
    }
}