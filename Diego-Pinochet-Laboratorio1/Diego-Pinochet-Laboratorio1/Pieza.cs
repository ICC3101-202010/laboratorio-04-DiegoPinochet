using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diego_Pinochet_Laboratorio1
{
    class Pieza
    {
        private string tipo;
        private string material;
        private int cantidad;

        public Pieza(string Tipo, string Material, int cant)
        {
            this.tipo = Tipo;
            this.material = Material;
            this.cantidad = cant;
        }
        public string Infopiezas()
        {
            string info = tipo + " " + material + " " + cantidad;
            return info;
        }
        public string infoMaterial()
        {
            string mat = material;
            return mat;
        }
    }
}
