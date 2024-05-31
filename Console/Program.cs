using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. A) Apresentar todos os valores numéricos inteiros ímpares situados na faixa de 0 a 40.");
                Console.WriteLine("2. B) Apresentar o total da soma dos 100 primeiros números inteiros.");
                Console.WriteLine("3. C) Apresentar todos os números divisíveis por 4 que sejam menores que 40.");
                Console.WriteLine("4. D) Apresentar os quadrados dos números inteiros de 15 a 200.");
                Console.WriteLine("5. E) Apresentar o resultado da soma de todos os valores pares existentes na faixa numérica de 1 a 50.");
                Console.WriteLine("0. Sair.");
                Console.Write("Digite a sua escolha: ");

                string input = Console.ReadLine();
                int escolha;

                if (!int.TryParse(input, out escolha))
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número.");
                    continue;
                }

                switch (escolha)
                {
                    case 1:
                        alternativaA();
                        break;
                    case 2:
                        alternativaB();
                        break;
                    case 3:
                        alternativaC();
                        break;
                    case 4:
                        alternativaD();
                        break;
                    case 5:
                        alternativaE();
                        break;
                    case 0:
                        return; 
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        private static void alternativaE()
        {
            int somaPares = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    somaPares += i;
                }
            }
            Console.WriteLine("Soma de todos os valores pares de 1 a 50: " + somaPares);
        }

        private static void alternativaD()
        {
            Console.WriteLine("Quadrados dos números inteiros de 15 a 200:");
            for (int i = 15; i <= 200; i++)
            {
                Console.WriteLine($"{i}^2 = {i * i}");
            }
        }

        private static void alternativaC()
        {
            Console.WriteLine("Números divisíveis por 4 menores que 40:");
            for (int i = 1; i < 40; i++)
            {
                if (i % 4 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        private static void alternativaA()
        {
            Console.WriteLine("Valores ímpares de 0 a 40:");
            for (int i = 0; i <= 40; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        private static void alternativaB()
        {
            int soma = 0;
            for (int i = 1; i <= 100; i++)
            {
                soma += i;
            }
            Console.WriteLine("Soma dos 100 primeiros números inteiros: " + soma);
        }
    }
}
