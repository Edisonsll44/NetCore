namespace ClinicMedicalAppointments.Entities;

public class Usuario: GenericEntity
{
    public string Identificacion { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Correo { get; set; }
    public string Clave { get; set; }
    public string Token { get; set; }
    public string RefreshToken { get; set; }
    public DateTime FechaActivacion { get; set; } = DateTime.UtcNow;
    public bool OlvidoContasenia { get; set; } = false;
    public short IntentosFallidos { get; set; } = 0;
    public bool Bloqueado { get; set; } = false;
    public Guid KeyToken { get; set; } = Guid.Empty;
    public bool Activado { get; set; } = false;
    public string Celular { get; set; }
    public string Genero { get; set; }
    
    public Guid RolId { get; set; }
    public Rol Rol { get; set; }
    public ICollection<MedicoVeterinario> MedicosVeterinarios { get; set; }

    public Usuario(Guid id, string estado, string nombre, string correo, string clave, Guid rolId, string apellido, string celular, string genero, string identificacion) 
        : base(id, estado)
    {
        Nombre = nombre;
        Correo = correo;
        Clave = clave;
        RolId = rolId;
        Apellido = apellido;
        Celular = celular;
        Genero = genero;
        Identificacion = identificacion;
    }

    public bool EmailExist(IEnumerable<Usuario> usuarios)
    {
        return usuarios.Any(u => u.Correo.Equals(Correo, StringComparison.OrdinalIgnoreCase) && u.Id != Id);
    }
    public bool EmailIdentification(IEnumerable<Usuario> usuarios)
    {
        return usuarios.Any(u => u.Identificacion.Equals(Identificacion, StringComparison.OrdinalIgnoreCase) && u.Id != Id);
    }
}