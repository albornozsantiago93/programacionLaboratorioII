using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio21
{
    class Kelvin
    {
        private double cantidad;
        private static double respectoCelcius;

        private Kelvin()
        {
            cantidad = 0;
            respectoCelcius = 0;
        }

        public Kelvin(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Kelvin( double cantidad,double gradosRespectoCelcius):this(cantidad)
        {
            respectoCelcius = gradosRespectoCelcius;
        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public double GetRespecto()
        {
            return respectoCelcius;
        }

       
        
    }
}
