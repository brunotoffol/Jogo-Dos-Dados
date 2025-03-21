# Jogo Dos Dados

## Introdução

Jogo onde o jogador compete contra o computador via rolagem de dados com o objetivo de chegar a linha de chegada primeiro.

### Exemplo

![]()

### Funcionalidades

- Rolagem de dados (1 a 6) aleatória para o computador e o jogador, exibindo os resultados na tela.
- Eventos especiais, tanto para avanço extra de casas, quanto para recuo de casas para os dois jogadores.
- Informa a posição atual do jogador e computador após cada rolagem ou evento especial.
- Primeiro jogador a passar pela casa 30 vence o jogo.

### Como utilizar:
1. Clone o repositório ou baixe o código fonte
2. Abre o terminal ou prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as depências do projeto

```
dotnet restore
```
4. Em seguida, compile a solução utilizando o comando:
```
dotnet build --configuration Release
```
5. Para Executar o projeto compilando em tempo real
```
dotnet run --project JogoDosDadosConsoleApp
```
6. Para executar o arquivo compilado, navegue até a pasta ./JogoDosDadosConsoleApp/bin/Release/net8.0/ e execute o arquivo:
```
JogoDosDadosConsoleApp.exe
```

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.