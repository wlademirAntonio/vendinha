using vendinha.Models;

Console.WriteLine(Cpf.EValido("123.456.789-09"));
Console.WriteLine(Cpf.EValido("12345678909"));
Console.WriteLine(Cpf.EValido("111.111.111-11"));
Console.WriteLine(Cpf.EValido("529.982.247-25"));
Console.WriteLine(Cpf.EValido("529.982.247-24"));