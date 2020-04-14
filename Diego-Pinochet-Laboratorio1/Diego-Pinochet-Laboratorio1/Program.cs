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

            recepcion.Nombre = "Máquina Recepción";
            almacenamiento.Nombre = "Máquina Almacenamiento";
            ensamblaje.Nombre = "Máquina Ensamblaje";
            verificacion.Nombre = "Máquina Verificación";
            empaque.Nombre = "Máquina Empaque";

            recepcion.Memoria = 0;
            almacenamiento.Memoria = 0;
            ensamblaje. Memoria = 0;
            verificacion.Memoria = 0;
            empaque.Memoria = 0;

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
                Console.WriteLine("La hora es: " + hora + ":00");

                int memory1 = recepcion.aumentarMemoria(random.Next(4));
                recepcion.informarMemoria();
                if (memory1 == 3)
                {
                    recepcion.reiniciado();
                }
                int memory2 = almacenamiento.aumentarMemoria(random.Next(4));
                almacenamiento.informarMemoria();
                if (memory2 == 3)
                {
                    almacenamiento.reiniciado();
                }
                int memory3 = ensamblaje.aumentarMemoria(random.Next(4));
                ensamblaje.informarMemoria();
                if (memory2 == 3)
                {
                    ensamblaje.reiniciado();
                }
                int memory4 = verificacion.aumentarMemoria(random.Next(4));
                verificacion.informarMemoria();
                if (memory4 == 3)
                {
                    verificacion.reiniciado();
                }
                int memory5 = empaque.aumentarMemoria(random.Next(4));
                empaque.informarMemoria();
                if (memory2 == 3)
                {
                    empaque.reiniciado();
                }
                if (hora == 19)
                {
                    break;
                }
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
