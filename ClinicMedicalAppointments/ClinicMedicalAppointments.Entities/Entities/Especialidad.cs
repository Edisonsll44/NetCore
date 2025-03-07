namespace ClinicMedicalAppointments.Entities.Entities;

public class Especialidad : GenericEntity
{
    public string TipoEspecialidad { get; set; }
    public ICollection<MedicoVeterinario> MedicosVeterinarios { get; set; }

    public Especialidad(Guid id, bool estado, DateTime fechaCreacion, DateTime fechaModificacion, string tipoEspecialidad) 
        : base(id, estado, fechaCreacion, fechaModificacion)
    {
        TipoEspecialidad = tipoEspecialidad;
    }
}