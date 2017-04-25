﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class RPEntities : DbContext
    {
        public RPEntities()
            : base("name=RPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Alta> Alta { get; set; }
        public DbSet<Cita> Cita { get; set; }
        public DbSet<Cronograma_Especialista> Cronograma_Especialista { get; set; }
        public DbSet<Cronograma_EspecialistaDetalle> Cronograma_EspecialistaDetalle { get; set; }
        public DbSet<Cronograma_Servicio> Cronograma_Servicio { get; set; }
        public DbSet<Cronograma_Terapista> Cronograma_Terapista { get; set; }
        public DbSet<Cronograma_TerapistaDetalle> Cronograma_TerapistaDetalle { get; set; }
        public DbSet<Diagnostico> Diagnostico { get; set; }
        public DbSet<Equipo> Equipo { get; set; }
        public DbSet<Especialista> Especialista { get; set; }
        public DbSet<Ficha_Evolucion> Ficha_Evolucion { get; set; }
        public DbSet<Historia_Clinica> Historia_Clinica { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Sala> Sala { get; set; }
        public DbSet<Terapista> Terapista { get; set; }
        public DbSet<TipoDocumento> TipoDocumento { get; set; }
        public DbSet<TipoEspecialidad> TipoEspecialidad { get; set; }
    
        public virtual ObjectResult<spUPCtp2_DatosDiagnostico_Result> spUPCtp2_DatosDiagnostico(string dNIPaciente)
        {
            var dNIPacienteParameter = dNIPaciente != null ?
                new ObjectParameter("DNIPaciente", dNIPaciente) :
                new ObjectParameter("DNIPaciente", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spUPCtp2_DatosDiagnostico_Result>("spUPCtp2_DatosDiagnostico", dNIPacienteParameter);
        }
    
        public virtual ObjectResult<string> spUPCtp2_HorasXFechaTerapista(Nullable<System.DateTime> fecha)
        {
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("spUPCtp2_HorasXFechaTerapista", fechaParameter);
        }
    
        public virtual ObjectResult<spUPCtp2_ProfesionalXFechaYHora_Result> spUPCtp2_ProfesionalXFechaYHora(string fecha, string hora, Nullable<int> tipoProfesional)
        {
            var fechaParameter = fecha != null ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(string));
    
            var horaParameter = hora != null ?
                new ObjectParameter("hora", hora) :
                new ObjectParameter("hora", typeof(string));
    
            var tipoProfesionalParameter = tipoProfesional.HasValue ?
                new ObjectParameter("TipoProfesional", tipoProfesional) :
                new ObjectParameter("TipoProfesional", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spUPCtp2_ProfesionalXFechaYHora_Result>("spUPCtp2_ProfesionalXFechaYHora", fechaParameter, horaParameter, tipoProfesionalParameter);
        }
    
        public virtual ObjectResult<spUPCtp2_SesionesProgramadasXPaciente_Result> spUPCtp2_SesionesProgramadasXPaciente(string docPaciente)
        {
            var docPacienteParameter = docPaciente != null ?
                new ObjectParameter("DocPaciente", docPaciente) :
                new ObjectParameter("DocPaciente", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spUPCtp2_SesionesProgramadasXPaciente_Result>("spUPCtp2_SesionesProgramadasXPaciente", docPacienteParameter);
        }
    
        public virtual ObjectResult<spUPCtp2_DatosPaciente_Result> spUPCtp2_DatosPaciente(string nroDoc)
        {
            var nroDocParameter = nroDoc != null ?
                new ObjectParameter("nroDoc", nroDoc) :
                new ObjectParameter("nroDoc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spUPCtp2_DatosPaciente_Result>("spUPCtp2_DatosPaciente", nroDocParameter);
        }
    }
}
