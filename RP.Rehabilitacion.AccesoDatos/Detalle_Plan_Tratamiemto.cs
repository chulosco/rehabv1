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
    
    public partial class Detalle_Plan_Tratamiemto
    {
        public int nDetallePlanTratamientoId { get; set; }
        public Nullable<int> nCitaId { get; set; }
        public Nullable<int> nPlanTratamientoId { get; set; }
        public Nullable<int> nTipoAgenteFisicoId { get; set; }
        public Nullable<int> nPuntaje { get; set; }
        public string cCalificacion { get; set; }
    
        public virtual Cita Cita { get; set; }
        public virtual Plan_Tratamiento Plan_Tratamiento { get; set; }
    }
}