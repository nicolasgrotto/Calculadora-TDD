using Models.Calculadora;

Calculadora calculadora = new Calculadora();

while (true)
{
    Console.WriteLine("Escolha sua operação:");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Potência");
    Console.WriteLine("6 - Mostrar histórico");

    try
    {
        int opcao = Convert.ToInt32(Console.ReadLine());

        int num1 = 0, num2 = 0;

        if (opcao > 0 && opcao < 6)
        {
            Console.WriteLine("Digite o primeiro número:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            num2 = Convert.ToInt32(Console.ReadLine());
        }

        switch (opcao)
        {
            case 1:
                Console.WriteLine("Resultado da soma: " + calculadora.Somar(num1, num2));
                break;

            case 2:
                Console.WriteLine("Resultado da subtração: " + calculadora.Subtrair(num1, num2));
                break;

            case 3:
                Console.WriteLine("Resultado da multiplicação: " + calculadora.Multiplicar(num1, num2));
                break;

            case 4:
                Console.WriteLine("Resultado da divisão: " + calculadora.Dividir(num1, num2));
                break;

            case 5:
                Console.WriteLine("Resultado da potência: " + calculadora.Potencia(num1, num2));
                break;

            case 6:
                calculadora.MostrarHistorico();
                break;

            default:
                Console.WriteLine("Opção inválida");
                break;
        }

        Console.WriteLine("Deseja utilizar a calculadora novamente? (S/N)");
        string resposta = Console.ReadLine().ToUpper();

        if (resposta != "S")
        {
            break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Digite um número inteiro.");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Não é possível dividir por 0.");
    }
    catch (Exception)
    {
        Console.WriteLine("Ocorreu um erro inesperado.");
    }
}