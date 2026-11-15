# Vendinha

Sistema desktop para controlar os clientes de uma vendinha e as dívidas penduradas (o "fiado") de cada um. Feito em C# (Windows Forms) com PostgreSQL.

## O que ele faz

- Cadastrar, editar, excluir e pesquisar clientes
- Registrar dívidas de um cliente e marcá-las como pagas
- Mostrar quanto cada cliente está devendo

**Regras importantes:**
- O CPF precisa ser válido e não pode se repetir
- Cada cliente só pode ter **uma dívida em aberto** por vez
- Valor da dívida: de R$ 0,01 a R$ 9.999,99
- Excluir um cliente apaga também as dívidas dele

## O que você precisa instalar

- **Windows 10 ou 11** (o sistema não roda em Linux nem macOS)
- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- [PostgreSQL](https://www.postgresql.org/download/)
- [Git](https://git-scm.com/downloads)

## Como rodar

**1. Baixe o projeto**

```bash
git clone https://github.com/wlademirAntonio/vendinha.git
cd vendinha
```

**2. Crie o banco de dados**

```bash
psql -U postgres -c "CREATE DATABASE vendinhadb;"
psql -U postgres -d vendinhadb -f database/vendinhadb.sql
```

Opcional, para ter clientes e dívidas de exemplo:

```bash
psql -U postgres -d vendinhadb -f database/insertspteste.sql
```

> Se o `psql` não for reconhecido, rode os arquivos `.sql` pelo pgAdmin (*Query Tool*).

**3. Coloque a senha do seu PostgreSQL**

Abra estes dois arquivos e troque `Password=wlad` pela sua senha, na linha 18 de cada um:

- `vendinha/Services/ClienteService.cs`
- `vendinha/Services/DividaService.cs`

```csharp
private const string ConnectionString = "Host=localhost;Port=5432;Database=vendinhadb;Username=postgres;Password=SUA_SENHA";
```

**4. Execute**

```bash
dotnet run --project vendinha.Desktop
```

Ou abra o `vendinha.slnx` no Visual Studio, defina `vendinha.Desktop` como projeto de inicialização e aperte **F5**.

## Como usar

1. Na tela inicial, clique em **Acessar Sistema**.
2. Na lista de clientes:
   - digite no campo de pesquisa para filtrar pelo nome
   - use **Adicionar**, **Editar** e **Excluir** (selecione a linha antes de editar ou excluir)
   - use **←** e **→** para trocar de página
   - dê um **clique duplo** em um cliente para ver as dívidas dele
3. Na tela de dívidas:
   - digite o valor (ex.: `123,45`) e clique em **Adicionar** para pendurar uma dívida
   - selecione uma dívida e clique em **Marcar Pagamento** para quitá-la

## Estrutura

```
database/          Scripts SQL (tabelas e dados de exemplo)
vendinha/          Lógica do sistema (modelos, validações e acesso ao banco)
vendinha.Desktop/  Telas Windows Forms (projeto que você executa)
```

## Problemas comuns

| Erro | Solução |
|---|---|
| `password authentication failed` | A senha no passo 3 está errada (confira os dois arquivos) |
| `database "vendinhadb" does not exist` | Refaça o passo 2 |
| `relation "cliente" does not exist` | Rode o `vendinhadb.sql` no banco `vendinhadb` |
| `Failed to connect to ...:5432` | O PostgreSQL não está rodando. Inicie o serviço |
| Programa fecha ao clicar em Editar ou Excluir | Selecione um cliente na lista antes |
| Pesquisa não acha o cliente | A busca diferencia maiúsculas e minúsculas. Digite como está cadastrado |

## Licença

MIT. Veja o arquivo [LICENSE.txt](LICENSE.txt).
