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
    public partial class OrdConfUC : UserControl
    {
        clientREST client = new clientREST();
        public OrdConfUC()
        {
            InitializeComponent();

            dbOrdConf1.Hide();
            cmbDb2.SelectedIndex = cmbDb2.Items.Count - 1;


        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool err = false;    
            string ord = ordBox.Text;
            string view = cmbDb2.Text;
           // if (!string.IsNullOrEmpty(ord) && view == "Ordenes a confirmar")



            // nconfirm 
            // confirm

            if (view == "Ordenes a confirmar")
            {

            }


    
        }
    }
}
