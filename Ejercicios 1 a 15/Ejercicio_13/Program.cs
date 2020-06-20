using System;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Ingrese un número");
            numero = int.Parse(Console.ReadLine());
            
            /*if(esPrimo(numero)){
                Console.WriteLine("El número ingresado es primo");
                Console.ReadKey();
            }else{
                Console.WriteLine("El número ingresado no es primo");
                Console.ReadKey();
            }*/

        }
        static bool esPrimo(int numero)
        {
            int divisor = 2;
            int resto = 0;
            while (divisor < numero)
            {
                resto = numero % divisor;
                if(resto == 0)
                {
                    return true;
                }
                divisor = divisor + 1;
            }
            return false;
        }
        static void PrimerosPrimos()
        {
            //Chequear este enlace
        }
    }
}
