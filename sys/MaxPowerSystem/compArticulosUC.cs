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
        JToken json = "";
        public compArticulosUC()
        {
            InitializeComponent();
        }

        private void CompArticulosUC_Load(object sender, EventArgs e)
        {
            json = "";
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
                cmbOrd.Items.Clear();

                List<string> orders = new List<string>();
                
                foreach (var ord in json)
                {
                    orders.Add((String)ord["orden"]);
                }
                orders.Add("");
                object[] list = orders.ToArray<object>();
                cmbOrd.Items.AddRange(list);
                cmbOrd.SelectedIndex = cmbOrd.Items.Count - 1;
            }

        }

        private void CmbOrd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ord = (String)cmbOrd.SelectedItem;
            if(ord != "")
            {
                labEnt.Visible = true;
                resEnt.Visible = true;
                labDesc.Visible = true;
                resDesc.Visible = true;
                butAccept.Visible = true;
                foreach(var orden in json)
                {
                    if((String)orden["orden"] == ord)
                    {
                        resEnt.Text = (String)orden["cliente"];
                        resDesc.Text = (String)orden["descr"];
                        break;
                    }
                }
            }
            else
            {
                labEnt.Visible = false;
                resEnt.Visible = false;
                labDesc.Visible = false;
                resDesc.Visible = false;
                butAccept.Visible = false;
            }
        }

        private void CmbOrd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' || e.KeyChar == '\n')
            {
                Console.WriteLine(cmbOrd.Text);
            }
        }
    }
}
