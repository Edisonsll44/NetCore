namespace ClinicMedicalAppointments.Entities;

public class GenericEntity
{
    public Guid Id { get; set; }
    public string Estado { get; set; }
    public DateTime FechaCreacion { get; private set; } = DateTime.UtcNow;
    public DateTime FechaModificacion { get; private set; } = DateTime.UtcNow;

    protected GenericEntity(Guid id, string estado)
    {
        Id = id;
        Estado = estado; 
    }
    public void SetUpdateDate()
    {
        FechaModificacion = DateTime.UtcNow;
    }
}