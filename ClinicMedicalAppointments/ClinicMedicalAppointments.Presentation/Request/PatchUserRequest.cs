using ClinicMedicalAppointments.Application.Commands.User;
using ClinicMedicalAppointments.Entities.Sedwork;

namespace ClinicMedicalAppointments.Presentation.Request;

public class PatchUserRequest
{
    private  Guid Id;
    

    public PatchUserRequest(Guid id)
    {
        Id = id;
    }
    public PatchUserCommand ToApplicationRequest()
    {
        
        return new PatchUserCommand(Id, StatusRecord.Inactive);
    }
}