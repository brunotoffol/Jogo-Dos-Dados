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
     * Implementar o evento de avanço extra nas posições 5, 10, 15
     * Implementar o evento de recuo extra nas posições 7, 13, 20
     * Exibir mensagens informativas quando os eventos ocorrerem
     * Atualizar a posição do jogador conforme as regras de evento
     * Exibir nova posição
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
            bool jogoEmAndamento = true;

            while (jogoEmAndamento) //loop para determinar se a partida está ativa ou não
            {
                //Menu principal
                Console.Clear();
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Jogo dos Dados");
                Console.WriteLine("---------------------------------");

                //Permite que o usuário pressione enter para jogar o dado
                Console.Write("Pressione ENTER para lançar o dado!");
                Console.ReadLine();

                //Geração dos valores do dado
                Random geradorDeNumeros = new Random();
                int resultado = geradorDeNumeros.Next(1, 7);

                //Escreve o resultado do dado na tela
                Console.WriteLine("---------------------------------");
                Console.WriteLine($"O valor sorteado foi: {resultado}.");
                Console.WriteLine("---------------------------------");

                posicaoJogador += resultado;

                Console.WriteLine($"Sua posição atual é: {posicaoJogador} de {limiteLinhaChegada}");                

                //Evento especial de avanço de casas
                if (posicaoJogador == 5 || posicaoJogador == 10 || posicaoJogador == 15 || posicaoJogador == 25)
                    {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Evento especial: Avanço extra de 3 casas!");                       

                        posicaoJogador += 3;

                        Console.WriteLine($"Sua nova posição é: {posicaoJogador}");
                    }
                //Evento especial de recuo de casas
                else if (posicaoJogador == 7 || posicaoJogador == 13 || posicaoJogador == 20)
                    {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Que pena! Seu resultado lhe fez recurar 2 casas!");

                        posicaoJogador -= 2;
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine($"Sua nova posição é: {posicaoJogador}");
                    }

                //Condição de Vitória
                if (posicaoJogador >= limiteLinhaChegada)
                    {
                        jogoEmAndamento = false;
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Parabéns! Você alcançou a linha de chegada!");
                        Console.WriteLine("---------------------------------");
                    }
                    else
                        Console.WriteLine("---------------------------------");
                        Console.ReadLine();                    
            }            
            //Quebra do loop e opção de continuar
            Console.WriteLine("Deseja continuar? (S/N) ");
            string opcaoContinuar = Console.ReadLine()!.ToUpper();

            if (opcaoContinuar != "S")
                break;
        }
    }
}
}
