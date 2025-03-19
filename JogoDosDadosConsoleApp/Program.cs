namespace JogoDosDadosConsoleApp
{ 
    /** Versão 1 - Estrutura Básica e simulação de dados
    *  Exibir um Banner para o Jogo de Dados [X]
    *  Implementar a geração de números aleatórios para simular um dado (1-6) [X]
    *  * Exibir o resultado do lançamento do dado [X]
    *  * Permitir que o usuário pressione Enter para lançar o dado [X]
    **/

    /** Versão 2 - Controle de posição do jogador
     * Armazenar a posição do jogador na pista e atualizar o valor após o lançamento do dado [X]
     * Exibir a posição atual do jogador na pista [X]
     * Definir a linha de chegada em 30, verificar se o jogador alcançou ou ultrapassou a linha de chegada [X]
     * Permitir ao jogador realizar várias jogadas [X]
     **/

    /** Versão 3 - Eventos Especiais: Avanço Extra e Recuo
     * Implementar o evento de avanço extra nas posições 5, 10, 15 [X]
     * Implementar o evento de recuo extra nas posições 7, 13, 20 [X]
     * Exibir mensagens informativas quando os eventos ocorrerem [X]
     * Atualizar a posição do jogador conforme as regras de evento [X]
     * Exibir nova posição
     **/

    /** Versão 4 - Incluir o computador como concorrente
     * Informar que o computador está jogando [X]
     * Armazenar a posição do computador no tabuleiro e atualizar o valor após o lançamento do dado [X]
     * Atualizar a posição do computador após o lançamento do dado [X]
     * Implementar o evento de avanço extra nas posições 5, 10, 15 [X]
     * Implementar o evento de recuo nas posições 7, 13 , 20 [X]
     * Exibir mensagens informativas quando os eventos ocorrerem [X]
     * Atualizar a posição do jogador conforme as regras dos eventos [X]
     * Exibir a nova posição [X]
     * Verificar se o computador alcançou ou ultrapassou a linha de chegada [X]
     * Informar quem venceu o jogo [X]
     * Implementar turnos alternados entre jogador e computador [X]
     **/

    internal class Program
    {
        static void Main(string[] args)
        {

            //Declarando uma constante para determinar o número máximo de espaços do tabuleiro, este valor não pode ser alterado, serve apenas como leitura
            const int limiteLinhaChegada = 30;

            while (true)
            {

                int posicaoJogador = 0;
                int posicaoComputador = 0;

                bool jogoEmAndamento = true;

                while (jogoEmAndamento) //loop para determinar se a partida está ativa ou não
                {
                    //Menu principal
                    Console.Clear();
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Jogo dos Dados");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Rodada do Usuário");
                    Console.WriteLine("---------------------------------");
                    //Permite que o usuário pressione enter para jogar o dado
                    Console.Write("Pressione ENTER para lançar o dado!");
                    Console.ReadLine();

                    //Geração dos valores do dado do Jogador
                    int resultadoJogador = SortearDado();

                    //Escreve o resultado do dado na tela
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($"O valor sorteado foi: {resultadoJogador}.");
                    Console.WriteLine("---------------------------------");

                    posicaoJogador += resultadoJogador;

                    Console.WriteLine($"Sua posição atual é: {posicaoJogador} de {limiteLinhaChegada}");
                    Console.WriteLine("---------------------------------");

                    //Evento especial de avanço de casas
                    if (posicaoJogador == 5 || posicaoJogador == 10 || posicaoJogador == 15 || posicaoJogador == 25)
                    {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Evento especial: Avanço extra de 3 casas!");

                        posicaoJogador += 3;

                        Console.WriteLine("---------------------------------");
                        Console.WriteLine($"Sua nova posição é: {posicaoJogador}");
                        Console.WriteLine("---------------------------------");
                    }
                    //Evento especial de recuo de casas
                    else if (posicaoJogador == 7 || posicaoJogador == 13 || posicaoJogador == 20)
                    {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Que pena! Seu resultado lhe fez recurar 2 casas!");
                        Console.WriteLine("---------------------------------");

                        posicaoJogador -= 2;
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine($"Sua nova posição é: {posicaoJogador}");
                        Console.WriteLine("---------------------------------");
                    }

                    //Condição de Vitória do Jogador
                    if (posicaoJogador >= limiteLinhaChegada)
                    {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Parabéns! Você alcançou a linha de chegada!");
                        Console.WriteLine("---------------------------------");
                        
                        jogoEmAndamento = false;
                        continue;
                    }

                    //Rodada do Computador 
                    Console.WriteLine("\n\n---------------------------------");
                    Console.WriteLine("Iniciando a rodada do Computador");
                    Console.WriteLine("---------------------------------");
                    Console.Write("Pressione ENTER para visualizar a rodada do computador");
                    Console.ReadLine();
                    //Geração dos valores do dado para o Computador                    
                    int resultadoComputador = SortearDado();

                    //Escreve o resultado do dado do computador na tela
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($"O valor sorteado foi: {resultadoComputador}.");
                    Console.WriteLine("---------------------------------");

                    posicaoComputador += resultadoComputador;

                    Console.WriteLine($"A posição atual do computador  é: {posicaoComputador} de {limiteLinhaChegada}");
                    Console.WriteLine("---------------------------------");

                    //Evento especial de avanço de casas para o Computador
                    if (posicaoComputador == 5 || posicaoComputador == 10 || posicaoComputador == 15 || posicaoComputador == 25)
                    {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Evento especial: O computador avançou 3 casas extras!");
                        Console.WriteLine("---------------------------------");

                        posicaoComputador += 3;

                        Console.WriteLine("---------------------------------");
                        Console.WriteLine($"A nova posição do computador é:{posicaoComputador}");
                    }
                    //Evento especial de recuo de casas para o Computador
                    else if (posicaoComputador == 7 || posicaoComputador == 13 || posicaoComputador == 20)
                    {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Evento especial: O computador recuou 2 casas!");
                        Console.WriteLine("---------------------------------");

                        posicaoComputador -= 2;
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine($"A nova posição do computador é:{posicaoComputador}");
                        Console.WriteLine("---------------------------------");
                    }

                    //Condição de Vitória para o Computador
                    if (posicaoComputador >= limiteLinhaChegada)
                    {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Que pena! Você perdeu! O computador chegou na última casa primeiro.");
                        Console.WriteLine("---------------------------------");

                        jogoEmAndamento = false;
                        continue;
                    }

                    Console.ReadLine();

                }
                //Quebra do loop e opção de continuar a jogar
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Deseja jogar novamente? (S/N) ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }

        static int SortearDado()
        {
            //Geração dos valores do dado para o Computador e Jogador
            Random geradorDeNumeros = new Random();
            
            int resultado = geradorDeNumeros.Next(1, 7);
            
            return resultado;
        }

    }
}