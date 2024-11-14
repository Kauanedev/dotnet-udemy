using logica;


int a, b, c, d, ex, num, hrs;
double valorHora, A, B, C;
Calculadora calc = new();

Console.WriteLine("\n---------------- Menu de Exercícios ---------------- ");
Console.WriteLine("\n1 - Soma");
Console.WriteLine("2 - Área do Circulo");
Console.WriteLine("3 - Diferença do Produto");
Console.WriteLine("4 - Salário");
Console.WriteLine("5 - Valor da Compra");
Console.WriteLine("6 - Calcular Áreas");

Console.WriteLine("\nDigite o Número do Exercício Desejado: ");
ex = Convert.ToInt32(Console.ReadLine());
switch (ex)
{
    case 1:
        Console.WriteLine("\nExercício 01");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Digite Apenas Números Inteiros ");

        Console.Write("Digite o Primeiro Número: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o Segundo Número: ");
        b = Convert.ToInt32(Console.ReadLine());

        Calculadora.Soma(a, b);
        break;
    case 2:
        double r;
        Console.WriteLine("\nExercício 02");
        Console.WriteLine("---------------------------------------------");
        Console.Write("Digite o Raio do Circulo: ");
        r = Convert.ToDouble(Console.ReadLine());

        calc.AreaCirculo(r);
        break;
    case 3:
        Console.WriteLine("\nExercício 03");
        Console.WriteLine("---------------------------------------------");
        Console.Write("Digite o Primeiro Número: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o Segundo Número: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o Terceiro Número: ");
        c = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o Quarto Número: ");
        d = Convert.ToInt32(Console.ReadLine());

        calc.DiferencaProduto(a, b, c, d);
        break;
    case 4:
        Console.WriteLine("\nExercício 04");
        Console.WriteLine("---------------------------------------------");

        Console.Write("Digite o Número do Funcionário: ");
        num = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o Número de Horas Trabalhadas: ");
        hrs = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o Valor da Hora: ");
        valorHora = Convert.ToDouble(Console.ReadLine());

        calc.Salario(num, hrs, valorHora);
        break;
    case 5:
        Console.WriteLine("\nExercício 05");
        Console.WriteLine("---------------------------------------------");


        int option;
        do
        {
            Console.WriteLine("\n---------------- Menu de Opções ---------------- ");
            Console.WriteLine("\n1 - Calcular valor da compra de várias peças");
            Console.WriteLine("0 - Sair");
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
        break;
    case 6:
        Console.WriteLine("\nExercício 06");
        Console.WriteLine("---------------------------------------------");

        Console.Write("Digite um valor para A: ");
        A = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite um valor para B: ");
        B = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite um valor para C: ");
        C = Convert.ToDouble(Console.ReadLine());

        calc.CalcularAreas(A, B, C);
        break;

    default:
        Console.WriteLine("Opção Inválida");
        break;
}

