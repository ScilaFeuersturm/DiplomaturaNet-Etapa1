using System;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Ingrese el año: ");
            year = Convert.ToInt32(Console.ReadLine());

            if(year % 4 == 0 && year % 100 != 0 || year % 400 == 0){
                Console.WriteLine($"El año {year} es bisiesto");
                Console.ReadKey();
            }else
            {
                Console.WriteLine($"El año {year} no es bisiesto");
                Console.ReadKey();
            }
        }
    }
}
