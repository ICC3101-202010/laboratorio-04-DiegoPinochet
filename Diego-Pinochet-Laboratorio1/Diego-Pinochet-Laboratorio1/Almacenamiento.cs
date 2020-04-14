using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diego_Pinochet_Laboratorio1
{
    class Almacenamiento : Maquina
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
        public override int aumentarMemoria(int numero)
        {
            if (numero == 1)
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
            Console.WriteLine("Memoria " + getName() + ": " + memory + ".");
        }
        public override int reiniciado()
        {
            Console.WriteLine("Memoria de " + getName() + " se a borrado.");
            memory = 0;
            return memory;

        }
    }
    
}
