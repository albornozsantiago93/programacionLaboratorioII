using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    class Local : Llamada
    {
        protected float costo;


        private float CalcularCosto()
        {
            float retorno = 0;

            retorno = this.duracion * this.costo;

            return retorno;
        }

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public Local(string origen,float duracion,string destino,float costo)
        {
            this.nroOrigen = origen;
            this.duracion = duracion;
            this.nroDestino = destino;
            this.costo = costo;
        }

        public Local(Llamada llamada, float costo)
        {
            this.duracion = llamada.Duracion;
            this.costo = costo;
            this.nroDestino = llamada.NroDestino;
            this.nroOrigen = llamada.NroOrigen;
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("Duracion: " + this.Duracion);
            retorno.AppendLine("Origen: " + this.NroOrigen);
            retorno.AppendLine("Destino: " + this.NroDestino);
            retorno.AppendLine("Costo:" + this.CostoLlamada);

            return retorno.ToString();
        }
    }
}
