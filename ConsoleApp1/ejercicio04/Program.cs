using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio04";

            int b; int num; int j;
            string divisores = "";

            Console.Write("Ingrese numero: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                b = 0;

                for (j = 1; j <= (i / 2); j++)
                {
                    if (i % j == 0)
                    {
                        b += j;
                        divisores += " " + j + " ";
                    }
                }
                if (b == i)
                    Console.WriteLine("El numero " + i + " es perfecto y su divisores son: " + divisores);
                divisores = "";
            }
            Console.ReadKey();
        }
    }
}
