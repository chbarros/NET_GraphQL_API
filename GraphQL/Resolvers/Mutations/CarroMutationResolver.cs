using NET_GraphQL_API.Models;
using NET_GraphQL_API.Repositories;
using System.Numerics;

namespace NET_GraphQL_API.GraphQL.Resolvers.Mutations
{
    [ExtendObjectType("Mutation")]
    public class CarroMutationResolver
    {
        [GraphQLName("CreateCarro")]
        [GraphQLDescription("Adicionar novo carro")]
        public async Task<Carro> CreateCarro(CarroInput carroInput, [Service] ICarroRepository carroRepository)
        {
            var carro = new Carro()
            {
                Id = carroInput.Id,
                Nome = carroInput.Nome,
                MontadoraId = carroInput.MontadoraId
            };

            return await carroRepository.CreateCarro(carro);
        }

        [GraphQLName("DeleteCarro")]
        [GraphQLDescription("Excluir um carro")]
        public async Task<int> DeleteCarro(int carroId, [Service] ICarroRepository carroRepository)
        {
            Carro carro = carroRepository.GetCarroById(carroId);

            if (carro == null)
            {
                throw new GraphQLException(new Error("Carro não encontrado.", "CARRO_NOT_FOUND"));
            }

            return await carroRepository.DeleteCarro(carro);
        }

        [GraphQLName("UpdateCarro")]
        [GraphQLDescription("Atualizar Carro")]
        public async Task<Carro> UpdatePlayerAsync(int carroId, CarroInput carroInput,[Service] ICarroRepository carroRepository)
        {
            Carro carro = carroRepository.GetCarroById(carroId);

            if (carro == null)
            {
                throw new GraphQLException(new Error("Carro não encontrado.", "CARRO_NOT_FOUND"));
            }

            carro.Nome = carroInput.Nome;
            carro.MontadoraId = carroInput.MontadoraId;

            await carroRepository.UpdateCarro(carro);

            return carro;
        }
    }
}
