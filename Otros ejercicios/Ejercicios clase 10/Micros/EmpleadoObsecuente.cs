namespace Micros
{
    public class EmpleadoObsecuente : Empleado
    {
        public bool subioJefe;
        public EmpleadoObsecuente(bool subioJefe, string nombre): base(nombre)
        {
            this.subioJefe = subioJefe;
        }

        public override void Bajar()
        {
            throw new System.NotImplementedException();
        }

        public override bool AceptaSubir(Micro micro)
        {
            return subioJefe;  
        }
    }
}