namespace JogoDosDadosConsoleApp
{
    /** Versão 1 - Estrutura Básica e simulação de dados
    *  Exibir um Banner para o Jogo de Dados [X]
    *  Implementar a geração de números aleatórios para simular um dado (1-6) [X]
    *  * Exibir o resultado do lançamento do dado [X]
    *  * Permitir que o usuário pressione Enter para lançar o dado [X]
    **/     
    
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
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

                //Quebra do loop e opção de continuar
                Console.WriteLine("Deseja continuar? (S/N) ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
