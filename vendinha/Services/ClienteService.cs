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

        public bool VerificarCpf(Cliente cliente, out List<ValidationResult> erros)
        {
            erros = new List<ValidationResult>();
            var existente = Context.Clientes.Any(e => e.Cpf == cliente.Cpf);

            if (existente)
            {
                erros.Add(new ValidationResult("Já existe um cliente com este CPF."));
                return true;
            }
            return false;
        }

        public bool ValidaPeloId(Cliente cliente, out List<ValidationResult> erros)
        {
            //var context = new ValidationContext(id);
            erros = new List<ValidationResult>();
           //var valido = Validator.TryValidateObject(id, context, erros, true);
            var existente = Context.Clientes.Any(e => e.Id == cliente.Id);

            if (!existente)
            {
                erros.Add(new ValidationResult("Cliente não existe."));
                return false;
            }
            return true;
        }

        public bool Criar(Cliente cliente, out List<ValidationResult> erros)
        {
            if (VerificarCpf(cliente, out erros))
                return false;

            Context.Add(cliente);
            Context.SaveChanges();
            return true;
        }

        public List<Cliente> Listar(int page = 1)
        {
            int pageSize = 20;
            var skip = (page - 1) * pageSize;

            var resultado = Context.Clientes
                .OrderBy(c => c.Nome)
                .Skip(skip)
                .Take(pageSize)
                .ToList();

            return resultado;
        }

        public bool Atualizar(Cliente cliente, out List<ValidationResult> erros)
        {
            if (!ValidaPeloId(cliente, out erros))
                return false;

            var clienteExistente = Context.Clientes.Find(cliente.Id);
            clienteExistente.Nome = cliente.Nome;
            clienteExistente.Cpf = cliente.Cpf;
            clienteExistente.DataNascimento = cliente.DataNascimento;
            clienteExistente.Email = cliente.Email;

            Context.SaveChanges();
            return true;
        }

        public bool Excluir(Cliente cliente, out List<ValidationResult> erros)
        {
            if (!ValidaPeloId(cliente, out erros))
                return false;

            Context.Clientes.Remove(cliente);
            Context.SaveChanges();
            return true;
        }
    }
}
