using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    public static class Conversor
    {
        public static string DecimalBinario(double numeroAux)
        {
            if (numeroAux > 0)
            {
                String cadena = "";
                while (numeroAux > 0)
                {
                    if (numeroAux % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    numeroAux = (int)(numeroAux / 2);
                }
                return cadena;
            }
            else
            {
                if (numeroAux == 0)
                {
                    Console.WriteLine("0");
                    return "0";                    
                }
                else
                {
                    Console.WriteLine("Ingrese solo numeros positivos");
                    return "0";
                }
            }
        }

        public static double BinarioDecimal(string stringBinario)
        {
            char[] array = stringBinario.ToCharArray();     // Invertido pues los valores van incrementandose de derecha a izquierda: 16-8-4-2-1
            Array.Reverse(array);
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    // Usamos la potencia de 2, según la posición
                    sum += (int)Math.Pow(2, i);
                }
            }
            return sum;
        }
    }
}
