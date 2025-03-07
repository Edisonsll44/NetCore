namespace ClinicMedicalAppointments.Entities.Entities;

public class GenericEntity
{
    public Guid Id { get; set; }
    public bool Estado { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaModificacion { get; set; }

    public GenericEntity(Guid id, bool estado, DateTime fechaCreacion, DateTime fechaModificacion)
    {
        Id = id;
        Estado = estado;
        FechaCreacion = fechaCreacion;
        FechaModificacion = fechaModificacion;  
    }
}