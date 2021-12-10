using System;
namespace Hospital.Clases
{
    public class Medico
    {
        internal string name;
        private string matricula;
        private string estado;
        private string especialidad;
        public Medico()
        {
        }

        public Medico(string name, string matricula, string estado, string especialidad)
        {
            this.name = name;
            this.matricula = matricula;
            this.estado = estado;
            this.especialidad = especialidad;
        }

        public string Name { get => name; }
        public string Matricula { get => matricula; }
        public string Estado { get => estado; }
        public string Especialidad { get => especialidad;}
    }
}
