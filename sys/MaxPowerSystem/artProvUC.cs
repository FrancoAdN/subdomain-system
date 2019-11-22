using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace MaxPowerSystem
{
    public partial class artProvUC : UserControl
    {

        public delegate void ProvFunc(string p);
        public ProvFunc addprov;
        public delegate void NextProdFunc();
        public NextProdFunc nextfunc;

        List<Articulo> _arts;
        public artProvUC()
        {
            InitializeComponent();
        }

        public void setValues()
        {
            this.Visible = true;
            this.Show();
            this.BringToFront();
            _arts = (List<Articulo>)FormArticulos.ListArt.GetArticulos();
            labProd.Text = _arts[FormArticulos.Index].producto;
            string tipo = _arts[FormArticulos.Index].tipo;

            JToken json;
            bool err = false;
            clientREST client = new clientREST();

            comboProv.Items.Clear();

            client.endPoint = "http://system.maxpower-ar.com/prov/rub/"+tipo;

            client.httpMethod = httpVerb.GET;

            string resp = string.Empty;

            resp = client.makeRequest();
            if (resp == "0")
            {
                MessageBox.Show("SQL ERROR (Cod. 0)", "Maxpower System dice: ");
                err = true;
            }
            else if (resp == "15")
            {
                err = true;
                MessageBox.Show("No existen proveedores de dicho rubro, por favor ingrese un proveedor (Cod. 15)", "Maxpower System dice: ");
            }
            json = JToken.Parse(resp);

            if (json.Type != JTokenType.Array)
                err = true;
            else if (!err)
            {


                List<string> prods = new List<string>();
                foreach (var p in json)
                {
                    prods.Add((String)p["emp"]);
                }
                prods.Add("");
                object[] list = prods.ToArray<object>();
                comboProv.Items.AddRange(list);


            }


        }
        private void checkNum(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan numeros", "Maxpower System dice: ");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //string item = (String)tArtCombo.SelectedItem;
            string prov = (String)comboProv.SelectedItem;
            string precio = boxPrecio.Text;
            string plazo = boxCant.Text;
  
            if (string.IsNullOrEmpty(prov) || string.IsNullOrEmpty(precio) || string.IsNullOrEmpty(plazo))
            {
                MessageBox.Show("Es necesario completar los campos:\n* Proveedores.\n* Precio.\n* Plazo.", "Maxpower System dice: ");
            }
            else
            {
                ListViewItem item = new ListViewItem(prov);
                item.SubItems.Add(precio);
                item.SubItems.Add(plazo);
                listView1.Items.Add(item);
                comboProv.Items.Remove(comboProv.SelectedItem);
                comboProv.SelectedIndex = comboProv.Items.Count - 1;
                boxCant.Text = string.Empty;
                boxPrecio.Text = string.Empty;

            }
            sigBut.Enabled = true;
             
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem item in listView1.SelectedItems)
            {
                object aux = comboProv.Items[comboProv.Items.Count - 1];
                comboProv.Items.Add(item.SubItems[0].Text);
                comboProv.Items[comboProv.Items.Count - 2] = comboProv.Items[comboProv.Items.Count - 1];
                comboProv.Items[comboProv.Items.Count - 1] = aux;
                item.Remove();
            }
            if (listView1.Items.Count == 0)
                sigBut.Enabled = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                object aux = comboProv.Items[comboProv.Items.Count - 1];
                comboProv.Items.Add(item.SubItems[0].Text);
                comboProv.Items[comboProv.Items.Count - 2] = comboProv.Items[comboProv.Items.Count - 1];
                comboProv.Items[comboProv.Items.Count - 1] = aux;
            }
           
            listView1.Items.Clear();
            sigBut.Enabled = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (addprov != null)
                addprov(_arts[FormArticulos.Index].tipo);
        }

        private void SigBut_Click(object sender, EventArgs e)
        {

            if (_arts.Count >= FormArticulos.Index + 1)
            {
                FormArticulos.Index += 1;
            }
            if (nextfunc != null)
                nextfunc();

        }
    }
}
