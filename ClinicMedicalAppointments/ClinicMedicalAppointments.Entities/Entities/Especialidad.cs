namespace ClinicMedicalAppointments.Entities;

public class Especialidad : GenericEntity
{
    public string TipoEspecialidad { get; set; }
    public ICollection<MedicoVeterinario> MedicosVeterinarios { get; set; }

    public Especialidad(Guid id, string estado, DateTime fechaCreacion, DateTime fechaModificacion, string tipoEspecialidad) 
        : base(id, estado)
    {
        TipoEspecialidad = tipoEspecialidad;
    }
}