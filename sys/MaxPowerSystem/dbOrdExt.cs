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
    public partial class dbOrdExt : UserControl
    {
        public string db;
        public JToken json;
        public dbOrdExt()
        {
            InitializeComponent();
        }
        public void chInco(string str)
        {
            labInco.Text = str;
           
        }
        public void changeVal(string indb)
        {
            int i = 0;
            TableLayoutPanel panel = new TableLayoutPanel();
            panel.Location = new System.Drawing.Point(265, 40);
            panel.Size = new Size(375, 130);
            panel.MaximumSize = new Size(375, 130);
            panel.AutoScroll = true;

            panel.ColumnCount = 4;
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.5F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.5F));

            panel.RowCount = json["tabla"].Count() + 1;
            panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            Label cant = new Label();
            cant.Text = "Cant";
            cant.AutoSize = true;
            cant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cant.TextAlign = ContentAlignment.MiddleCenter;

            Label desc = new Label();
            desc.Text = "Descripción";
            desc.AutoSize = true;
            desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            desc.TextAlign = ContentAlignment.MiddleCenter;

            Label pu = new Label();
            pu.Text = "Precio unitario";
            pu.AutoSize = true;
            pu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pu.TextAlign = ContentAlignment.MiddleCenter;

            Label total = new Label();
            total.Text = "Precio total";
            total.AutoSize = true;
            total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            total.TextAlign = ContentAlignment.MiddleCenter;

            panel.Controls.Add(cant, 0, 0);
            panel.Controls.Add(desc, 1, 0);
            panel.Controls.Add(pu, 2, 0);
            panel.Controls.Add(total, 3, 0);

            for (i = 1; i < panel.RowCount; i++)
            {
                Label cantText = new Label();
                cantText.Text = (String)json["tabla"][i - 1]["cant"];
                int n_cant = (int)json["tabla"][i - 1]["cant"];
                cantText.AutoSize = false;
                cantText.TextAlign = ContentAlignment.MiddleCenter;
                panel.Controls.Add(cantText, 0, i);


                Label descText = new Label();
                descText.Text = (String)json["tabla"][i - 1]["descr"];
                descText.AutoSize = false;
                descText.TextAlign = ContentAlignment.MiddleCenter;
                panel.Controls.Add(descText, 1, i);

                Label punitText = new Label();
                punitText.Text = (String)json["tabla"][i - 1]["punit"];
                int n_punit = (int)json["tabla"][i - 1]["punit"];
                punitText.AutoSize = false;
                punitText.TextAlign = ContentAlignment.MiddleCenter;
                panel.Controls.Add(punitText, 2, i);

                Label totalText = new Label();
                totalText.Text = (n_punit * n_cant).ToString();
                totalText.AutoSize = false;
                totalText.TextAlign = ContentAlignment.MiddleCenter;
                panel.Controls.Add(totalText, 3, i);
                /*for (int j = 0; j < panel.ColumnCount; j++)
                {
                    Label test = new Label();
                    test.Text = i + "" + j;
                    test.AutoSize = false;
                    test.TextAlign = ContentAlignment.MiddleCenter;
                    panel.Controls.Add(test, j, i);
                }*/
            }




            Controls.Add(panel);

            labOrden.Text = (String)json["orden"];
            labValEnt.Text = (String)json["emp"];
            labValInco.Text = (String)json["inco"];
            labValMon.Text = (String)json["mon"];
            labValPmde.Text = (String)json["pmde"] + " días";
            labDate.Text = (String)json["fecha"];
            db = indb;
        }

        private void regen_file(object sender, MouseEventArgs e)
        {
            Console.WriteLine("regen file " + db);
        }

       
    }
}
