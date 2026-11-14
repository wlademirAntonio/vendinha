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

var divida = new Divida
{
    //Id = 1,
    ClienteId = 6,
    Valor = 100.00m,
};

var dividaService = new DividaService();
var sucesso = dividaService.Criar(divida, out var erros);
//var sucesso = dividaService.Pagar(divida, out var erros);

//var service = new ClienteService();
//var sucesso = service.Excluir(cliente, out var erros);
//var sucesso = service.Atualizar(cliente, out var erros);
//var sucesso = service.Criar(cliente, out var erros);
//var clientes = service.Listar();

//foreach (var c in clientes)
//{
//    Console.WriteLine($"Id: {c.Id}, Nome: {c.Nome}, CPF: {c.Cpf}, Idade: {c.Idade}");
//}

if (sucesso)
{
    Console.WriteLine("Feito!");
}
else
{
    Console.WriteLine("Falha!");

    foreach (var erro in erros)
    {
        Console.WriteLine(erro.ErrorMessage);
    }
}