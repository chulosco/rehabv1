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
    
    public partial class USP_ListarCitasTratamiento_Result
    {
        public Nullable<long> RowNumber { get; set; }
        public int nDetallePlanTratamientoId { get; set; }
        public int nCitaId { get; set; }
        public int nDetPlanServicioId { get; set; }
        public Nullable<System.DateTime> dFecha { get; set; }
        public Nullable<System.TimeSpan> dHora { get; set; }
        public string cAmbienteNombre { get; set; }
        public Nullable<int> nAmbienteId { get; set; }
        public string estadoCita { get; set; }
        public string nombreProfesional { get; set; }
        public Nullable<int> nPuntaje { get; set; }
        public string cCalificacion { get; set; }
        public string cObservacion { get; set; }
        public string cRecomendacion { get; set; }
    }
}
