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
    public partial class solicitudesUC : UserControl
    {
        public solicitudesUC()
        {
            InitializeComponent();
        }

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            string prec = boxPrec.Text;
            string cli = boxCli.Text;
            string desc = boxDesc.Text;

            if (string.IsNullOrEmpty(prec) || string.IsNullOrEmpty(cli) || string.IsNullOrEmpty(desc))
                MessageBox.Show("Debe completar todos los campos para poder guardar la solicitud.");
            else
            {
                

                JToken json = "";
                bool err = false;
                clientREST client = new clientREST();

                client.endPoint = "http://system.maxpower-ar.com/emp/" + boxCli.Text;

                client.httpMethod = httpVerb.GET;
                string resp = string.Empty;
                try
                {
                    resp = client.makeRequest();
                    if (resp == "0")
                    {
                        MessageBox.Show("SQL ERROR (Cod. 0)");
                        err = true;
                    }
                    else if (resp == "6")
                    {
                        MessageBox.Show("No existen los registros buscados (Cod. 6)");
                        err = true;
                    }
                    json = JToken.Parse(resp);
                    if (json.Type != JTokenType.Array)
                    {
                        err = true;
                        MessageBox.Show("No se pudo conectar con el servidor (Cod. 3)");
                    }

                    if (!(json.Count() == 1))
                        err = true;

                }
                catch (WebException)
                {
                    err = true;
                    MessageBox.Show("No se pudo conectar con el servidor (Cod. 3)");
                }
                //MessageBox.Show("Debe completar todos los campos para poder guardar la solicitud.");
                if (!err)
                {
                    JObject postJ = new JObject();
                    postJ["prec"] = boxPrec.Text;
                    postJ["cliente"] = boxCli.Text;
                    postJ["descr"] = boxDesc.Text;

                    //client.endPoint = 
                }


                boxDesc.Text = string.Empty;
                boxCli.Text = string.Empty;
                boxPrec.Text = string.Empty;
            }
                
                
            
        }
    }
}
