using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio03";

            int aux;
            Console.WriteLine("Ingrese numero:");

            if(int.TryParse(Console.ReadLine(), out aux))
            {
                int a = 0;
                
                for(int i=1;i<= aux;i++)
                {
                    if(aux%i==0)
                    {
                        a++;
                    }                      
                }
                if(a!=2)
                {
                    Console.Write("No es primo");
                }
                else
                {
                    Console.Write("Si es primo");
                }
            }
            Console.ReadKey();
        }
    }
}
