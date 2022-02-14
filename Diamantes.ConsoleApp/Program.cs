using System;

namespace Diamantes.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());
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
                        Console.Write(" ");
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
