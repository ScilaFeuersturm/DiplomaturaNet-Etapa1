using System;

namespace Vectores
{
    class Program
    {
        static void Main(string[] args)
        {   int vecesAparece = 0;
            int cantidadNumeros= 0;
            int numeroABuscar = 0;
            int cantidadVeces = 0;


            Console.WriteLine("Ingrese la cantidad de números que se ingresaran por consola:");
            cantidadNumeros = Convert.ToInt32(Console.ReadLine());
            int [] arrayNumeros = new int [cantidadNumeros];


            for(int i = 0; i < cantidadNumeros; i++){
                Console.WriteLine("Ingrese el número {0}",arrayNumeros [i] + 1);
                arrayNumeros [i] = Convert.ToInt16(Console.ReadLine());
            }
            Buscar(arrayNumeros,numeroABuscar);

            Console.WriteLine($"El número ingresado aparece {vecesAparece} veces");
            Console.ReadKey();

        }

        private static void Buscar(int [] arrayNumeros, int numeroABuscar)
        {   
            Console.WriteLine("Ingrese el número que desea buscar: ");
            numeroABuscar = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                if (arrayNumeros[i] == numeroABuscar)
                {
                    //cantidadVeces = i+1;
                }
            }
            
        }

    
    }
}
