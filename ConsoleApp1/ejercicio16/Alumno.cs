using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio16
{
    class Alumno
    {
        public int nota1;
        public int nota2;
        public float notaFinal;
        public string apellido;
        public string nombre;
        public int legajo;


        public void Estudiar(int notaUno, int notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public bool Aprobados(int nota)
        {
            bool retorno = false;

            if (nota >= 4)
            {
                retorno = true;
            }
            return retorno;
        }

        public static void Mostrar()
        {

        }
    }
}
