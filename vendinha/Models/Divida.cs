using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vendinha.Models
{
    public class Divida
    {
        public int Id { get; set; }

        [Required]
        public int ClienteId { get; set; }
        
        [Required]
        public decimal Valor { get; set; }

        public bool Pago { get; set; }

        public DateTime DataCriacao { get; set; } = DateTime.Now;

        public DateTime? DataPagamento { get; set; }
        [NotMapped]
        public Cliente? Cliente { get; set; }
    }
}
