namespace ClinicMedicalAppointments.Entities.Entities;

public class Rol: GenericEntity
{
    public string Descripcion { get; set; }
    public ICollection<Usuario> Usuarios { get; set; }

    public Rol(Guid id, bool estado, DateTime fechaCreacion, DateTime fechaModificacion, string descripcion) 
        : base(id, estado, fechaCreacion, fechaModificacion)
    {
        Descripcion = descripcion;
    }
}