using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            char operacion;
            string stringNumero;
            string stringNumeroB;
            double numero, numeroB, resultado;

            Console.Write("Ingrese Numero A:");
            stringNumero = Console.ReadLine();
            if (double.TryParse(stringNumero,out numero))
            {
                Console.Write("\nIngrese Numero B: ");
                stringNumeroB = Console.ReadLine();
                if(double.TryParse(stringNumeroB,out numeroB))
                {
                    Console.Write("\nEscoga operacion a realizar");
                    operacion = Convert.ToChar(Console.ReadLine());
                    resultado= Calculadora.Calcular(numero, numeroB, operacion);

                    Console.WriteLine("\nResultado: {0}", resultado);
                }
            }
            Console.ReadKey();
        }
    }
}
