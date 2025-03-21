# Jogo Dos Dados

## Introdu��o

Jogo onde o jogador compete contra o computador via rolagem de dados com o objetivo de chegar a linha de chegada primeiro.

### Exemplo

![]()

### Funcionalidades

- Rolagem de dados (1 a 6) aleat�ria para o computador e o jogador, exibindo os resultados na tela.
- Eventos especiais, tanto para avan�o extra de casas, quanto para recuo de casas para os dois jogadores.
- Informa a posi��o atual do jogador e computador ap�s cada rolagem ou evento especial.
- Primeiro jogador a passar pela casa 30 vence o jogo.

### Como utilizar:
1. Clone o reposit�rio ou baixe o c�digo fonte
2. Abre o terminal ou prompt de comando e navegue at� a pasta raiz
3. Utilize o comando abaixo para restaurar as dep�ncias do projeto

```
dotnet restore
```
4. Em seguida, compile a solu��o utilizando o comando:
```
dotnet build --configuration Release
```
5. Para Executar o projeto compilando em tempo real
```
dotnet run --project JogoDosDadosConsoleApp
```
6. Para executar o arquivo compilado, navegue at� a pasta ./JogoDosDadosConsoleApp/bin/Release/net8.0/ e execute o arquivo:
```
JogoDosDadosConsoleApp.exe
```

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.