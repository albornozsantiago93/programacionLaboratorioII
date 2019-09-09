using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio20
{
    class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        private Euro()
        {
            cantidad = 0;
            cotizRespectoDolar = 0;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad,double cotizacion):this(cantidad)
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

        public static explicit operator Dolar(Euro eur)
        {
            Dolar auxiliar = new Dolar(eur.cantidad * eur.GetCotizacion());
            return auxiliar;
        }

        public static explicit operator Peso(Euro eur)
        {
            double cotizacionPesosEuro = 38.33 * 1.16;
            Peso pesos = new Peso(eur.GetCantidad() * cotizacionPesosEuro);
            return pesos;
        }


        public static bool operator ==(Euro eur, Dolar dls)
        {
            double cantidadDls = dls.GetCantidad();
            double cantidadEur = eur.GetCantidad();
            bool retorno = false;

            if(cantidadDls==cantidadEur)
            {
                retorno = true;
            }
            return retorno;         
        }

        public static bool operator !=(Euro eur, Dolar dls)
        {

            bool retorno = false;

            if (eur != dls)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Euro eur, Peso pss)
        {
            double cantidadEur = eur.GetCantidad();
            double cantidadPss = pss.GetCantidad();
            bool retorno = false;

            if(cantidadEur == cantidadPss)
            {
                retorno = true;
            }

            return retorno; 
      
        }

        public static bool operator !=(Euro eur,Peso pss)
        {

            bool retorno = false;

            if(eur!=pss)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Euro eur, Euro eur2)
        {
            double cantidadEur = eur.GetCantidad();
            double cantidadEur2 = eur2.GetCantidad();
            bool retorno = false;

            if(cantidadEur== cantidadEur2)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Euro eur, Euro eur2)
        {
            bool retorno = false;

            if(eur != eur2)
            {
                retorno = true;
            }
            return retorno;
        }

        public static Euro operator +(Euro eur, Dolar dls)
        {
            Euro euros = new Euro(eur.GetCantidad() + (dls.GetCantidad() / eur.GetCotizacion()));
            return euros;
        }

        public static Euro operator -(Euro eur, Dolar dls)
        {
            Euro euros = new Euro(eur.GetCantidad() - (dls.GetCantidad() / eur.GetCotizacion()));
            return euros;
        }

        public static Euro operator +(Euro eur, Peso pss)
        {
            double cotizacionPesosEuro;

            cotizacionPesosEuro = pss.GetCotizacion()* eur.GetCotizacion();
            Euro euros = new Euro(eur.GetCantidad() + (pss.GetCantidad() / cotizacionPesosEuro));
            return euros;
        }

        public static Euro operator -(Euro eur, Peso pss)
        {
            double cotizacionPesosEuro;

            cotizacionPesosEuro = pss.GetCotizacion() * eur.GetCotizacion();
            Euro euros = new Euro(eur.GetCantidad() - (pss.GetCantidad() / cotizacionPesosEuro));
            return euros;
        }

        public static implicit operator Euro(double dls)
        {
            Euro euros = new Euro(dls);
            return euros;
        }

    }
}
