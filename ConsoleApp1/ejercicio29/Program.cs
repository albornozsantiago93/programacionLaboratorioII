using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio29
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(6,"VOKITA");
         
            Jugador jugador = new Jugador(123, "PEPE", 5, 2);
            Jugador jugador2= new Jugador(234, "JUAN", 1, 6);
            Jugador jugador3 = new Jugador(114, "TOTO", 0, 6);
            Jugador jugador4 = new Jugador(244, "LULU", 6, 6);



                Console.WriteLine(jugador.MostrarDatos());
                Console.WriteLine(jugador2.MostrarDatos());
                Console.WriteLine(jugador4.MostrarDatos());
                Console.WriteLine(jugador3.MostrarDatos());

            Console.WriteLine("Ingrese Nombre: ");
            string nombre= Console.ReadLine();
            Console.WriteLine("Ingrese DNI: ");
            string dniString = Console.ReadLine();
            int dni= int.Parse(dniString);
            Console.WriteLine("Ingrese cantidad de goles: ");
            string cantidadGolesString = Console.ReadLine();
            int cantidadGoles = int.Parse(cantidadGolesString);
            Console.WriteLine("Ingrese Partidos jugados: ");
            string partidosJugadosString = Console.ReadLine();
            int partidosJugados = int.Parse(partidosJugadosString);

            Jugador jugador5 = new Jugador(dni, nombre, cantidadGoles, partidosJugados);

            Console.WriteLine(jugador5.MostrarDatos());



            Console.ReadKey();

        }
    }
}
