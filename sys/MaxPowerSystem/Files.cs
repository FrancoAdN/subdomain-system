using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxPowerSystem
{
    class Files
    {
        public string data;
        public string reference;
        public Files(string d, string refe)
        {
            this.data = d;
            this.reference = refe;
        }

        public string Data => data;

        public string Ref
        {
            get { return reference; }
        }
    }
}
