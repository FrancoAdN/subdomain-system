using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxPowerSystem
{
    class Articulo
    {
        public string tipo;
        public string producto;
        public int cantidad;

        public Articulo(string t, string p, int c)
        {
            this.tipo = t;
            this.producto = p;
            this.cantidad = c;
        }
    }
}
