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
    }
}