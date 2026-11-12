using vendinha.Models;

var cliente = new Cliente
{
    Nome = "",
    Cpf = "46120074848",
    DataNascimento = new DateTime(2004, 11, 6),
    Email = ""
};

Console.WriteLine($"Nome: {cliente.Nome}");
Console.WriteLine($"CPF: {cliente.Cpf}");
Console.WriteLine($"E-mail: {cliente.Email}");
Console.WriteLine($"Idade: {cliente.Idade}");
Console.WriteLine($"Erros: {cliente.Validar().Count}");

foreach (var erro in cliente.Validar())
{
    Console.WriteLine($"- {erro}");
}