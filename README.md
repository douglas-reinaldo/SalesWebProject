# SalesWebMVC

**SalesWebMVC** é uma aplicação web desenvolvida em **ASP.NET Core MVC** com suporte a banco de dados **MySQL**, focada no gerenciamento de vendedores (Sellers), departamentos e registros de vendas.

O sistema implementa um CRUD completo para Sellers e Departments, enquanto os registros de vendas (SalesRecords) ainda são gerenciados diretamente via SQL ou migrações.

## Funcionalidades

- CRUD completo para:
  - Vendedores (Sellers)
  - Departamentos (Departments)
- Relacionamento entre vendedores e departamentos
- Visualização de registros de vendas (SalesRecords)
- Interface amigável baseada em Razor Pages

## Tecnologias Utilizadas

- ASP.NET Core MVC
- Entity Framework Core
- MySQL
- C#
- Razor Pages
- Bootstrap

## Como Executar o Projeto


### 1. Clone o repositório

```bash
git clone https://github.com/douglas-reinaldo/SalesWebProject.git
cd SalesWebProject

```


### 2. Configure o banco de dados
```bash
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=saleswebmvc;User=seuUsuario;Password=suaSenha;"
}
```

### 3. Executa as migrations
```bash
dotnet ef database update
```
ou no Package Manager Console
```bash
Update-Database
```



