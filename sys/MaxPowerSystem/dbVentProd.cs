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
    public partial class dbVentProd : UserControl
    {
        public string db;
        public JToken json;
        public int Index;
        public TableLayoutPanel panel = new TableLayoutPanel();
        public dbVentProd()
        {
            InitializeComponent();
        }

       public void changeVal(string indb)
        {
            int i = 0;
            Controls.Remove(panel);
            panel.Location = new System.Drawing.Point(265, 40);
            panel.Size = new Size(620, 200);
            panel.MaximumSize = new Size(620, 200);
            panel.AutoScroll = true;

            panel.ColumnCount = 4;
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.5F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.5F));

            panel.RowCount = json[Index]["tabla"].Count() + 1;
            panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            panel.Controls.Clear();

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
                cantText.Text = (String)json[Index]["tabla"][i - 1]["cant"];
                int n_cant = (int)json[Index]["tabla"][i - 1]["cant"];
                cantText.AutoSize = false;
                cantText.TextAlign = ContentAlignment.MiddleCenter;
                panel.Controls.Add(cantText, 0, i);


                Label descText = new Label();
                descText.Text = (String)json[Index]["tabla"][i - 1]["descr"];
                descText.AutoSize = true;
                descText.TextAlign = ContentAlignment.MiddleCenter;
                panel.Controls.Add(descText, 1, i);

                Label punitText = new Label();
                punitText.Text = (String)json[Index]["tabla"][i - 1]["punit"];
                int n_punit = (int)json[Index]["tabla"][i - 1]["punit"];
                punitText.AutoSize = false;
                punitText.TextAlign = ContentAlignment.MiddleCenter;
                panel.Controls.Add(punitText, 2, i);  

                Label totalText = new Label();
                totalText.Text = (n_punit * n_cant).ToString();
                totalText.AutoSize = false;
                totalText.TextAlign = ContentAlignment.MiddleCenter;
                panel.Controls.Add(totalText, 3, i);
            }

            Controls.Add(panel);

            labOrden.Text = (String)json[Index]["orden"];
            entLab.Text = (String)json[Index]["emp"];
            edmLab.Text = (String)json[Index]["edm"];
            cdpLab.Text = (String)json[Index]["cdp"];
            pmdeLab.Text = (String)json[Index]["pmde"];
            labDate.Text = (String)json[Index]["fecha"];
            labP.Text = (String)json[Index]["precio"];
            db = indb;
       }

        private void edm_click(object sender, EventArgs e)
        {
            MessageBox.Show(edmLab.Text);
        }

        private void cdp_click(object sender, EventArgs e)
        {
            MessageBox.Show(cdpLab.Text);
        }

        private void ent_click(object sender, MouseEventArgs e)
        {
            MessageBox.Show(entLab.Text);
        }

        private void pmde_click(object sender, MouseEventArgs e)
        {
            MessageBox.Show(pmdeLab.Text);
        }

        private void date_click(object sender, MouseEventArgs e)
        {
            MessageBox.Show(labDate.Text);
        }

        private void regen_file(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Regen file " +db);
        }

        private void cdp_click(object sender, MouseEventArgs e)
        {

        }

        private void edm_click(object sender, MouseEventArgs e)
        {

        }
    }
}
