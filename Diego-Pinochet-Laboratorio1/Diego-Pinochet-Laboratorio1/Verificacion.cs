using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diego_Pinochet_Laboratorio1
{
    class Verificacion : Maquina
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
            return memoria;
        }

        public override List<Pieza> reiniciado(List<Pieza> lista_pieza)
        {
            lista_pieza.Clear();
            Console.WriteLine("Se ha borrado la memoria.\n");
            return lista_pieza;
        }
        public bool confirm(List<string> posible_ensamblaje)
        {
            if (posible_ensamblaje[1] == posible_ensamblaje[0])
            {
                Console.WriteLine("Ambas piezas se pueden ensamblar.");
                memoria++;
                return true;
            }
            else
            {
                Console.WriteLine("Las piezas son de distinto material, no se puede ensamblar.");
                memoria++;
                return false;
            }
        }
    
    }
}
