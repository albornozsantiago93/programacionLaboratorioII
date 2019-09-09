using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio19
{
    class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador()
        {
            cantidadSumas = 0;
        }

        public long Sumar(long a, long b)
        {
            long retorno;

            retorno =  a + b;

            return retorno;
        }

        public string Sumar(string a, string b)
        {
            string retorno = " " + a + " " + b;
            return retorno;
        }

        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        public static long operator +(Sumador s,Sumador s2)
        {
            long retorno;

            retorno = (long)s.cantidadSumas + s2.cantidadSumas;

            return retorno;
        }

        public static bool operator |(Sumador s, Sumador s2)
        {
            bool retorno = false;

            if(s.cantidadSumas== s2.cantidadSumas)
            {
                retorno = true;
            }
            return retorno;
        }


    }
}
