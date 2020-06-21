using System;
using System.Linq;
using System.Collections.Generic; 


namespace Micros
{
    public class Micro
    {
        public int cantidadAsientos {set;get;} //A esto lo vas a tener que setear de este lado con el length de la lista
        public int cantidadParados {set;get;} // Si todos los asientos
        public int espaciosDisponibles {set;get;}
        public int asientosDisponibles{set;get;}
        
        public int lugaresDisponibles{set;get;}
        public int volumen{set;get;}
        public Empleado [] empleadosSentados;
        public Empleado [] empleadosParados;

        public Micro(int cantidadAsientos, int cantidadParados)
        {
            this.cantidadAsientos = cantidadAsientos;
            this.cantidadParados = cantidadParados;
            espaciosDisponibles = cantidadParados;
            asientosDisponibles = cantidadAsientos;
            lugaresDisponibles = espaciosDisponibles + asientosDisponibles;
            empleadosParados = new Empleado [cantidadParados];
            empleadosSentados = new Empleado [cantidadAsientos];

        }

        public Boolean PuedeSubir(Empleado empleado)
        {
            return empleado.AceptaSubir(this);
        }

        public void Subir(Empleado empleado)
        {   
            int i = 0;
            int j = 0;
            if(asientosDisponibles > 0 && PuedeSubir(empleado))
            {
                if(i < empleadosSentados.Length)
                {
                    empleadosSentados[i] = empleado;
                     i++;
                     asientosDisponibles--;
                     lugaresDisponibles--;
                }
            }
            else if (espaciosDisponibles > 0 && PuedeSubir(empleado))
            {
                if(j < empleadosParados.Length)
                {
                    empleadosParados[j] = empleado;
                    j++;
                    espaciosDisponibles--;
                    lugaresDisponibles--;
                    
                } 
            }
            else{
                Console.WriteLine("Ya no hay espacio en el micro, por favor busque otro");
            }
        }
        public void Baja(Empleado empleado)
        {

        }
        public void Primero()
        {
            Console.WriteLine($"El primer usuario en subir fue {empleadosSentados[0].Nombre}");
            Console.ReadKey();
        }
    }

}