// See https://aka.ms/new-console-template for more information

/* 1)  Faça um programa para declarar variáveis dos seguinites tipos:
 * short
 * int
 * long
 * float
 * double
 * decimal
 * 
 * a) Atribua valores iniciais para as variáveis em um primeiro teste
*/

short a = 0;
int b = 0;
long c = 0;
float f = 0.0f;
double d = 0.0;
decimal e = 0.0m;

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(f);
Console.WriteLine(d);
Console.WriteLine(e);

// b) Em um segundo teste receba valores informados por um usuário

a = short.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = long.Parse(Console.ReadLine()); 
f = float.Parse(Console.ReadLine());
d = double.Parse(Console.ReadLine());
e = decimal.Parse(Console.ReadLine());

// c) Depois imprima os resultados das variáveis na saida do console

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(f);
Console.WriteLine(d);
Console.WriteLine(e);
