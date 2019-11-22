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

namespace MaxPowerSystem
{
    public partial class uploadDataBaseUC : UserControl
    {
        string titulo;
        
        public uploadDataBaseUC()
        {
            InitializeComponent();

        }

        public void changeName(string tit)
        {
            titulo = tit;
            labTitulo.Text = tit;
            //Proveedores
            if (tit == "Clientes")
            {
                comboRub.Visible = false;
                boxRub.Visible = true;
                boxEsp.ReadOnly = false;
                boxEsp.Enabled = true;
            }
            else if (tit == "Proveedores")
            {
                comboRub.Visible = true;
                boxRub.Visible = false;
                boxEsp.ReadOnly = true;
                boxEsp.Enabled = false;
            }
        }

        public void setProv(string prop)
        {
            comboRub.Items.Clear();

            if (prop == "All")
            {
                comboRub.Items.AddRange(new object[] {
                "Eléctricos","Electrónicos", "Seguridad"});
            }
            else if (prop == "Eléctricos")
            {
                comboRub.Items.AddRange(new object[] {
                "Eléctricos"});
                comboRub.SelectedIndex = 0;
            }
            else if (prop == "Electrónicos")
            {
                comboRub.Items.AddRange(new object[] {
                "Electrónicos"});
                comboRub.SelectedIndex = 0;
            }
            else if (prop == "Seguridad")
            {
                comboRub.Items.AddRange(new object[] {
                "Seguridad"});
                comboRub.SelectedIndex = 0;
            }
        }

        private void checkNumber(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan numeros");
            }
        }

        private void insertData(object sender, EventArgs e)
        {
            if (titulo == "Clientes")
            {
                //tit
                string emp = boxEmp.Text;
                string cuit = boxCuit.Text;
                string dir = boxDir.Text;
                string loc = boxLoc.Text;
                string rub = boxRub.Text;
                string esp = boxEsp.Text;
                string web = boxWeb.Text;
                string cont = boxCont.Text;
                string tel = boxTel.Text;
                string mail = boxMail.Text;
                string contb = boxContB.Text;
                string telb = boxTelB.Text;
                string mailb = boxMailB.Text;
                string telCom = boxTelCom.Text;

                if (string.IsNullOrEmpty(emp) || string.IsNullOrEmpty(cuit) || string.IsNullOrEmpty(dir) ||
                string.IsNullOrEmpty(loc) || string.IsNullOrEmpty(rub) || string.IsNullOrEmpty(esp) ||
                string.IsNullOrEmpty(web) || string.IsNullOrEmpty(cont) || string.IsNullOrEmpty(tel) ||
                string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(contb) || string.IsNullOrEmpty(telb) ||
                string.IsNullOrEmpty(mailb) || string.IsNullOrEmpty(telCom))
                {
                    MessageBox.Show("Todos los campos deben estar completos");
                }
                else
                {
                    clientREST client = new clientREST();

                    JObject json = new JObject();

                    json["emp"] = emp;
                    json["cuit"] = cuit;
                    json["dir"] = dir;
                    json["loc"] = loc;
                    json["rub"] = rub;
                    json["esp"] = esp;
                    json["web"] = web;
                    json["cont"] = cont;
                    json["tel"] = tel;
                    json["mail"] = mail;
                    json["contb"] = contb;
                    json["telb"] = telb;
                    json["mailb"] = mailb;
                    json["telcom"] = telCom;

                    client.endPoint = "http://system.maxpower-ar.com/emp";

                    client.httpMethod = httpVerb.POST;

                    client.postJSON = json.ToString();

                    string resp = string.Empty;

                    try
                    {
                        resp = client.makeRequest();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo conectar con el servidor (Cod. 3)");
                    }


                    if (resp == "0")
                    {
                        MessageBox.Show("SQL ERROR (Cod. 0)");
                    }
                    else if (resp == "1")
                    {
                        MessageBox.Show("Operación finalizada con éxito");
                        boxEmp.Text = string.Empty;
                        boxCuit.Text = string.Empty;
                        boxDir.Text = string.Empty;
                        boxLoc.Text = string.Empty;
                        boxWeb.Text = string.Empty;
                        boxTelCom.Text = string.Empty;
                        boxRub.Text = string.Empty;
                        boxEsp.Text = string.Empty;
                        boxCont.Text = string.Empty;
                        boxContB.Text = string.Empty;
                        boxTel.Text = string.Empty;
                        boxTelB.Text = string.Empty;
                        boxMail.Text = string.Empty;
                        boxMailB.Text = string.Empty;
                    }
                    else if (resp == "2")
                    {
                        MessageBox.Show("Ya existen registros de la empresa ingresada (Cod. 2)");
                    }

                }
            }
            else if(titulo == "Proveedores")
            {
                //prov
                string emp = boxEmp.Text;
                string cuit = boxCuit.Text;
                string dir = boxDir.Text;
                string loc = boxLoc.Text;
                string rub = comboRub.Text;
                string web = boxWeb.Text;
                string cont = boxCont.Text;
                string tel = boxTel.Text;
                string mail = boxMail.Text;
                string contb = boxContB.Text;
                string telb = boxTelB.Text;
                string mailb = boxMailB.Text;
                string telCom = boxTelCom.Text;

                if (string.IsNullOrEmpty(emp) || string.IsNullOrEmpty(cuit) || string.IsNullOrEmpty(dir) ||
                string.IsNullOrEmpty(loc) || string.IsNullOrEmpty(rub) || string.IsNullOrEmpty(web) ||
                string.IsNullOrEmpty(cont) || string.IsNullOrEmpty(tel) || string.IsNullOrEmpty(mail) ||
                string.IsNullOrEmpty(contb) || string.IsNullOrEmpty(telb) || string.IsNullOrEmpty(mailb) ||
                string.IsNullOrEmpty(telCom))
                {
                    MessageBox.Show("Todos los campos deben estar completos");
                }
                else
                {
                    clientREST client = new clientREST();

                    JObject json = new JObject();

                    json["emp"] = emp;
                    json["cuit"] = cuit;
                    json["dir"] = dir;
                    json["loc"] = loc;
                    json["rub"] = rub;
                    json["web"] = web;
                    json["cont"] = cont;
                    json["tel"] = tel;
                    json["mail"] = mail;
                    json["contb"] = contb;
                    json["telb"] = telb;
                    json["mailb"] = mailb;
                    json["telcom"] = telCom;

                    client.endPoint = "http://system.maxpower-ar.com/prov";

                    client.httpMethod = httpVerb.POST;

                    client.postJSON = json.ToString();

                    string resp = string.Empty;

                    try
                    {
                        resp = client.makeRequest();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo conectar con el servidor (Cod. 3)");
                    }


                    if (resp == "0")
                    {
                        MessageBox.Show("SQL ERROR (Cod. 0)");
                    }
                    else if (resp == "1")
                    {
                        MessageBox.Show("Operación finalizada con éxito");
                        boxEmp.Text = string.Empty;
                        boxCuit.Text = string.Empty;
                        boxDir.Text = string.Empty;
                        boxLoc.Text = string.Empty;
                        boxWeb.Text = string.Empty;
                        boxTelCom.Text = string.Empty;
                        boxRub.Text = string.Empty;
                        boxEsp.Text = string.Empty;
                        boxCont.Text = string.Empty;
                        boxContB.Text = string.Empty;
                        boxTel.Text = string.Empty;
                        boxTelB.Text = string.Empty;
                        boxMail.Text = string.Empty;
                        boxMailB.Text = string.Empty;
                    }
                    else if (resp == "2")
                    {
                        MessageBox.Show("Ya existen registros de la empresa ingresada (Cod. 2)");
                    }

                }
            }
            

           
        }
    }
}
