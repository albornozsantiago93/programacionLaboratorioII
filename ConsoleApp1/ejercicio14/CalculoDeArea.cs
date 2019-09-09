using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14
{
    public static class CalculoDeArea
    {
        public static double CalcularCuadrado(double numeroAux)
        {
            double retorno=0;

            if(numeroAux>0)
            {
                retorno= Math.Pow(2, numeroAux);
            }
            return retorno;
        }
    }
}
