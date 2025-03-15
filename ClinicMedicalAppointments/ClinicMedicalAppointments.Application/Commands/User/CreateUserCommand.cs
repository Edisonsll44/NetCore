using ClinicMedicalAppointments.Entities.Shared;
using MediatR;

namespace ClinicMedicalAppointments.Application.Commands.User;

public class CreateUserCommand :IRequest<ProcessResponse<bool>>
{
    public string Identificacion { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public string Clave { get; set; }
    public string Genero { get; set; }
    public string Celular { get; set; }
    public string Correo { get; set; }
    public Guid RolId { get; set; }

    public CreateUserCommand(string nombres, string apellidos, string clave, string genero, string celular, string correo, string identificacion, Guid rolId)
    {
        Nombres = nombres;
        Apellidos = apellidos;
        Clave = clave;
        Genero = genero;
        Celular = celular;
        Correo = correo;
        Identificacion = identificacion;
        RolId = rolId;
    }
    
    public CreateUserCommand AddRolId(Guid rolId)
    {
        RolId = rolId;
        return this;
    }
}