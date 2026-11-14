using vendinha.Models;
using vendinha.Services;

//var cliente = new Cliente
//{
//    Id = 6,
//    Nome = "Wlademir Antonio",
//    Cpf = "46120074848",
//    DataNascimento = new DateTime(2003, 11, 6),
//    Email = "xb14396798@outlook.com"
//};

//Console.WriteLine($"Nome: {cliente.Nome}");
//Console.WriteLine($"CPF: {cliente.Cpf}");
//Console.WriteLine($"E-mail: {cliente.Email}");
//Console.WriteLine($"Idade: {cliente.Idade}");

var service = new ClienteService();
//var sucesso = service.Excluir(cliente, out var erros);
//var sucesso = service.Atualizar(cliente, out var erros);
//var sucesso = service.Criar(cliente, out var erros);
var clientes = service.Listar();

foreach (var c in clientes)
{
    Console.WriteLine($"Id: {c.Id}, Nome: {c.Nome}, CPF: {c.Cpf}, Idade: {c.Idade}");
}

//if (sucesso)
//{
//    Console.WriteLine("Aluno cadastrado com sucesso!");
//}
//else
//{
//    Console.WriteLine("Falha ao cadastrar o aluno");

//    foreach (var erro in erros)
//    {
//        Console.WriteLine(erro.ErrorMessage);
//    }
//}