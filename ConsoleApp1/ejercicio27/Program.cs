using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            Queue<int> colaPositivos = new Queue<int>();
            Stack<int> pilaPositivos = new Stack<int>();
            Queue<int> colaNegativos = new Queue<int>();
            Stack<int> pilaNegativos = new Stack<int>();
            Random aleatorio = new Random();

            for(int i=0;i<10;i++)
            {
                lista.Add(aleatorio.Next(-10, 10));
            }

            lista.Sort();

            foreach(int i in lista)
            {
                Console.WriteLine(i);
            }

            foreach(int i in lista)
            {
                if(i>0)
                {
                    colaPositivos.Enqueue(i);//AGREGA UN OBJETO POSITIVO AL FINAL DE LA COLA
                }
                else
                {
                    colaNegativos.Enqueue(i);//AGREGA UN OBJETO NEGATIVO 
                }
            }
            Console.WriteLine("Cola NEGATIVOS\n");
            foreach (int i in colaNegativos)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Cola POSITIVOS\n");
            foreach(int i in colaPositivos)
            {
                Console.WriteLine(i);
            }

            foreach (int i in lista)
            {
                if (i > 0)
                {
                    pilaPositivos.Push(i);
                }
                else
                {
                    pilaNegativos.Push(i);//INSERTA UN OBJETO AL PRINCIPIO DEL STACK
                }
            }

            Console.WriteLine("PILA POSITIVOS\n");


            foreach (int i in pilaPositivos)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("PILA NEGATIVOS\n");

            foreach (int i in pilaNegativos)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
