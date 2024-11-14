using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace condicionais
{
    public class Condicionais
    {
        public void IsNegative(int num)
        {
            if (num < 0) Console.WriteLine("\n--> O número É NEGATIVO");

            else if (num > 0) Console.WriteLine("\n--> O número NÃO É NEGATIVO");

            else Console.WriteLine("\n--> O número é zero");
        }

        public void IsEven(int num)
        {
            if (num % 2 == 0) Console.WriteLine("\n--> O número é PAR");

            else Console.WriteLine("\n--> O número é ÍMPAR");
        }

        public void AreMultiples(int num1, int num2)
        {
            if (num1 % num2 == 0 || num2 % num1 == 0) Console.WriteLine("Os números SÃO MULTIPLOS");

            else Console.WriteLine("\n--> Os números NÃO SÃO MULTIPLOS");
        }

        public void GameTime(int hr1, int hr2)
        {
            int duration;

            if (hr1 < hr2) duration = hr2 - hr1;

            else duration = 24 - hr1 + hr2;

            Console.WriteLine($"\n--> O jogo durou {duration} hora(s)");

        }

        public void SnackBar(int cod, int qtd)
        {
            console.WriteLine("---- Menu ----")
            Console.WriteLine("Código | Produto | Preço");
            Console.WriteLine("  1    |  Cachorro Quente | R$ 4,00");
            Console.WriteLine("  2    |  X-Salada | R$ 4,50");
            Console.WriteLine("  3    |  X-Bacon | R$ 5,00");
            Console.WriteLine("  4    |  Torrada Simples | R$ 2,00");
            Console.WriteLine("  5    |  Refrigerante | R$ 1, 50");

            console.Write("Digite o código do produto desejado: ");
            cod = int.Parse(Console.ReadLine());
            switch (cod)
            {
                case 1:
                    Console.WriteLine($"\n--> Total: R$ {4.00 * qtd}");
                    break;
                case 2:
                    Console.WriteLine($"\n--> Total: R$ {4.50 * qtd}");
                    break;
                case 3:
                    Console.WriteLine($"\n--> Total: R$ {5.00 * qtd}");
                    break;
                case 4:
                    Console.WriteLine($"\n--> Total: R$ {2.00 * qtd}");
                    break;
                case 5:
                    Console.WriteLine($"\n--> Total: R$ {1.50 * qtd}");
                    break;
                default:
                    Console.WriteLine("\n--> Código inválido");
                    break;
            }

        }
    }
}