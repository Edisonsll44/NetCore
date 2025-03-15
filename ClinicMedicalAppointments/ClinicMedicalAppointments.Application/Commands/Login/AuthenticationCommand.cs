using ClinicMedicalAppointments.Entities.Shared;
using MediatR;

namespace ClinicMedicalAppointments.Application.Commands.Login;

public class AuthenticationCommand:IRequest<ProcessResponse<bool>>
{
    
}