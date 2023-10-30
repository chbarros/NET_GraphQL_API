using Microsoft.EntityFrameworkCore;
using NET_GraphQL_API.Context;
using NET_GraphQL_API.Models;
using NET_GraphQL_API.Repositories;
using HotChocolate.AspNetCore;
using HotChocolate;
using NET_GraphQL_API.GraphQL.Resolvers.Queries;
using NET_GraphQL_API.GraphQL.Resolvers.Mutations;

namespace NET_GraphQL_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IMontadoraRepository, MontadoraRepository>();
            builder.Services.AddScoped<ICarroRepository, CarroRepository>();

            builder.Services.AddDbContextFactory<ApplicationDbContext>(options => options.UseInMemoryDatabase("GerenciamentoCarros"));

            builder.Services
                .AddGraphQLServer()
                .AddQueryType(q => q.Name("Query"))
                .AddType<MontadoraQueryResolver>()
                .AddType<CarroQueryResolver>()
                .AddMutationType(m => m.Name("Mutation"))
                .AddType<CarroMutationResolver>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.MapGraphQL();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}