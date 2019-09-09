using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio15
{
    public static class Calculadora
    {
        public static double Calcular(double numeroA,double numeroB,char operacion)
        {
            double resultado=0;

            switch(operacion)
            {
                case '+':
                    resultado = numeroB + numeroA;
                    break;

                case '-':
                    resultado = numeroA - numeroB;
                    break;

                case '*':
                    resultado = numeroA * numeroB;
                    break;

                case '/':
                    if(Calculadora.Validar(numeroB))
                    {
                        resultado = numeroA / numeroB;
                    }
                    else
                    {
                        Console.Write("\nIngrese numero distinto de 0");
                    }
                    break;
            }
            return resultado;
        }

        static bool Validar(double numeroB)
        {
            bool retorno = false;

            if(numeroB>0)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
