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

                client.endPoint = "http://system.maxpower-ar.com/emp/" + cli;

                client.httpMethod = httpVerb.GET;
                string resp = string.Empty;

                resp = client.makeRequest();
                if (resp == "0")
                {
                    MessageBox.Show("SQL ERROR (Cod. 0)");
                    err = true;
                }
                else if (resp == "9")
                {
                    MessageBox.Show("No existen los registros buscados (Cod. 9)");
                    err = true;
                }
                json = JToken.Parse(resp);
             
                if (!(json.Count() == 1))
                    err = true;

                
                if (!err)
                {
                    client.endPoint = "http://system.maxpower-ar.com/last";

                    client.httpMethod = httpVerb.GET;
                    resp = string.Empty;

                    resp = client.makeRequest();
                    if (resp == "0")
                    {
                        MessageBox.Show("SQL ERROR (Cod. 0)");
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


                if (!err)
                {
                    JObject postJ = new JObject();
                    int nof = (int)json[0]["num"] + 1;
                    postJ["orden"] = "MAX-" + nof +"-AR19-1";
                    postJ["proc"] = prec;
                    postJ["cliente"] = cli;
                    postJ["descr"] = desc;
                    postJ["fecha"] = DateTime.Now.ToString("dd/MM/yyyy");

                    client.endPoint = "http://system.maxpower-ar.com/sol";
                    client.httpMethod = httpVerb.POST;
                    client.postJSON = postJ.ToString();
                    resp = string.Empty;
                    resp = client.makeRequest();

                    if (resp == "0")
                        MessageBox.Show("SQL ERROR (Cod. 0)");
                    else if (resp == "14")
                        MessageBox.Show("No se pudo ingresar la solicitud (Cod. 14)");
                    else if (resp == "1")
                    {
                        MessageBox.Show("La solicitud ha sido ingresada con éxito.");
                        boxDesc.Text = string.Empty;
                        boxCli.Text = string.Empty;
                        boxPrec.Text = string.Empty;

                    }
                }



            }
        }
    }
}
