using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace vendinha.Models
{
    public class Divida
    {
        public int Id { get; set; }

        [Required]
        public int ClienteId { get; set; }
        
        [Required]
        [Range(typeof(decimal), "0.01", "9999.99",
            ParseLimitsInInvariantCulture = true,
            ConvertValueInInvariantCulture = true,
            ErrorMessage = "O valor deve estar entre 0,01 e 9.999,99.")]
        public decimal Valor { get; set; }

        public bool Pago { get; set; }

        public DateTime DataCriacao { get; set; } = DateTime.Now;

        public DateTime? DataPagamento { get; set; }
        [NotMapped]
        public Cliente? Cliente { get; set; }
    }
}
