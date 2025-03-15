using ClinicMedicalAppointments.Entities.Dtos.Responses;
using ClinicMedicalAppointments.Entities.Handles;
using ClinicMedicalAppointments.Entities.Shared;
using ClinicMedicalAppointments.Infraestructure.Repository;
using MediatR;

namespace ClinicMedicalAppointments.Application.Querys;

public class UserQueryHandler:  IRequestHandler<UserQuery, ProcessResponse<IEnumerable<UsuarioQueryResponse>>>
{
    private readonly IUserRepository _usuarioRepository;
    
    public UserQueryHandler(IUserRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }
    public async Task<ProcessResponse<IEnumerable<UsuarioQueryResponse>>> Handle(UserQuery request, CancellationToken cancellationToken)
    {
        var users = await _usuarioRepository.GetUsersByStatus(request.Status);
        var usersQueryResponses = users.Select(user => new UsuarioQueryResponse(user.Id,
            user.Nombre, 
            user.Nombre, 
            user.Apellido, user.Celular, user.Genero, user.Identificacion, user.Estado,user.Rol.Descripcion,
            user.FechaActivacion)).ToList();
        return usersQueryResponses.Any()
            ? ProcessResponse<IEnumerable<UsuarioQueryResponse>>.Success(usersQueryResponses)
            : ProcessResponse<IEnumerable<UsuarioQueryResponse>>.Failure(CodesHandles.NoDataFoundMessage);
    }
}