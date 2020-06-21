namespace Micros
{
    public class EmpleadoModerado : Empleado
    {
        int lugaresLibres;
        public EmpleadoModerado(int lugaresLibres, string nombre): base(nombre)
        {
            this.lugaresLibres = lugaresLibres;
        }

        public override void Bajar()
        {
            throw new System.NotImplementedException();
        }

        public override bool AceptaSubir(Micro micro)
        {
            return lugaresLibres >= micro.lugaresDisponibles;
        }

    }
}