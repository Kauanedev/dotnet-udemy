using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace logica
{
    public class Calculadora
    {
        public void Soma(int a, int b)
        {
            try
            {
                Console.WriteLine($"\n---> A soma dos numeros é: {a + b}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void AreaCirculo(double r)
        {
            try
            {
                if (r < 0)
                {
                    throw new Exception("O raio não pode ser negativo");
                }
                Console.WriteLine($"\n---> A área do circulo é: {Math.Round(Math.PI * Math.Pow(r, 2), 4)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void DiferencaProduto(int a, int b, int c, int d)
        {
            try
            {
                Console.WriteLine($"\n---> A diferença do produto é: {(a * b) - (c * d)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Salario(int num, int hrs, double valorHora)
        {
            try
            {
                double salary = hrs * valorHora;

                Console.WriteLine($"\nNumber: {num}");
                Console.WriteLine($"Salary: {Math.Round(salary, 2)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void CalcularValorCompra()
        {
            double total = 0;
            string continuar = "s";

            while (continuar.ToLower() == "s")
            {
                try
                {
                    Console.Write("\nDigite o código da peça: ");
                    int cod = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite o número de peças: ");
                    int qte = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite o valor unitário da peça: ");
                    double preco = Convert.ToDouble(Console.ReadLine());

                    total += qte * preco;

                    Console.Write("\nDeseja adicionar outra peça? (s/n): ");
                    continuar = Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nErro: " + e.Message);
                }
            }

            Console.WriteLine($"\n---> VALOR A PAGAR: R$ {total:F2}");
        }

        public void CalcularAreas(double A, double B, double C)
        {
            double areaTriangulo = A * C / 2;
            double areaCirculo = 3.14159 * Math.Pow(C, 2);
            double areaTrapezio = (A + B * C) / 2;
            double areaQuadrado = Math.Pow(B, 2);
            double areaRetangulo = A * B;

            Console.WriteLine($"\nTRIANGULO: {Math.Round(areaTriangulo, 3)}");
            Console.WriteLine($"CIRCULO: {Math.Round(areaCirculo, 3)}");
            Console.WriteLine($"TRAPEZIO: {Math.Round(areaTrapezio, 3)}");
            Console.WriteLine($"QUADRADO: {Math.Round(areaQuadrado, 3)}");
            Console.WriteLine($"RETANGULO: {Math.Round(areaRetangulo, 3)}");
        }

    }
}