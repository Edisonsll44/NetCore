using ClinicMedicalAppointments.Entities;
using ClinicMedicalAppointments.Infraestructure.Repository.Generic;
using Microsoft.EntityFrameworkCore;

namespace ClinicMedicalAppointments.Infraestructure.Repository;

public class UserRepository :  GenericRepository<Usuario>, IUserRepository
{
    public UserRepository(ClinicaVeterinariaDbContext context) : base(context)
    {
    }

    public async Task<IReadOnlyCollection<Usuario>> GetUsersByStatus(string status)
    {
        var query = _context.Usuarios
            .Include(x=> x.Rol)
            .Where(x => x.Estado == status && x.Rol.Estado == status);
        return await query.ToListAsync();
    }
}