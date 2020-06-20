using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
        
            double precioHotDog, precioPapas, precioSoda, totalHotdog =0, totalPapas =0, totalSoda=0, totalSinPropina =0 , totalConPropina = 0;
            int hotDogs, papas, cantidadSoda;       
            char opcion;
// bool result = Int32.TryParse(Ingresoporconsolaovariable, out numero);
            precioHotDog = 2.0;
            precioPapas = 1.0;
            precioSoda = 0.85;
            
        do {
            Console.WriteLine("---TOMAR ORDEN---");
            Console.WriteLine("Seleccione un ítem de la lista:");
            Console.WriteLine("\th - Hot dogs");
            Console.WriteLine("\tp - Papas");
            Console.WriteLine("\ts - Soda");
            Console.WriteLine("\tc - Calcular total");
            Console.Write("Elige la opcion deseada: ");

            opcion = Convert.ToChar(Console.ReadLine());
               switch (opcion)
            {
                case 'h':
                    Console.WriteLine("Ingrese la cantidad de hot dogs que desea comprar: ");
                    hotDogs = Convert.ToInt16(Console.ReadLine()) ;
                    totalHotdog = hotDogs * precioHotDog;
                    break;
                case 'p':
                    Console.WriteLine("Ingrese la cantidad de papas que desea comprar: ");
                    papas = Convert.ToInt16(Console.ReadLine());
                    totalPapas = papas * precioPapas;
                    break;
                case 's':
                    Console.WriteLine("Ingrese la cantidad de sodas que desea comprar: ");
                    cantidadSoda = Convert.ToInt16(Console.ReadLine());
                    totalSoda = cantidadSoda * precioSoda;
                    break;
                case 'c':
                    totalSinPropina = totalHotdog + totalPapas + totalSoda;
                    totalConPropina = totalSinPropina + ((totalSinPropina/100)*10);
                    totalConPropina = Math.Round(totalConPropina, 2);
                    Console.WriteLine($"El total a pagar es de {totalConPropina} propina incluida ");
                    Console.WriteLine("Ingrese cualquier tecla para terminar");
                    Console.ReadKey();
                    break;
                default :
                    Console.WriteLine("Por favor ingrese un caracter válido");
                    break;
            }
            } while (!opcion.Equals('c'));
        }










            


        }
    }
