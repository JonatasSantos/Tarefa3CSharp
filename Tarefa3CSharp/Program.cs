using System;

namespace Tarefa3CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 7, 11, 15 };
            int[] array2 = new int[2];
            int num;
            
            Console.Write("Entre com um numero: ");
            int entrada = int.Parse(Console.ReadLine());
            num = entrada;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (num == 0)
                {
                    continue;
                }
                if (array[i] > entrada)
                {
                    continue;
                }
                else
                {
                    num -= array[i];
                    
                    if (array2[0] == 0)
                    {
                        array2[0] = array[i];
                    }
                    else
                    {
                        array2[1] = array[i];
                    }
                }
            }

            Console.WriteLine("Entrada = " + entrada);
            Console.WriteLine(entrada + " e a soma de " + array2[0] + " + " + array2[1]);
            Console.WriteLine(array2[0] + " + " + array2[1] + " sao os numeros encontrados no array de entrada");

        }
    }
}
