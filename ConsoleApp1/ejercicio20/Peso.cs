using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio20
{
    public class Peso
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        private Peso()
        {
            cantidad = 0;
            cotizRespectoDolar = 0;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad,double cotizacion):this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Dolar(Peso pss)
        {
            Dolar dolares = new Dolar(pss.GetCantidad() / (Peso.cotizRespectoDolar));
            return dolares;
        }

        public static explicit operator Euro(Peso pss)
        {
            double cotizaciosPesosEuro = pss.GetCotizacion() * 1.16;
            Euro euros = new Euro(pss.GetCantidad() / cotizaciosPesosEuro);
            return euros;
        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static implicit operator Peso(double d)
        {
            Peso pesos = new Peso(d);
            return pesos;
        }

        public static bool operator !=(Peso pss, Dolar dls)
        {
            double cantidadPesos = pss.GetCantidad();
            double cantidadDls = dls.GetCantidad();
            bool retorno = false;

            if(cantidadDls!= cantidadPesos)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Peso pss, Dolar dls)
        {
            double cantidadPesos = pss.GetCantidad();
            double cantidadDls = dls.GetCantidad();
            bool retorno = false;

            if (cantidadDls == cantidadPesos)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Peso pss, Euro eur)
        {
            double cantidadPss = pss.GetCantidad();
            double cantidadEur = eur.GetCantidad();
            bool retorno = false;

            if(cantidadEur!= cantidadPss)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Peso pss, Euro eur)
        {
            double cantidadPss = pss.GetCantidad();
            double cantidadEur = eur.GetCantidad();
            bool retorno = false;

            if (cantidadEur == cantidadPss)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Peso pss,Peso pss2)
        {
            double cantidadPss = pss.GetCantidad();
            double cantidadPss2 = pss2.GetCantidad();
            bool retorno = false;

            if(cantidadPss!= cantidadPss2)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Peso pss, Peso pss2)
        {
            double cantidadPss = pss.GetCantidad();
            double cantidadPss2 = pss2.GetCantidad();
            bool retorno = false;

            if (cantidadPss == cantidadPss2)
            {
                retorno = true;
            }
            return retorno;
        }

        public static Peso operator +(Peso pss, Euro eur)
        {
            double cotizacionPesosEuro = pss.GetCotizacion() * eur.GetCotizacion();
            Peso pesos = new Peso(pss.GetCantidad() + (eur.GetCantidad() * cotizacionPesosEuro));
            return pesos;
        }

        public static Peso operator -(Peso pss, Euro eur)
        {
            double cotizacionPesosEuro = pss.GetCotizacion() * eur.GetCotizacion();
            Peso pesos = new Peso(pss.GetCantidad() - (eur.GetCantidad() * cotizacionPesosEuro));
            return pesos;
        }

        public static Peso operator +(Peso pss, Dolar dls)
        {
            Peso pesos = new Peso(pss.GetCantidad() + (dls.GetCantidad() * pss.GetCotizacion()));
            return pesos;
        }

        public static Peso operator -(Peso pss, Dolar dls)
        {
            Peso pesos = new Peso(pss.GetCantidad() - (dls.GetCantidad() * pss.GetCotizacion()));
            return pesos;
        }
    }
}
