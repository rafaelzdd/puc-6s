using Microsoft.EntityFrameworkCore;

namespace puc_6s.Models
{
    public class AppDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ConsultaUsuarios>().HasKey(c => new { c.ConsultaId, c.PacienteId, c.MedicoId });

            builder.Entity<ConsultaUsuarios>().HasOne(c => c.Consulta).WithMany(c => c.Usuarios).HasForeignKey(c => c.ConsultaId);

            builder.Entity<ConsultaUsuarios>().HasOne(c => c.Usuario).WithMany(c => c.Consultas).HasForeignKey(c => c.PacienteId + c.MedicoId);
        }

        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Notificacao> Notificacoes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<ConsultaUsuarios> ConsultasUsuarios { get; set; }
    }
}
