using vendinha.Models;
using vendinha.Services;

var cliente = new Cliente
{
    Nome = "Wlademir Antonio",
    Cpf = "46120074848",
    DataNascimento = new DateTime(2004, 11, 6),
    Email = "tonymartinsjunior@gmail.com"
};

Console.WriteLine($"Nome: {cliente.Nome}");
Console.WriteLine($"CPF: {cliente.Cpf}");
Console.WriteLine($"E-mail: {cliente.Email}");
Console.WriteLine($"Idade: {cliente.Idade}");

var service = new ClienteService();
var sucesso = service.Criar(cliente, out var erros);

if (sucesso)
{
    Console.WriteLine("Aluno cadastrado com sucesso!");
}
else
{
    Console.WriteLine("Falha ao cadastrar o aluno");

    foreach (var erro in erros)
    {
        Console.WriteLine("{0}: {1}", 
            erro.MemberNames.First(),
            erro.ErrorMessage);
    }
}