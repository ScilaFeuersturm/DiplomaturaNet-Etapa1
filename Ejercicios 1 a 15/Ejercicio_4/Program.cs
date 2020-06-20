using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra1;
            string palabra2;
            int palabra1Longitud;
            int palabra2Longitud;
            int diferencia;

            Console.WriteLine("Ingrese una palabra");
            palabra1 = Console.ReadLine();
            palabra1Longitud = palabra1.Length;

            Console.WriteLine("Ingrese otra palabra");
            palabra2 = Console.ReadLine();
            palabra2Longitud = palabra2.Length;

            if(palabra1Longitud>palabra2Longitud){
                diferencia = palabra1Longitud - palabra2Longitud;
                Console.WriteLine($"La palabra más larga es {palabra1} que tiene {diferencia} letra/s más que {palabra2}");
                Console.ReadKey();
            }else if(palabra2Longitud>palabra1Longitud){
                diferencia = palabra2Longitud - palabra1Longitud;
                Console.WriteLine($"La palabra más larga es {palabra2} que tiene {diferencia} letra/s más que {palabra1}");
                Console.ReadKey();
            }else{
                Console.WriteLine($"Las palabras {palabra1} y {palabra2} tienen la misma cantidad de letras");
                Console.ReadKey();


            }
            
        }
    }
}
