using System.Collections.Generic;

namespace Hospital.Clases
{
    class Medico
    {
        internal string name;
        internal string matricula;
        internal EstadoMedico estado;
        internal EspecializacionMedico especialidad;
        internal List<Paciente> pacientes;
        internal Paciente pacienteEnConsulta;

        public Medico(string name, string matricula, EstadoMedico estado, EspecializacionMedico especialidad, List<Paciente> pacientes)
        {
            this.name = name;
            this.matricula = matricula;
            this.estado = estado;
            this.especialidad = especialidad;
            this.pacientes = new List<Paciente>();
            this.pacienteEnConsulta = null;
        }

        public string Name { get => name; }
        public string Matricula { get => matricula; }
        public EstadoMedico Estado { get => estado; }
        public EspecializacionMedico Especialidad { get => especialidad; }
        public bool estoyDisponible() {
            return this.estado == EstadoMedico.libre;
        }
        public bool IniciarConsulta(Paciente paciente)
        {
            if (this.estado == EstadoMedico.atendiendo) return false;
            this.pacientes.Add(paciente);
            pacienteEnConsulta.IniciarConsulta(this);
            this.estado = EstadoMedico.ocupado;
            return true;
        }
        public void FinalizarConsulta()
        {

        }

    }
}
