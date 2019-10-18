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
    public partial class dbEnterprise : UserControl
    {
        public JToken json;
        public int Index;
        public dbEnterprise()
        {
            InitializeComponent();
        }

        public void changeVal()
        {
            labEmp.Text = (String)json[Index]["emp"];
            labCuit.Text = (String)json[Index]["cuit"];
            labDir.Text = (String)json[Index]["dir"];
            labLoc.Text = (String)json[Index]["loc"];
            labWeb.Text = (String)json[Index]["web"];
            labTelCom.Text = (String)json[Index]["telcom"];
            labRub.Text = (String)json[Index]["rub"];
            labDescRub.Text = (String)json[Index]["descrub"];
            labMail.Text = (String)json[Index]["mail"];
            labMailB.Text = (String)json[Index]["mailb"];
            labTel.Text = (String)json[Index]["tel"];
            labTelB.Text = (String)json[Index]["telb"];
            groupCont.Text = (String)json[Index]["cont"];
            groupContB.Text = (String)json[Index]["contb"];
        }

        private void LabDescRub_Click(object sender, EventArgs e)
        {
            MessageBox.Show(labDescRub.Text);
        }
    }
}
