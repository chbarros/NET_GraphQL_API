using NET_GraphQL_API.Models;
using NET_GraphQL_API.Repositories;

namespace NET_GraphQL_API.GraphQL.Resolvers.Queries
{
    [ExtendObjectType("Query")]
    public class MontadoraQueryResolver
    {
        public IEnumerable<Montadora> GetMontadoras([Service] IMontadoraRepository montadoraRepository)
        {
            return montadoraRepository.GetMontadoras();
        }

        public Montadora GetMontadorasById(int montadoraId, [Service] IMontadoraRepository montadoraRepository)
        {
            return montadoraRepository.GetMontadoraById(montadoraId);
        }
    }
}
