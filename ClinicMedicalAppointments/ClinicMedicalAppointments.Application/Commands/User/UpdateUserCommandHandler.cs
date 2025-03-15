using ClinicMedicalAppointments.Entities.Shared;
using MediatR;

namespace ClinicMedicalAppointments.Application.Commands.User;

public class UpdateUserCommandHandler: IRequestHandler<UpdateUserCommand,ProcessResponse<bool>>
{
    public Task<ProcessResponse<bool>> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}