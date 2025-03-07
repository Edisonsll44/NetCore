namespace ClinicMedicalAppointments.Entities.Entities;

public class Usuario: GenericEntity
{
    public string NombreUsuario { get; set; }
    public string Correo { get; set; }
    public string Contrasena { get; set; }
    public Guid RolId { get; set; }
    public Rol Rol { get; set; }
    public ICollection<MedicoVeterinario> MedicosVeterinarios { get; set; }

    public Usuario(Guid id, bool estado, DateTime fechaCreacion, DateTime fechaModificacion, string nombreUsuario, string correo, string contrasena, Guid rolId) 
        : base(id, estado, fechaCreacion, fechaModificacion)
    {
        NombreUsuario = nombreUsuario;
        Correo = correo;
        Contrasena = contrasena;
        RolId = rolId;
    }
}