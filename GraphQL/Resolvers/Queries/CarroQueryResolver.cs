using NET_GraphQL_API.Models;
using NET_GraphQL_API.Repositories;

namespace NET_GraphQL_API.GraphQL.Resolvers.Queries
{
    [ExtendObjectType("Query")]
    public class CarroQueryResolver
    {
        public List<Carro> GetCarros([Service] ICarroRepository carroRepository)
        {
            return carroRepository.GetCarros();
        }

        public Carro GetCarroById(int carroId, [Service] ICarroRepository carroRepository)
        {
            return carroRepository.GetCarroById(carroId);
        }

        public List<Carro> GetCarrosByMontadora(int montadoraId, [Service] ICarroRepository carroRepository)
        {
            return carroRepository.GetCarrosByMontadora(montadoraId);
        }
    }
}
