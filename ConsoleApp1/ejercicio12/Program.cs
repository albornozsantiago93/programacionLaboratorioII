using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringNumero;
            int numero;
            bool opcion=true;
            char opcionChar;

            do
            {
                Console.Write("Ingrese numero: ");
                stringNumero = Console.ReadLine();
                if(int.TryParse(stringNumero, out numero))
                {
                    Console.Write("Numero ingresado: {0}", numero);


                    Console.Write("\nDesea continuar? s/n");
                    opcionChar = Convert.ToChar(Console.ReadLine());

                    if(!MiClase.validaS_N(opcionChar))
                    {
                        opcion = false;
                    }        
                }
            } while (opcion==true);
        }
    }
}
