using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diego_Pinochet_Laboratorio1
{
    class Almacenamiento : Maquina
    {
        public override int memoria { get => memoria; set => memoria = 0; }
        public override string nombre { get => nombre; set => nombre = "Maquina Almacenamiento"; }

        public int aumentarMemoria(int numero)
        {
            if (numero == 2)
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
