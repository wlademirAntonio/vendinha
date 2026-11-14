using System.ComponentModel.DataAnnotations;
using vendinha.Context;
using vendinha.Models;

namespace vendinha.Services
{
    public class ClienteService
    {
        private VendinhaDbContext Context;

        public ClienteService(VendinhaDbContext context)
        {
            this.Context = context;
        }

        public ClienteService() : this(new VendinhaDbContext(ConnectionString)) { }

        private const string ConnectionString = "Host=localhost;Port=5432;Database=vendinhadb;Username=postgres;Password=wlad";

        public bool Validar(Cliente cliente, out List<ValidationResult> erros)
        {
            var context = new ValidationContext(cliente);
            erros = new List<ValidationResult>();
            var valido = Validator.TryValidateObject(cliente, context, erros, true);
            var existente = Context.Clientes.Any(e => e.Cpf == cliente.Cpf);

            if (existente)
            {
                erros.Add(new ValidationResult("Já existe um cliente com este CPF."));
            }

            return valido;
        }

        public bool Criar(Cliente cliente, out List<ValidationResult> erros)
        {
            if (!Validar(cliente, out erros))
            {
                return false;
            }

            Context.Add(cliente);
            Context.SaveChanges();
            return true;
        }
    }
}
