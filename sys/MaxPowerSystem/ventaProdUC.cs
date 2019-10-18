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
    public partial class ventaProdUC : UserControl
    {
        private List<Detalle> productos = new List<Detalle>();

        internal List<Detalle> Productos { get => productos; set => productos = value; }

        public ventaProdUC()
        {
            InitializeComponent();
        }

        private void ButtonWordFile_Click(object sender, EventArgs e)
        {
            object temp = @"C:\Users\User\Desktop\sys\MaxPowerSystem\static\temp_vent_prod.docx";
            object SaveAs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MaxPowerSystem\MaxPowerSystem\Venta de productos\test_vent.docx";
            if (Productos.Count > 0 &&
              !string.IsNullOrEmpty(EntBox.Text) &&
              !string.IsNullOrEmpty(EntregaBox.Text) &&
              !string.IsNullOrEmpty(PayBox.Text) &&
              !string.IsNullOrEmpty(maxPlBox.Text))
            {
                int precio = 0;
                List<Files> data = new List<Files>();
                foreach (Detalle d in Productos)
                {
                    int n;
                    bool isNumber = int.TryParse(d.Total, out n);
                    if (isNumber)
                        precio += n;
                }

                JToken json = "";
                bool err = false;
                clientREST client = new clientREST();

                client.endPoint = "http://system.maxpower-ar.com/emp/" + EntBox.Text;
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

                if (!err)
                {
                    data.Add(new Files((string)json[0]["cont"], "<para>"));
                    data.Add(new Files((string)json[0]["mail"], "<email>"));
                    data.Add(new Files((string)json[0]["tel"], "<tel>"));
                    Form1 F1 = new Form1();
                    Productos.Add(new Detalle("Cant.", "Descripción", "Precio unitario USD", "Precio Total USD"));
                    try
                    {
                        F1.CreateTableWord(temp, SaveAs, Productos, 3);
                    }
                    catch (Exception ex)
                    {
                        err = true;
                        MessageBox.Show("Error al generar el archivo (Cod. 4)");
                    }




                    client.endPoint = "http://system.maxpower-ar.com/last";

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

                    }
                    catch (WebException)
                    {
                        err = true;
                        MessageBox.Show("No se pudo conectar con el servidor (Cod. 3)");
                    }

                    if (!err)
                    {
                        int nof = (int)json[0]["num"] + 1;

                        data.Add(new Files("MAX-" + nof + "-AR19-1", "<noferta>"));
                        data.Add(new Files(DateTime.Now.ToString("dd/MM/yyyy"), "<fecha>"));
                        data.Add(new Files(EntBox.Text, "<empresa>"));
                        data.Add(new Files(precio.ToString(), "<precio>"));
                        data.Add(new Files(EntregaBox.Text, "<entrega>"));
                        data.Add(new Files(PayBox.Text, "<formadepago>"));
                        data.Add(new Files(maxPlBox.Text, "<plazomax>"));

                        bool done = false;
                        try
                        {
                            done = F1.CreateWordDocument(SaveAs, SaveAs, data);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al generar el archivo (Cod. 4)");
                        }


                        if (done)
                        {
                            EntBox.Text = "";
                            EntregaBox.Text = "";
                            PayBox.Text = "";
                            maxPlBox.Text = "";

                            client.postJSON = string.Empty;
                            client.postJSON = "{";
                            string aux = string.Empty;
                            foreach (Files d in data)
                            {
                                aux += d.toSTR();
                            }
                            aux += "\"tabla\": [";

                            string prod = string.Empty;
                            for (int i = 1; i < Productos.Count; i++)
                            {
                                prod += Productos[i].toSTR();
                                if (i != Productos.Count - 1)
                                    prod += ", ";
                            }
                            aux += prod;
                            aux += "]}";
                            client.postJSON += aux;

                            client.endPoint = "http://system.maxpower-ar.com/venta_prod";
                            client.httpMethod = httpVerb.POST;


                            resp = string.Empty;
                            try
                            {
                                resp = client.makeRequest();
                                if (resp == "0")
                                    MessageBox.Show("SQL ERROR (Cod. 0)");
                                else if (resp == "1")
                                    MessageBox.Show("Operación finalizada con éxito");
                                else if (resp == "2")
                                    MessageBox.Show("Ya existen registros de la empresa ingresada (Cod. 2)");
                                else
                                    MessageBox.Show("Error al enviar al servidor (Cod. 5)");
                            }
                            catch (WebException)
                            {
                                MessageBox.Show("No se pudo conectar con el servidor (Cod. 3)");
                            }
                            string f = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MaxPowerSystem\MaxPowerSystem\Venta de productos\MAX-" + nof + "-AR19-1.docx";
                            System.IO.File.Delete(f);
                            System.IO.File.Move((string)SaveAs, f);
                            Productos.Clear();
                            data.Clear();
                        }
                    }
                }


            }
            else
            {
                MessageBox.Show("Todo los campos deben estar completos");
            }

        }
        
        private void addProduct(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CantBox.Text) &&
                !string.IsNullOrEmpty(DescBox.Text) &&
                !string.IsNullOrEmpty(UnitPrBox.Text))
            {
                int cant = int.Parse(CantBox.Text);
                string desc = DescBox.Text;
                int price = int.Parse(UnitPrBox.Text);



                Productos.Add(new Detalle(cant.ToString(), desc, price.ToString(), (cant * price).ToString())); ;

                CantBox.Text = "";
                DescBox.Text = "";
                UnitPrBox.Text = "";
            }
            else
            {
                MessageBox.Show("Es necesario completar todos los campos para agregar un producto.");
            }

        }

        private void CantBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan numeros");
            }
        }

        private void UnitPrBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan numeros");
            }
        }

        private void MaxPlBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan numeros");
            }
        }

      


    }



}
