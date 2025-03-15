
using ClinicMedicalAppointments.Application.Commands.User;

namespace ClinicMedicalAppointments.Presentation.Request;

public class CreateUserRequest
{
    public Guid RolId { get; set; }
    public string Identificacion { get; set; }
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public string Clave { get; set; }
    public string Genero { get; set; }
    public string Celular { get; set; }
    public string Correo { get; set; }

    public CreateUserRequest(Guid rolId, string identificacion, string nombre, string apellidos, string clave, string genero, string celular, string correo)
    {
        RolId = rolId;
        Identificacion = identificacion;
        Nombre = nombre;
        Apellidos = apellidos;
        Clave = clave;
        Genero = genero;
        Celular = celular;
        Correo = correo;
    }
    public CreateUserCommand ToApplicationRequest()
    {
        return new CreateUserCommand(Nombre, Apellidos, Clave, Genero, Celular, Correo,Identificacion,RolId);
    }
}