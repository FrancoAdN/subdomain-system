﻿using System;
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
    public partial class repProdUC : UserControl
    {
        private List<Detalle> productos = new List<Detalle>();

        internal List<Detalle> Productos { get => productos; set => productos = value; }
        public int IdUser;
        public repProdUC()
        {
            InitializeComponent();
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

        

        private void notNumberCheck(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan numeros");
            }
        }

        private void genWord(object sender, MouseEventArgs e)
        {
            JToken tempJ = "";
            object temp = @"C:\Program Files\Maxpower\Maxpower System\static\temp_rep_prod.docx";
            object SaveAs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MaxPowerSystem\MaxPowerSystem\Reparación de laboratorio\test_rep.docx";
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
                        MessageBox.Show("SQL ERROR (Cod. 0)", "Maxpower System dice: ");
                        err = true;
                    }
                    else if (resp == "6")
                    {
                        err = true;
                        MessageBox.Show("No existen los registros buscados (Cod. 6)", "Maxpower System dice: ");
                    }
                    json = JToken.Parse(resp);
                    if (json.Type != JTokenType.Array)
                    {
                        err = true;
                        MessageBox.Show("No se pudo conectar con el servidor (Cod. 3)", "Maxpower System dice: ");
                    }

                    if (!(json.Count() == 1))
                        err = true;

                }
                catch (WebException)
                {
                    err = true;
                    MessageBox.Show("No se pudo conectar con el servidor (Cod. 3)", "Maxpower System dice: ");
                }

                if (!err)
                {
                    string msg = $"Contacto 1: {json[0]["cont"]}\n\nContacto 2: {json[0]["contb"]}\n\n\nPresione \"Si\" para el contacto 1, \"No\" para el contacto 2";
                    if (MessageBox.Show(msg, "Maxpower System dice: ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        data.Add(new Files((string)json[0]["cont"], "<para>"));
                        data.Add(new Files((string)json[0]["mail"], "<email>"));
                    }
                    else
                    {
                        data.Add(new Files((string)json[0]["contb"], "<para>"));
                        data.Add(new Files((string)json[0]["mailb"], "<email>"));
                    }
                    data.Add(new Files((string)json[0]["telcom"], "<tel>"));

                    Form1 F1 = new Form1();
                    Productos.Add(new Detalle("Cant.", "Descripción", "Precio unitario USD", "Precio Total USD"));
                    try
                    {
                        F1.CreateTableWord(temp, SaveAs, Productos, 3);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al generar el archivo (Cod. 4)", "Maxpower System dice: ");
                    }


                    

                    client.endPoint = "http://system.maxpower-ar.com/last";

                    try
                    {
                        resp = client.makeRequest();

                        if (resp == "0")
                            MessageBox.Show("SQL ERROR (Cod. 0)");
                        else if (resp == "6")
                            MessageBox.Show("No existen los registros buscados (Cod. 6)", "Maxpower System dice: ");

                        json = JToken.Parse(resp);
                        if (json.Type != JTokenType.Array)
                        {
                            err = true;
                            MessageBox.Show("No se pudo conectar con el servidor (Cod. 3)", "Maxpower System dice: ");
                            Console.WriteLine(json["errorMessages"]);
                        }

                    }
                    catch (WebException)
                    {
                        MessageBox.Show("No se pudo conectar con el servidor (Cod. 3)", "Maxpower System dice: ");
                    }

                    if (!err)
                    {
                        int nof = (int)json[0]["num"] + 1;
                        
                        data.Add(new Files("MAX-" + nof + "-AR19-1", "<noferta>"));
                        data.Add(new Files(DateTime.Now.ToString("dd/MM/yyyy"), "<fecha>"));
                        data.Add(new Files(EntBox.Text, "<empresa>"));
                        data.Add(new Files(boxRef.Text, "<ref>"));
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
                            MessageBox.Show("Error al generar el archivo (Cod. 4)", "Maxpower System dice: ");
                        }


                        if (done)
                        {
                            EntBox.Text = "";
                            EntregaBox.Text = "";
                            PayBox.Text = "";
                            maxPlBox.Text = "";
                            boxRef.Text = "";

                            client.postJSON = string.Empty;
                            client.postJSON = "{";
                            string aux = string.Empty;
                            foreach (Files d in data)
                            {
                                aux += d.toSTR();
                            }
                            aux += "\"tabla\": [";

                            string prod = string.Empty;
                            for(int i = 1; i < Productos.Count; i++)
                            {
                                prod += Productos[i].toSTR();
                                if (i != Productos.Count - 1)
                                    prod += ", ";
                            }
                            aux += prod;
                            aux += "]}";
                            client.postJSON += aux;

                            tempJ = JToken.Parse(client.postJSON);
                            tempJ["id_empleado"] = this.IdUser;
                            client.postJSON = tempJ.ToString();

                            client.endPoint = "http://system.maxpower-ar.com/rep_lab";
                            client.httpMethod = httpVerb.POST;


                            resp = string.Empty;
                            try
                            {
                                resp = client.makeRequest();
                                if (resp == "0")
                                    MessageBox.Show("SQL ERROR (Cod. 0)", "Maxpower System dice: ");
                                else if (resp == "1")
                                    MessageBox.Show("Operación finalizada con éxito", "Maxpower System dice: ");
                                else if (resp == "2")
                                    MessageBox.Show("Ya existen registros de la empresa ingresada (Cod. 2)", "Maxpower System dice: ");
                                else
                                    MessageBox.Show("Error al enviar al servidor (Cod. 5)", "Maxpower System dice: ");
                            }
                            catch (WebException)
                            {
                                MessageBox.Show("No se pudo conectar con el servidor (Cod. 3)", "Maxpower System dice: ");
                            }
                            string f = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MaxPowerSystem\MaxPowerSystem\Reparación de laboratorio\MAX-" + nof + "-AR19-1.docx";
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
                MessageBox.Show("Todo los campos deben estar completos", "Maxpower System dice: ");
            }
        }

        private void addProduct(object sender, MouseEventArgs e)
        {

        }
    }

}

