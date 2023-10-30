using NET_GraphQL_API.Models;

namespace NET_GraphQL_API.Repositories
{
    public interface ICarroRepository
    {
        public List<Carro> GetCarros();
        public Carro GetCarroById(int id);
        List<Carro> GetCarrosByMontadora(int montadoraId);
        public Task<Carro> CreateCarro(Carro carro);
        public Task<int> DeleteCarro(Carro Carro);
        Task<int> UpdateCarro(Carro carro);
    }
}
