using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorAzul = ConsoleColor.Blue;
            ConsoleColor colorRojo = ConsoleColor.Red;

            Boligrafo boligrafo = new Boligrafo(100,colorAzul);
            Boligrafo boligrafoDos = new Boligrafo(50, colorRojo);
        }
    }
}
