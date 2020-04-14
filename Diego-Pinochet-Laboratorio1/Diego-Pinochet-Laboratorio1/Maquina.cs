using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Diego_Pinochet_Laboratorio1
{
    abstract class Maquina:IProcesos
    {
        public abstract int Memoria { get; set; }
        public abstract string Nombre { get; set; }

        public abstract void informarMemoria();

        public int encendido()
        {
            Console.WriteLine("Se ha encendido la " + Nombre + ".");
            return 1;
        }
        public int reiniciado()
        {
            Console.WriteLine("Se ha reiniciado la memoria de " + Nombre + ".");
            Memoria = 0;
            return Memoria;
        }
        public int apagado()
        {
            Console.WriteLine("Se ha apagado la " + Nombre + ".");
            return 0;
        }

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
