using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Diego_Pinochet_Laboratorio1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Pieza pieza = new Pieza("tornillo","cobre", 2);
            Recepcion recepcion = new Recepcion();
            Almacenamiento almacenamiento = new Almacenamiento();
            Ensamblaje ensamblaje = new Ensamblaje();
            Verificacion verificacion = new Verificacion();
            Empaque empaque = new Empaque();
            int memory;

            bool x = true;
            while (x == true)
            {
                bool i = recepcion.encendido(recepcion.confirmarRecepcion(2, pieza)); // cantidad debe ser variable
                memory = recepcion.informarMemoria();
                if(memory == 5)
                {
                    recepcion.reiniciado(); //vacia la lista de piezas --> se queda sin info.
                }
                else
                {
                    
                }

                Console.WriteLine("Se ha acabado el día.\n");  
            }

        }
    }
}
