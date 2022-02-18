using System;

namespace Diamantes.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            while (true)
            {
                Console.WriteLine("Digite um número ímpar: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero % 2 != 1)
                {
                    Console.WriteLine("Número inválido! Tente novamente.");
                    continue;
                }
            }
           
            int meio = numero / 2 ;
            int direita = meio, esquerda = meio;

            for (int i = 0; i < meio ; i++)
            {
                for (int j = 0; j < numero; j++)
                {
                    if (j <= direita && j >= esquerda)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write("y");
                    }
                }
                esquerda--;
                direita++;
                Console.WriteLine();
            }
            for (int i = meio; i < numero; i++)
            {
                for (int j = 0; j < numero; j++)
                {
                    if (j <= direita && j >= esquerda)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                esquerda++;
                direita--;
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
