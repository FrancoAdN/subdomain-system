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
    public partial class NotificacionesUC : UserControl
    {
        public TableLayoutPanel panel = new TableLayoutPanel();
        public NotificacionesUC()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            bool err = false;
            JToken json = "";
            clientREST client = new clientREST();

            client.endPoint = "http://system.maxpower-ar.com/notif";

            client.httpMethod = httpVerb.GET;

            string resp = string.Empty;

            resp = client.makeRequest();


            json = JToken.Parse(resp);
            if (json.Type == JTokenType.Array)
            {
                Controls.Remove(panel);
                panel.Location = new System.Drawing.Point(100, 60);
                panel.Size = new Size(800, 400);
                panel.MaximumSize = new Size(800, 400);
                panel.AutoScroll = true;

                panel.ColumnCount = 4;
                panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
                panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
                panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
                panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));

                panel.RowCount = json.Count() + 1;
                panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                panel.Controls.Clear();

                Label cod = new Label();
                cod.Text = "Código";
                cod.AutoSize = true;
                cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                cod.TextAlign = ContentAlignment.TopCenter;

                Label descr = new Label();
                descr.Text = "Descripción";
                descr.AutoSize = true;
                descr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                descr.TextAlign = ContentAlignment.TopCenter;

                Label tipo = new Label();
                tipo.Text = "Tipo";
                tipo.AutoSize = true;
                tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                tipo.TextAlign = ContentAlignment.TopCenter;

                Label orden = new Label();
                orden.Text = "Orden";
                orden.AutoSize = true;
                orden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                orden.TextAlign = ContentAlignment.TopCenter;

                panel.Controls.Add(cod, 0, 0);
                panel.Controls.Add(descr, 1, 0);
                panel.Controls.Add(tipo, 2, 0);
                panel.Controls.Add(orden, 3, 0);

                for (int i = 1; i < panel.RowCount; i++)
                {


                    int ncod = (int)json[i - 1]["cod"];

                    Label codText = new Label();
                    codText.Text = ncod.ToString();
                    codText.AutoSize = false;
                    //codText.TextAlign = ContentAlignment.MiddleCenter;
                    panel.Controls.Add(codText, 0, i);


                    Label descText = new Label();
                    string d = string.Empty;
                    if (ncod == 0)
                        d = "Entrega tarde.";
                    else if (ncod == 1)
                        d = "Día de entrega.";
                    else if (ncod == 2)
                        d = "Día anterior a la entrega.";
                    else if (ncod == 3)
                        d = "El plazo máximo de entrega fue excedido pero la orden no fue confirmada.";
                    else if (ncod == 4)
                        d = "Falta una semana para la entrega.";
                    else if (ncod == 5)
                        d = "Faltan 5 días para la entrega.";

                    descText.Text = d;
                    descText.AutoSize = true;
                    descText.TextAlign = ContentAlignment.MiddleCenter;
                    panel.Controls.Add(descText, 1, i);

                    Label tipoText = new Label();
                    string db = string.Empty;
                    string idb = (String)json[i - 1]["db"];
                    if (idb == "venta_prod")
                        db = "Cot. Venta de productos";
                    else if (idb == "rep_lab")
                        db = "Cot. Reparación de laboratorio";
                    else if (idb == "asis_tec")
                        db = "Cot. Asistencia técnica";
                    else if (idb == "ord_nac")
                        db = "Orden de compra nacional";
                    else if (idb == "ord_ext")
                        db = "Orden de compra exterior";

                    tipoText.Text = db;
                    tipoText.AutoSize = true;
                   // tipoText.TextAlign = ContentAlignment.MiddleCenter;
                    panel.Controls.Add(tipoText, 2, i);


                    Label ordText = new Label();
                    ordText.Text = (String)json[i - 1]["orden"];
                    ordText.AutoSize = true;
                    //ordText.TextAlign = ContentAlignment.MiddleCenter;
                    panel.Controls.Add(ordText, 3, i);


                }



                Controls.Add(panel);
            }

            
        }

        private void infoNot_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Pestaña donde se recibiran las notificaciones correspondientes a los procesos y/o tareas que se encuentren realizadas, esten pendientes o requieran de atencion de un usuario provenientes de MaxPower System.");
        }
    }
}
