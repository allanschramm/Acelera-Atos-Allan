// See https://aka.ms/new-console-template for more information

/*
 * 3) Apesar do tipo int ser o tipo primitivo mais comum, no C# existem outros tipos de dados para armazenar inteiros, 
 * cada um com sua caracteristica de tamanho em memória e capacidade ou não de armazenar numeros negativos.
 * 
 * São eles:
 * 
 * short/ushort
 * int/uint
 * long/ulong
 * 
*/

// a) Faça um program console que declare variáveis dos tipos acima descritos

short a;
ushort b;
int c;
uint d;
long e;
ulong f;

// b) Atribua valores iniciais para as variáveis e tente atribuir valores de variaveis de um tipo para outro tipo. 

a = 10;
b = 20;
c = 30;
d = 12;
e = 50;
f = 2;

a = (short)a;
b = (ushort)(short)a;
c = (short)a;
f = (ulong)(short)a;
d = (uint)(short)a;
e = (short)a;

Console.WriteLine("Valor de 'a': " + a);
Console.WriteLine("Valor de 'b': " + b);
Console.WriteLine("Valor de 'c': " + c);
Console.WriteLine("Valor de 'd': " + d);
Console.WriteLine("Valor de 'e': " + e);
Console.WriteLine("Valor de 'f': " + f);

a = 10;
b = 20;
c = 30;
d = 12;
e = 50;
f = 2;

a = (short)(int)c;
b = (ushort)(int)c;
c = (int)c;
d = (uint)(int)c;
e = (int)c;
f = (ulong)(int)c;

Console.WriteLine("Valor de 'a': " + a);
Console.WriteLine("Valor de 'b': " + b);
Console.WriteLine("Valor de 'c': " + c);
Console.WriteLine("Valor de 'd': " + d);
Console.WriteLine("Valor de 'e': " + e);
Console.WriteLine("Valor de 'f': " + f);

a = 10;
b = 20;
c = 30;
d = 12;
e = 50;
f = 2;

a = (short)(long)e;
b = (ushort)(long)e;
c = (int)(long)e;
f = (ulong)(long)e;
d = (uint)(long)e;
e = (long)e;

// c) Sempre printando na tela o resultado do teste quando possivel

Console.WriteLine("Valor de 'a': " + a);
Console.WriteLine("Valor de 'b': " + b);
Console.WriteLine("Valor de 'c': " + c);
Console.WriteLine("Valor de 'd': " + d);
Console.WriteLine("Valor de 'e': " + e);
Console.WriteLine("Valor de 'f': " + f);