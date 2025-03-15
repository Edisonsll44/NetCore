namespace ClinicMedicalAppointments.Presentation.Request;

public class AutenticationRequest
{
    public string NombreUsuario { get; set; }
    public string Correo { get; set; }
    public string Contrasena { get; set; }
    public string Token { get; set; }
    public string RefreshToken { get; set; }
    public DateTime FechaActivacion { get; set; }
    public bool OlvidoContasenia { get; set; }
    public short IntentosFallidos { get; set; }
    public bool Bloqueado { get; set; }
    public Guid KeyToken { get; set; }
    
    public Guid RolId { get; set; }

    public AutenticationRequest(string nombreUsuario, string correo, string contrasena, string token, string refreshToken, DateTime fechaActivacion, bool olvidoContasenia, short intentosFallidos, bool bloqueado, Guid keyToken, Guid rolId)
    {
        NombreUsuario = nombreUsuario;
        Correo = correo;
        Contrasena = contrasena;
        Token = token;
        RefreshToken = refreshToken;
        FechaActivacion = fechaActivacion;
        OlvidoContasenia = olvidoContasenia;
        IntentosFallidos = intentosFallidos;
        Bloqueado = bloqueado;
        KeyToken = keyToken;
        RolId = rolId;
    }
}