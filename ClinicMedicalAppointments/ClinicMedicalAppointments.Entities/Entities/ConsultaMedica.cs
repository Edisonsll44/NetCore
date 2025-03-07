namespace ClinicMedicalAppointments.Entities.Entities;

public class ConsultaMedica : GenericEntity
{
    public string MotivoConsulta { get; set; }
    public string Vacunas { get; set; }
    public string Desparasitacion { get; set; }
    public DateTime FechaDesparasitacion { get; set; }
    public string EstadoReproductivo { get; set; }
    public string Procedencia { get; set; }
    public string Diagnostico { get; set; }
    public string Pronostico { get; set; }
    public string Observaciones { get; set; }
    public Guid RecetaId { get; set; }
    public RecetaMedica RecetaMedica { get; set; }
    public Guid HistoriaId { get; set; }
    public HistoriaClinica HistoriaClinica { get; set; }

    public ConsultaMedica(Guid id, bool estado, DateTime fechaCreacion, DateTime fechaModificacion, string motivoConsulta, string vacunas, string desparasitacion, DateTime fechaDesparasitacion, string estadoReproductivo, string procedencia, string diagnostico, string pronostico, string observaciones, Guid recetaId, Guid historiaId) 
        : base(id, estado, fechaCreacion, fechaModificacion)
    {
        MotivoConsulta = motivoConsulta;
        Vacunas = vacunas;
        Desparasitacion = desparasitacion;
        FechaDesparasitacion = fechaDesparasitacion;
        EstadoReproductivo = estadoReproductivo;
        Procedencia = procedencia;
        Diagnostico = diagnostico;
        Pronostico = pronostico;
        Observaciones = observaciones;
        RecetaId = recetaId;
        HistoriaId = historiaId;
    }
}