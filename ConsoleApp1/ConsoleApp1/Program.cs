using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int minimo = 999999;
            int maximo = 0;
            float acumulador = 0;
            float promedio;
            int contador = 0;

            Console.Title = "ejercicio 01";

            do
            {
                Console.WriteLine("Ingrese numero:");
                string aux = Console.ReadLine();

                if (int.TryParse(aux, out numero))
                {
                    Console.WriteLine("Numero ingresado OK");
                    acumulador = acumulador + numero;
                    contador++;

                    if(numero<minimo)
                    {
                        minimo = numero;
                    }
                    
                    if(numero>maximo)
                    {
                        maximo = numero;
                    }
                }

            } while (contador<5);

            promedio = acumulador / contador;
            Console.WriteLine("Minimo: {0}\nMaximo: {1}\nPromedio: {2}", minimo, maximo, promedio);

            Console.ReadKey();
        }
    }
}
