using System.ComponentModel.DataAnnotations;

namespace vendinha.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O CPF é obrigatório.")]
        private string cpf = string.Empty;
        public string Cpf
        {
            get { return cpf; }
            set { cpf = Models.Cpf.Normalizar(value); }
        }

        public DateTime DataNascimento { get; set; }

        private string? email;
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        [StringLength(150)]
        public string? Email
        {
            get { return email; }
            set { email = string.IsNullOrWhiteSpace(value) ? null : value.Trim().ToLower(); }
        }

        public int Idade
        {
            get
            {
                var hoje = DateTime.Today;
                var idade = hoje.Year - DataNascimento.Year;
                if (DataNascimento.Date > hoje.AddYears(-idade))
                    idade--;
                return idade;
            }
        }
    }
}
