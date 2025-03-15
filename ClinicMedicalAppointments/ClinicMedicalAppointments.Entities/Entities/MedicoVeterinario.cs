namespace ClinicMedicalAppointments.Entities;

public class MedicoVeterinario : GenericEntity
{
    public string Cedula { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string Correo { get; set; }
    public string Celular { get; set; }
    public Guid EspecialidadId { get; set; }
    public Especialidad Especialidad { get; set; }
    public Guid UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
    public ICollection<HistoriaClinica> HistoriasClinicas { get; set; }

    public MedicoVeterinario(Guid id, string estado, DateTime fechaCreacion, DateTime fechaModificacion, string cedula, string nombre, string apellido, DateTime fechaNacimiento, string correo, string celular, Guid especialidadId, Guid usuarioId) 
        : base(id, estado)
    {
        Cedula = cedula;
        Nombre = nombre;
        Apellido = apellido;
        FechaNacimiento = fechaNacimiento;
        Correo = correo;
        Celular = celular;
        EspecialidadId = especialidadId;
        UsuarioId = usuarioId;
    }
}