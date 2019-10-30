using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;
using System.Net;

namespace MaxPowerSystem
{
    public partial class OrdConfUC : UserControl
    {
        clientREST client = new clientREST();
        public OrdConfUC()
        {
            InitializeComponent();

            dbOrdConf1.Hide();
            cmbDb2.SelectedIndex = cmbDb2.Items.Count - 1;


        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool err = false;    
            string ord = ordBox.Text;
            string view = cmbDb2.Text;

            if (view == "Ordenes confirmadas")
            {
                dbOrdConf1.Hide();
                JToken json = "";
                if (!string.IsNullOrEmpty(ord))
                {
                    client.endPoint = "http://system.maxpower-ar.com/confirm/" + ord;

                    client.httpMethod = httpVerb.GET;

                    string resp = string.Empty;

                    resp = client.makeRequest();
                    if (resp == "0")
                    {
                        MessageBox.Show("SQL ERROR (Cod. 0)");
                        err = true;
                    }
                    else if (resp == "7")
                    {
                        err = true;
                        MessageBox.Show("No existen los registros buscados (Cod. 7)");
                    }

                    json = JToken.Parse(resp);
                    if (json.Type != JTokenType.Array)
                    {
                        err = true;

                    }
                }
                else
                {
                    client.endPoint = "http://system.maxpower-ar.com/confirm";

                    client.httpMethod = httpVerb.GET;

                    string resp = string.Empty;

                    resp = client.makeRequest();
                    if (resp == "0")
                    {
                        MessageBox.Show("SQL ERROR (Cod. 0)");
                        err = true;
                    }
                    else if (resp == "12")
                    {
                        err = true;
                        MessageBox.Show("No existen ordenes confirmadas (Cod. 12)");
                    }

                    json = JToken.Parse(resp);
                    if (json.Type != JTokenType.Array)
                    {
                        err = true;

                    }
                }

                if (!err)
                {
                    ordBox.Text = string.Empty;
                    dbOrdConf1.db = false;
                    dbOrdConf1.json = (JArray)json;
                    dbOrdConf1.changeVal();
                    dbOrdConf1.Show();
                    dbOrdConf1.BringToFront();
                }
            }
            else if (view == "Ordenes sin confirmar")
            {
                dbOrdConf1.Hide();
                JToken json = "";
                if (!string.IsNullOrEmpty(ord))
                {
                    client.endPoint = "http://system.maxpower-ar.com/nconfirm/" + ord;

                    client.httpMethod = httpVerb.GET;

                    string resp = string.Empty;

                    resp = client.makeRequest();
                    if (resp == "0")
                    {
                        MessageBox.Show("SQL ERROR (Cod. 0)");
                        err = true;
                    }
                    else if (resp == "7")
                    {
                        err = true;
                        MessageBox.Show("No existen los registros buscados (Cod. 7)");
                    }

                    json = JToken.Parse(resp);
                    if (json.Type != JTokenType.Array)
                    {
                        err = true;

                    }
                }
                else
                {
                    
                    client.endPoint = "http://system.maxpower-ar.com/nconfirm";
                    client.httpMethod = httpVerb.GET;

                    string resp = string.Empty;

                    resp = client.makeRequest();
                    if (resp == "0")
                    {
                        MessageBox.Show("SQL ERROR (Cod. 0)");
                        err = true;
                    }
                    else if (resp == "12")
                    {
                        err = true;
                        MessageBox.Show("Todas las ordenes están confirmadas (Cod. 11)");
                    }

                    json = JToken.Parse(resp);
                    if (json.Type != JTokenType.Array)
                    {
                        err = true;

                    }
                }

                if (!err)
                {
                    dbOrdConf1.db = true;
                    ordBox.Text = string.Empty;
                    cmbDb2.SelectedIndex = cmbDb2.Items.Count - 1;
                    dbOrdConf1.json = (JArray)json;
                    dbOrdConf1.changeVal();
                    dbOrdConf1.Show();
                    dbOrdConf1.BringToFront();
                }

            }
            else
                dbOrdConf1.Hide();



        }
    }
}
