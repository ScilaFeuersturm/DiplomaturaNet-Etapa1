using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado1, lado2, lado3, sumatoriaLado2Lado3, sumatoriaLado1Lado2, sumatoriaLado3Lado1;

            Console.WriteLine("Ingrese el lado 1");
            lado1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el lado 2");
            lado2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el lado 3");
            lado3 = Convert.ToDouble(Console.ReadLine());


            sumatoriaLado1Lado2 = lado1 + lado2;
            sumatoriaLado2Lado3 = lado2 + lado3;
            sumatoriaLado3Lado1 = lado3 + lado1;


            if(lado1 <= sumatoriaLado2Lado3 && lado2 <= sumatoriaLado3Lado1 && lado3 <= sumatoriaLado1Lado2)
            {   
                Console.WriteLine("Es un triángulo válido");
                if(lado1 == lado2 && lado1 != lado3 || lado2 == lado3 && lado2 != lado1 || lado3 == lado1 && lado3 != lado2){
                    Console.WriteLine("Es un triángulo isoceles");
                    Console.ReadKey();
                }else if(lado1 != lado2 || lado2 != lado3 || lado3 != lado1){
                    Console.WriteLine("Es un triángulo escaleno");
                    Console.ReadKey();
                }else{
                    Console.WriteLine("Es un triángulo equilátero");
                    Console.ReadKey();
                }
            } else{
                 Console.WriteLine("No es un triángulo válido");
                 Console.ReadKey();
            }
        }
    }
}
