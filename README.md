<h1 align="center">
    <p>🔗 Challenge Blip</p>
</h1>
<p align="center"> 🐱‍🏍 API + Blip Bot</p>

<p align="center">
  <a href="#-tecnologias">Tecnologias</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-projeto">Projeto</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-requisitos">Requisitos</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-requisitos">Requisitos</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#memo-licença">Licença</a>
</p>

<p align="center">
<a href="https://opensource.org/licenses/MIT">
<img align="center" src="https://img.shields.io/npm/l/express">
</a>
</p>

<br>

## 🚀 Tecnologias

Esse projeto foi desenvolvido com as seguintes tecnologias:

- [C#](https://docs.microsoft.com/pt-br/dotnet/csharp/)
- [.NET 5](https://docs.microsoft.com/pt-br/dotnet/)
- [Newtonsoft](https://www.nuget.org/packages/Newtonsoft.Json/)
- [Refit](https://www.nuget.org/packages/refit/6.0.8)
- [Swashbuckle](https://www.nuget.org/packages/Swashbuckle.AspNetCore/)

## 💻 Projeto

O challange é uma api desenvolvida no processo seletivo da Take, com o intuito de prover dados para que o bot criado na plataforma da [Blip](https://account.blip.ai/) possa apresentar os 5 repositórios mais antigos da stack C# criados na Take.

A api do projeto encontra-se publicado no Heroku neste <b><a href="https://challenge-take-api.herokuapp.com/api/v1/challenge">LINK</a></b> 

* Para testar o projeto é necessario criar uma conta no portal da blip e importar o fluxo contido na pasta [FLOW](https://github.com/JordhanFelix/challenge/tree/main/Flow). 


## 🔖 Requisitos

Antes de começar, você vai precisar ter instalado em sua máquina as seguintes ferramentas:
[Git](https://git-scm.com), [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0). 
Além disto é bom ter um editor para trabalhar com o código como [VSCode](https://code.visualstudio.com/) ou [Visual Studio Comunity](https://visualstudio.microsoft.com/pt-br/vs/community/)

### 🎲 Rodando o Back-End (servidor) em modo de desenvolvimento

```bash
# Clone este repositório
$ git clone <https://github.com/JordhanFelix/challenge.git>

# Acesse a pasta do projeto no terminal/cmd
$ cd Api/Api


# Para compilar o projeto
$ dotnet build

# Execute a aplicação em modo de desenvolvimento
$ dotnet run

# O servidor inciará e no console terá uma mensagem informando a porta, EX: Now listening on: http://localhost:5000
```

## :memo: Licença

Esse projeto está sob a licença MIT. Veja o arquivo [LICENSE](https://challenge-take-api.herokuapp.com/api/v1/challenge) para mais detalhes.

---

Feito com ♥ by Jordhan Félix :wave:
