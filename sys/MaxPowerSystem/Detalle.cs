using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxPowerSystem
{
    class Detalle
    {
        public string cant;
        public string desc;
        public string unit;
        public string total;

        public Detalle(string c, string d, string u, string t)
        {
            this.cant = c.ToString();
            this.desc = d;
            this.unit = u.ToString();
            this.total = t;
        }

        public string Cant => cant;
        public string Desc => desc;
        public string Unit => unit;
        public string Total => total;
    }
}
