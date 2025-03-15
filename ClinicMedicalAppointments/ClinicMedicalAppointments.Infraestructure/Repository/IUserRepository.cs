using ClinicMedicalAppointments.Entities;
using ClinicMedicalAppointments.Infraestructure.Repository.Generic;

namespace ClinicMedicalAppointments.Infraestructure.Repository;

public interface  IUserRepository: IGenericRepository<Usuario>
{
    Task<IReadOnlyCollection<Usuario>> GetUsersByStatus(string status);
}