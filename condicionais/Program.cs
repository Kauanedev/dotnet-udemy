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
                    menu.ExecuteMenuIsEven(condicionais);
                    break;
                case 3:
                    menu.ExecuteMenuAreMultiples(condicionais);
                    break;
                case 4:
                    menu.ExecuteMenuGameTime(condicionais);
                    break;
                case 5:
                    menu.ExecuteMenuSnackBar(condicionais);
                    break;
                case 6:
                    menu.ExecuteMenuIndicateGap(condicionais);
                    break;
                case 7:
                    menu.ExecuteMenuIndicateQuadrant(condicionais);
                    break;
                case 8:
                    menu.ExecuteMenuTaxPayment(condicionais);
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
        Console.WriteLine("1 - Número Negativo");
        Console.WriteLine("2 - Par ou Ímpar");
        Console.WriteLine("3 - Múltiplos");
        Console.WriteLine("4 - Tempo de Jogo");
        Console.WriteLine("5 - Snack Bar");
        Console.WriteLine("6 - Intervalo");
        Console.WriteLine("7 - Quadrante");
        Console.WriteLine("8 - Imposto de Renda");
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