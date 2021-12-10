using System;
using System.Collections.Generic;

namespace Hospital.Clases
{
    public class Sistema
    {
        internal List<Paciente> pacientes;

        internal static Sistema instance;

        internal Sistema() { }

        public static Sistema Instance
        {
            get
            {
                if (instance == null)
                    instance = new Sistema();
                return instance;
            }
        }

        public void AddPaciente(Paciente paciente)
        {
            this.pacientes.Add(paciente);

        }
        public List<Paciente> GetPacientes(){

            return this.pacientes;
        }
        

    }
}
