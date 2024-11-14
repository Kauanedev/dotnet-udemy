using condicionais;

class Progrma
{
    static void Main(string[] args)
    {
        Condicionais condicionais = new();
        ProgramMenu menu = new();
        int option;
        do
        {
            MostrarMenuPrincipal();
            option = ReadOption();

            switch (option)
            {
                case 1:
                    menu.ExecuteMenuIsNegative(condicionais);
                    break;
                case 2:
                    menu.ExecuteMenuAreMultiples(condicionais);
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
        Console.WriteLine("1 - É Negativo");
        Console.WriteLine("2 - Área do Circulo");
        Console.WriteLine("3 - Diferença do Produto");
        Console.WriteLine("4 - Salário");
        Console.WriteLine("5 - Valor da Compra");
        Console.WriteLine("6 - Calcular Áreas");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("Obs: Para números não inteiros, utilize a vírgula (,).");
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
}