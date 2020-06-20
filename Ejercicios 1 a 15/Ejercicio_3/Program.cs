using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int DiaNacimiento = 0;
            int MesNacimiento = 0;
            int AnoNacimiento = 0;
            DateTime FechaNacimiento;
            int Edad = 0;

            Console.WriteLine("Ingrese su día de nacimiento");
            DiaNacimiento = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su mes de nacimiento");
            MesNacimiento = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su año de nacimiento");
            AnoNacimiento = Convert.ToInt32(Console.ReadLine());

            FechaNacimiento = new DateTime(AnoNacimiento, MesNacimiento, DiaNacimiento);
            var FechaFormateada = FechaNacimiento.ToString("dd-MM-yyyy"); //Como formatear fechas
            Console.WriteLine("Usted nació en {0}", FechaFormateada);
            Edad = (DateTime.Now.Subtract(FechaNacimiento).Days / 365);

            Console.WriteLine($"Usted tiene {Edad} años");
            Console.ReadKey();

        }   
    }
}
