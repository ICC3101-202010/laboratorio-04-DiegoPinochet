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
            throw new NotImplementedException();
        }

        public override int informarMemoria()
        {
            throw new NotImplementedException();
        }

        public override List<Pieza> reiniciado()
        {
            throw new NotImplementedException();
        }
    }
}
