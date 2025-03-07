using ClinicMedicalAppointments.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicMedicalAppointments.Infraestructure.Configuration;

public class HistoriaClinicaConfiguration:IEntityTypeConfiguration<HistoriaClinica>
{
    public void Configure(EntityTypeBuilder<HistoriaClinica> builder)
    {
        builder.ToTable("historia_clinica");

        builder.HasKey(t => t.Id);
    }
}