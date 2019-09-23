using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio31
{
    class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> cliente;
        private string nombre;

        public Cliente Cliente
        {
            get
            {
                return this.cliente.Dequeue();
            }
            set
            {
                if (!(this == value))
                {
                    this.cliente.Enqueue(value);
                }
            }
        }

        private Negocio()
        {
            this.cliente = new Queue<Cliente>();
        }

        public Negocio(string nombre):this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Negocio n,Cliente c)
        {
            bool retorno = false;

            if(n.cliente.Contains(c))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Negocio n,Cliente c)
        {
            bool retorno = false;

            if(n!=c)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator +(Negocio n,Cliente c)
        {
            bool retorno = false;

            if(n!=c)
            {
                n.cliente.Enqueue(c);//AGREGA UN OBJETO AL FINAL
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ~(Negocio n)
        {
            bool retorno = false;

            n.caja.Atender(Cliente.Nombre);

            return retorno;
        }
           
    }
}
