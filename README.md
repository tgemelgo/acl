
# Desenho de Solução.
> O desenho de solução foi idealizado com base nos requisitos funcionais, contudo tomei a liberdade de incluir um SPA para visualização dos dados fora a API

![enter image description here](https://github.com/tgemelgo/acl/raw/main/Desenho%20de%20Solu%C3%A7%C3%A3o.jpg)
# Build Application
Abaixo teremos duas formas execução do projeto, uma utilizando o docker e outra utilizando o proprio .net 6

## docker
 1. Abra o prompt de comando do windows o bash do linux
 2. Acesse o diretório onde o projeto foi baixado e descompactado
 3. Execute os comandos na ordem abaixo
	 1. `Docker build -t teste-tiago-gemelgo .`
	 2. `Docker run -p 8080:80 teste-tiago-gemelgo`
	 3. a documentação das apis estão disponiveis no link abaixo
		[***http://localhost:8080/swagger/index.html***](http://localhost:8080/swagger/index.html)

## dotnet
 Abra o prompt de comando do windows o bash do linux
 1. Acesse o diretório onde o projeto foi baixado e descompactado
 2. Execute os comandos na ordem abaixo
	 1. Instale o .net 6 caso ele não esteja instalado.
	 2. Execute o comando abaixo para executar a aplicação. 
	 3. `dotnet run urls=http://localhost:8080`
	 4. a documentação das apis estão disponiveis no link abaixo http://localhost:8080/swagger/index.html
