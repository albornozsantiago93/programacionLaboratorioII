using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio05";

            double acumulador=1,numero, i, j, paraAdelante, paraAtras;

            Console.Write("Ingrese numero: ");
            string aux = Console.ReadLine();

            if(double.TryParse(aux, out numero))
            {
                while(acumulador<numero)
                {
                    acumulador++;
                    paraAdelante = 0;
                    paraAtras = 0;

                    //Calculo hacia atras

                for(i=1;i<acumulador;i++)
                    {
                        paraAtras = paraAtras + i;
                    }
                    //calculo hacia adelante

                for(j= acumulador+1; j<=paraAtras;j++)
                    {
                        if((paraAtras==paraAdelante)||(paraAdelante>paraAtras))
                        {
                            break;
                        }
                        paraAdelante = paraAdelante + j;
                    }

                if(paraAtras==paraAdelante)
                    {
                        Console.WriteLine("El centro numerico es {0}", acumulador);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
