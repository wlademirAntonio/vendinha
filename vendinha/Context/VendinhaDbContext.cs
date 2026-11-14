using Microsoft.EntityFrameworkCore;

using System.Diagnostics;
using vendinha.Models;

namespace vendinha.Context
{
    public class VendinhaDbContext : DbContext
    {
        private string connectionString;

        public VendinhaDbContext(string connString)
        {
            this.connectionString = connString;
        }

        public VendinhaDbContext(DbContextOptions opt) : base(opt) { }

        public DbSet<Cliente> Cliente => Set<Cliente>();
        public DbSet<Divida> Divida => Set<Divida>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var entityCliente = modelBuilder.Entity<Cliente>();

            entityCliente.Property(c => c.Id).HasColumnName("id");
            entityCliente.Property(c => c.Nome).HasColumnName("nome");
            entityCliente.Property(c => c.Cpf).HasColumnName("cpf");
            entityCliente.Property(c => c.DataNascimento).HasColumnName("data_nascimento");
            entityCliente.Property(c => c.Email).HasColumnName("email");

            var entityDivida = modelBuilder.Entity<Divida>();

            entityDivida.Property(c => c.Id).HasColumnName("id");
            entityDivida.Property(c => c.ClienteId).HasColumnName("cliente_id");
            entityDivida.Property(c => c.Valor).HasColumnName("valor");
            entityDivida.Property(c => c.Pago).HasColumnName("pago");
            entityDivida.Property(c => c.DataCriacao).HasColumnName("data_criacao");
            entityDivida.Property(c => c.DataPagamento).HasColumnName("data_pagamento");

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString)
                .LogTo(message => Debug.WriteLine(message))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();

            base.OnConfiguring(optionsBuilder);
        }
    }
}
