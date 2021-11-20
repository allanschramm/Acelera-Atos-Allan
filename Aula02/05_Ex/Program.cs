// See https://aka.ms/new-console-template for more information

/*
 * 5) Construa um programa console para receber 5 dados fornecidos por um usuário,
 * estas dados podem ser dos tipos (int, double, char, string). Voce deve receber os dados
 * e armazer em um vetor ou lista. Logo em seguida o programa deve exibir na saida do console a listagem dos dados recebidos.
 */

var names = new List<string>();

for(int i = 0; i < 5; i++)
{
    names.Add(Console.ReadLine());
}

foreach (var name in names)
{
    Console.WriteLine($"My name is {name}.");
}
