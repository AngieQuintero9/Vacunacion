using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Modelo
{
    public class Contexto : DbContext
    {
        public Contexto() : base()
        {

        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Sexo> Sexos { get; set; }
        public DbSet<TipoDocumento> TiposDocumentos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<RegimenAfiliacion> RegimenAfiliaciones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
           builder.UseSqlServer(ConfigurationManager.ConnectionStrings["Vacunación"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<TipoDocumento>()
                .HasMany(e => e.Pacientes)
                .WithOne(e => e.TipoDocumento)
                .HasForeignKey(e => e.IdTipoDocumento);

            builder.Entity<Sexo>()
                .HasMany(e => e.Pacientes)
                .WithOne(e => e.Sexo)
                .HasForeignKey(e => e.IdSexo);

            builder.Entity<Municipio>()
                .HasMany(e => e.Pacientes)
                .WithOne(e => e.Municipio)
                .HasForeignKey(e => e.IdMunicipio);

            builder.Entity<Departamento>()
                .HasMany(e => e.Municipio)
                .WithOne(e => e.Departamento)
                .HasForeignKey(e => e.IdDepartamento);

            builder.Entity<RegimenAfiliacion>()
                .HasMany(e => e.Pacientes)
                .WithOne(e => e.RegimenAfiliacion)
                .HasForeignKey(e => e.IdRegimenAfiliacion);

   
        }
    }
}