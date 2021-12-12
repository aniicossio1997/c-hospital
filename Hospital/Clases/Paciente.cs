using System;
using System.Collections.Generic;

namespace Hospital.Clases
{
    class Paciente
    {
        internal string name;
        internal string apellido;
        internal ObraSocial obraSocial;
        internal List<Medico> medicos;
        internal EnumPacienteEstado estado;
        public Paciente(string name,string apellido,ObraSocial obraSocial)
        {
            this.name = name;
            this.apellido = apellido;
            this.obraSocial = obraSocial;
        }
        public string GetName()
        {
            return this.name;
        }
        public string GetApellido()
        {
            return this.apellido;
        }
        public ObraSocial GetObraSocial()
        {
            return this.obraSocial;
        }
        public bool IniciarConsulta(Medico medico)
        {
            if (this.estado == EnumPacienteEstado.realizandoLaConsulta) return false;
            this.medicos.Add(medico);
            this.estado = EnumPacienteEstado.realizandoLaConsulta;
            return false;
        }
        public void FinalizarConsulta()
        {
            this.estado = EnumPacienteEstado.finalizando;

        }
    }
}
