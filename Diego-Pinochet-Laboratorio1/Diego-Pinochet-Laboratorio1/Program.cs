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
            List<Pieza> lista_pieza = new List<Pieza>();
            List<String> bodega = new List<string>();

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
                bool i = recepcion.encendido(recepcion.confirmarRecepcion(2, pieza, lista_pieza)); // cantidad debe ser variable
                memory = recepcion.informarMemoria();
                if(memory == 5)
                {
                    recepcion.reiniciado(lista_pieza); //vacia la lista de piezas --> se queda sin info.
                }
                else
                {
                    if(i == true)
                    {
                        i = almacenamiento.encendido(almacenamiento.Storage(lista_pieza,bodega));
                        memory = almacenamiento.informarMemoria();
                        if(memory == 5)
                        {
                            almacenamiento.reiniciado(lista_pieza);
                        }
                        else
                        {
                            if(i == true)
                            {
                                i = ensamblaje.encendido();
                                memory = ensamblaje.informarMemoria();
                            }
                        }
                    }
                }

                Console.WriteLine("Se ha acabado el día.\n");  
            }

        }
    }
}
