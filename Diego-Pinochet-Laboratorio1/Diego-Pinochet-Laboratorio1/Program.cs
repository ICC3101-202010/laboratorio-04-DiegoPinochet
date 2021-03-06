﻿using System;
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
            int cont = 0;

            PcCentral pc = new PcCentral();
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
            bool u = true;


            int on = pc.encendido(recepcion);
            if(on == 1)
            {
                on = pc.encendido(almacenamiento);
                if (on == 1)
                {
                    on = pc.encendido(ensamblaje);
                    if (on == 1)
                    {
                        on = pc.encendido(verificacion);
                        if (on == 1)
                        {
                            pc.encendido(empaque);
                        }
                    }
                }
            }
            Console.WriteLine("-------------------------------------------------------------------------");
            while (x == true)
            {
                Console.WriteLine("La hora es: " + hora + ":00\n");

                int memory1 = recepcion.Recepcion(random.Next(4));
                recepcion.informarMemoria();
                if (memory1 == 3)
                {
                    Console.WriteLine("Se ha alcanzado la memoría máxima de " + recepcion.Nombre + "(1)");
                    cont++;
                    u = true;
                }
                int memory2 = almacenamiento.Almacenamiento(random.Next(4));
                almacenamiento.informarMemoria();
                if (memory2 == 3)
                {
                    Console.WriteLine("Se ha alcanzado la memoría máxima de " + almacenamiento.Nombre + "(2)");
                    cont++;
                    u = true;
                }
                int memory3 = ensamblaje.Ensamblaje(random.Next(4));
                ensamblaje.informarMemoria();
                if (memory3 == 3)
                {
                    Console.WriteLine("Se ha alcanzado la memoría máxima de " + ensamblaje.Nombre + "(3)");
                    cont++;
                    u = true;
                }
                int memory4 = verificacion.Verificacion(random.Next(4));
                verificacion.informarMemoria();
                if (memory4 == 3)
                {
                    Console.WriteLine("Se ha alcanzado la memoría máxima de " + verificacion.Nombre + "(4)");
                    cont++;
                    u = true;
                }
                int memory5 = empaque.Empaque(random.Next(4));
                empaque.informarMemoria();
                if (memory5 == 3)
                {
                    Console.WriteLine("Se ha alcanzado la memoría máxima de " + empaque.Nombre + "(5)");
                    cont++;
                    u = true;
                }
                if(cont != 0)
                {
                    while (u == true)
                    { 
                        Console.WriteLine("Desea reiniciar una máquina? (Si/No)");
                        string decision = Console.ReadLine();
                        Console.WriteLine("\n");

                        if (decision == "Si")
                        {
                            Console.WriteLine("Qué máquina desea reiniciar? (1,2,3,4,5)");
                            string num = Console.ReadLine();
                            Console.WriteLine("\n");

                            if (num == "1")
                            {
                                pc.reiniciado(recepcion);
                                recepcion.Memoria = pc.Memoria;
                                cont--;
                            }
                            else if (num == "2")
                            {
                                pc.reiniciado(almacenamiento);
                                almacenamiento.Memoria = pc.Memoria;
                                cont--;
                            }
                            else if (num == "3")
                            {
                                pc.reiniciado(ensamblaje);
                                ensamblaje.Memoria = pc.Memoria;
                                cont--;
                            }
                            else if (num == "4")
                            {
                                pc.reiniciado(verificacion);
                                verificacion.Memoria = pc.Memoria;
                                cont--;
                            }
                            else if (num == "5")
                            {
                                pc.reiniciado(empaque);
                                empaque.Memoria = pc.Memoria;
                                cont--;
                            }

                        }
                        else
                        {
                            u = false;
                        }
                    }
                }
                if (hora == 19)
                {
                    break;
                }
                Console.WriteLine("\n");
                hora++;
            }
            Console.WriteLine("-------------------------------------------------------------------------");
            int off = pc.apagado(recepcion);
            if (off == 0)
            {
                off = pc.apagado(almacenamiento);
                if (off == 0)
                {
                    off = pc.apagado(ensamblaje);
                    if (off == 0)
                    {
                        off = pc.apagado(verificacion);
                        if (off == 0)
                        {
                            pc.apagado(empaque);
                        }
                    }
                }
            }
        }
    }
}
