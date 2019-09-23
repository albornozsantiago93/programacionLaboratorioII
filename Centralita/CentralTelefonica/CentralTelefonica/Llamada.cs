using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    class Llamada
    {
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }                
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        public Llamada()
        {
            duracion = 0;
            nroDestino = "";
            nroOrigen = "";
        }

        public Llamada(float duracion,string nroDestino,string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("Duracion: " + this.duracion);
            retorno.AppendLine("NroDestino: " + this.nroDestino);
            retorno.AppendLine("NroOrigen: " + this.nroOrigen);

            return retorno.ToString();
        }

        public int OrdenarPorDuracion(Llamada llamada1,Llamada llamada2)
        {
            int retorno = 0;

            if(llamada1.duracion>llamada2.duracion)
            {
                retorno = 1;
            }
            else if(llamada1.duracion < llamada2.duracion)
            {
                retorno = -1;
            }
            else
            {
                retorno = 0;
            }
            return retorno;
        }



    }
}
