using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca,string codigoDeBarra,float precio)
        {
            this.precio = precio;
            this.marca = marca;
            this.codigoDeBarra = codigoDeBarra;
        }

        public string GetMarca()
        {
            return marca;
        }

        public float GetPrecio()
        {
            return precio;
        }

        static public string MostrarProducto(Producto p)
        {
            string retorno = "Marca: " + p.marca + "Precio:  " + p.precio + "Cod Barras: " + (string)p;

            return retorno;
        }

        public static bool operator ==(Producto p1, string marca)
        {
            bool retorno = false;

            if(p1.marca== marca)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator!=(Producto p, string marca)
        {
            return !(p.marca == marca);
        }

        public static bool operator ==(Producto prd1,Producto prd2)
        {
            bool retorno = false;

            if(prd1.marca== prd2.marca && prd1.codigoDeBarra == prd2.codigoDeBarra)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Producto prd1,Producto prd2)
        {
            return !(prd1.marca == prd2.marca && prd1.codigoDeBarra == prd2.codigoDeBarra);
        }



        public static explicit operator string(Producto prod)
        {
            return prod.codigoDeBarra;
        }

    }
}
