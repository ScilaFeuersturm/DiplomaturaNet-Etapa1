namespace Micros
{
    public class EmpleadoFiaca : Empleado
    {
        public EmpleadoFiaca(string nombre): base (nombre)
        {
        }

        public override void Bajar()
        {
            throw new System.NotImplementedException();
        }

        public override bool AceptaSubir(Micro micro)
        {
            return micro.asientosDisponibles > 0;
        }
    }
}