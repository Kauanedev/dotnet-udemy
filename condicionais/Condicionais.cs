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
            if (num < 0) Console.WriteLine("\n--> O número é negativo");

            else if (num > 0) Console.WriteLine("\n--> O número é par");

            else Console.WriteLine("\n--> O número é zero");
        }

        public void AreMultiples(int num1, int num2)
        {
            if (num1 % num2 == 0 || num2 % num1 == 0) Console.WriteLine("Os números são múltiplos");

            else Console.WriteLine("Os números não são múltiplos");
        }

    }
}