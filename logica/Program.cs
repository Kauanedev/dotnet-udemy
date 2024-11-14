using System.ComponentModel.Design;
using System.Xml.Linq;
using logica;
class Program
{
    static void Main(string[] args)
    {
        Calculadora calc = new();
        Menu menu = new();
        int option;

        do
        {
            MostrarMenuPrincipal();
            option = ReadOption();
            switch (option)
            {
                case 1:
                    menu.ExecutarMenuSoma(calc);
                    break;
                case 2:
                    ExecutarMenuAreaCirculo(calc);
                    break;
                case 3:
                    ExecutarMenuDiferencaProduto(calc);
                    break;
                case 4:
                    ExecutarMenuSalario(calc);
                    break;
                case 5:
                    ExecutarMenuValorCompra(calc);
                    break;
                case 6:
                    ExecutarMenuAreasGeometricas(calc);
                    break;
                case 0:
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        } while (option != 0);
    }

    static void MostrarMenuPrincipal()
    {
        Console.WriteLine("\n---------------- Menu Principal ----------------");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Área do Circulo");
        Console.WriteLine("3 - Diferença do Produto");
        Console.WriteLine("4 - Salário");
        Console.WriteLine("5 - Valor da Compra");
        Console.WriteLine("6 - Calcular Áreas");
        Console.WriteLine("0 - Sair");
        Console.Write("\nDigite o Número da Opção Desejada: ");
    }

    static int ReadOption()
    {
        {
            int opcao;
            while (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.Write("Opção inválida! Digite um número: ");
            }
            return opcao;
        }
    }

    static void ExecutarMenuAreaCirculo(Calculadora calc)
    {
        Console.WriteLine("\nExercício 02 - Área do Circulo");
        Console.Write("Digite o Raio do Circulo: ");

        double r = Convert.ToDouble(Console.ReadLine());

        calc.AreaCirculo(r);
    }

    static void ExecutarMenuDiferencaProduto(Calculadora calc)
    {
        Console.WriteLine("\nExercício 03 - Diferença do Produto");

        Console.Write("Digite o Primeiro Número: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o Segundo Número: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o Terceiro Número: ");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o Quarto Número: ");
        int d = Convert.ToInt32(Console.ReadLine());

        calc.DiferencaProduto(a, b, c, d);
    }

    static void ExecutarMenuSalario(Calculadora calc)
    {
        Console.WriteLine("\nExercício 04 - Salário");

        Console.Write("Digite o Número do Funcionário: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o Número de Horas Trabalhadas: ");
        int hrs = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o Valor da Hora: ");
        double valorHora = Convert.ToDouble(Console.ReadLine());

        calc.Salario(num, hrs, valorHora);
    }

    static void ExecutarMenuValorCompra(Calculadora calc)
    {
        int option;
        do
        {
            Console.WriteLine("\n--- Menu de Valor da Compra ---");
            Console.WriteLine("1 - Calcular valor da compra de várias peças");
            Console.WriteLine("0 - Voltar ao menu principal");
            Console.Write("Escolha uma opção: ");
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

    static void ExecutarMenuAreasGeometricas(Calculadora calc)
    {
        Console.WriteLine("\nExercício 06 - Calcular Áreas");

        Console.Write("Digite um valor para A: ");
        double A = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite um valor para B: ");
        double B = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite um valor para C: ");
        double C = Convert.ToDouble(Console.ReadLine());

        calc.CalcularAreas(A, B, C);
    }

}
