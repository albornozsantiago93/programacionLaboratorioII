using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio31
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;

            Negocio nuevoNegocio = new Negocio("NeGoCio NuEvO");
            Cliente clienteUno = new Cliente(1, "Pepe");
            Cliente clienteDos = new Cliente(2, "Pipo");
            Cliente clienteTres = new Cliente(3, "Papa");
            Cliente clienteCuatro= new Cliente(4, "Pupu");

            Console.WriteLine("1-Mostrar\n2-Agregar\n3-Borrar\n4-Salir\n");
            opcion = Console.ReadLine();
            do
            {
                switch (opcion)
                {
                    case "1":
                        for(int i=0;i<4;i++)
                        {
                            Console.WriteLine();
                        }
                        break;

                    case "2":
                        break;

                    case "3":
                        break;
                }
            } while (opcion != "4");
        }
    }
}
