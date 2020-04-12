using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Diego_Pinochet_Laboratorio1
{
    class Recepcion:Maquina
    {
        public override int memoria { get => memoria; set => memoria = 0;}
        public override string nombre { get => nombre; set => nombre = "Maquina recepción"; }

        public int aumentarMemoria(int numero)
        {
            if(numero == 1)
            {
                memoria++;
            }
            
            return memoria;
        }
        public override string getName()
        {
            string name = nombre;
            return name;
        }

        public override void informarMemoria()
        {
            Console.WriteLine("Memoria: " + memoria + ".");
        }
    }
}
