using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diego_Pinochet_Laboratorio1
{
    class Ensamblaje:Maquina
    {
        private string name;
        private int memory;
        public override string Nombre
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public override int Memoria
        {
            get
            {
                return this.memory;
            }
            set
            {
                this.memory = value;
            }
        }

        public override void informarMemoria()
        {
            Console.WriteLine("Memoria " + name + ": " + memory + ".");
        }
    }
}
