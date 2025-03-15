namespace ClinicMedicalAppointments.Entities.Dtos.Responses;

public record UserResponse
{
    
}

public record UsuarioQueryResponse(Guid id,
    string nombre, 
    string apellidos, 
    string correo, 
    string celular, 
    string genero, 
    string identificacion, 
    string estado,
    string rol,
    DateTime fechaActivacion);