namespace Micros
{
    public class EmpleadoApurado : Empleado
    {
        public EmpleadoApurado(string nombre): base (nombre)
        {
        }

        public override void Bajar()
        {
            throw new System.NotImplementedException();
        }

        public override bool AceptaSubir(Micro micro)
        {
            return true;
        }
    }
}