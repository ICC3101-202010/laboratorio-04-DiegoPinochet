using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Diego_Pinochet_Laboratorio1
{
    abstract class Maquina:IMemory
    {
        public abstract string Nombre { get; set; }
        public abstract int Memoria { get; set; }

        public abstract void informarMemoria();

        public int Recepcion(int numero)
        {
            if (numero == 1)
            {
                Memoria++;
            }
            
            return Memoria;   
        }

        public int Almacenamiento(int numero)
        {
            if (numero == 1)
            {
                Memoria++;
            }

            return Memoria;
        }

        public int Ensamblaje(int numero)
        {
            if (numero == 1)
            {
                Memoria++;
            }

            return Memoria;
        }

        public int Verificacion(int numero)
        {
            if (numero == 1)
            {
                Memoria++;
            }

            return Memoria;
        }

        public int Empaque(int numero)
        {
            if (numero == 1)
            {
                Memoria++;
            }

            return Memoria;
        }
    }
}
