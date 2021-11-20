// See https://aka.ms/new-console-template for more information

/* 6) Qual diferença do metodo int.Parse para o metodo Convert.ToInt32?
 */

// a) Faça um programa console para declarar duas variáveis uma int e outra float

int a;
float b;

// b) Atribua valores iniciais para a variável float e tente converter de forma explicita, o valor na variável float para a viariável int usando os dois metos acima

b = 12.7f;

Console.WriteLine(b);

// c) Finalize o programa, caso seja possivel deve exibir na saida do console o resultado da conversão.

a = (int)b;
Console.WriteLine(a);

a = Convert.ToInt32(b);
Console.WriteLine(a);


