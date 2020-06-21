namespace Micros
{
    public class EmpleadoClaustrofobica : Empleado
    {
        public EmpleadoClaustrofobica(string nombre): base (nombre)
        {
        }


        public override void Bajar()
        {
            throw new System.NotImplementedException();
        }

        public override bool AceptaSubir(Micro micro)
        {
             return micro.volumen > 120;
        }
    }
}