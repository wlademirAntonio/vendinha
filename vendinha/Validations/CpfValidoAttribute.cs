using System.ComponentModel.DataAnnotations;

namespace vendinha.Validations
{
    public class CpfValidoAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (EValido(value as string))
                return ValidationResult.Success;

            return new ValidationResult(ErrorMessage ?? "CPF inválido.");
        }

        public static string Normalizar(string? valor) =>
            new string((valor ?? string.Empty).Where(char.IsDigit).ToArray());

        public static bool EValido(string? valor)
        {
            var cpf = Normalizar(valor);

            if (cpf.Length != 11) return false;

            if (cpf.Distinct().Count() == 1) return false;

            var digito1 = CalcularDigito(cpf, 9);
            var digito2 = CalcularDigito(cpf, 10);

            return cpf[9] - '0' == digito1 && cpf[10] - '0' == digito2;
        }

        private static int CalcularDigito(string cpf, int quantidade)
        {
            var soma = 0;
            for (var i = 0; i < quantidade; i++)
                soma += (cpf[i] - '0') * (quantidade + 1 - i);

            var resto = soma % 11;
            return resto < 2 ? 0 : 11 - resto;
        }
    }
}
