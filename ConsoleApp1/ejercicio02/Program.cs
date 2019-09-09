using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            double cubo;
            double cuadrado;

            Console.Title = "ejercicio02";

            Console.WriteLine("Ingrese numero:");
            string aux = Console.ReadLine();

            if(int.TryParse(aux, out numero))
            {
                if(numero<=0)
                {
                    Console.WriteLine("Error numero no valido");
                }                
            }
            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);

            Console.WriteLine("Numero: {0}\nAl cuadrado: {1}\nAl cubo: {2}", numero, cuadrado, cubo);
            Console.ReadKey();
        }
    }
}
