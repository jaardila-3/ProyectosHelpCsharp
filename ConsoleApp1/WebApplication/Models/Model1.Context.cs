﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class URS_REHUEntities : DbContext
    {
        public URS_REHUEntities()
            : base("name=URS_REHUEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<FUNCIONARIO_NOVEDAD> FUNCIONARIO_NOVEDAD { get; set; }
        public virtual DbSet<NOV_UNIDADES_TRASLADOS> NOV_UNIDADES_TRASLADOS { get; set; }
        public virtual DbSet<OBSERVACION_FUNCIONARIO> OBSERVACION_FUNCIONARIO { get; set; }
        public virtual DbSet<PROYECTO_FUNCIONARIO> PROYECTO_FUNCIONARIO { get; set; }
        public virtual DbSet<PROYECTO_NOVEDAD> PROYECTO_NOVEDAD { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<OBSERVACION_PROYECTO> OBSERVACION_PROYECTO { get; set; }
    }
}