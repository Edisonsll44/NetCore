using ClinicMedicalAppointments.Application.Commands.User;

namespace ClinicMedicalAppointments.Presentation.Request;

public class UpdateUserRequest
{
    private  Guid Id;
    private Guid RolId { get; set; }
    private string Identificacion { get; set; }
    private string Nombre { get; set; }
    private string Apellidos { get; set; }
    private string Clave { get; set; }
    private string Genero { get; set; }
    private string Celular { get; set; }
    private string Correo { get; set; }

    public UpdateUserRequest(Guid id, Guid rolId, string identificacion, string nombre, string apellidos, string clave, string genero, string celular, string correo)
    {
        Id = id;
        RolId = rolId;
        Identificacion = identificacion;
        Nombre = nombre;
        Apellidos = apellidos;
        Clave = clave;
        Genero = genero;
        Celular = celular;
        Correo = correo;
    }
    public UpdateUserCommand ToApplicationRequest()
    {
        return null;
        //return new UpdateUserCommand(Id, Nombre, Apellidos, Clave, Genero, Celular, Correo,Identificacion,RolId);
    }
}