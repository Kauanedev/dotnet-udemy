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

        public void IndicateGap(double num)
        {
            if (num >= 0 && num <= 25) Console.WriteLine("\n--> Intervalo [0,25]");
            else if (num > 25 && num <= 50) Console.WriteLine("\n--> Intervalo (25,50]");
            else if (num > 50 && num <= 75) Console.WriteLine("\n--> Intervalo (50,75]");
            else if (num > 75 && num <= 100) Console.WriteLine("\n--> Intervalo (75,100]");

            else Console.WriteLine("\n--> Fora de intervalo");
        }

        public void IndicateQuadrant(double x, double y)
        {
            if (x > 0 && y < 0) Console.WriteLine("\n--> Q4");
            else if (x == 0) Console.WriteLine("\n--> Eixo X");
            else if (y == 0) Console.WriteLine("\n--> Eixo Y");
            else if (x > 0 && y > 0) Console.WriteLine("\n--> Q1");
            else if (x < 0 && y > 0) Console.WriteLine("\n--> Q2");
            else if (x < 0 && y < 0) Console.WriteLine("\n--> Q3");

            else Console.WriteLine("\n--> Origem");
        }

        public void TaxPayment(double salary)
        {
            double tax;

            if (salary <= 2000) Console.WriteLine("\n--> Isento");
            else if (salary <= 3000)
            {
                tax = (salary - 2000) * 0.08;
                Console.WriteLine($"\n--> R$ {tax}");
            }
            else if (salary <= 4500)
            {
                tax = (salary - 3000) * 0.18 + 1000 * 0.08;
                Console.WriteLine($"\n--> R$ {tax}");
            }
            else
            {
                tax = (salary - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
                Console.WriteLine($"\n--> R$ {tax}");
            }
        }
    }
}
