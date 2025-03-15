using ClinicMedicalAppointments.Entities.Dtos.Responses;
using ClinicMedicalAppointments.Entities.Shared;
using MediatR;

namespace ClinicMedicalAppointments.Application.Querys;

public class UserQuery: IRequest<ProcessResponse<IEnumerable<UsuarioQueryResponse>>>
{
    public string Status { get; set; }
    
    public UserQuery(string status)
    {
        Status = status;
    }
}