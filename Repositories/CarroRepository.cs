using Microsoft.EntityFrameworkCore;
using NET_GraphQL_API.Context;
using NET_GraphQL_API.Models;
using System.Numerics;

namespace NET_GraphQL_API.Repositories
{
    public class CarroRepository : ICarroRepository
    {
        private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

        public CarroRepository(IDbContextFactory<ApplicationDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;

            using (var applicationDbContext =_dbContextFactory.CreateDbContext())
            {
                applicationDbContext.Database.EnsureCreated();
            }
        }

        public Carro GetCarroById(int id)
        {
            using (var applicationDbContext = _dbContextFactory.CreateDbContext())
            {
                return applicationDbContext.Carros.FirstOrDefault(x => x.Id == id);
            }
        }

        public List<Carro> GetCarros()
        {
            using (var applicationDbContext =_dbContextFactory.CreateDbContext())
            {
                return applicationDbContext.Carros.ToList();
            }
        }

        public List<Carro> GetCarrosByMontadora(int montadoraId)
        {
            using (var applicationDbContext = _dbContextFactory.CreateDbContext())
            {
                return applicationDbContext.Carros.Where(c => c.MontadoraId == montadoraId).ToList();
            }
        }

        public async Task<Carro> CreateCarro(Carro carro)
        {
            using (var applicationDbContext = _dbContextFactory.CreateDbContext())
            {
                await applicationDbContext.Carros.AddAsync(carro);

                await applicationDbContext.SaveChangesAsync();

                return carro;
            }
        }

        public async Task<int> DeleteCarro(Carro carro)
        {
            using (var applicationDbContext = _dbContextFactory.CreateDbContext())
            {
                applicationDbContext.Carros.Remove(carro);

                return await applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<int> UpdateCarro(Carro carro)
        {
            using (var applicationDbContext = _dbContextFactory.CreateDbContext())
            {
                applicationDbContext.Carros.Update(carro);

                return await applicationDbContext.SaveChangesAsync();
            }
        }
    }
}
