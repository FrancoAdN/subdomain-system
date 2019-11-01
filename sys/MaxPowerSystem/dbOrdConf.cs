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
using System.Runtime.Caching;

namespace MaxPowerSystem
{
    public partial class dbOrdConf : UserControl
    {

        public JArray json;
        public bool db;
        public int Index = 0;
        public TableLayoutPanel panel = new TableLayoutPanel();
        public dbOrdConf()
        {
            InitializeComponent();
        }



        public void changeVal()
        {
            
            int i = 0;
            Controls.Remove(panel);
            panel.Location = new System.Drawing.Point(50, 20);
            panel.Size = new Size(800, 400);
            panel.MaximumSize = new Size(800, 400);
            panel.AutoScroll = true;

            panel.ColumnCount = 4;
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.5F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.5F));

            panel.RowCount = json.Count() + 1;
            panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            panel.Controls.Clear();

            Label orden = new Label();
            orden.Text = "Orden";
            orden.AutoSize = true;
            orden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            orden.TextAlign = ContentAlignment.MiddleCenter;

            Label emp = new Label();
            emp.Text = "Empresa";
            emp.AutoSize = true;
            emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emp.TextAlign = ContentAlignment.MiddleCenter;

            Label fecha = new Label();
            fecha.Text = "Fecha";
            fecha.AutoSize = true;
            fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fecha.TextAlign = ContentAlignment.MiddleCenter;

            Label pmde = new Label();
            pmde.Text = "Plazo maximo de entrega";
            pmde.AutoSize = true;
            pmde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pmde.TextAlign = ContentAlignment.MiddleCenter;

            panel.Controls.Add(orden, 0, 0);
            panel.Controls.Add(emp, 1, 0);
            panel.Controls.Add(fecha, 2, 0);
            panel.Controls.Add(pmde, 3, 0);

            for (i = 1; i < panel.RowCount; i++)
            {
                int d = 0;
                string inx = i.ToString();
                if (db)
                     d = (int)json[i - 1]["db"];

                string ordn = (String)json[i - 1]["orden"];

                Label ordText = new Label();
                if (db)
                    ordText.Click += (sender2, e2) => ConfirmOrder(sender2, e2, ordn, d, inx);
                
                ordText.Text = ordn;
                ordText.AutoSize = false;
                ordText.TextAlign = ContentAlignment.MiddleCenter;
                panel.Controls.Add(ordText, 0, i);


                Label empText = new Label();
                if (db)
                    empText.Click += (sender2, e2) => ConfirmOrder(sender2, e2, ordn, d, inx);
               

                empText.Text = (String)json[i - 1]["emp"];
                empText.AutoSize = true;
                empText.TextAlign = ContentAlignment.MiddleCenter;
                panel.Controls.Add(empText, 1, i);

                Label dateText = new Label();
                if (db)
                    dateText.Click += (sender2, e2) => ConfirmOrder(sender2, e2, ordn, d, inx);

                    

                dateText.Text = (String)json[i - 1]["fecha"];
                dateText.AutoSize = true;
                dateText.TextAlign = ContentAlignment.MiddleCenter;
                panel.Controls.Add(dateText, 2, i);


                Label pmdeText = new Label();

                if (db)
                    pmdeText.Click += (sender2, e2) => ConfirmOrder(sender2, e2, ordn, d, inx);

                if (json[i - 1]["pmde"] != null)
                    pmdeText.Text = (String)json[i - 1]["pmde"];
                else
                    pmdeText.Text = "-";

                pmdeText.AutoSize = false;
                pmdeText.TextAlign = ContentAlignment.MiddleCenter;
                panel.Controls.Add(pmdeText, 3, i);
                
                
            }

            Controls.Add(panel);

        }



        public void ConfirmOrder(object sender, EventArgs e, string order, int db, string index)
        {
            
            if (MessageBox.Show("¿Desea confirmar la orden "+ order +"?", "Maxpower System dice: ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                int idx = int.Parse(index);

                clientREST client = new clientREST();

                client.endPoint = "http://system.maxpower-ar.com/confirm";

                client.httpMethod = httpVerb.POST;

                JObject sjson = new JObject();
                sjson["orden"] = order;
                sjson["db"] = db;
                sjson["fecha"] = DateTime.Now.ToString("dd/MM/yyyy");

                client.postJSON = sjson.ToString();

                string resp = string.Empty;

                resp = client.makeRequest();

                if (resp == "0")
                    MessageBox.Show("SQL ERROR (Cod. 0)", "Maxpower System dice: ");
                else if (resp == "13")
                    MessageBox.Show("Error al confirmar la orden (Cod. 13)", "Maxpower System dice: ");
                else if(resp == "1") {
                    json.RemoveAt(idx - 1);
                    this.changeVal();
                }
                    

            }

        }

    }
}
