using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio06";

            int anioComienzo, anioFinal;
            string anioStringComienzo, anioStringFinal;

            Console.Write("Ingrese anio de inicio: ");
            anioStringComienzo = Console.ReadLine();
            if(int.TryParse(anioStringComienzo,out anioComienzo))
            {
                Console.Write("Ingrese ultimo anio: ");
                anioStringFinal = Console.ReadLine();
                if(int.TryParse(anioStringFinal, out anioFinal))
                {
                    for(int i= anioComienzo;i<=anioFinal;i++)
                    {

                        if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
                        {
                            Console.WriteLine("Anio biciesto: {0}", i);
                        }
                    }                    
                }
            }
            Console.ReadKey();
        }
    }
}
