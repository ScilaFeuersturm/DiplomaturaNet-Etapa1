using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pulgadas = 2.54; 
            double valor = 0;
            double valorPulgadas = 0;
            Console.WriteLine("Ingrese un valor en cm : ");
            valor = Convert.ToDouble(Console.ReadLine());
            valorPulgadas = valor / pulgadas;

            Console.Write($"{valor} cm equivalen a {valorPulgadas} pulgadas");
            Console.ReadLine();
        }
    }
}
