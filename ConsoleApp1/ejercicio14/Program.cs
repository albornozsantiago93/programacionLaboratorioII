using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringNumero;
            double numero;

            Console.Write("Ingrese numero: ");
            stringNumero = Console.ReadLine();
            if (double.TryParse(stringNumero,out numero))
            {
                CalculoDeArea.CalcularCuadrado(numero);
                Console.Write(numero);
            }
            Console.ReadKey();
        }
    }
}
