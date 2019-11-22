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
    public partial class artProvUC : UserControl
    {

        List<Articulo> _arts;
        public artProvUC()
        {
            InitializeComponent();
        }

        public void setValues()
        {
            this.Visible = true;
            this.Show();
            this.BringToFront();
            _arts = (List<Articulo>)FormArticulos.ListArt.GetArticulos();
            labProd.Text = _arts[FormArticulos.Index].producto;

        }

    }
}
