using System;

namespace Micros
{
    class Program
    {
        static void Main(string[] args)
        {
            Micro micro1 = new Micro(1, 1){
                volumen = 125, 

            };

            EmpleadoApurado pepe = new EmpleadoApurado("pepe");
            
            if(pepe.AceptaSubir(micro1))
            {
                Console.WriteLine("Pepe aceptó subir");
                micro1.Subir(pepe);
            }
            else{Console.WriteLine("Pepe no aceptó subir"); }
            EmpleadoClaustrofobica pedro = new EmpleadoClaustrofobica("Pedro");
            if(pedro.AceptaSubir(micro1))
            {
                Console.WriteLine("Pedro aceptó subir");
                micro1.Subir(pedro);

            }else{
                Console.WriteLine("Pedro no aceptó subir");
            }   

            EmpleadoFiaca lucas = new EmpleadoFiaca("Lucas");
            if(lucas.AceptaSubir(micro1))
            {
                Console.WriteLine("Lucas aceptó subir");
                micro1.Subir(lucas);
            }
            else
            {Console.WriteLine("Lucas no aceptó subir");}

            EmpleadoObsecuente nana = new EmpleadoObsecuente(true, "Nana");
            if(nana.AceptaSubir(micro1))
            {
                Console.WriteLine("Nana aceptó subir");
                micro1.Subir(nana);
            }
            else{Console.WriteLine("Nana no aceptó subir");
                Console.ReadKey();}
                

            micro1.Primero();    

            
        }
    }
}
