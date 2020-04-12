using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diego_Pinochet_Laboratorio1
{
    class PCcentral
    {
        public int encendido(string name) 
        {
            Console.WriteLine("Se ha encendido la maquina" + name);
            return 1;
        }
        public int reiniciado(int memoria)
        {
            memoria = 0;
            return memoria;
        }
        public int apagado(string name)
        {
            Console.WriteLine("Se ha apagado la maquina" + name);
            return 0;
        }
    }
}
