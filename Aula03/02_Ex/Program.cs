// See https://aka.ms/new-console-template for more information

/*2) Construa uma calculadora para implementar as 4 operações elementares.
 * 
 * a) Um menu deve ser criado no console para escolher a operação.
 * b) O programa deve solicitar os valores de entrada.
 * c) Realizar a operação solicitada e retornar para o menu.
 * d) Uma opção de saida do programa também deve existir no menu.
 */

bool running = true;

Console.WriteLine("Bem vindo a Calculadora!\n");

do
{
    {
        static void Menu(int operacao, double a, double b)
        {
            double resultado;

            switch (operacao)
            {
                case 1:
                    resultado = a + b;
                    Console.WriteLine($"\nA soma dos numeros é: {resultado}\n");
                    break;
                case 2:
                    resultado = a - b;
                    Console.WriteLine($"\nA subtração dos numeros é: {resultado}\n");
                    break;
                case 3:
                    resultado = a * b;
                    Console.WriteLine($"\nA multiplicação dos numeros é: {resultado}\n");
                    break;
                case 4:
                    resultado = a / b;
                    Console.WriteLine($"\nA divisão dos numeros é: {resultado}\n");
                    break;

                default:
                    Console.WriteLine("\nOperação invalida!\n");
                    break;
            }
        }

        Console.WriteLine("Qual operação matematica deseja realizar?\n");
        Console.WriteLine("0 - Sair da Calculadora");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        int operacao = int.Parse(Console.ReadLine());

        if (operacao != 0)
        {
            double num1, num2;

            Console.WriteLine("\nDigite o primeiro numero: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo numero: ");
            num2 = double.Parse(Console.ReadLine());

            Menu(operacao, num1, num2);
        }
        else
        {
            running = false;
        }

        
    }
}
while (running);