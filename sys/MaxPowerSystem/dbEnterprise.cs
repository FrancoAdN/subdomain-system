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
    public partial class dbEnterprise : UserControl
    {
        public dbEnterprise()
        {
            InitializeComponent();
        }

        public void changeVal(string emp, string cuit, string dir, string loc, string web, string telcom,
            string rub, string desc_rub, string mail, string mailB, string tel, string telB, string cont, string contB)
        {
            labEmp.Text = emp;
            labCuit.Text = cuit;
            labDir.Text = dir;
            labLoc.Text = loc;
            labWeb.Text = web;
            labTelCom.Text = telcom;
            labRub.Text = rub;
            labDescRub.Text = desc_rub;
            labMail.Text = mail;
            labMailB.Text = mailB;
            labTel.Text = tel;
            labTelB.Text = telB;
            groupCont.Text = cont;
            groupContB.Text = contB;
        }

        private void LabDescRub_Click(object sender, EventArgs e)
        {
            MessageBox.Show(labDescRub.Text);
        }
    }
}
