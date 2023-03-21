namespace JogoDaAdivinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(" ####################################");
            Console.Write(" # ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Bem Vindo Ao Jogo De Adivinhação");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" #\n");
            Console.WriteLine(" ####################################\n");

            int numeroChances = 0;
            int numeroAleatorio;
            int numeroChutado = 0;
            int pontuacao = 1000;

            Random numeroGerador = new Random();
            numeroAleatorio = numeroGerador.Next(1, 21);

            Console.WriteLine("   Escolha o nível de dificuldade: ");
            Console.WriteLine("   (1) Fácil");
            Console.WriteLine("   (2) Médio");
            Console.WriteLine("   (3) Difícil\n");
            Console.Write("   Nível: ");
            int.TryParse(Console.ReadLine(), out int dificuldade);

            switch (dificuldade)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("\nDificuldade 'Dente de Leite' (Fácil)");
                    numeroChances = 15;
                    Console.WriteLine("\nAperte qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("\nDificuldade 'Crescidinho' (Médio)");
                    numeroChances = 10;
                    Console.WriteLine("\nAperte qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("\nDificuldade 'Mestre' (Difícil)");
                    numeroChances = 5;
                    Console.WriteLine("\nAperte qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine("\nAperte qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
            }

            for (int i = 0; i < numeroChances; i++)
            {
                Console.WriteLine("Chute um número entre 1 e 20");
                numeroChutado = int.Parse(Console.ReadLine());

                if (numeroChutado == numeroAleatorio)
                {
                    Console.WriteLine("Parabéns, você acertou!");
                    Console.WriteLine("Sua pontuação é {0}", pontuacao);
                    break;
                }
                else if (numeroChutado > numeroAleatorio)
                {
                    Console.WriteLine("Seu chute foi maior que o número sorteado");
                }
                else
                {
                    Console.WriteLine("Seu chute foi menor que o número sorteado");
                }

                pontuacao -= (Math.Abs(numeroChutado - numeroAleatorio)) / 2;
            }
            if (numeroChutado != numeroAleatorio)
            {
                Console.WriteLine("Você perdeu!");
                Console.WriteLine($"O número sorteado era {numeroAleatorio}");
                Console.WriteLine($"Sua pontuação é {pontuacao}");
            }
        }
    }
}