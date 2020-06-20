using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            char caracter;

            Console.WriteLine("Por favor ingrese un caracter");
            caracter = Convert.ToChar(Console.ReadLine());

            if(Char.IsDigit(caracter)){
                Console.WriteLine("Es un número");
                Console.ReadKey();
            } else if (Char.IsLetter(caracter)){
                if(Char.IsLower(caracter)){
                    Console.WriteLine("Es una letra minúscula");
                    Console.ReadKey();
                }else{
                    Console.WriteLine("Es una letra mayúscula");
                    Console.ReadKey();
                }
            } else {
                Console.WriteLine("No es letra ni número");
                Console.ReadKey();
            }
        }
    }
}
