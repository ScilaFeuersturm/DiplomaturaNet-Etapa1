using System;

namespace Ejercicio_10
{
    class Program
    {
        
        static void Main(string[] args)
        {
           int edad;
           double peso;
           double altura;
           double imc;
           string riesgo;

           Console.WriteLine("Ingrese su edad");
           edad = int.Parse(Console.ReadLine());

           Console.WriteLine("Ingrese su peso");
           peso = double.Parse(Console.ReadLine());

           Console.WriteLine("Ingrese su altura");
           altura = double.Parse(Console.ReadLine());

           imc = CalcularMasa(altura, peso);
           riesgo = CalcularRiesgo(imc, edad);
           ImprimirResultados(imc, riesgo);
          
        }
        

        static double CalcularMasa(double altura, double peso){
            double imc;

            imc = peso / (Math.Pow(altura,2));

            return imc;
        }
        static string CalcularRiesgo(double imc, int edad){
            var estadoRiesgo = "";
            if(imc < 22.0)
            {
                if(edad < 45)
                {
                    estadoRiesgo = "riesgo bajo";
                }else
                {
                    estadoRiesgo = "riesgo medio";
                }
            }
            else
            {
            if(edad < 45)
                {
                    estadoRiesgo = "riesgo bajo";
                }else
                {
                    estadoRiesgo = "riesgo alto";
                }
            }
            return estadoRiesgo;
        }

        static void ImprimirResultados(double imc, string riesgo)
        {
            
            Console.WriteLine($"El IMC de la persona es de {imc}");
            Console.WriteLine($"El estado de la persona es de {riesgo}");
            Console.ReadKey();

        }
    
    }
}
