namespace Micros
{
    public abstract class Empleado
    {
        public string Nombre {set;get;}
        protected Empleado(string nombre)
        {
            this.Nombre = nombre;
        }
        
        public abstract bool AceptaSubir(Micro micro);
        public abstract void Bajar();
       

    }
}