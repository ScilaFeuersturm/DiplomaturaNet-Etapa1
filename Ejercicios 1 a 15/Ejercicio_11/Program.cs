using System;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Ingrese un número");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"El número ingresado tiene {checkLength(numero)} digitos");
            Console.ReadKey();
            
        }
        static int checkLength(int checkLength)
        {
            return checkLength.ToString().Length;
        }
    }
}
