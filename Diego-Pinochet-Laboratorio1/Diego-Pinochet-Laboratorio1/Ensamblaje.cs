using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diego_Pinochet_Laboratorio1
{
    class Ensamblaje : Maquina
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

        public bool piezasEnsamble(List<Pieza> lista_pieza, List<string> posible_ensamblaje, Random random)
        {
            int pieza_a_ensamblar1 = random.Next(lista_pieza.Count());
            int pieza_a_ensamblar2 = random.Next(lista_pieza.Count());

            posible_ensamblaje.Add(lista_pieza[pieza_a_ensamblar1].infoMaterial());
            posible_ensamblaje.Add(lista_pieza[pieza_a_ensamblar2].infoMaterial());


            if (posible_ensamblaje.Count != 0)
            {
                Console.WriteLine("Hay 2 piezas que podrian ser ensambladas");
                memoria++;
                return true;
            }
            else
            {
                memoria++;
                return false;
            }
        }
    
    }
}
