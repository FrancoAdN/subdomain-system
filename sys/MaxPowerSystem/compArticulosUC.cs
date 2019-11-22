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
        public delegate void OpenAddArt();
        public OpenAddArt openart;
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
                string ord = cmbOrd.Text;
                JToken response;
                bool err = false;
                clientREST client = new clientREST();
                client.endPoint = "http://system.maxpower-ar.com/sol/" + ord;

                client.httpMethod = httpVerb.GET;

                string resp = string.Empty;

                resp = client.makeRequest();
                if (resp == "0")
                {
                    MessageBox.Show("SQL ERROR (Cod. 0)", "Maxpower System dice: ");
                    err = true;
                }
                else if (resp == "6")
                {
                    err = true;
                    MessageBox.Show("No existen los registros buscados (Cod. 6)", "Maxpower System dice: ");
                }
                else if (resp == "7")
                {
                    MessageBox.Show("No existen registros (Cod. 7)", "Maxpower System dice: ");
                    err = true;
                }
                if (!err)
                {
                    response = JToken.Parse(resp);
                    if ((String)response[0]["tipo"] != "Cot. Venta de productos")
                    {
                        MessageBox.Show("La orden buscada no corresponde (Cod. 15)", "Maxpower System dice:");
                        labEnt.Visible = false;
                        resEnt.Visible = false;
                        labDesc.Visible = false;
                        resDesc.Visible = false;
                        butAccept.Visible = false;
                    }
                    else
                    {
                        labEnt.Visible = true;
                        resEnt.Visible = true;
                        labDesc.Visible = true;
                        resDesc.Visible = true;
                        butAccept.Visible = true;
                        resEnt.Text = (String)response[0]["cliente"];
                        resDesc.Text = (String)response[0]["descr"];
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
        }

        private void ButAccept_MouseClick(object sender, MouseEventArgs e)
        {
<<<<<<< HEAD
            this.Hide();
            FormArticulos fa = new FormArticulos();
            fa.setOrd(cmbOrd.Text);
=======

            this.Hide();
            FormArticulos.Orden = cmbOrd.Text;
            if (openart != null)
                openart();

>>>>>>> f20159896b464afdfbf0f7961a90edb0a2ba5124
        }

    }
}
