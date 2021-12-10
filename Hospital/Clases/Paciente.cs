using System;
namespace Hospital.Clases
{
    class Paciente
    {
        internal string name;
        internal string apellido;
        internal ObraSocial obraSocial;
        public Paciente(string name,string apellido,ObraSocial obrasocail)
        {
            this.name = name;
            this.apellido = apellido;
            this.obraSocial = obraSocial;
        }
    }
}
