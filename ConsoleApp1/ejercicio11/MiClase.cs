using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    public static class MiClase
    {
        public static bool Validar(int valor,int min,int max)
        {
            bool retorno = false;

            if(valor>min && valor<max)
            {
                retorno = true;    
            }
            else
            {
                Console.WriteLine("Numero no valido \nMinimo permitido: {0}\nMaximo permitido: {1}",min,max);
            }
            return retorno;
        }
    }
}
