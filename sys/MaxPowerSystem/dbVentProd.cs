using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxPowerSystem
{
    public partial class dbVentProd : UserControl
    {
        public string db;
        public dbVentProd()
        {
            InitializeComponent();
        }

       public void changeVal(string ord, string ent, string edm, string cdp, string pmde, string date, string indb)
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

            panel.RowCount = 10;
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
                for (int j = 0; j < panel.ColumnCount; j++)
                {
                    Label test = new Label();
                    test.Text = i + "" + j;
                    test.AutoSize = false;
                    test.TextAlign = ContentAlignment.MiddleCenter;
                    panel.Controls.Add(test, j, i);
                }
            }




            Controls.Add(panel);

            labOrden.Text = ord;
            entLab.Text = ent;
            edmLab.Text = edm;
            cdpLab.Text = cdp;
            pmdeLab.Text = pmde;
            labDate.Text = date;
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
    }
}
