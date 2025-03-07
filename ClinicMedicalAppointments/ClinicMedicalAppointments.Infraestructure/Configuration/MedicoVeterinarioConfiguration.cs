using ClinicMedicalAppointments.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicMedicalAppointments.Infraestructure.Configuration;

public class MedicoVeterinarioConfiguration : IEntityTypeConfiguration<MedicoVeterinario>
{
    public void Configure(EntityTypeBuilder<MedicoVeterinario> builder)
    {
        builder.ToTable("medico_veterinario");

        builder.HasKey(t => t.Id);
    }
}