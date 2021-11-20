// See https://aka.ms/new-console-template for more information

/* 1) Execute o programa abaixo, e adicione comentários sobre a saida do mesmo.
 * você deve transcrever a saída nos comentários, e explicar porque a saída foi esta.
 * 
 *  class PassandoParametrosReferencia
 *  {
 *      static void Muda(int[] pArray)
 *      {
 *          pArray[0] = 888;
 *          pArray = new int[5] { -3, -1, -2, -3, -4 };   
 *  
 *          System.Console.WriteLine("Dentro do metodo muda, o primeiro elemento é: {0}", pArray[0]);
 *      }
 *          
 *      static void Main()
 *      {
 *          int[] arr = { 1, 4, 5 };
 *  
 *          System.Console.WriteLine("Dentro do Main, antes de chamar o metodo muda, o primeiro elemento é: {0}", arr[0]);
 *  
 *          Muda(arr);
 *          System.Console.WriteLine("Dentro do Main, apos chamar o metodo muda, o primeiro elemento é: {0}", arr[0]);
 *      }
 *  }
 * 
 */

Console.WriteLine("Hello, World!");
