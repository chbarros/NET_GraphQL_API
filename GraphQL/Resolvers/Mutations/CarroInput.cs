namespace NET_GraphQL_API.GraphQL.Resolvers.Mutations
{
    public class CarroInput
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int MontadoraId { get; set; }
    }
}
