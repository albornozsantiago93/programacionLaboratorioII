using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumeros;
            arrayNumeros= new int[20];
            Random aleatorio = new Random();
            int length = arrayNumeros.Length;

            for(int i=0;i<20;i++)
            {
                arrayNumeros[i] = aleatorio.Next(-100, 100);
            }

            Array.Sort(arrayNumeros);
            Array.Reverse(arrayNumeros);//PRIMERO SE DEBE DE ORDENAR UN ARRAY, REVERESE LO INVIERTE
            for(int i=0; i<20;i++)
            {
                Console.WriteLine(arrayNumeros[i]);
            }
            Console.ReadKey();
        }
    }
}
