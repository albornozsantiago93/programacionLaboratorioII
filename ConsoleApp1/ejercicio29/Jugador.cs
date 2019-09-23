using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio29
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.dni = 0;
            this.nombre = "";
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni,string nombre,int totalGoles,int totalPartidos):this(dni,nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
            this.promedioGoles = GetPromedioGoles();
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            bool retorno = false;

            if(j1.dni!=j2.dni)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool retorno = false;

            if (j1 == j2)
            {
                retorno = true;
            }
            return retorno;
        }

        public string MostrarDatos()
        {
            string mostrar;

            mostrar= " Nombre: " + nombre + " DNI: " + dni + " Partidos Jugados: " + partidosJugados + " Total Goles: " + totalGoles + " Promedio Goles: " + promedioGoles ;

            return mostrar;
        }

        public float GetPromedioGoles()
        {
            float retorno;

            retorno = (float)totalGoles / partidosJugados;

            return retorno;
        }


    }
}
