using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
            this.razonSocial = "";
        }

        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }


        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float retorno = 0;

            foreach(Llamada auxiliar in listaDeLlamadas)
            {
                if(Llamada.TipoLlamada.Local== tipo)
                {
                    retorno= 
                }
            }

        }



        
    }
}
