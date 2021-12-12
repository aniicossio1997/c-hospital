using System;
using System.Collections.Generic;
using Gtk;
using Hospital.Clases;

namespace Hospital
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*    Application.Init();
                MainWindow win = new MainWindow();
                win.Show();
                Application.Run();
                */
            Console.WriteLine("-----");

            List<Medico> medicos = new List<Medico>();
            Console.WriteLine(medicos.Count);

        }
    }
}
