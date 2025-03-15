using ClinicMedicalAppointments.Entities.Shared;
using MediatR;

namespace ClinicMedicalAppointments.Application.Commands.User;

public class PatchUserCommandHandler: IRequestHandler<PatchUserCommand,ProcessResponse<bool>>
{
    public Task<ProcessResponse<bool>> Handle(PatchUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}