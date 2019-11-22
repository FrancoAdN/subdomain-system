using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace MaxPowerSystem
{
    public partial class agregarArtUC : UserControl
    {
        public delegate void OutsideFunc();
        public OutsideFunc openprov;

        public string Orden { get; set; }
        public agregarArtUC()
        {
            InitializeComponent();
            
        }

        
        

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan numeros", "Maxpower System dice: ");
            }
        }

        private int maxWidth()
        {
            int maxWidth = 0;
            int temp = 0;
            Label label1 = new Label();

            foreach (var obj in productoCombo.Items)
            {
                label1.Text = obj.ToString();
                temp = label1.PreferredWidth;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            label1.Dispose();
            return maxWidth;
        }
        private int maxHeight()
        {
            return productoCombo.Items.Count * productoCombo.ItemHeight;
        }

        private void ProductoCombo_Enter(object sender, EventArgs e)
        {
            productoCombo.DroppedDown = true;
        }

        private void ProductoCombo_Leave(object sender, EventArgs e)
        {
            productoCombo.DroppedDown = false;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            string tipo = tArtCombo.Text;
            string prod = productoCombo.Text;
            string cant = boxCant.Text;
            if (string.IsNullOrEmpty(tipo) || string.IsNullOrEmpty(prod) || string.IsNullOrEmpty(cant))
            {
                MessageBox.Show("Es necesario completar los campos:\n* Tipo de Art.\n* Producto.\n* Cant.", "Maxpower System dice: ");
            }
            else
            {
                if (!string.IsNullOrEmpty(boxDetalle.Text))
                    prod = prod + " " + boxDetalle.Text;
                ListViewItem item = new ListViewItem(tipo);
                item.SubItems.Add(prod);
                item.SubItems.Add(cant);
                listView1.Items.Add(item);
                productoCombo.SelectedIndex = productoCombo.Items.Count - 1;
                boxCant.Text = string.Empty;
                boxDetalle.Text = string.Empty;

            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                item.Remove();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void TArtCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = (String)tArtCombo.SelectedItem;
            JToken json;
            bool err = false;
            clientREST client = new clientREST();

            productoCombo.Items.Clear();

            if (item == "Seguridad")
            {

                client.endPoint = "http://system.maxpower-ar.com/seguridad";

                client.httpMethod = httpVerb.GET;

                string resp = string.Empty;

                resp = client.makeRequest();
                if (resp == "0")
                {
                    MessageBox.Show("SQL ERROR (Cod. 0)", "Maxpower System dice: ");
                    err = true;
                }
                json = JToken.Parse(resp);

                if (json.Type != JTokenType.Array)
                    err = true;
                else if (!err)
                {


                    List<string> prods = new List<string>();
                    foreach (var p in json)
                    {
                        prods.Add((String)p["Nombre"]);
                    }
                    prods.Add("");
                    object[] list = prods.ToArray<object>();
                    productoCombo.Items.AddRange(list);


                }

            }
            else if (item == "Electrónicos")
            {
                client.endPoint = "http://system.maxpower-ar.com/electronicos";

                client.httpMethod = httpVerb.GET;

                string resp = string.Empty;

                resp = client.makeRequest();
                if (resp == "0")
                {
                    MessageBox.Show("SQL ERROR (Cod. 0)", "Maxpower System dice: ");
                    err = true;
                }
                json = JToken.Parse(resp);

                if (json.Type != JTokenType.Array)
                    err = true;
                else if (!err)
                {

                    List<string> prods = new List<string>();
                    foreach (var p in json)
                    {
                        prods.Add((String)p["Nombre"]);
                    }
                    prods.Add("");
                    object[] list = prods.ToArray<object>();
                    productoCombo.Items.AddRange(list);


                }
            }
            else if (item == "Eléctricos")
            {
                //find in electricos
            }


            int height = maxHeight();
            if (height > 300)
                productoCombo.DropDownHeight = 300;
            else if (height > 0)
                productoCombo.DropDownHeight = height + 10;
            else
                productoCombo.DropDownHeight = productoCombo.ItemHeight;

            int width = maxWidth();
            if (width > 0)
                productoCombo.DropDownWidth = maxWidth();
            else
                productoCombo.DropDownWidth = 270;

            productoCombo.SelectedIndex = productoCombo.Items.Count - 1;
        }

        public void Button4_Click(object sender, EventArgs e)
        {
            int items = listView1.Items.Count;
            if(items == 0)
                MessageBox.Show("Es necesario ingresar al menos un producto a la lista:", "Maxpower System dice: ");
            else
            {  
                List<Articulo> Arts = new List<Articulo>();
                foreach(ListViewItem item in listView1.Items)
                {
                    Arts.Add(new Articulo(item.SubItems[0].Text, item.SubItems[1].Text, int.Parse(item.SubItems[2].Text)));
                }
                FormArticulos.ListArt.SetArticulos(Arts);
                FormArticulos.Index = 0;
                this.Hide();
                if (openprov != null)
                    openprov();

            }
            
        }
    }
}
