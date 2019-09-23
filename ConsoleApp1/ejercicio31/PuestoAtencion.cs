using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio31
{
    class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1,Caja2
        }

        private static int numeroActual;
        private Puesto puesto;

        private PuestoAtencion()
        {
           PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public static int NumeroActual
        {
            get
            {
                return ++ PuestoAtencion.numeroActual; ;
            }
        }



        public bool Atender(Cliente cli)
        {
            System.Threading.Thread.Sleep(1000);

            return true;
        }


    }
}
