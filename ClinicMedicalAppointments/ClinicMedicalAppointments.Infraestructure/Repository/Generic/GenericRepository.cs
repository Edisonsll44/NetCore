using Microsoft.EntityFrameworkCore;

namespace ClinicMedicalAppointments.Infraestructure.Repository.Generic;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected readonly ClinicaVeterinariaDbContext _context;
    private readonly DbSet<T> _dbSet;

    public GenericRepository(ClinicaVeterinariaDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<T> GetByIdAsync(object id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
    }

    public async Task UpdateAsync(T entity)
    {
        _dbSet.Update(entity);
        await SaveAsync();
    }

    public async Task DeleteAsync(object id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _dbSet.Remove(entity);
            await SaveAsync();
        }
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public async Task<bool> ExistAsync()
    {
        return await _dbSet.AnyAsync();
    }

    public async Task<int> CountAsync()
    {
        return await _dbSet.CountAsync();
    }
}