using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Diego_Pinochet_Laboratorio1
{
    class Recepcion:Maquina
    {
        protected override int memoria { get; set; }

        private List<Pieza> lista_pieza = new List<Pieza>();
        private bool confirmar;

        public bool confirmarRecepcion(int cantidad, Pieza pieza)
        {
            for(int i = 0; i < cantidad; i++)
            {
                lista_pieza.Add(pieza);
            }
            
            if(lista_pieza.Count() != 0)
            {
                confirmar = true;
            }
            else
            {
                confirmar = false;
            }

            return confirmar;
        }
        public void Info()
        {
            for (int i = 0; i < lista_pieza.Count(); i++)
            {
                Console.WriteLine(lista_pieza[i].Infopiezas());
                memoria ++;
            }
        }

        public override bool encendido(bool x)
        {
            return x;
        }

        public override List<Pieza> reiniciado()
        {
            lista_pieza.Clear();
            Console.WriteLine("Se ha borrado la memoria.\n");
            return lista_pieza;
        }

        public override bool apagado(bool x)
        {
            return x;
        }

        public override int informarMemoria()
        {
            return memoria;
        }
    }
}
