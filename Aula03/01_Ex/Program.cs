// See https://aka.ms/new-console-template for more information

/* 
 * 1) Execute o programa abaixo, e adicione comentários sobre a saida do mesmo.
 * Você deve transcrever a saída nos comentários, e explicar porque a saída foi esta.
 */

class PassandoParametrosReferencia
{
    static void Muda(int[] pArray)
    {
        pArray[0] = 888;
        pArray = new int[5] { -3, -1, -2, -3, -4 };

        System.Console.WriteLine("Dentro do metodo muda, o primeiro elemento é: {0}", pArray[0]);
    }

    static void Main()
    {
        int[] arr = { 1, 4, 5 };

        System.Console.WriteLine("Dentro do Main, antes de chamar o metodo muda, o primeiro elemento é: {0}", arr[0]);  // A primeira saida foi "1" pois escreveu na tela a posição 0 do array "arr" recem criado

        Muda(arr); // O valor da posição 0 do array "arr" foi alterada para 888 por referencia, mas foi atribuido 5 novas posições pro array "pArray" e depois impresso na tela, então imprimiu -3
        System.Console.WriteLine("Dentro do Main, apos chamar o metodo muda, o primeiro elemento é: {0}", arr[0]); // Imprimiu 888, pois o valor foi passado para "arr[0]" por referencia dentro do metodo "Muda"
    }
}