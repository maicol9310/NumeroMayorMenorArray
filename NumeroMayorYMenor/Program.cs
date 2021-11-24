using System;
using System.Linq;

namespace NumeroMayorYMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            int NumD;
            for (int i = 0; i < 10; i++)
            {
                int j = i + 1;
                Console.Write("Digite un numero en la posicion: #"+ j + " ");
                NumD = int.Parse(Console.ReadLine());
                num[i] = NumD;
            }

            Console.Write("\n\nEl numero mayor es: " + num.Max());
            Console.Write("\n\nEl numero menor es: " + num.Min());
            Console.ReadKey();
        }
    }
}
