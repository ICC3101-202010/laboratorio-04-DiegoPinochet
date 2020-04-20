using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diego_Pinochet_Laboratorio1
{
    class PcCentral:IMemory
    {
        private int memory;
        public int Memoria
        {
            get
            {
                return this.memory;
            }
            set
            {
                this.memory = 0;
            }
        }

        public int encendido(Maquina maquina)
        {
            Console.WriteLine("Se ha encendido la " + maquina.Nombre + ".");
            return 1;
        }
        public int reiniciado(Maquina maquina)
        {
            Console.WriteLine("Se ha reiniciado la memoria de " + maquina.Nombre + ".");
            return Memoria;
        }
        public int apagado(Maquina maquina)
        {
            Console.WriteLine("Se ha apagado la " + maquina.Nombre + ".");
            return 0;
        }
    }
}
