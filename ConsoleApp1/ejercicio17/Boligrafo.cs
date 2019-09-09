using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio17
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima= 100;
        ConsoleColor color;
        short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        public short GetTinta()
        {
            return tinta;
        }

        private void SetTinta(short tintaAux)
        {
            if(tintaAux>=0 && tintaAux<=cantidadTintaMaxima)
            {
                this.tinta = tintaAux;
            }
        }

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        public void Pintar(short gasto, out string nivel)
        {
            if(gasto>=0 && gasto<=cantidadTintaMaxima)
            {
                string aux = "";
                short tintaAux = GetTinta();

                if(gasto>tintaAux)
                {
                    tintaAux = gasto;
                }

                for(int i= 0; i<gasto;i++)
                {
                    aux += "*";
                    tintaAux--;
                }
                this.SetTinta(tintaAux);
                nivel = aux;

            }
            else
            {
                nivel = " ";
            }
        }
    }
}
