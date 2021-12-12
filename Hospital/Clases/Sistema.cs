using System;
using System.Collections.Generic;

namespace Hospital.Clases
{
    class Sistema
    {
        internal Queue<Paciente> pacientes=  new Queue<Paciente>();

        internal static Sistema instance;
        internal List<Medico> medicos= new List<Medico>();

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
            this.pacientes.Enqueue(paciente);

        }
        public Queue<Paciente> GetPacientes(){

            return this.pacientes;
        }
        public bool AtendiendoHaUnPaciente(Paciente paciente, Medico medico)
        {

            return (medico.IniciarConsulta(paciente));
        }
        public Paciente FinalizandoAtencion(Paciente paciente, Medico medico)
        {
            paciente.FinalizarConsulta();
            medico.FinalizarConsulta();
            return paciente;
        }
        public List<Medico> medicosDisponibles()
        {
            List<Medico> disponibles = new List<Medico>();
            this.medicos.ForEach(item => {
                if (item.estoyDisponible())
                {
                    disponibles.Add(item);
                }

            });
            return disponibles;
        }



    }
}
