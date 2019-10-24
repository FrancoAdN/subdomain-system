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
    public partial class tecAsistUC : UserControl
    {
        public tecAsistUC()
        {
            InitializeComponent();
        }



        private void ButtonWordFile_Click(object sender, EventArgs e)
        {
            
            string detail = labPor.Text +" "+ boxDays.Text +" "+ labDay.Text +" "+ boxHours.Text +" "+ labAsist.Text +" "+ labTec.Text +" "+ labForAsist.Text +" "+ boxDetalle.Text; 
            Form1 F1= new Form1();
            
            if(!string.IsNullOrEmpty(boxEnterprise.Text) && 
                !string.IsNullOrEmpty(boxAsist.Text) &&
                !string.IsNullOrEmpty(boxPrice.Text) &&
                !string.IsNullOrEmpty(boxForm.Text) &&
                !string.IsNullOrEmpty(boxDays.Text) &&
                !string.IsNullOrEmpty(boxHours.Text) &&
                !string.IsNullOrEmpty(boxDetalle.Text))
            {
                JToken json = "";
                bool err = false; 
                clientREST client = new clientREST();

                client.endPoint = "http://system.maxpower-ar.com/emp/" + boxEnterprise.Text;

                client.httpMethod = httpVerb.GET;


                string resp = string.Empty;

                try
                {
                    resp = client.makeRequest();
                    if (resp == "0")
                    {
                        err = true;
                        MessageBox.Show("SQL ERROR (Cod. 0)");
                    }
                    else if (resp == "6")
                    {
                        err = true;
                        MessageBox.Show("No existen los registros buscados (Cod. 6)");
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

                    List<Files> data = new List<Files>();
                    data.Add(new Files(DateTime.Now.ToString("dd/MM/yyyy"), "<fecha>"));
                    data.Add(new Files((string)json[0]["cont"],"<para>"));
                    data.Add(new Files((string)json[0]["mail"], "<email>"));
                    data.Add(new Files((string)json[0]["tel"], "<tel>"));
                    data.Add(new Files(boxEnterprise.Text, "<empresa>"));
                    data.Add(new Files(boxAsist.Text, "<asistencia>"));
                    data.Add(new Files(detail, "<detalle>"));
                    data.Add(new Files(boxPrice.Text, "<precio>"));
                    data.Add(new Files(boxForm.Text, "<formadepago>"));

                    client.endPoint = "http://system.maxpower-ar.com/last";

                    try
                    {
                        resp = client.makeRequest();

                        if (resp == "0")
                            MessageBox.Show("SQL ERROR (Cod. 0)");
                        else if (resp == "6")
                            MessageBox.Show("No existen los registros buscados (Cod. 6)");

                        json = JToken.Parse(resp);
                        if (json.Type != JTokenType.Array)
                        {
                            err = true;
                            MessageBox.Show("No se pudo conectar con el servidor (Cod. 3)");
                            Console.WriteLine(json["errorMessages"]);
                        }

                    }
                    catch (WebException)
                    {
                        MessageBox.Show("No se pudo conectar con el servidor (Cod. 3)");
                    }

                    if (!err)
                    {
                        int nof = (int)json[0]["num"] + 1;
                        data.Add(new Files("MAX-"+nof+"-AR19-1", "<noferta>"));
                        string filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MaxPowerSystem\MaxPowerSystem\Asistencia Técnica\asist_tec.docx";
                        bool done = false;

                        try
                        {
                            done = F1.CreateWordDocument(@"C:\Program Files\Maxpower\Maxpower System\static\temp_asist_tec.docx", filepath, data);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al generar el archivo (Cod. 4)");

                        }


                        if (done)
                        {
                            boxEnterprise.Text = "";
                            boxAsist.Text = "";
                            boxPrice.Text = "";
                            boxForm.Text = "";
                            boxDays.Text = "";
                            boxHours.Text = "";
                            boxDetalle.Text = "";
                            boxDays.Text = "";
                            boxHours.Text = "";

                            client.postJSON = string.Empty;
                            client.postJSON = "{";
                            char[] tr = { '{', '}' };
                            string aux = string.Empty;
                            foreach (Files d in data)
                            {
                                aux += d.toSTR();
                            }
                            aux = aux.Remove(aux.Length - 1);
                            client.postJSON += aux;
                            client.postJSON += "}";


                            client.endPoint = "http://system.maxpower-ar.com/asis_tec";

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
                            string f = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MaxPowerSystem\MaxPowerSystem\Asistencia Técnica\MAX-" + nof + "-AR19-1.docx";
                            System.IO.File.Delete(f);
                            System.IO.File.Move(filepath, f);
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


        private void BoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan numeros");
            }
        }

        private void BoxDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan numeros");
            }
        }

        private void BoxHours_KeyPress(object sender, KeyPressEventArgs e)
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
