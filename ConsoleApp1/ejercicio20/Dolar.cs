using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio20
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        private Dolar()
        {
            cantidad = 0;
            cotizRespectoDolar = 0;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion):this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static explicit operator Euro(Dolar dls)
        {
            Euro auxiliar = new Euro(dls.cantidad / Dolar.cotizRespectoDolar);
            return auxiliar;
        }

        public static explicit operator Peso(Dolar dls)
        {
            
            Peso auxiliar = new Peso(dls.cantidad / Dolar.cotizRespectoDolar);
            return auxiliar;
        }

        public static bool operator ==(Dolar dls, Euro eur)
        {
            double cantidadDls = dls.GetCantidad();
            double cantidadEur = eur.GetCantidad();
            bool retorno = false;

            if (cantidadDls == cantidadEur)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Dolar dls, Euro eur)
        {
            double cantidadDls = dls.GetCantidad();
            double cantidadEur = eur.GetCantidad();
            bool retorno = false;

            if (cantidadDls != cantidadEur)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Dolar dls1,Dolar dls2)
        {
            double cantidadDls1 = dls1.GetCantidad();
            double cantidadDls2 = dls2.GetCantidad();
            bool retorno = false;

            if(cantidadDls1 == cantidadDls2)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Dolar dls1, Dolar dls2)
        {
            double cantidadDls1 = dls1.GetCantidad();
            double cantidadDls2 = dls2.GetCantidad();
            bool retorno = false;

            if (cantidadDls1 != cantidadDls2)
            {
                retorno = true;
            }
            return retorno;
        }
    
        public static bool operator ==(Dolar dls, Peso pss)
        {
            double cantidadDls = dls.GetCantidad();
            double cantidadPss = pss.GetCantidad();
            bool retorno = false;

            if(cantidadDls==cantidadPss)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Dolar dls,Peso pss)
        {
            double cantidadDls = dls.GetCantidad();
            double cantidadPss = pss.GetCantidad();
            bool retorno = false;

            if (cantidadDls != cantidadPss)
            {
                retorno = true;
            }
            return retorno;
        }

        public static Dolar operator +(Dolar dls,Euro eur)
        {
            Dolar dolares = new Dolar(dls.GetCantidad()+ (eur.GetCantidad()*1.16));

            return dolares;
        }

        public static Dolar operator +(Dolar dls,Peso pss)
        {
            Dolar dolares = new Dolar(dls.GetCantidad() + (pss.GetCantidad() / 38.33));

            return dolares;
        }

        public static Dolar operator -(Dolar dls,Euro eur)
        {
            Dolar dolares = new Dolar(dls.GetCantidad() - (eur.GetCantidad() * 1.16));

            return dolares;
        }

        public static Dolar operator -(Dolar dls,Peso pss)
        {
            Dolar dolares = new Dolar(dls.GetCantidad() - (pss.GetCantidad() / 38.33));

            return dolares;
        }

        public static implicit operator Dolar(double dls)
        {
            Dolar dolares = new Dolar(dls);
            return dolares;
        }
    }
}
