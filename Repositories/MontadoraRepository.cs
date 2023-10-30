using Microsoft.EntityFrameworkCore;
using NET_GraphQL_API.Context;
using NET_GraphQL_API.Models;

namespace NET_GraphQL_API.Repositories
{
    public class MontadoraRepository : IMontadoraRepository
    {
        private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

        public MontadoraRepository(IDbContextFactory<ApplicationDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;

            using (var _applicationDbContext = _dbContextFactory.CreateDbContext())
            {
                _applicationDbContext.Database.EnsureCreated();
            }
        }

        public Montadora GetMontadoraById(int id)
        {
            using (var applicationDbContext =_dbContextFactory.CreateDbContext())
            {
                return applicationDbContext.Montadoras.FirstOrDefault(x => x.Id == id);
            }
        }

        public List<Montadora> GetMontadoras()
        {
            using (var applicationDbContext =_dbContextFactory.CreateDbContext())
            {
                return applicationDbContext.Montadoras.ToList();
            }
        }
    }
}
