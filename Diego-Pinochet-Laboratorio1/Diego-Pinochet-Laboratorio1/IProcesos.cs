using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diego_Pinochet_Laboratorio1
{
    interface IProcesos
    {
        int Recepcion(int numero);
        int Almacenamiento(int numero);
        int Ensamblaje(int numero);
        int Verificacion(int numero);
        int Empaque(int numero);
    }
}
