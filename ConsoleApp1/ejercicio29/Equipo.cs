using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio29
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        public List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.cantidadDeJugadores = 0;
            this.nombre = "";
            this.jugadores= new List<Jugador>();
        }

        public Equipo(short cantidadJugadores,string nombre)
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombre = nombre;
        }

        public int CalcularEspacioDisponible()
        {
            int espaciosOcupados = 0;

            foreach(Jugador j in this.jugadores)
            {
                espaciosOcupados= jugadores.Count();
                
            }
            return this.cantidadDeJugadores - espaciosOcupados;
        }

        public static bool operator +(Equipo e,Jugador j)
        {
            bool retorno = false;

            if(e.CalcularEspacioDisponible()<e.cantidadDeJugadores)
            {
                if(!(e.jugadores.Contains(j)))
                {
                    e.jugadores.Add(j);
                    retorno = true;
                }                
            }
            return retorno;
        }

    }
}
