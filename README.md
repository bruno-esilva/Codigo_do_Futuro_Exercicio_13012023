
# Autenticação com JWT

### Código do Futuro.

Repositório do Exercício de 13/01/2023 sobre autenticação com JWT.


## Ordem de Execução

* Criado o Projeto:
```bash
  dotnet new webapi -n Nome_do_Projeto
```
* Criados os Models;
* Configurado o Contexto\DbContext;
* Configurado o Serviço DbContext no Program.cs;
* Instaladas as dependências:
**Pacotes Necessários:**
```bash
  dotnet add package Microsoft.EntityFrameworkCore
  dotnet add package Pomelo.EntityFrameworkCore.MySql --version 7.0.0-silver.1
  dotnet add package Microsoft.EntityFrameworkCore.Tools
  dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
  dotnet add package Microsoft.EntityFrameworkCore.SqlServer
  dotnet tool install -g dotnet-aspnet-codegenerator
```
* Gerada a Migration e criada a Database:
```bash
  dotnet ef migrations add Nome_da_Migração
  dotnet ef database update
```
* Criados os Controllers com o Scaffold
```bash
  dotnet aspnet-codegenerator controller -name NOMEDOCONTROLLER -async -api -m NOMEDOMODEL -dc NOMEDACLASSECONTEXTO -outDir Controllers
```

