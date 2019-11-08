using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net;

namespace MaxPowerSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            usrBox.Text = "Usuario";
            usrBox.ForeColor = Color.LightGray;
            pwdBox.Text = "Contraseña";
            pwdBox.ForeColor = Color.LightGray;
        }
        public void TextGotFocus(object sender, EventArgs e)
        {

            if (usrBox.Text == "Usuario")
            {
                usrBox.Text = "";
                usrBox.ForeColor = Color.Black;
            }
        }

        public void TextLostFocus(object sender, EventArgs e)
        {

            if (usrBox.Text == "")
            {
                usrBox.Text = "Usuario";
                usrBox.ForeColor = Color.LightGray;
            }
        }
        public void OnFocusPWD(object sender, EventArgs e)
        {

            if (pwdBox.Text == "Contraseña")
            {
                pwdBox.Text = "";
                pwdBox.PasswordChar = '*';
                pwdBox.ForeColor = Color.Black;
            }
        }

        public void LostFocusPWD(object sender, EventArgs e)
        {

            if (pwdBox.Text == "")
            {
                pwdBox.PasswordChar = '\0';
                pwdBox.Text = "Contraseña";
                pwdBox.ForeColor = Color.LightGray;
            }
        }
        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            /*Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();*/
            Application.Exit();
        }

        private void Button2_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ValLogin(object sender, EventArgs e)
        {
            bool err = false;
            string usr = usrBox.Text;
            string pwd = pwdBox.Text;
            if ((!string.IsNullOrEmpty(usr) && !string.IsNullOrEmpty(pwd)) || usr == "Usuario" || pwdBox.PasswordChar != '\0')
            {
                clientREST client = new clientREST();
                client.endPoint = "http://system.maxpower-ar.com/login?usr=" + pwd + "&&pwd=" + pwd;
                client.httpMethod = httpVerb.GET;
                string resp = string.Empty;
                JToken json = "";
                resp = client.makeRequest();
                json = JToken.Parse(resp);
                if (resp == "0")
                {
                    err = true;
                    MessageBox.Show("SQL ERROR (Cod. 0)", "Maxpower System dice: ");
                }
                else if (resp == "false")
                {
                    err = true;
                    MessageBox.Show("Usuario o contraseña incorrecta", "Maxpower System dice: ");
                }
                else if (!(json.Count() == 1))
                    err = true;


                if (!err)
                {
                    Console.WriteLine("User logged on " + json[0]["usuario"]);
                    Form1 f1 = new Form1();
                    this.Hide();
                    f1.ShowDialog();
                    this.Close();
                }



            }
            else
                MessageBox.Show("Los campos deben estar completos para iniciar sesion", "Maxpower System dice: ");


        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' || e.KeyChar == '\n')
            {
                e.Handled = true;
                this.ValLogin(new object(), new EventArgs());
            }
        }

    }
}
