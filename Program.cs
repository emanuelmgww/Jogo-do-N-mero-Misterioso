using System;

namespace JogoDoNúmeroMisterioso
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("----- Jogo do Número Misterioso -----\n");
            System.Console.WriteLine("Tente acertar o número em que o computador pensou entre 0 e 10.\n");
            System.Console.WriteLine("Você tem 4 tentativas!\n");

            int contador = 1;
            int tentativas = 4;

            Random random = new Random();
            int numeroComputador = random.Next(1, 11);

            while (contador <= 4)
            {
                System.Console.Write($"Digite o {contador}° número: ");
                int numeroUsuario = int.Parse(System.Console.ReadLine());

                tentativas--;
                System.Console.WriteLine();

                if (numeroUsuario == numeroComputador)
                {
                    System.Console.WriteLine("Certa resposta!\n");
                    System.Console.WriteLine($"O número sorteado foi {numeroComputador}.\n");
                    break;
                }

                else
                {
                    if (tentativas > 0)
                    {
                        System.Console.WriteLine("Resposta errada!");
                        System.Console.WriteLine($"Você ainda tem {tentativas} tentativas.");
                    }
                    else
                    {
                        System.Console.WriteLine("Tentativas esgotadas!");
                        System.Console.WriteLine("Você perdeu.\n");
                        System.Console.WriteLine($"O número sorteado foi {numeroComputador}.");
                    }
                }

                System.Console.WriteLine();
                contador++;
            }

            System.Console.WriteLine("Obrigado por jogar :)");

            System.Console.ReadLine();
        }        
    }
}