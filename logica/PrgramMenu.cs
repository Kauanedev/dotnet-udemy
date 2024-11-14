using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace logica
{
    public class Menu
    {
        public void ExecutarMenuSoma(Calculadora calc)
        {
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine("Exercício 01 - Soma");
            Console.WriteLine("-----------------------------------------");

            Console.Write("\nDigite o Primeiro Número: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o Segundo Número: ");
            int b = Convert.ToInt32(Console.ReadLine());

            calc.Soma(a, b);
        }

        public void ExecutarMenuAreaCirculo(Calculadora calc)
        {
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine("Exercício 02 - Área do Circulo");
            Console.WriteLine("-----------------------------------------");

            Console.Write("\nDigite o Raio do Circulo: ");

            double r = Convert.ToDouble(Console.ReadLine());

            calc.AreaCirculo(r);
        }
        public void ExecutarMenuDiferencaProduto(Calculadora calc)
        {
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine("Exercício 03 - Diferença do Produto");
            Console.WriteLine("-----------------------------------------");

            Console.Write("\nDigite o Primeiro Número: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o Segundo Número: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o Terceiro Número: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o Quarto Número: ");
            int d = Convert.ToInt32(Console.ReadLine());

            calc.DiferencaProduto(a, b, c, d);
        }

        public void ExecutarMenuSalario(Calculadora calc)
        {
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine("Exercício 04 - Salário");
            Console.WriteLine("-----------------------------------------");

            Console.Write("\nDigite o Número do Funcionário: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o Número de Horas Trabalhadas: ");
            int hrs = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o Valor da Hora: ");
            double valorHora = Convert.ToDouble(Console.ReadLine());

            calc.Salario(num, hrs, valorHora);
        }

        public void ExecutarMenuValorCompra(Calculadora calc)
        {
            int option;
            do
            {
                Console.WriteLine("\n-----------------------------------------");
                Console.WriteLine("Exercício 05 - Calcular Valor da Compra");
                Console.WriteLine("-----------------------------------------");

                Console.WriteLine("\n---- Menu de Valor da Compra ----");
                Console.WriteLine("1 - Calcular valor da compra de várias peças");
                Console.WriteLine("0 - Voltar ao menu principal");
                Console.Write("\nEscolha uma opção: ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        calc.CalcularValorCompra();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
            } while (option != 0);
        }

        public void ExecutarMenuAreasGeometricas(Calculadora calc)
        {
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine("Exercício 06 - Calcular Áreas");
            Console.WriteLine("-----------------------------------------");

            Console.Write("\nDigite um valor para A: ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite um valor para B: ");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite um valor para C: ");
            double C = Convert.ToDouble(Console.ReadLine());

            calc.CalcularAreas(A, B, C);
        }
    }
}