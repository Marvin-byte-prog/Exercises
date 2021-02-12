using Cola.Clases;
using System;

namespace Cola
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int numNombres;

            Console.WriteLine("Cantidad de nombres a ingresar: ");
            numNombres = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            clsArray[] nombres = new clsArray[numNombres];
            
            for(int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre de la persona No. {0}", i + 1);
                nombre = Console.ReadLine();

                nombres[i] = new clsArray(nombre);
            }

            Console.Clear();

            Console.WriteLine("Orden en el que entraron las personas.");
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i].mostrar());
            }
        }

    }
    
}

 