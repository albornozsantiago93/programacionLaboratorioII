using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            string strLegajo, strNombre, strApellido, strNota1, strNota2;
            int legajo, nota1, nota2;

            Alumno estudiante = new Alumno();

            Console.Write("Ingrese nombre de alumno:");
            strNombre = Console.ReadLine();

            Console.Write("Ingrese apellido de alumno:");
            strApellido = Console.ReadLine();

            Console.Write("Ingrese legajo de alumno: ");
            strLegajo = Console.ReadLine();
            if (int.TryParse(strLegajo, out legajo))
            {
                estudiante.nombre = strNombre;
                estudiante.apellido = strApellido;
                estudiante.legajo = legajo;

                Console.Write("Ingrese primera nota: ");
                strNota1 = Console.ReadLine();
                if (int.TryParse(strNota1, out nota1))
                {
                    Console.Write("Ingrese segunda nota: ");
                    strNota2 = Console.ReadLine();
                    if (int.TryParse(strNota2, out nota2))
                    {
                        Alumno.Estudiar(nota1, nota2);
                    }
                }

            }
        }
    }
}
