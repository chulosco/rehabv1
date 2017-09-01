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
    
    public partial class SIGH_RPEntities : DbContext
    {
        public SIGH_RPEntities()
            : base("name=SIGH_RPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Ambiente_Especialidad> Ambiente_Especialidad { get; set; }
        public DbSet<Ambiente_Profesional> Ambiente_Profesional { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<CitaAdicional> CitaAdicionals { get; set; }
        public DbSet<Disponibilidad_Medica> Disponibilidad_Medica { get; set; }
        public DbSet<Especialidad_Prestacion> Especialidad_Prestacion { get; set; }
        public DbSet<HorarioMedico> HorarioMedicoes { get; set; }
        public DbSet<HorarioPrograma> HorarioProgramas { get; set; }
        public DbSet<Profesional_Especialidad> Profesional_Especialidad { get; set; }
        public DbSet<Programacion_Medica> Programacion_Medica { get; set; }
        public DbSet<Reserva_Cita> Reserva_Cita { get; set; }
        public DbSet<Ambiente> Ambientes { get; set; }
        public DbSet<Detalle_Historia_Clinica> Detalle_Historia_Clinica { get; set; }
        public DbSet<Historia_Clinica> Historia_Clinica { get; set; }
        public DbSet<Maestro> Maestroes { get; set; }
        public DbSet<Orden_Medica> Orden_Medica { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Profesional> Profesionals { get; set; }
        public DbSet<Tipo_Intervencion> Tipo_Intervencion { get; set; }
        public DbSet<Turno> Turnoes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Orden_Intervencion> Orden_Intervencion { get; set; }
        public DbSet<Requisito> Requisitos { get; set; }
        public DbSet<Requisitos_Orden_Int> Requisitos_Orden_Int { get; set; }
        public DbSet<Detalle_Plan_Servicio> Detalle_Plan_Servicio { get; set; }
        public DbSet<Detalle_Plan_Tratamiemto> Detalle_Plan_Tratamiemto { get; set; }
        public DbSet<Diagnostico> Diagnosticoes { get; set; }
        public DbSet<Equipo> Equipoes { get; set; }
        public DbSet<Equipo_Ambiente> Equipo_Ambiente { get; set; }
        public DbSet<Plan_Servicio> Plan_Servicio { get; set; }
        public DbSet<Plan_Tratamiento> Plan_Tratamiento { get; set; }
        public DbSet<ProfesionalPlan> ProfesionalPlans { get; set; }
        public DbSet<Recomendacion_Agente> Recomendacion_Agente { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<USP_ObtenerMaestro_Result> USP_ObtenerMaestro(string mAESTRODESC)
        {
            var mAESTRODESCParameter = mAESTRODESC != null ?
                new ObjectParameter("MAESTRODESC", mAESTRODESC) :
                new ObjectParameter("MAESTRODESC", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_ObtenerMaestro_Result>("USP_ObtenerMaestro", mAESTRODESCParameter);
        }
    
        public virtual ObjectResult<USP_ObtenerPaciente_Result> USP_ObtenerPaciente(Nullable<int> tIPDOC, string nRODOC)
        {
            var tIPDOCParameter = tIPDOC.HasValue ?
                new ObjectParameter("TIPDOC", tIPDOC) :
                new ObjectParameter("TIPDOC", typeof(int));
    
            var nRODOCParameter = nRODOC != null ?
                new ObjectParameter("NRODOC", nRODOC) :
                new ObjectParameter("NRODOC", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_ObtenerPaciente_Result>("USP_ObtenerPaciente", tIPDOCParameter, nRODOCParameter);
        }
    
        public virtual int USP_GrabarCita(Nullable<int> nPacienteId, Nullable<int> nProfesionalId, string dFecha, string dHora, Nullable<int> nDetPlanServicioId, string flgNueva)
        {
            var nPacienteIdParameter = nPacienteId.HasValue ?
                new ObjectParameter("nPacienteId", nPacienteId) :
                new ObjectParameter("nPacienteId", typeof(int));
    
            var nProfesionalIdParameter = nProfesionalId.HasValue ?
                new ObjectParameter("nProfesionalId", nProfesionalId) :
                new ObjectParameter("nProfesionalId", typeof(int));
    
            var dFechaParameter = dFecha != null ?
                new ObjectParameter("dFecha", dFecha) :
                new ObjectParameter("dFecha", typeof(string));
    
            var dHoraParameter = dHora != null ?
                new ObjectParameter("dHora", dHora) :
                new ObjectParameter("dHora", typeof(string));
    
            var nDetPlanServicioIdParameter = nDetPlanServicioId.HasValue ?
                new ObjectParameter("nDetPlanServicioId", nDetPlanServicioId) :
                new ObjectParameter("nDetPlanServicioId", typeof(int));
    
            var flgNuevaParameter = flgNueva != null ?
                new ObjectParameter("flgNueva", flgNueva) :
                new ObjectParameter("flgNueva", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_GrabarCita", nPacienteIdParameter, nProfesionalIdParameter, dFechaParameter, dHoraParameter, nDetPlanServicioIdParameter, flgNuevaParameter);
        }
    
        public virtual ObjectResult<USP_ListarAgentesRecomendados_Result> USP_ListarAgentesRecomendados(Nullable<int> nTipoDiagnosticoId)
        {
            var nTipoDiagnosticoIdParameter = nTipoDiagnosticoId.HasValue ?
                new ObjectParameter("nTipoDiagnosticoId", nTipoDiagnosticoId) :
                new ObjectParameter("nTipoDiagnosticoId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_ListarAgentesRecomendados_Result>("USP_ListarAgentesRecomendados", nTipoDiagnosticoIdParameter);
        }
    
        public virtual ObjectResult<USP_ListarCitas_Result> USP_ListarCitas(Nullable<int> nPacienteId)
        {
            var nPacienteIdParameter = nPacienteId.HasValue ?
                new ObjectParameter("nPacienteId", nPacienteId) :
                new ObjectParameter("nPacienteId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_ListarCitas_Result>("USP_ListarCitas", nPacienteIdParameter);
        }
    
        public virtual ObjectResult<USP_ObtenerProfesionalesFechaTurno_Result> USP_ObtenerProfesionalesFechaTurno(string fECHA, Nullable<int> nTURNOID, string hORA)
        {
            var fECHAParameter = fECHA != null ?
                new ObjectParameter("FECHA", fECHA) :
                new ObjectParameter("FECHA", typeof(string));
    
            var nTURNOIDParameter = nTURNOID.HasValue ?
                new ObjectParameter("NTURNOID", nTURNOID) :
                new ObjectParameter("NTURNOID", typeof(int));
    
            var hORAParameter = hORA != null ?
                new ObjectParameter("HORA", hORA) :
                new ObjectParameter("HORA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_ObtenerProfesionalesFechaTurno_Result>("USP_ObtenerProfesionalesFechaTurno", fECHAParameter, nTURNOIDParameter, hORAParameter);
        }
    
        public virtual ObjectResult<USP_ObtenerUltimoDiagnostico_Result> USP_ObtenerUltimoDiagnostico(Nullable<int> nPacienteId)
        {
            var nPacienteIdParameter = nPacienteId.HasValue ?
                new ObjectParameter("nPacienteId", nPacienteId) :
                new ObjectParameter("nPacienteId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_ObtenerUltimoDiagnostico_Result>("USP_ObtenerUltimoDiagnostico", nPacienteIdParameter);
        }
    
        public virtual int USP_BuscarPaciente(Nullable<int> tipo_Documento_nIdTipoDocumento, string nNroDocumento)
        {
            var tipo_Documento_nIdTipoDocumentoParameter = tipo_Documento_nIdTipoDocumento.HasValue ?
                new ObjectParameter("Tipo_Documento_nIdTipoDocumento", tipo_Documento_nIdTipoDocumento) :
                new ObjectParameter("Tipo_Documento_nIdTipoDocumento", typeof(int));
    
            var nNroDocumentoParameter = nNroDocumento != null ?
                new ObjectParameter("nNroDocumento", nNroDocumento) :
                new ObjectParameter("nNroDocumento", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_BuscarPaciente", tipo_Documento_nIdTipoDocumentoParameter, nNroDocumentoParameter);
        }
    
        public virtual ObjectResult<USP_ListarMedicosRecomendados_Result> USP_ListarMedicosRecomendados(Nullable<int> idPaciente)
        {
            var idPacienteParameter = idPaciente.HasValue ?
                new ObjectParameter("idPaciente", idPaciente) :
                new ObjectParameter("idPaciente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_ListarMedicosRecomendados_Result>("USP_ListarMedicosRecomendados", idPacienteParameter);
        }
    }
}
