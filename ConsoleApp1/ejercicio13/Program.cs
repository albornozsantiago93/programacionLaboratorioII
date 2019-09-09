using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringNumero;
            string numeroBinario;
            double numero;
            double numeroDecimal;
            string respuesta;

            Console.Write("Ingrese numero: ");
            stringNumero = Console.ReadLine();
            if(double.TryParse(stringNumero,out numero))
            {
                respuesta= Conversor.DecimalBinario(numero);
                Console.Write("Decimal {0}\nBinario {1}", numero, respuesta);

                Console.Write("\nIngrese numero binario: ");
                numeroBinario = Console.ReadLine();
                numeroDecimal = Conversor.BinarioDecimal(numeroBinario);
                Console.Write("Binario: {0}\nDecimal: {1}", numeroBinario, numeroDecimal);
            }
            Console.ReadKey();
        }
    }
}
