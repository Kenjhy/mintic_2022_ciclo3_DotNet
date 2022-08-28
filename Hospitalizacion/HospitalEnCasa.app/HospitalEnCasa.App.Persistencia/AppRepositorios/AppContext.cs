using Microsoft.EntityFrameworkCore;
using HospitalEnCasa.App.Dominio;
//using System.Data.Entity.SqlServer;

namespace HospitalEnCasa.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Enfermera> Enfermeras { get; set; }
        public DbSet<FamiliarDesignado> FamiliaresDesignados { get; set; }
        public DbSet<SignoVital> SignosVitales { get; set; }
        public DbSet<Historia> Historias { get; set; }
        public DbSet<SugerenciaCuidado> SugerenciasCuidado { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=HospitalEnCasaData; Persist Security Info=False;MultipleActiveResultSets=False;TrustServerCertificate=False;Connection Timeout=30;");
                // optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=HospitalEnCasaData; Persist Security Info=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;", builder =>
                // {
                //     builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
                // });
                // base.OnConfiguring(optionsBuilder);
               //.UseSqlServer("Server=tcp:misiontic2022.database.windows.net,1433;Initial Catalog=HospiEncasatData;Persist Security Info=False;User ID=admin_01;Password=09122006_Hf;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            
            }
        }

    }
}