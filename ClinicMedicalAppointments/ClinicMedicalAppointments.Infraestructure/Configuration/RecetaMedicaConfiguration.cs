using ClinicMedicalAppointments.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicMedicalAppointments.Infraestructure.Configuration;

public class RecetaMedicaConfiguration : IEntityTypeConfiguration<RecetaMedica>
{
    public void Configure(EntityTypeBuilder<RecetaMedica> builder)
    {
        builder.ToTable("receta_medica");

        builder.HasKey(t => t.Id);
    }
}