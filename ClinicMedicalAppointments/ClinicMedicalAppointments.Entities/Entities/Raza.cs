namespace ClinicMedicalAppointments.Entities.Entities;

public class Raza : GenericEntity
{
    public string Nombre { get; set; }
    public ICollection<Mascota> Mascotas { get; set; }

    public Raza(Guid id, bool estado, DateTime fechaCreacion, DateTime fechaModificacion, string nombre) 
        : base(id, estado, fechaCreacion, fechaModificacion)
    {
        Nombre = nombre;
    }
}