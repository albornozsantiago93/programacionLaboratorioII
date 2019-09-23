using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected Franja franjaHoraria;

        public Provincial(Franja miFranja,Llamada llamada)
        {
            this.franjaHoraria = miFranja;
            this.duracion = llamada.Duracion;
            this.nroDestino = llamada.NroDestino;
            this.nroOrigen = llamada.NroOrigen;                        
        }
        
        public string Mostrar()
        {
            StringBuilder retorno= new StringBuilder();
       
            retorno.AppendLine("Duracion: " + this.Duracion);
            retorno.AppendLine("Origen: " + this.NroOrigen);
            retorno.AppendLine("Destino: " + this.NroDestino);
            retorno.AppendLine("Franja: " + this.franjaHoraria);

            return retorno.ToString();
        }

        private float CalcularCosto()
        {
            float retorno=0;

            if(this.franjaHoraria == Franja.Franja_1)
            {
                retorno = this.CalcularCosto() *(float)0.99 ;
            }
            else if(this.franjaHoraria== Franja.Franja_2)
            {
                retorno = this.CalcularCosto() * (float)1.25;
            }
            else if(this.franjaHoraria== Franja.Franja_3)
            {
                retorno = this.CalcularCosto() * (float)0.66;
            }
            return retorno;
        }

    }
}
