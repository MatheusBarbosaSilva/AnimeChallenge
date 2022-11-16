# AnimeChallenge

<h2> O Projeto tem como objetivo realizar as operações CRUD, utilizando os padrões da API REST.</h2>

O Cenário utilizado é o registro de animes, onde podemos inserir seu nome, sumário e autor, 
realizar páginação dos animes registrados no banco de dados, pesquisar o anime por nome, sumário ou autor,
realizar update do anime e realizar a exclusão lógica do anime.

<h2> Tecnologias Utilizadas: </h2>

* .Net 6
* C#
* Docker
* Entity FrameWork Core
* SqlServer
* Swagger
* MSTEST - para testes unitário (incompleto).

<h2> Rodar SqlServer no Docker: <h2> 

* Necessario tem o Docker instalado na máquina.
* Comando Necessários (Windows):
  Obter imagem - docker pull mcr.microsoft.com/mssql/server
  Rodar o SqlServer - docker run --name sqlserver -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=[senha]" -p 1433:1433 -d mcr.microsoft.com/mssql/server
  
* Se estiver rodando o **WSL 2**:
  Rodar o SqlServer - docker run -v ~/docker --name sqlserver -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=[senha]" -p 1433:1433 -d mcr.microsoft.com/mssql/server
  
* Connection String:
  Server=localhost,1433;Database=Banco_Animes;User ID=sa;Password=[senha]
  
<h1> Aplicação disponibiliza Swagger para realização dos testes <h1>
