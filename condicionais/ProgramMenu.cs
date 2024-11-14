using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace condicionais
{
    public class ProgramMenu
    {
        public void ExecuteMenuIsNegative(Condicionais condicionais)
        {
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine("Exercício 01 - Número Negativo");
            Console.WriteLine("-----------------------------------------");

            Console.Write("\nDigite um Número: ");
            int a = Convert.ToInt32(Console.ReadLine());

            condicionais.IsNegative(a);
        }

        public void ExecuteMenuIsEven(Condicionais condicionais)
        {
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine("Exercício 01 - Par ou Ímpar");
            Console.WriteLine("-----------------------------------------");

            Console.Write("\nDigite um Número: ");
            int a = Convert.ToInt32(Console.ReadLine());

            condicionais.IsEven(a);
        }

        public void ExecuteMenuAreMultiples(Condicionais condicionais)
        {
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine("Exercício 02 - Multiplos");
            Console.WriteLine("-----------------------------------------");

            Console.Write("\nDigite o primeiro Número: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo Número: ");
            int b = Convert.ToInt32(Console.ReadLine());

            condicionais.AreMultiples(a, b);
        }

        public void ExecuteMenuGameTime(Condicionais condicionais)
        {
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine("Exercício 03 - Tempo de Jogo");
            Console.WriteLine("-----------------------------------------");

            Console.Write("\nDigite a hora inicial: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a hora final: ");
            int b = Convert.ToInt32(Console.ReadLine());

            condicionais.GameTime(a, b);
        }

        public void ExecuteMenuSnackBar(Condicionais condicionais)
        {
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine("Exercício 04 - Snack Bar");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("-------------- Menu --------------");
            Console.WriteLine("Código | Produto          |Preço");
            Console.WriteLine("  1    |  Cachorro Quente | R$ 4,00");
            Console.WriteLine("  2    |  X-Salada        | R$ 4,50");
            Console.WriteLine("  3    |  X-Bacon         | R$ 5,00");
            Console.WriteLine("  4    |  Torrada Simples | R$ 2,00");
            Console.WriteLine("  5    |  Refrigerante    | R$ 1,50");

            Console.Write("\nCódigo do Produto: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantidade: ");
            int b = Convert.ToInt32(Console.ReadLine());

            condicionais.SnackBar(a, b);
        }

        public void ExecuteMenuIndicateGap(Condicionais condicionais)
        {
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine("Exercício 05 - Intervalo");
            Console.WriteLine("-----------------------------------------");

            Console.Write("\nDigite um número: ");
            double a = Convert.ToDouble(Console.ReadLine());

            condicionais.IndicateGap(a);
        }

        public void ExecuteMenuIndicateQuadrant(Condicionais condicionais)
        {
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine("Exercício 06 - Quadrante");
            Console.WriteLine("-----------------------------------------");

            Console.Write("\nDigite a coordenada X: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a coordenada Y: ");
            double b = Convert.ToDouble(Console.ReadLine());

            condicionais.IndicateQuadrant(a, b);
        }

        public void ExecuteMenuTaxPayment(Condicionais condicionais)
        {
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine("Exercício 07 - Imposto de Renda");
            Console.WriteLine("-----------------------------------------");

            Console.Write("\nDigite um salário: ");
            double a = Convert.ToDouble(Console.ReadLine());

            condicionais.TaxPayment(a);
        }

    }
}