using NET_GraphQL_API.Models;

namespace NET_GraphQL_API.Repositories
{
    public interface IMontadoraRepository
    {
        public List<Montadora> GetMontadoras();
        public Montadora GetMontadoraById(int id);
    }
}
