using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxPowerSystem
{
    public partial class FormArticulos : Form
    {
        public FormArticulos()
        {
            InitializeComponent();
        }

        private void FormArticulos_Load(object sender, EventArgs e)
        {
            compArticulosUC1.Show();
            compArticulosUC1.BringToFront();
        }
    }
}
