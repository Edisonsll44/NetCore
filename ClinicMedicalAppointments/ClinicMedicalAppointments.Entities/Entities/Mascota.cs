namespace ClinicMedicalAppointments.Entities;

public class Mascota : GenericEntity
{
    public string Nombre { get; set; }
    public string Sexo { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string Edad { get; set; }
    public string Color { get; set; }
    public Guid RazaId { get; set; }
    public Raza Raza { get; set; }
    public Guid PropietarioId { get; set; }
    public Propietario Propietario { get; set; }
    public ICollection<HistoriaClinica> HistoriasClinicas { get; set; }

    public Mascota(Guid id, string estado, DateTime fechaCreacion, DateTime fechaModificacion, string nombre, string sexo, DateTime fechaNacimiento, string edad, string color, Guid razaId, Guid propietarioId) 
        : base(id, estado)
    {
        Nombre = nombre;
        Sexo = sexo;
        FechaNacimiento = fechaNacimiento;
        Edad = edad;
        Color = color;
        RazaId = razaId;
        PropietarioId = propietarioId;
    }
}