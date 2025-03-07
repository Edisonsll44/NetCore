using ClinicMedicalAppointments.Entities.Entities;
using ClinicMedicalAppointments.Infraestructure.Configuration;
using Microsoft.EntityFrameworkCore;

namespace ClinicMedicalAppointments.Infraestructure;

public class ClinicaVeterinariaDbContext : DbContext
{
    public ClinicaVeterinariaDbContext(DbContextOptions<ClinicaVeterinariaDbContext> options) : base(options)
    {
    }
    
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Rol> Roles { get; set; }
    public DbSet<Especialidad> Especialidades { get; set; }
    public DbSet<MedicoVeterinario> MedicosVeterinarios { get; set; }
    public DbSet<Raza> Razas { get; set; }
    public DbSet<Propietario> Propietarios { get; set; }
    public DbSet<Mascota> Mascotas { get; set; }
    public DbSet<HistoriaClinica> HistoriasClinicas { get; set; }
    public DbSet<RecetaMedica> RecetasMedicas { get; set; }
    public DbSet<ConsultaMedica> ConsultasMedicas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new RazaConfiguration());
        modelBuilder.ApplyConfiguration(new RolConfiguration());
        modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
        modelBuilder.ApplyConfiguration(new EspecialidadConfiguration());
        modelBuilder.ApplyConfiguration(new MedicoVeterinarioConfiguration());
        modelBuilder.ApplyConfiguration(new PropietarioConfiguration());
        modelBuilder.ApplyConfiguration(new MascotaConfiguration());
        modelBuilder.ApplyConfiguration(new HistoriaClinicaConfiguration());
        modelBuilder.ApplyConfiguration(new RecetaMedicaConfiguration());
        modelBuilder.ApplyConfiguration(new ConsultaMedicaConfiguration());
        base.OnModelCreating(modelBuilder);
    }
}