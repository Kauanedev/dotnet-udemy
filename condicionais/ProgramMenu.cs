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

            Console.Write("\nDigite o segundo Número: ");
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

            Console.Write("\nDigite a hora final: ");
            int b = Convert.ToInt32(Console.ReadLine());

            condicionais.GameTime(a, b);
        }

        public void ExecuteMenuSnackBar(Condicionais condicionais)
        {
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine("Exercício 04 - Snack Bar");
            Console.WriteLine("-----------------------------------------");

            Console.Write("\nCódigo do Produto: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nQuantidade: ");
            int b = Convert.ToInt32(Console.ReadLine());

            condicionais.SnackBar(a, b);
        }

    }
}