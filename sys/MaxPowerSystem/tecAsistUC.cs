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
    public partial class tecAsistUC : UserControl
    {
        public tecAsistUC()
        {
            InitializeComponent();
        }



        private void ButtonWordFile_Click(object sender, EventArgs e)
        {
            
            string detail = labPor.Text +" "+ boxDays.Text +" "+ labDay.Text +" "+ boxHours.Text +" "+ labAsist.Text +" "+ labTec.Text +" "+ labForAsist.Text +" "+ boxDetalle.Text; 
            Form1 F1= new Form1();
            
            if(!string.IsNullOrEmpty(boxEnterprise.Text) && 
                !string.IsNullOrEmpty(boxAsist.Text) &&
                !string.IsNullOrEmpty(boxPrice.Text) &&
                !string.IsNullOrEmpty(boxForm.Text) &&
                !string.IsNullOrEmpty(boxDays.Text) &&
                !string.IsNullOrEmpty(boxHours.Text) &&
                !string.IsNullOrEmpty(boxDetalle.Text))
            {
                List<Files> data = new List<Files>();
                data.Add(new Files(boxEnterprise.Text, "<empresa>"));
                data.Add(new Files(boxAsist.Text, "<asistencia>"));
                data.Add(new Files(detail, "<detalle>"));
                data.Add(new Files(boxPrice.Text, "<precio>"));
                data.Add(new Files(boxForm.Text, "<formadepago>"));

                string filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MaxPowerSystem\MaxPowerSystem\Asistencia Técnica\asist_tec.docx";
                bool done = false;

                try
                {
                    done = F1.CreateWordDocument(@"C:\Users\User\Desktop\sys\MaxPowerSystem\static\temp_asist_tec.docx", filepath, data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el archivo (Cod. 4)");

                }

               
                if (done)
                {
                    boxEnterprise.Text = "";
                    boxAsist.Text = "";
                    boxPrice.Text = "";
                    boxForm.Text = "";
                    boxDays.Text = "";
                    boxHours.Text = "";
                    boxDetalle.Text = "";
                    boxDays.Text = "";
                    boxHours.Text = "";

                }

            }
            else
            {
                MessageBox.Show("Todo los campos deben estar completos");
            }

        }


        private void BoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan numeros");
            }
        }

        private void BoxDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan numeros");
            }
        }

        private void BoxHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan numeros");
            }
        }
    }
}
