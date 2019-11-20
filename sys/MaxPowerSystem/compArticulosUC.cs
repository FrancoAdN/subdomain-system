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
using System.Net;

namespace MaxPowerSystem
{
    public partial class compArticulosUC : UserControl
    {
        public compArticulosUC()
        {
            InitializeComponent();
        }

        private void CompArticulosUC_Load(object sender, EventArgs e)
        {
            JToken json = "";
            bool err = false;
            clientREST client = new clientREST();

            client.endPoint = "http://system.maxpower-ar.com/s/last/";

            client.httpMethod = httpVerb.GET;
            string resp = string.Empty;

            resp = client.makeRequest();
            if (resp == "0")
            {
                MessageBox.Show("SQL ERROR (Cod. 0)", "Maxpower System dice: ");
                err = true;
            }
            json = JToken.Parse(resp);



            if (!err)
            {
                Console.WriteLine(json);
            }

        }
    }
}
