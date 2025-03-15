using ClinicMedicalAppointments.Entities;
using ClinicMedicalAppointments.Entities.Sedwork;
using ClinicMedicalAppointments.Entities.Shared;
using MediatR;

namespace ClinicMedicalAppointments.Application.Commands.User;

public class CreateUserCommandHandler: IRequestHandler<CreateUserCommand,ProcessResponse<bool>>
{
    public Task<ProcessResponse<bool>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var validate = CreatenewUser(request);
        return null;
    }

    private async Task<ProcessResponse<bool>> CreatenewUser(CreateUserCommand request)
    {
        var newUsuer = new Usuario(Guid.NewGuid(), 
            StatusRecord.Active,
            request.Nombres,
            request.Correo,
            request.Clave,
            request.RolId,
            request.Apellidos,
            request.Celular,
            request.Genero,
            request.Identificacion
            );
        return null;
    }
}