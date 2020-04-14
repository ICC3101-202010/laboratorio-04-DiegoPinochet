﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Diego_Pinochet_Laboratorio1
{
    abstract class Maquina
    {
        public abstract int Memoria { get; set; }
        public abstract string Nombre { get; set; }

        public abstract void informarMemoria();
        public abstract string getName();
        public abstract int aumentarMemoria(int numero);
        public abstract int reiniciado();

    }
}
