using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diego_Pinochet_Laboratorio1
{
    class Almacenamiento : Maquina
    {
        protected override int memoria { get; set; }
        

        public override bool apagado(bool x)
        {
            throw new NotImplementedException();
        }

        public override bool encendido(bool x)
        {
            return x;
        }

        public override int informarMemoria()
        {
            throw new NotImplementedException();
        }

        public override List<Pieza> reiniciado(List<Pieza> lista_pieza)
        {
            lista_pieza.Clear();
            Console.WriteLine("Se ha borrado la memoria.\n");
            return lista_pieza;
        }

        public bool Storage(List<Pieza> lista_pieza, List<String> bodega)
        {

            for(int i = 0; i < lista_pieza.Count(); i++)
            {
                bodega.Add(lista_pieza[i].Infopiezas());
                memoria++;
            }

            if(bodega.Count() != 0)
            {
                Console.WriteLine("Se añadieron correctamente las piezas al almacen.");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
}
