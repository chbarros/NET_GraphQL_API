using Microsoft.EntityFrameworkCore;
using NET_GraphQL_API.Models;

namespace NET_GraphQL_API.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Montadora> Montadoras { get; set; }
        public DbSet<Carro> Carros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Montadora mont1 = new Montadora
            {
                Id = 1,
                Nome = "Volkswagen"
            };
            Montadora mont2 = new Montadora
            {
                Id = 2,
                Nome = "Ford"
            };
            Montadora mont3 = new Montadora
            {
                Id = 3,
                Nome = "Toyota"
            };
            Montadora mont4 = new Montadora
            {
                Id = 4,
                Nome = "Lamborghini"
            };

            modelBuilder.Entity<Montadora>().HasData(mont1, mont2, mont3, mont4);

            modelBuilder.Entity<Carro>().HasData(
                new Carro
                {
                    Id = 1,
                    Nome = "Polo",
                    MontadoraId = 1
                },
                new Carro
                {
                    Id = 2,
                    Nome = "Golf",
                    MontadoraId = 1
                },
                new Carro
                {
                    Id = 3,
                    Nome = "Tiguan",
                    MontadoraId = 1
                },
                new Carro
                {
                    Id = 4,
                    Nome = "Fiesta",
                    MontadoraId = 2
                },
                new Carro
                {
                    Id = 5,
                    Nome = "Mustang",
                    MontadoraId = 2
                },
                new Carro
                {
                    Id = 6,
                    Nome = "Ranger",
                    MontadoraId = 2
                },
                new Carro
                {
                    Id = 7,
                    Nome = "Corolla",
                    MontadoraId = 3
                },
                new Carro
                {
                    Id = 8,
                    Nome = "Yaris",
                    MontadoraId = 3
                },
                new Carro
                {
                    Id = 9,
                    Nome = "Supra",
                    MontadoraId = 3
                },
                new Carro
                {
                    Id = 10,
                    Nome = "Huracan",
                    MontadoraId = 4
                },
                new Carro
                {
                    Id = 11,
                    Nome = "Aventador",
                    MontadoraId = 4
                },
                new Carro
                {
                    Id = 12,
                    Nome = "Urus",
                    MontadoraId = 4
                }
            );
        }
    }
}
