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
    public partial class dbTecAsist : UserControl
    {
        public dbTecAsist()
        {
            InitializeComponent();
        }

        private void reg_file(object sender, MouseEventArgs e)
        {
            Form1 F1 = new Form1();

            List<Files> data = new List<Files>();
            data.Add(new Files(labOrden.Text, "<noferta>"));
            data.Add(new Files(entLab.Text, "<empresa>"));
            data.Add(new Files(labDate.Text, "<fecha>"));
            data.Add(new Files(labTdAsist.Text, "<asistencia>"));
            data.Add(new Files(labDet.Text, "<detalle>"));
            data.Add(new Files(labPrice.Text, "<precio>"));
            data.Add(new Files(fdpLab.Text, "<formadepago>"));
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MaxPowerSystem\MaxPowerSystem\Asistencia Técnica\asist_tec.docx";
            bool done = F1.CreateWordDocument(@"C:\Users\User\Desktop\sys\MaxPowerSystem\static\temp_asist_tec.docx", filepath, data);
            if (done)
            {
                this.Hide();
            }
        }


        public void changeVal(string ent, string tda, string price, string fdp, string det, string date, string ord)
        {
            entLab.Text = ent;
            labTdAsist.Text = tda;
            labPrice.Text = price;
            fdpLab.Text = fdp;
            labDet.Text = det;
            labDate.Text = date;
            labOrden.Text = ord;
        }
    }
}
