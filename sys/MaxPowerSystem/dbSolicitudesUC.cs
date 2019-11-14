using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace MaxPowerSystem
{
    public partial class dbSolicitudesUC : UserControl
    {
        public int Index;
        public JToken json;
        public dbSolicitudesUC()
        {
            InitializeComponent();
        }

        public void changeVal()
        {
            labProc.Text = (String)json[Index]["procedencia"];
            labCli.Text = (String)json[Index]["cliente"];
            labDesc.Text = (String)json[Index]["descr"];
            labDate.Text = (String)json[Index]["fecha"];
            labOrd.Text = (String)json[Index]["orden"];
            labTSol.Text = (String)json[Index]["tipo"];

        }
    }
    
}
