using System.ComponentModel.DataAnnotations;
using vendinha.Context;
using vendinha.Models;

namespace vendinha.Services
{
    public class DividaService
    {
        private VendinhaDbContext Context;

        public DividaService(VendinhaDbContext context)
        {
            this.Context = context;
        }

        public DividaService() : this(new VendinhaDbContext(ConnectionString)) { }

        private const string ConnectionString = "Host=localhost;Port=5432;Database=vendinhadb;Username=postgres;Password=wlad";

        public bool ValidaPeloId(Divida divida, out List<ValidationResult> erros)
        {
            erros = new List<ValidationResult>();
            var existente = Context.Dividas.Any(e => e.Id == divida.Id);

            if (!existente)
            {
                erros.Add(new ValidationResult("Divida não existe."));
                return false;
            }
            return true;
        }

        public bool Criar(Divida divida, out List<ValidationResult> erros)
        {
            erros = new List<ValidationResult>();
            var clienteExistente = Context.Clientes.Any(c => c.Id == divida.ClienteId);
            var dividaAberta = Context.Dividas.Any(d => d.ClienteId == divida.ClienteId && !d.Pago);

            if (!clienteExistente)
            {
                erros.Add(new ValidationResult("Cliente não existe."));
                return false;
            }

            if (dividaAberta)
            {
                erros.Add(new ValidationResult("Cliente já possui uma dívida aberta."));
                return false;
            }

            Context.Add(divida);
            Context.SaveChanges();
            return true;
        }

        public bool Pagar(Divida divida, out List<ValidationResult> erros)
        {

            if (!ValidaPeloId(divida, out erros))
            {
                return false;
            }

            var dividaExistente = Context.Dividas.Find(divida.Id);
            dividaExistente.Pago = true;
            dividaExistente.DataPagamento = DateTime.Now;
            Context.SaveChanges();
            return true;
        }   
    }
}
