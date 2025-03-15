namespace ClinicMedicalAppointments.Entities;

public class Rol: GenericEntity
{
    public string Descripcion { get; set; }
    public ICollection<Usuario> Usuarios { get; set; }

    public Rol(Guid id, string estado, DateTime fechaCreacion, DateTime fechaModificacion, string descripcion) 
        : base(id, estado)
    {
        Descripcion = descripcion;
    }
}