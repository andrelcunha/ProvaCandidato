namespace ProvaCandidato.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using ProvaCandidato.Data.Entidade;

    internal sealed class Configuration : DbMigrationsConfiguration<ProvaCandidato.Data.ContextoPrincipal>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProvaCandidato.Data.ContextoPrincipal context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var cities = new List<Cidade>
            {
                new Cidade
                {
                    Nome = "Curitiba"
                },
                new Cidade
                {
                    Nome = "Pinhais"
                },
                new Cidade
                {
                    Nome = "Colombo"
                },
                new Cidade
                {
                    Nome = "Piraquara"
                },
                new Cidade
                {
                    Nome = "Araucaria"
                },
            };
            cities.ForEach(s => context.Cidades.AddOrUpdate(p => p.Codigo, s));
            context.SaveChanges();


            var clients = new List<Cliente>
            {
                new Cliente
                {
                        Nome = "Mario Speedwagon",
                        DataNascimento = new DateTime(1998,09,30),
                        CidadeId = 1,
                        Ativo = true

                },
                new Cliente
                {
                        Nome = "Petey Cruiser",
                        DataNascimento = new DateTime(1981,04,20),
                        CidadeId = 2,
                        Ativo = false
                },
                new Cliente
                {
                        Nome = "Anna Sthesia",
                        DataNascimento = new DateTime(1990,10,25),
                        CidadeId = 3,
                        Ativo = true

                },
                new Cliente
                {
                        Nome = "Paul Molive",
                        DataNascimento = new DateTime(1978,08,03),
                        CidadeId = 1,
                        Ativo = false

                },
                new Cliente
                {
                        Nome = "Anna Mull",
                        DataNascimento = new DateTime(1968,06,16),
                        CidadeId = 2,
                        Ativo = true

                },
                new Cliente
                {
                        Nome = "Gail Forcewind",
                        DataNascimento = new DateTime(1955,04,12),
                        CidadeId = 3,
                        Ativo = false

                },
                new Cliente
                {
                        Nome = "Paige Turner",
                        DataNascimento = new DateTime(2000,02,28),
                        CidadeId = 1,
                        Ativo = true

                },
                new Cliente
                {
                        Nome = "Bob Frapples",
                        DataNascimento = new DateTime(1998,01,30),
                        CidadeId = 2,
                        Ativo = false
                }
            };
            clients.ForEach(s => context.Clientes.AddOrUpdate(p => p.Codigo, s));
            context.SaveChanges();
        }
    }
}
