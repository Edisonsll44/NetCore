using ClinicMedicalAppointments.Application.Querys;
using ClinicMedicalAppointments.Entities.Sedwork;

namespace ClinicMedicalAppointments.Presentation.Request;

public class QueryUserRequest
{
    private bool Status { get; set; }

    public UserQuery ToApplicationRequest(bool status)
    {
        Status = status;
        var statusRecord = Status  ? StatusRecord.Active : StatusRecord.Inactive;
        return new UserQuery(statusRecord);
    }
}