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
using System.Net;


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
            dbSolicitudesUC1.Hide();
            cmbDb.SelectedIndex = cmbDb.Items.Count - 1;

            //init(15, 5);
        }



        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool err = false;
            string query = string.Empty;
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
                    client.endPoint = "http://system.maxpower-ar.com/ord_ext";

                    client.httpMethod = httpVerb.GET;

                    string resp = string.Empty;

                    resp = client.makeRequest();
                    if (resp == "0")
                    {
                        MessageBox.Show("SQL ERROR (Cod. 0)");
                        err = true;
                    }
                    else if (resp == "6")
                    {
                        err = true;
                        MessageBox.Show("No existen los registros buscados (Cod. 6)");
                    }
                    else if (resp == "9")
                    {
                        err = true;
                        MessageBox.Show("No existen registros (Cod. 9)");
                    }
                    json = JToken.Parse(resp);
                    if (json.Type != JTokenType.Array)
                    {
                        err = true;
                       
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(ord))
                    {
                        client.endPoint = "http://system.maxpower-ar.com/ord_ext/" + ord;

                        client.httpMethod = httpVerb.GET;

                        string resp = string.Empty;

                        resp = client.makeRequest();
                        if (resp == "0")
                        {
                            MessageBox.Show("SQL ERROR (Cod. 0)");
                            err = true;
                        }
                        else if (resp == "6")
                        {
                            err = true;
                            MessageBox.Show("No existen los registros buscados (Cod. 6)");
                        }
                        else if (resp == "7")
                        {
                            MessageBox.Show("No existen registros (Cod. 7)");
                            err = true;
                        }

                        json = JToken.Parse(resp);
                        if (json.Type != JTokenType.Array)
                        {
                            err = true;
                   
                        }
                    }
                    else if (!string.IsNullOrEmpty(ent))
                    {
                        client.endPoint = "http://system.maxpower-ar.com/ord_ext/emp/" + ent;

                        client.httpMethod = httpVerb.GET;

                        string resp = string.Empty;

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
                        else if (resp == "8")
                        {
                            MessageBox.Show("No existen registros (Cod. 8)");
                            err = true;
                        }

                        json = JToken.Parse(resp);
                        if (json.Type != JTokenType.Array)
                        {
                            err = true;

                        }
                    }

                    entBox.Text = string.Empty;
                    ordBox.Text = string.Empty;

                }

                dbVentProd1.Hide();
                dbTecAsist1.Hide();
                dbEnterprise1.Hide();
                dbOrdExt1.Hide();
                dbSolicitudesUC1.Hide();

                if (!err)
                {
                    dbOrdExt1.json = json;

                    if (json.Count() == 1)
                    {
                        leftBut.Visible = false;
                        leftLab.Visible = false;
                        rightBut.Visible = false;
                        rightLab.Visible = false;
                        dbOrdExt1.Index = 0;
                        dbOrdExt1.changeVal(view);
                    }
                    else
                    {
                        dbOrdExt1.Index = 0;
                        leftBut.Visible = true;
                        leftLab.Text = (dbOrdExt1.Index + 1).ToString();
                        leftLab.Visible = true;
                        rightBut.Visible = true;
                        rightLab.Text = json.Count().ToString();
                        rightLab.Visible = true;
                        dbOrdExt1.changeVal(view);
                    }
                    dbOrdExt1.chInco("Incoterm:");
                    dbOrdExt1.Show();
                    dbOrdExt1.BringToFront();
                }
   
            }
            else if (view == "Orden de compra nacional")
            {
                JToken json = "";

                if (string.IsNullOrEmpty(ord) && string.IsNullOrEmpty(ent))
                {
                    client.endPoint = "http://system.maxpower-ar.com/ord_nac";

                    client.httpMethod = httpVerb.GET;

                    string resp = string.Empty;

                    resp = client.makeRequest();
                    if (resp == "0")
                    {
                        MessageBox.Show("SQL ERROR (Cod. 0)");
                        err = true;
                    }
                    else if (resp == "6")
                    {
                        err = true;
                        MessageBox.Show("No existen los registros buscados (Cod. 6)");
                    }
                    else if (resp == "9")
                    {
                        err = true;
                        MessageBox.Show("No existen registros (Cod. 9)");
                    }
                    json = JToken.Parse(resp);
                    if (json.Type != JTokenType.Array)
                    {
                        err = true;

                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(ord))
                    {
                        client.endPoint = "http://system.maxpower-ar.com/ord_nac/" + ord;

                        client.httpMethod = httpVerb.GET;

                        string resp = string.Empty;

                        resp = client.makeRequest();
                        if (resp == "0")
                        {
                            MessageBox.Show("SQL ERROR (Cod. 0)");
                            err = true;
                        }
                        else if (resp == "6")
                        {
                            err = true;
                            MessageBox.Show("No existen los registros buscados (Cod. 6)");
                        }
                        else if (resp == "7")
                        {
                            MessageBox.Show("No existen registros (Cod. 7)");
                            err = true;
                        }

                        json = JToken.Parse(resp);
                        if (json.Type != JTokenType.Array)
                        {
                            err = true;
          
                        }
                    }
                    else if (!string.IsNullOrEmpty(ent))
                    {
                        client.endPoint = "http://system.maxpower-ar.com/ord_nac/emp/" + ent;

                        client.httpMethod = httpVerb.GET;

                        string resp = string.Empty;

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
                        else if (resp == "8")
                        {
                            MessageBox.Show("No existen registros (Cod. 8)");
                            err = true;
                        }

                        json = JToken.Parse(resp);
                        if (json.Type != JTokenType.Array)
                        {
                            err = true;
                            
                        }
                    }

                    entBox.Text = string.Empty;
                    ordBox.Text = string.Empty;

                }
                dbVentProd1.Hide();
                dbTecAsist1.Hide();
                dbEnterprise1.Hide();
                dbOrdExt1.Hide();
                dbSolicitudesUC1.Hide();

                if (!err)
                {
                    dbOrdExt1.json = json;

                    if (json.Count() == 1)
                    {
                        leftBut.Visible = false;
                        leftLab.Visible = false;
                        rightBut.Visible = false;
                        rightLab.Visible = false;
                        dbOrdExt1.Index = 0;
                        dbOrdExt1.changeVal(view);
                    }
                    else
                    {
                        dbOrdExt1.Index = 0;
                        leftBut.Visible = true;
                        leftLab.Text = (dbOrdExt1.Index + 1).ToString();
                        leftLab.Visible = true;
                        rightBut.Visible = true;
                        rightLab.Text = json.Count().ToString();
                        rightLab.Visible = true;
                        dbOrdExt1.changeVal(view);
                    }
                    dbOrdExt1.chInco("Forma de pago:");
                    dbOrdExt1.Show();
                    dbOrdExt1.BringToFront();
                }
                
            }
            else if (view == "Cot. Reparación de laboratorio")
            {
                JToken json = "";

                if (string.IsNullOrEmpty(ord) && string.IsNullOrEmpty(ent))
                {
                    client.endPoint = "http://system.maxpower-ar.com/rep_lab";

                    client.httpMethod = httpVerb.GET;

                    string resp = string.Empty;

                    resp = client.makeRequest();
                    if (resp == "0")
                    {
                        MessageBox.Show("SQL ERROR (Cod. 0)");
                        err = true;
                    }
                    else if (resp == "6")
                    {
                        err = true;
                        MessageBox.Show("No existen los registros buscados (Cod. 6)");
                    }
                    else if (resp == "9")
                    {
                        err = true;
                        MessageBox.Show("No existen registros (Cod. 9)");
                    }
                    json = JToken.Parse(resp);
                    if (json.Type != JTokenType.Array)
                    {
                        err = true;

                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(ord))
                    {
                        client.endPoint = "http://system.maxpower-ar.com/rep_lab/" + ord;

                        client.httpMethod = httpVerb.GET;

                        string resp = string.Empty;

                        resp = client.makeRequest();
                        if (resp == "0")
                        {
                            MessageBox.Show("SQL ERROR (Cod. 0)");
                            err = true;
                        }
                        else if (resp == "6")
                        {
                            err = true;
                            MessageBox.Show("No existen los registros buscados (Cod. 6)");
                        }
                        else if (resp == "7")
                        {
                            MessageBox.Show("No existen registros (Cod. 7)");
                            err = true;
                        }

                        json = JToken.Parse(resp);
                        if (json.Type != JTokenType.Array)
                        {
                            err = true;

                        }
                    }
                    else if (!string.IsNullOrEmpty(ent))
                    {
                        client.endPoint = "http://system.maxpower-ar.com/rep_lab/emp/" + ent;

                        client.httpMethod = httpVerb.GET;

                        string resp = string.Empty;

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
                        else if (resp == "8")
                        {
                            MessageBox.Show("No existen registros (Cod. 8)");
                            err = true;
                        }

                        json = JToken.Parse(resp);
                        if (json.Type != JTokenType.Array)
                        {
                            err = true;
                        }
                    }

                    entBox.Text = string.Empty;
                    ordBox.Text = string.Empty;

                }


                dbOrdExt1.Hide();
                dbTecAsist1.Hide();
                dbEnterprise1.Hide();
                dbVentProd1.Hide();
                dbSolicitudesUC1.Hide();

                if (!err)
                {
                    dbVentProd1.json = json;
                    dbVentProd1.Index = 0;

                    if(json.Count() == 1)
                    {
                        leftBut.Visible = false;
                        leftLab.Visible = false;
                        rightBut.Visible = false;
                        rightLab.Visible = false;
                    }
                    else
                    {
                        leftBut.Visible = true;
                        leftLab.Visible = true;
                        rightBut.Visible = true;
                        rightLab.Visible = true;
                        rightLab.Text = json.Count().ToString();
                        leftLab.Text = 1.ToString();
                    }
                }

                dbVentProd1.changeVal(view);
                dbVentProd1.Show();
                dbVentProd1.BringToFront();
                
            }
            else if(view == "Cot. Venta de productos")
            {
                JToken json = "";

                if (string.IsNullOrEmpty(ord) && string.IsNullOrEmpty(ent))
                {
                    client.endPoint = "http://system.maxpower-ar.com/venta_prod";

                    client.httpMethod = httpVerb.GET;

                    string resp = string.Empty;

                    resp = client.makeRequest();
                    if (resp == "0")
                    {
                        MessageBox.Show("SQL ERROR (Cod. 0)");
                        err = true;
                    }
                    else if (resp == "6")
                    {
                        err = true;
                        MessageBox.Show("No existen los registros buscados (Cod. 6)");
                    }
                    else if (resp == "9")
                    {
                        err = true;
                        MessageBox.Show("No existen registros (Cod. 9)");
                    }
                    json = JToken.Parse(resp);
                    if (json.Type != JTokenType.Array)
                    {
                        err = true;
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(ord))
                    {
                        client.endPoint = "http://system.maxpower-ar.com/venta_prod/" + ord;

                        client.httpMethod = httpVerb.GET;

                        string resp = string.Empty;

                        resp = client.makeRequest();
                        if (resp == "0")
                        {
                            MessageBox.Show("SQL ERROR (Cod. 0)");
                            err = true;
                        }
                        else if (resp == "6")
                        {
                            err = true;
                            MessageBox.Show("No existen los registros buscados (Cod. 6)");
                        }
                        else if (resp == "7")
                        {
                            MessageBox.Show("No existen registros (Cod. 7)");
                            err = true;
                        }

                        json = JToken.Parse(resp);
                        if (json.Type != JTokenType.Array)
                        {
                            err = true;
                        }
                    }
                    else if (!string.IsNullOrEmpty(ent))
                    {
                        client.endPoint = "http://system.maxpower-ar.com/venta_prod/emp/" + ent;

                        client.httpMethod = httpVerb.GET;

                        string resp = string.Empty;

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
                        else if (resp == "8")
                        {
                            MessageBox.Show("No existen registros (Cod. 8)");
                            err = true;
                        }

                        json = JToken.Parse(resp);
                        if (json.Type != JTokenType.Array)
                        {
                            err = true;
                        }
                    }

                    entBox.Text = string.Empty;
                    ordBox.Text = string.Empty;

                }
                dbOrdExt1.Hide();
                dbTecAsist1.Hide();
                dbEnterprise1.Hide();
                dbVentProd1.Hide();
                dbSolicitudesUC1.Hide();

                if (!err)
                {
                    dbVentProd1.json = json;
                    dbVentProd1.Index = 0;

                    if(json.Count() == 1)
                    {
                        leftBut.Visible = false;
                        leftLab.Visible = false;
                        rightBut.Visible = false;
                        rightLab.Visible = false;
                    }
                    else
                    {
                        leftBut.Visible = true;
                        leftLab.Visible = true;
                        rightBut.Visible = true;
                        rightLab.Visible = true;
                        rightLab.Text = json.Count().ToString();
                        leftLab.Text = 1.ToString();
                    }

                    dbVentProd1.changeVal(view);
                    dbVentProd1.Show();
                    dbVentProd1.BringToFront();
                }

                
                
                
            }
            else if(view == "Cot. Asistencia técnica")
            {
                JToken json = "";
                if (string.IsNullOrEmpty(ord) && string.IsNullOrEmpty(ent))
                {
                    client.endPoint = "http://system.maxpower-ar.com/asis_tec";

                    client.httpMethod = httpVerb.GET;

                    string resp = string.Empty;

                    resp = client.makeRequest();
                    if (resp == "0")
                    {
                        MessageBox.Show("SQL ERROR (Cod. 0)");
                        err = true;
                    }
                    else if (resp == "6")
                    {
                        err = true;
                        MessageBox.Show("No existen los registros buscados (Cod. 6)");
                    }
                    else if (resp == "9")
                    {
                        err = true;
                        MessageBox.Show("No existen registros (Cod. 9)");
                    }
                    json = JToken.Parse(resp);
                    if (json.Type != JTokenType.Array)
                    {
                        err = true;
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(ord))
                    {
                        client.endPoint = "http://system.maxpower-ar.com/asis_tec/" + ord;

                        client.httpMethod = httpVerb.GET;

                        string resp = string.Empty;

                        resp = client.makeRequest();
                        if (resp == "0")
                        {
                            MessageBox.Show("SQL ERROR (Cod. 0)");
                            err = true;
                        }
                        else if (resp == "6")
                        {
                            err = true;
                            MessageBox.Show("No existen los registros buscados (Cod. 6)");
                        }
                        else if (resp == "7")
                        {
                            MessageBox.Show("No existen registros (Cod. 7)");
                            err = true;
                        }

                        json = JToken.Parse(resp);
                        if (json.Type != JTokenType.Array)
                        {
                            err = true;
                        }
                    }
                    else if (!string.IsNullOrEmpty(ent))
                    {
                        client.endPoint = "http://system.maxpower-ar.com/asis_tec/emp/" + ent;

                        client.httpMethod = httpVerb.GET;

                        string resp = string.Empty;

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
                        else if (resp == "8")
                        {
                            MessageBox.Show("No existen registros (Cod. 8)");
                            err = true;
                        }

                        json = JToken.Parse(resp);
                        if (json.Type != JTokenType.Array)
                        {
                            err = true;
                     
                        }
                    }

                    entBox.Text = string.Empty;
                    ordBox.Text = string.Empty;

                }
                dbOrdExt1.Hide();
                dbSolicitudesUC1.Hide();
                dbVentProd1.Hide();
                dbEnterprise1.Hide();
                dbTecAsist1.Hide();
                if(!err)
                {
                    if(json.Count() == 1)
                    {
                        leftBut.Visible = false;
                        leftLab.Visible = false;
                        rightBut.Visible = false;
                        rightLab.Visible = false;
                    }
                    else
                    {
                        leftBut.Visible = true;
                        leftLab.Text = (dbTecAsist1.Index + 1).ToString();
                        leftLab.Visible = true;
                        rightBut.Visible = true;
                        rightLab.Text = json.Count().ToString();
                        rightLab.Visible = true;
                    }

                    dbTecAsist1.json = json;
                    dbTecAsist1.Index = 0;
                    dbTecAsist1.changeVal();
                    dbTecAsist1.Show();
                    dbTecAsist1.BringToFront();
                }
                

            }
            else if(view == "Empresas")
            {
                JToken json = "";

                if (string.IsNullOrEmpty(ent) && string.IsNullOrEmpty(cuit))
                {
                    entBox.Text = string.Empty;

                    client.endPoint = "http://system.maxpower-ar.com/emp";

                    client.httpMethod = httpVerb.GET;

                    string resp = string.Empty;

                    resp = client.makeRequest();
                    if (resp == "0")
                    {
                        err = true;
                        MessageBox.Show("SQL ERROR (Cod. 0)");
                    }
                    else if (resp == "6")
                    {
                        MessageBox.Show("No existen los registros buscados (Cod. 6)");
                        err = true;
                    }else if(resp == "9")
                    {
                        MessageBox.Show("No existen registros (Cod. 9)");
                        err = true;
                    }
                        
                    json = JToken.Parse(resp);
                    if (json.Type != JTokenType.Array)
                    {
                        err = true;

                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(cuit))
                    {
                        
                        client.endPoint = "http://system.maxpower-ar.com/emp/" + cuit;

                        client.httpMethod = httpVerb.GET;

                        string resp = string.Empty;

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
                        else if (resp == "9")
                        {
                            MessageBox.Show("No existen registros (Cod. 9)");
                            err = true;
                        }
                        json = JToken.Parse(resp);
                        if (json.Type != JTokenType.Array)
                        {
                            err = true;
                        }
                    }
                    else if (!string.IsNullOrEmpty(ent))
                    {
                        client.endPoint = "http://system.maxpower-ar.com/emp/" + ent;

                        client.httpMethod = httpVerb.GET;

                        string resp = string.Empty;

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
                        else if (resp == "9") {
                            err = true;
                            MessageBox.Show("No existen los registros buscados (Cod. 9)");
                        }
                        json = JToken.Parse(resp);
                        if (json.Type != JTokenType.Array)
                        {
                            err = true;
                        }
                    }
                    cuitBox.Text = string.Empty;
                    entBox.Text = string.Empty;

                }

                dbOrdExt1.Hide();
                dbTecAsist1.Hide();
                dbEnterprise1.Hide();
                dbVentProd1.Hide();
                dbSolicitudesUC1.Hide();

                if (!err)
                {
                    dbEnterprise1.json = json;
                    dbEnterprise1.Index = 0;

                    if (json.Count() == 1)
                    {
                        leftBut.Visible = false;
                        leftLab.Visible = false;
                        rightBut.Visible = false;
                        rightLab.Visible = false;
                    }
                    else
                    {
                        leftBut.Visible = true;
                        leftLab.Visible = true;
                        rightBut.Visible = true;
                        rightLab.Visible = true;
                        rightLab.Text = json.Count().ToString();
                        leftLab.Text = 1.ToString();
                    }
                    dbEnterprise1.changeVal();
                    dbEnterprise1.Show();
                    dbEnterprise1.BringToFront();
                }

                

            }
            else if (view == "Solicitudes")
            {
                JToken json = "";
                if (string.IsNullOrEmpty(ord) && string.IsNullOrEmpty(ent))
                {
                    client.endPoint = "http://system.maxpower-ar.com/sol";

                    client.httpMethod = httpVerb.GET;

                    string resp = string.Empty;

                    resp = client.makeRequest();
                    if (resp == "0")
                    {
                        MessageBox.Show("SQL ERROR (Cod. 0)");
                        err = true;
                    }
                    else if (resp == "6")
                    {
                        err = true;
                        MessageBox.Show("No existen los registros buscados (Cod. 6)");
                    }
                    else if (resp == "9")
                    {
                        err = true;
                        MessageBox.Show("No existen registros (Cod. 9)");
                    }
                    json = JToken.Parse(resp);
                    if (json.Type != JTokenType.Array)
                    {
                        err = true;
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(ord))
                    {
                        client.endPoint = "http://system.maxpower-ar.com/sol/" + ord;

                        client.httpMethod = httpVerb.GET;

                        string resp = string.Empty;

                        resp = client.makeRequest();
                        if (resp == "0")
                        {
                            MessageBox.Show("SQL ERROR (Cod. 0)");
                            err = true;
                        }
                        else if (resp == "6")
                        {
                            err = true;
                            MessageBox.Show("No existen los registros buscados (Cod. 6)");
                        }
                        else if (resp == "7")
                        {
                            MessageBox.Show("No existen registros (Cod. 7)");
                            err = true;
                        }

                        json = JToken.Parse(resp);
                        if (json.Type != JTokenType.Array)
                        {
                            err = true;
                        }
                    }
                    else if (!string.IsNullOrEmpty(ent))
                    {
                        client.endPoint = "http://system.maxpower-ar.com/sol/emp/" + ent;
                        Console.WriteLine("aa");
                        client.httpMethod = httpVerb.GET;

                        string resp = string.Empty;

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
                        else if (resp == "8")
                        {
                            MessageBox.Show("No existen registros (Cod. 8)");
                            err = true;
                        }

                        json = JToken.Parse(resp);
                        if (json.Type != JTokenType.Array)
                        {
                            err = true;

                        }
                    }

                    entBox.Text = string.Empty;
                    ordBox.Text = string.Empty;

                }
                dbOrdExt1.Hide();
                dbSolicitudesUC1.Hide();
                dbVentProd1.Hide();
                dbEnterprise1.Hide();
                dbTecAsist1.Hide();
                if (!err)
                {
                    if (json.Count() == 1)
                    {
                        leftBut.Visible = false;
                        leftLab.Visible = false;
                        rightBut.Visible = false;
                        rightLab.Visible = false;
                    }
                    else
                    {
                        leftBut.Visible = true;
                        leftLab.Text = (dbSolicitudesUC1.Index + 1).ToString();
                        leftLab.Visible = true;
                        rightBut.Visible = true;
                        rightLab.Text = json.Count().ToString();
                        rightLab.Visible = true;
                    }

                    dbSolicitudesUC1.json = json;
                    dbSolicitudesUC1.Index = 0;
                    dbSolicitudesUC1.changeVal();
                    dbSolicitudesUC1.Show();
                    dbSolicitudesUC1.BringToFront();
                }


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
            dbSolicitudesUC1.Hide();
            newSearch.Visible = false;

            leftBut.Visible = false;
            rightBut.Visible = false;
            leftLab.Visible = false;
            rightLab.Visible = false;

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

        private void antReg(object sender, MouseEventArgs e)
        {
            string view = cmbDb.Text;

            if (view == "Orden de compra exterior" || view == "Orden de compra nacional")
            {
                if(dbOrdExt1.Index > 0)
                {
                    dbOrdExt1.Index -= 1;
                    leftLab.Text = (dbOrdExt1.Index + 1).ToString();
                    dbOrdExt1.changeVal(view);
                }
                
            }
            else if(view == "Cot. Asistencia técnica")
            {
                if (dbTecAsist1.Index > 0)
                {
                    dbTecAsist1.Index -= 1;
                    leftLab.Text = (dbTecAsist1.Index + 1).ToString();
                    dbTecAsist1.changeVal();
                }
            }
            else if(view == "Cot. Reparación de laboratorio" || view == "Cot. Venta de productos")
            {
                if (dbVentProd1.Index > 0)
                {
                    dbVentProd1.Index -= 1;
                    leftLab.Text = (dbVentProd1.Index + 1).ToString();
                    dbVentProd1.changeVal(view);
                }
            }
            else if(view == "Empresas")
            {
                if (dbEnterprise1.Index > 0)
                {
                    dbEnterprise1.Index -= 1;
                    leftLab.Text = (dbEnterprise1.Index + 1).ToString();
                    dbEnterprise1.changeVal();
                }
            }
            else if (view == "Solicitudes")
            {
                if (dbVentProd1.Index > 0)
                {
                    dbSolicitudesUC1.Index -= 1;
                    leftLab.Text = (dbSolicitudesUC1.Index + 1).ToString();
                    dbSolicitudesUC1.changeVal();
                }
            }
        }

        private void RightBut_MouseClick(object sender, MouseEventArgs e)
        {
            string view = cmbDb.Text;

            if (view == "Orden de compra exterior" || view == "Orden de compra nacional")
            {
                if (dbOrdExt1.Index < dbOrdExt1.json.Count()-1)
                {
                    dbOrdExt1.Index += 1;
                    leftLab.Text = (dbOrdExt1.Index + 1).ToString();
                    dbOrdExt1.changeVal(view);
                }

            }
            else if (view == "Cot. Asistencia técnica")
            {
                if (dbTecAsist1.Index < dbTecAsist1.json.Count() - 1)
                {
                    dbTecAsist1.Index += 1;
                    leftLab.Text = (dbTecAsist1.Index + 1).ToString();
                    dbTecAsist1.changeVal();
                }
            }
            else if (view == "Cot. Reparación de laboratorio" || view == "Cot. Venta de productos")
            {
                if (dbVentProd1.Index < dbVentProd1.json.Count() - 1)
                {
                    dbVentProd1.Index += 1;
                    leftLab.Text = (dbVentProd1.Index + 1).ToString();
                    dbVentProd1.changeVal(view);
                }
            }
            else if(view == "Empresas")
            {
                if (dbEnterprise1.Index < dbEnterprise1.json.Count() - 1)
                {
                    dbEnterprise1.Index += 1;
                    leftLab.Text = (dbEnterprise1.Index + 1).ToString();
                    dbEnterprise1.changeVal();
                }
            }
            else if (view == "Solicitudes")
            {
                if (dbSolicitudesUC1.Index < dbSolicitudesUC1.json.Count() - 1)
                {
                    dbSolicitudesUC1.Index += 1;
                    leftLab.Text = (dbSolicitudesUC1.Index + 1).ToString();
                    dbSolicitudesUC1.changeVal();
                }
            }
        }

    }
}
