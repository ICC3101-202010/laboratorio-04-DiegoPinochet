using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diego_Pinochet_Laboratorio1
{
    class PcCentral
    {
        public int encendido(Maquina maquina)
        {
            Console.WriteLine("Se ha encendido la " + maquina.Nombre + ".");
            return 1;
        }
        public int reiniciado(Maquina maquina)
        {
            Console.WriteLine("Se ha reiniciado la memoria de " + maquina.Nombre + ".");
            maquina.Memoria = 0;
            return maquina.Memoria;
        }
        public int apagado(Maquina maquina)
        {
            Console.WriteLine("Se ha apagado la " + maquina.Nombre + ".");
            return 0;
        }
    }
}
