using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Diego_Pinochet_Laboratorio1
{
    abstract class Maquina
    {
        protected abstract int memoria { get; set; }

        public abstract bool encendido(bool x);// si x es true puede seguir con la sgte maquina

        public abstract List<Pieza> reiniciado(List<Pieza> lista_pieza); // si la memoria sobre pasa un numero que aun no defino llamare a este metodo

        public abstract bool apagado(bool x); // si x es true se apaga la maquina y pasa a la sgte.

        public abstract int informarMemoria();


    }
}
