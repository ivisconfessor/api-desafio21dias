# Base de dados:
#### Esta aplicação foi criada por um DBA no exemplo da aula, por isso para utilizar a apliação crie a estrutura usando o arquivo estrutura.sql na pasta do projeto

``` bash
  ls estrutura
```

# Comandos iniciais:
``` bash
  mkdir api-desafio21dias
  cd api-desafio21dias
  dotnet new webapi
```

# Comandos git:
``` bash
  code .gitignore 
```
#### Gerei o conteúdo para ignorar como (Windows, Linux, Mac, DotnetCore, VisualStudioCore) no link: https://www.toptal.com/developers/gitignore
- Criei o repositório e rodei os comandos

``` bash
  git init
  git add .
  git commit -m "Iniciando projeto"
  git remote add origin git@github.com:torneseumprogramador/api-desafio21dias.git
  git branch -M main
  git push -u origin main
```

# Componentes instalados:
``` bash
  dotnet add package Microsoft.EntityFrameworkCore --version 5.0.9
  dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.9
  dotnet add package Swashbuckle.AspNetCore --version 5.6.3
  dotnet add package EntityFrameworkPaginateCore --version 2.1.0
```