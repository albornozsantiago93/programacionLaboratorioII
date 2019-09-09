using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int minimo = 9999999;
            int maximo = 0;
            int cantidad = 0;
            float acumulador = 0;
            float promedio = 0;

            do
            {
                Console.Write("Ingrese numero:");
                string aux = Console.ReadLine();
                if (int.TryParse(aux, out numero))
                {
                    if(MiClase.Validar(numero, -100, 100))
                    {
                        acumulador = acumulador + numero;
                        cantidad++;
                        if(minimo>numero)
                        {
                            minimo = numero;
                        }
                        if(maximo<numero)
                        {
                            maximo = numero;
                        }

                        promedio = acumulador / cantidad;
                    }                    
                }
            } while (cantidad < 5);

            Console.WriteLine("Promedio {0}\nMinimo {1}\nMaximo {2}", promedio, minimo, maximo);
            Console.ReadKey();
        }
    }
}
