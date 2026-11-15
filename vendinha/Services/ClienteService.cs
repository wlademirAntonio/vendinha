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
            var context = new ValidationContext(cliente);
            erros = new List<ValidationResult>();
            var valido = Validator.TryValidateObject(cliente, context, erros, true);
            var existente = Context.Clientes.Any(e => e.Cpf == cliente.Cpf);

            if (existente)
            {
                erros.Add(new ValidationResult("Já existe um cliente com este CPF."));
                return false;
            }
            return valido;
        }

        public bool ValidaPeloId(Cliente cliente, out List<ValidationResult> erros)
        {
            var context = new ValidationContext(cliente);
            erros = new List<ValidationResult>();
            var valido = Validator.TryValidateObject(cliente, context, erros, true);
            var existente = Context.Clientes.Find(cliente.Id);

            if (existente == null)
            {
                erros.Add(new ValidationResult("Cliente não existe."));
            }
            return valido;
        }

        public bool Criar(Cliente cliente, out List<ValidationResult> erros)
        {
            if (!VerificarCpf(cliente, out erros))
                return false;

            Context.Add(cliente);
            Context.SaveChanges();
            return true;
        }

        public List<Cliente> Listar(string pesquisa, int page = 1)
        {
            int pageSize = 10;
            var skip = (page - 1) * pageSize;

            var resultado = Context.Clientes
                .Where((cliente) => cliente.Nome.Contains(pesquisa))
                .Select((cliente) => new Cliente{
                    Id = cliente.Id,
                    Nome = cliente.Nome,
                    Cpf = cliente.Cpf,
                    DataNascimento = cliente.DataNascimento,
                    Email = cliente.Email,
                    QtdDividas = cliente.Dividas.Count(d => d.ClienteId == cliente.Id && !d.Pago),
                    TotalDividas = cliente.Dividas.Where(d => d.ClienteId == cliente.Id && !d.Pago).Sum(d => d.Valor)
                })
                .OrderByDescending(c => c.QtdDividas)
                .ThenByDescending(c => c.TotalDividas)
                .ThenBy(c => c.Nome)
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

            var c = Context.Clientes.Find(cliente.Id);

            Context.Clientes.Remove(c);
            Context.SaveChanges();
            return true;
        }
    }
}
