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
    public partial class solicitudesUC : UserControl
    {
        public solicitudesUC()
        {
            InitializeComponent();
        }

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            string prec = boxPrec.Text;
            string cli = boxCli.Text;
            string desc = boxDesc.Text;

            if (string.IsNullOrEmpty(prec) || string.IsNullOrEmpty(cli) || string.IsNullOrEmpty(desc))
                MessageBox.Show("Debe completar todos los campos para poder guardar la solicitud.");
            else
            {
                boxDesc.Text = string.Empty;
                boxCli.Text = string.Empty;
                boxPrec.Text = string.Empty;
                //MessageBox.Show("Debe completar todos los campos para poder guardar la solicitud.");
            }
                
                
            
        }
    }
}
