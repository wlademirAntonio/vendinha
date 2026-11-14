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

        public DbSet<Cliente> Clientes => Set<Cliente>();
        public DbSet<Divida> Dividas => Set<Divida>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var entityCliente = modelBuilder.Entity<Cliente>();

            entityCliente.ToTable("cliente");
            entityCliente.Property(c => c.Id).HasColumnName("id");
            entityCliente.Property(c => c.Nome).HasColumnName("nome");
            entityCliente.Property(c => c.Cpf).HasColumnName("cpf");
            entityCliente.Property(c => c.DataNascimento).HasColumnName("data_nascimento").HasColumnType("date");
            entityCliente.Property(c => c.Email).HasColumnName("email");
            entityCliente.HasKey(c => c.Id);

            var entityDivida = modelBuilder.Entity<Divida>();

            entityDivida.ToTable("divida");
            entityDivida.Property(c => c.Id).HasColumnName("id");
            entityDivida.Property(c => c.ClienteId).HasColumnName("cliente_id");
            entityDivida.Property(c => c.Valor).HasColumnName("valor");
            entityDivida.Property(c => c.Pago).HasColumnName("pago");
            entityDivida.Property(c => c.DataCriacao).HasColumnName("data_criacao").HasColumnType("date");
            entityDivida.Property(c => c.DataPagamento).HasColumnName("data_pagamento").HasColumnType("date");
            entityDivida.HasKey(c => c.Id);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!string.IsNullOrEmpty(connectionString))
            {
                optionsBuilder.UseNpgsql(connectionString)
                    .LogTo(message => Debug.WriteLine(message))
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors();
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
