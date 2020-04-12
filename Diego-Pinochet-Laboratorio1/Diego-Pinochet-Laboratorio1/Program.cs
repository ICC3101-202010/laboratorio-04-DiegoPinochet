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
            Random random = new Random();
            int hora = 8;

            PCcentral pc = new PCcentral();
            Recepcion recepcion = new Recepcion();
            Almacenamiento almacenamiento = new Almacenamiento();
            Ensamblaje ensamblaje = new Ensamblaje();
            Verificacion verificacion = new Verificacion();
            Empaque empaque = new Empaque();

            bool x = true;

            int on = pc.encendido(recepcion.getName());
            if(on == 1)
            {
                on = pc.encendido(almacenamiento.getName());
                if (on == 1)
                {
                    on = pc.encendido(ensamblaje.getName());
                    if (on == 1)
                    {
                        on = pc.encendido(verificacion.getName());
                        if (on == 1)
                        {
                            pc.encendido(empaque.getName());
                        }
                    }
                }
            }
            while (x == true)
            {
                int memory1 = recepcion.aumentarMemoria(random.Next(6));
                recepcion.informarMemoria();
                if (memory1 == 10)
                {
                    pc.reiniciado(memory1);
                }
                int memory2 = almacenamiento.aumentarMemoria(random.Next(6));
                almacenamiento.informarMemoria();
                if (memory2 == 10)
                {
                    pc.reiniciado(memory2);
                }
                int memory3 = ensamblaje.aumentarMemoria(random.Next(6));
                ensamblaje.informarMemoria();
                if (memory2 == 10)
                {
                    pc.reiniciado(memory3);
                }
                int memory4 = verificacion.aumentarMemoria(random.Next(6));
                verificacion.informarMemoria();
                if (memory4 == 10)
                {
                    pc.reiniciado(memory4);
                }
                int memory5 = empaque.aumentarMemoria(random.Next(6));
                empaque.informarMemoria();
                if (memory2 == 10)
                {
                    pc.reiniciado(memory5);
                }
                if (hora == 19)
                {
                    break;
                }
                Console.WriteLine("La hora es: " + hora + ":00");
                hora++;
            }
            int off = pc.apagado(recepcion.getName());
            if (off == 0)
            {
                off = pc.apagado(almacenamiento.getName());
                if (off == 0)
                {
                    off = pc.apagado(ensamblaje.getName());
                    if (off == 0)
                    {
                        off = pc.apagado(verificacion.getName());
                        if (off == 0)
                        {
                            pc.apagado(empaque.getName());
                        }
                    }
                }
            }
        }
    }
}
