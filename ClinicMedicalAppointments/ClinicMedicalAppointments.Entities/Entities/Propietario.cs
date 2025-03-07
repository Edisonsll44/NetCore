namespace ClinicMedicalAppointments.Entities.Entities;

public class Propietario : GenericEntity
{
    public string NombrePropietario { get; set; }
    public string ApellidoPropietario { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public string Ciudad { get; set; }
    public string Correo { get; set; }
    public ICollection<Mascota> Mascotas { get; set; }

    public Propietario(Guid id, bool estado, DateTime fechaCreacion, DateTime fechaModificacion, string nombrePropietario, string apellidoPropietario, string direccion, string telefono, string ciudad, string correo) 
        : base(id, estado, fechaCreacion, fechaModificacion)
    {
        NombrePropietario = nombrePropietario;
        ApellidoPropietario = apellidoPropietario;
        Direccion = direccion;
        Telefono = telefono;
        Ciudad = ciudad;
        Correo = correo;
    }
}