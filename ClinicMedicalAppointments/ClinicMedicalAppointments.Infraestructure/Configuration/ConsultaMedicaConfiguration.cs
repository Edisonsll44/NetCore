using ClinicMedicalAppointments.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicMedicalAppointments.Infraestructure.Configuration;

public class ConsultaMedicaConfiguration : IEntityTypeConfiguration<ConsultaMedica>
{
    public void Configure(EntityTypeBuilder<ConsultaMedica> builder)
    {
        builder.ToTable("consulta_medica");

        builder.HasKey(t => t.Id);
    }
}