using Application.Domain.Entities;
using MyApp.Application.Interfaces.Repository;
using MyApp.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Persistance.Repositories
{
    public class ProductRepository: GenericRepository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext dbContext;
        public ProductRepository(ApplicationDbContext dbContex):base(dbContex)
        {
        }
    }
}
