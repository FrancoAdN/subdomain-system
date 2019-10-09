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


namespace MaxPowerSystem
{
    public partial class viewDataBaseUC : UserControl
    {
        clientREST client = new clientREST();

        public viewDataBaseUC()
        {
            InitializeComponent();
            dbEnterprise1.Hide();
            dbOrdExt1.Hide();
            dbVentProd1.Hide();
            dbTecAsist1.Hide();
            cmbDb.SelectedIndex = cmbDb.Items.Count - 1;

            //init(15, 5);
        }



        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool err = false;
            string query = "";
            string ord = ordBox.Text;
            string ent = entBox.Text;
            string cuit = cuitBox.Text;
           
            string view = cmbDb.Text;
            if (!string.IsNullOrEmpty(cuit) && view != "Empresas")
            {
                MessageBox.Show("No se puede buscar por cuit en " + view);
                return;
            }
            else if (!string.IsNullOrEmpty(ord) && view == "Empresas")
            {
                MessageBox.Show("No se puede buscar por orden en " + view);
                return;
            }
            


            if(view == "Orden de compra exterior")
            {
                JToken json = ""; 
                if (string.IsNullOrEmpty(ord) && string.IsNullOrEmpty(ent))
                {
                    query = "SELECT * FROM ord_ext;";

                    client.endPoint = "http://system.maxpower-ar.com/ord_ext";

                    client.httpMethod = httpVerb.GET;

                    string resp = string.Empty;

                    resp = client.makeRequest();
                    
                    json = JToken.Parse(resp);
                    if (json.Type != JTokenType.Array)
                    {
                        err = true;
                        Console.WriteLine(json["errorMessages"]);
                    }
                    

                }
                else
                {
                    if (!string.IsNullOrEmpty(ord))
                        query = "SELECT * FROM ord_ext WHERE orden = ´" + ord + "´;";
                    else if(!string.IsNullOrEmpty(ent))
                        query = "SELECT * FROM ord_ext WHERE emp = ´" + ent + "´;";

                }

                dbVentProd1.Hide();
                dbTecAsist1.Hide();
                dbEnterprise1.Hide();
                dbOrdExt1.Hide();

                if (!err)
                {
                    
                    if (json.Count() == 1)
                    {
                        leftBut.Visible = false;
                        leftLab.Visible = false;
                        rightBut.Visible = false;
                        rightLab.Visible = false;

                        dbOrdExt1.json = json[0];
                        dbOrdExt1.changeVal(view);
                    }
                    dbOrdExt1.chInco("Incoterm:");
                    dbOrdExt1.Show();
                    dbOrdExt1.BringToFront();
                }
                else
                    MessageBox.Show("No se pudo conectar con el servidor (Cod. 3)");
            }
            else if (view == "Orden de compra nacional")
            {
                if (string.IsNullOrEmpty(ord) && string.IsNullOrEmpty(ent))
                {
                    query = "SELECT * FROM ord_nac;";
                }
                else
                {
                    if (!string.IsNullOrEmpty(ord))
                        query = "SELECT * FROM ord_nac WHERE orden = ´" + ord + "´;";
                    else if (!string.IsNullOrEmpty(ent))
                        query = "SELECT * FROM ord_nac WHERE emp = ´" + ent + "´;";

                }
                Console.WriteLine(query);
                dbVentProd1.Hide();
                dbTecAsist1.Hide();
                dbEnterprise1.Hide();

                dbOrdExt1.chInco("Forma de pago:");
               // dbOrdExt1.changeVal("MAX-AR-19-023", "Ingenio famailla", "EXW", "USD", "30 días", "25/09/2019", view);
                dbOrdExt1.Show();
                dbOrdExt1.BringToFront();
            }
            else if (view == "Reparación de laboratorio")
            {
                if (string.IsNullOrEmpty(ord) && string.IsNullOrEmpty(ent))
                {
                    query = "SELECT * FROM rep_lab;";
                }
                else
                {
                    if (!string.IsNullOrEmpty(ord))
                        query = "SELECT * FROM rep_lab WHERE orden = ´" + ord + "´;";
                    else if (!string.IsNullOrEmpty(ent))
                        query = "SELECT * FROM rep_lab WHERE emp = ´" + ent + "´;";

                }
                Console.WriteLine(query);

                dbOrdExt1.Hide();
                dbTecAsist1.Hide();
                dbEnterprise1.Hide();

                dbVentProd1.changeVal("MAX-AR-19-0578", "Ingenio Famailla",
                    "El material será entregado en transporte a designar por el cliente.",
                    "30 días contra presentación de factura y entrega del material",
                    "45 días", "25/09/2019", view);
                dbVentProd1.Show();
                dbVentProd1.BringToFront();
                
            }
            else if(view == "Venta de productos")
            {
                if (string.IsNullOrEmpty(ord) && string.IsNullOrEmpty(ent))
                {
                    query = "SELECT * FROM venta_prod;";
                }
                else
                {
                    if (!string.IsNullOrEmpty(ord))
                        query = "SELECT * FROM venta_prod WHERE orden = ´" + ord + "´;";
                    else if (!string.IsNullOrEmpty(ent))
                        query = "SELECT * FROM venta_prod WHERE emp = ´" + ent + "´;";

                }
                Console.WriteLine(query);

                dbOrdExt1.Hide();
                dbTecAsist1.Hide();
                dbEnterprise1.Hide();

                dbVentProd1.changeVal("MAX-AR-19-0578", "Ingenio Famailla",
                    "El material será entregado en transporte a designar por el cliente.",
                    "30 días contra presentación de factura y entrega del material",
                    "45 días","25/09/2019", view);
                dbVentProd1.Show();
                dbVentProd1.BringToFront();
                
            }
            else if(view == "Asistencia técnica")
            {
                if (string.IsNullOrEmpty(ord) && string.IsNullOrEmpty(ent))
                {
                    query = "SELECT * FROM asis_tec;";
                }
                else
                {
                    if (!string.IsNullOrEmpty(ord))
                        query = "SELECT * FROM asis_tec WHERE orden = ´" + ord + "´;";
                    else if (!string.IsNullOrEmpty(ent))
                        query = "SELECT * FROM asis_tec WHERE emp = ´" + ent + "´;";

                }
                Console.WriteLine(query);
                dbOrdExt1.Hide();
                dbVentProd1.Hide();
                dbEnterprise1.Hide();

                dbTecAsist1.changeVal("Ingenio Famailla", "Drives centrifugas Silver Maquina 2 refineria", "42720", "30 días fecha de factura",
                    "Por 2 días de 10hs de Asistencia Técnica de un Ingeniero Especializado para la asistencia técnica del drives ABB (Maquina 2 refineria) de la Centrifugas Silver Weibull, (Incluye hs de viaje, traslados aéreos y terrestres, alojamiento y viaticos):",
                    "21/09/2019", "MAX-AR-19-0604");
                dbTecAsist1.Show();
                dbTecAsist1.BringToFront();

            }
            else if(view == "Empresas")
            {
                if (string.IsNullOrEmpty(ent) && string.IsNullOrEmpty(cuit))
                {
                    query = "SELECT * FROM clientes;";
                }
                else
                {
                    if (!string.IsNullOrEmpty(cuit))
                        query = "SELECT * FROM asis_tec WHERE cuit = ´" + cuit + "´;";
                    else if (!string.IsNullOrEmpty(ent))
                        query = "SELECT * FROM asis_tec WHERE emp = ´" + ent + "´;";
                }

                Console.WriteLine(query);
                dbOrdExt1.Hide();
                dbVentProd1.Hide();
                dbTecAsist1.Hide();

                dbEnterprise1.changeVal("MaxPower", "20429045585", "Belgrano 180", "La Matanza", "maxpower-ar.com", "75566788",
                    "Ingeniería", "Automatizaciones industriales", "francoadinapoli@gmail.com", "tomasveratec@gmail.com", "1121916428", "1123456789",
                    "Franco di Nápoli", "Tomás Vera");
                dbEnterprise1.Show();
                dbEnterprise1.BringToFront();



            }
            else
            {
                dbEnterprise1.Hide();
                dbOrdExt1.Hide();
                dbVentProd1.Hide();
                dbTecAsist1.Hide();
            }
            newSearch.Visible = true;
            countPanel.Visible = true;
            
            

        }

        private void new_Search(object sender, EventArgs e)
        {
            dbOrdExt1.Hide();
            dbEnterprise1.Hide();
            dbVentProd1.Hide();
            dbTecAsist1.Hide();
            newSearch.Visible = false;
            
            cmbDb.SelectedIndex = cmbDb.Items.Count - 1;
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan numeros");
            }
        }

        private void OrdBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ordBox.Text))
            {
                labEnt.Visible = true;
                entBox.Visible = true;

                labCuit.Visible = true;
                cuitBox.Visible = true;

            }
            else
            {
                labEnt.Visible = false;
                entBox.Visible = false;

                labCuit.Visible = false;
                cuitBox.Visible = false;
            }
        }

        private void EntBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entBox.Text))
            {
                ordBox.Visible = true;
                ordLab.Visible = true;

                labCuit.Visible = true;
                cuitBox.Visible = true;

            }
            else
            {
                ordBox.Visible = false;
                ordLab.Visible = false;

                labCuit.Visible = false;
                cuitBox.Visible = false;
            }
        }

        private void CuitBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cuitBox.Text))
            {
                ordBox.Visible = true;
                ordLab.Visible = true;

                entBox.Visible = true;
                labEnt.Visible = true;

            }
            else
            {
                ordBox.Visible = false;
                ordLab.Visible = false;

                entBox.Visible = false;
                labEnt.Visible = false;
            }
        }
    }
}
