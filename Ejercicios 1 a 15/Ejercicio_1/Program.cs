using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double promedio = 0;
            
            for(int i = 0; i<4; i++){
                Console.WriteLine("Ingrese la nota {0}:" , i+1);
                var variable = Console.ReadLine();
                promedio += Int32.Parse(variable);
            }
            promedio = promedio / 4;
            Console.WriteLine($"El promedio es {promedio}");
            Console.ReadKey();
        }
    }
}
