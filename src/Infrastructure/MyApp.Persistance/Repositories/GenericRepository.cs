using MyApp.Application.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Domain.Common;
using MyApp.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Persistance.Repositories
{
    public class GenericRepository<T> : IGenericRepositoryAsync<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext dbContex;

        public GenericRepository(ApplicationDbContext dbContex)
        {
            this.dbContex = dbContex;
        }

        public async Task<T> AddAsync(T entity)
        {
            await dbContex.Set<T>().AddAsync(entity);
            await dbContex.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await dbContex.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid Id)
        {
            return await dbContex.Set<T>().FindAsync(Id);
        }
    }
}
