using System;
using System.Linq;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadPalabras = 0;
            string larga = "";
            string corta = "";
            string [] arrayPalabras; //new int [cantidadPalabras];
            Console.WriteLine("Ingrese la cantidad de palabras que se ingresarán en la comparación");
            cantidadPalabras = int.Parse(Console.ReadLine());

            arrayPalabras = new string [cantidadPalabras];

            for(int i = 0; i < arrayPalabras.Length; i++)
            {
            Console.WriteLine($"Ingrese la palabra {arrayPalabras[i]} ");
            arrayPalabras[i] = Console.ReadLine();
            }

            var sorted=arrayPalabras.OrderBy(n => n.Length);
            corta = sorted.FirstOrDefault();
            larga = sorted.LastOrDefault();

            for(int i = 0; i < arrayPalabras.Length; i++){
                Console.WriteLine($"Palabra {i + 1}:");
                Console.WriteLine($"{arrayPalabras[i]}");
            }
            Console.WriteLine($"La palabra más larga es {larga} ");
            Console.WriteLine($"La palabra más corta es {corta} ");
            Console.ReadKey();

        }
    }
}
