namespace ClinicMedicalAppointments.Entities.Entities;

public class HistoriaClinica: GenericEntity
{
    public DateTime FechaAdmision { get; set; }
    public Guid MedicoVeterinarioId { get; set; }
    public MedicoVeterinario MedicoVeterinario { get; set; }
    public Guid MascotaId { get; set; }
    public Mascota Mascota { get; set; }
    public ICollection<ConsultaMedica> ConsultasMedicas { get; set; }

    public HistoriaClinica(Guid id, bool estado, DateTime fechaCreacion, DateTime fechaModificacion, DateTime fechaAdmision, Guid medicoVeterinarioId,  Guid mascotaId) 
        : base(id, estado, fechaCreacion, fechaModificacion)
    {
        FechaAdmision = fechaAdmision;
        MedicoVeterinarioId = medicoVeterinarioId;
        MascotaId = mascotaId;
    }
}