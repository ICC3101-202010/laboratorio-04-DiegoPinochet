using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diego_Pinochet_Laboratorio1
{
    class Empaque : Maquina
    {
        public override int memoria { get => memoria; set => memoria = 0; }
        public override string nombre { get => nombre; set => nombre = "Maquina Empaque"; }

        public int aumentarMemoria(int numero)
        {
            if (numero == 5)
            {
                memoria++;
            }

            return memoria;
        }
        public override string getName()
        {
            return nombre;
        }
        public override void informarMemoria()
        {
            Console.WriteLine("Memoria: " + memoria + ".");
        }


    }
}
