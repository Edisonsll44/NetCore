using ClinicMedicalAppointments.Entities.Shared;
using MediatR;

namespace ClinicMedicalAppointments.Application.Commands.User;

public class PatchUserCommand: IRequest<ProcessResponse<bool>>
{
    public Guid Id { get; set; }
    public string Status { get; set; }

    public PatchUserCommand(Guid id, string status)
    {
        Id = id;
        Status = status;
    }
}