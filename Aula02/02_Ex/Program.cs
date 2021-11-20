/*
 * 2) O que acontece se eu colocar um valor maior do que o suportado em uma variável byte ou sbyte?
 * 
 * byte (8 bit)
 * 0 ate 255
 * sbyte (8 bit)  permite valores negativos
 * -128 ate 127
 * 
 * 2.1) Faça um programa console C# para fazer este teste, e printar na tela o resultado de duas variáveis uma byte e outra sbyte com valores superiores ao limites acima apresentados.
 * 
 * Faça usando tres formas que são:
*/

// a) Atribua diretamente um valor acima do limite para as variáveis.

int a = 300;

// byte b = 300; // CS0031: Constant value '300' cannot be converted to a 'byte'

Console.WriteLine(a);

// b) Atribua um valor acima do limite para uma variável int depois faça um cast para as variáveis byte e sbyte.

byte b = (byte)a;
sbyte c = (sbyte)a;

Console.WriteLine(b);
Console.WriteLine(c);

// c) Recupere valores do usuário para atribuir para as variáveis. Quando executar o programa

Console.WriteLine("Digite um valor para a variavel Byte: ");
b = byte.Parse(Console.ReadLine());

Console.WriteLine("Digite um valor para a variavel SByte: ");
c = sbyte.Parse(Console.ReadLine());

Console.WriteLine(b);
Console.WriteLine(c);

//  d) Insira valores acima do limite das variáveis.
//      Unhandled exception.System.OverflowException: Value was either too large or too small for a signed byte.
//          at System.Number.ThrowOverflowException(TypeCode type)
//          at System.SByte.Parse(String s)
//          at Program.<Main>$(String[] args) in E:\Dev\CSharp\AceleraAtos\Aula02\02_Ex\Program.cs:line 37