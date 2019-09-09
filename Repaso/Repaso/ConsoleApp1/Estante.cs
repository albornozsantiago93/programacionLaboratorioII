using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Estante
    {
        private Producto[] producto;
        private int ubicacionEstante;      


        private Estante(int capacidad)
        {
            producto = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) :this(capacidad)
        {
            ubicacionEstante = ubicacion;            
        }
       
        public Producto[] GetProducto()
        {                    
             return producto;
        }

        /*public string MostrarEstante(Estante est)
        {
            string retorno = "";

            retorno= 
        }
        */
        public static bool operator ==(Estante est,Producto prd)
        {
            bool retorno = false;

            foreach(Producto elemento in est.producto)
            {
                if(elemento==prd)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Estante est,Producto prd)
        {
            return !(est == prd);
        }

        public static bool operator +(Estante est, Producto prd)
        {
            bool retorno = false;

            if(est!=prd)
            {
                if(est.producto is null)
                {
                    for(int i=0; i<est.producto.Length;i++)
                    {
                        if(est.producto[i] is null)
                        {
                            est.producto[i] = prd;
                            retorno = true;
                        }
                    }
                }
            }            
            return retorno;
        }

        public static Estante operator -(Estante est,Producto prd)
        {
            for(int i=0; i<est.producto.Length;i++)
            {
                if(est.producto[i]== prd)
                {
                    est.producto[i] = null;
                    i = est.producto.Length;
                }
            }
            return est;
        }
    }
}
