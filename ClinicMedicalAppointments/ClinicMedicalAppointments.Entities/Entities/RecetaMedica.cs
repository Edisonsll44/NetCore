namespace ClinicMedicalAppointments.Entities.Entities;

public class RecetaMedica : GenericEntity
{
    public DateTime Fecha { get; set; }
    public string Prescripcion { get; set; }
    public ICollection<ConsultaMedica> ConsultasMedicas { get; set; }

    public RecetaMedica(Guid id, bool estado, DateTime fechaCreacion, DateTime fechaModificacion, DateTime fecha, string prescripcion) 
        : base(id, estado, fechaCreacion, fechaModificacion)
    {
        Fecha = fecha;
        Prescripcion = prescripcion;
    }
}