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
    public partial class dbOrdConf : UserControl
    {
        public string db;
        public JToken json;
        public int Index;
        public TableLayoutPanel panel = new TableLayoutPanel();
        public dbOrdConf()
        {
            InitializeComponent();
        }

        public void changeVal(string indb)
        {
            int i = 0;
            Controls.Remove(panel);
            panel.Location = new System.Drawing.Point(265, 40);
            panel.Size = new Size(375, 100);
            panel.MaximumSize = new Size(375, 100);
            panel.AutoScroll = true;

            panel.ColumnCount = 4;
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.5F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.5F));

            panel.RowCount = json[Index]["tabla"].Count() + 1;
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

                Label ordText = new Label();
                ordText.Text = (String)json[Index][i - 1]["orden"];
                ordText.AutoSize = false;
                ordText.TextAlign = ContentAlignment.MiddleCenter;
                panel.Controls.Add(ordText, 0, i);


                Label empText = new Label();
                empText.Text = (String)json[Index][i - 1]["emp"];
                empText.AutoSize = true;
                empText.TextAlign = ContentAlignment.MiddleCenter;
                panel.Controls.Add(empText, 1, i);

                Label dateText = new Label();
                dateText.Text = (String)json[Index][i - 1]["date"];
                dateText.AutoSize = true;
                dateText.TextAlign = ContentAlignment.MiddleCenter;
                panel.Controls.Add(dateText, 2, i);

                Label pmdeText = new Label();
                pmdeText.Text = (String)json[Index][i - 1]["pmde"];
                pmdeText.AutoSize = false;
                pmdeText.TextAlign = ContentAlignment.MiddleCenter;
                panel.Controls.Add(pmdeText, 3, i);
            }

            Controls.Add(panel);

        }

        private void date_click(object sender, MouseEventArgs e)
        {
            MessageBox.Show(labDate.Text);
        }

        private void regen_file(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Regen file " + db);
        }
    }
}
