using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diego_Pinochet_Laboratorio1
{
    class Verificacion : Maquina
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

        public int aumentarMemoria(int numero)
        {
            if (numero == 2)
            {
                memory++;
            }

            return memory;
        }
        public override string getName()
        {
            string name_ = name;
            return name_;
        }

        public override void informarMemoria()
        {
            Console.WriteLine("Memoria: " + memory + ".");
        }

        public int reiniciado()
        {
            Console.WriteLine("Memoria de " + name + " se a borrado.");
            memory = 0;
            return memory;

        }
    }
}
