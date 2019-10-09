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
    public partial class repProdUC : UserControl
    {
        private List<Detalle> productos = new List<Detalle>();

        internal List<Detalle> Productos { get => productos; set => productos = value; }
        public repProdUC()
        {
            InitializeComponent();
        }
 

        private void addProduct(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CantBox.Text) &&
                !string.IsNullOrEmpty(DescBox.Text) &&
                !string.IsNullOrEmpty(UnitPrBox.Text))
            {

                int cant = int.Parse(CantBox.Text);
                string desc = DescBox.Text;
                int price = int.Parse(UnitPrBox.Text);



                Productos.Add(new Detalle(cant.ToString(), desc, price.ToString(), (cant * price).ToString())); ;

                CantBox.Text = "";
                DescBox.Text = "";
                UnitPrBox.Text = "";
            }
            else
            {
                MessageBox.Show("Es necesario completar todos los campos para agregar un producto.");
            }

        }

        

        private void notNumberCheck(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan numeros");
            }
        }

        private void genWord(object sender, MouseEventArgs e)
        {
            object temp = @"C:\Users\User\Desktop\sys\MaxPowerSystem\static\temp_rep_prod.docx";
            object SaveAs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MaxPowerSystem\MaxPowerSystem\Reparación de laboratorio\test_rep.docx";
            if (Productos.Count > 0 &&
               !string.IsNullOrEmpty(EntBox.Text) &&
               !string.IsNullOrEmpty(EntregaBox.Text) &&
               !string.IsNullOrEmpty(PayBox.Text) &&
               !string.IsNullOrEmpty(maxPlBox.Text))
            {
                int precio = 0;
                foreach (Detalle d in Productos)
                {
                    int n;
                    bool isNumber = int.TryParse(d.Total, out n);
                    if (isNumber)
                        precio += n;
                }

                Form1 F1 = new Form1();
                Productos.Add(new Detalle("Cant.", "Descripción", "Precio unitario USD", "Precio Total USD"));
                try
                {
                    F1.CreateTableWord(temp, SaveAs, Productos, 3);
                }catch(Exception ex)
                {
                    MessageBox.Show("Error al generar el archivo (Cod. 4)");
                }

                
                Productos.Clear();



                List<Files> data = new List<Files>();
                data.Add(new Files(EntBox.Text, "<empresa>"));
                data.Add(new Files(precio.ToString(), "<precio>"));
                data.Add(new Files(EntregaBox.Text, "<entrega>"));
                data.Add(new Files(PayBox.Text, "<formadepago>"));
                data.Add(new Files(maxPlBox.Text, "<plazomax>"));

                bool done = false;
                try
                {
                    done = F1.CreateWordDocument(SaveAs, SaveAs, data);
                }catch(Exception ex)
                {
                    MessageBox.Show("Error al generar el archivo (Cod. 4)");
                }
                

                if (done)
                {
                    EntBox.Text = "";
                    EntregaBox.Text = "";
                    PayBox.Text = "";
                    maxPlBox.Text = "";

                }

            }
            else
            {
                MessageBox.Show("Todo los campos deben estar completos");
            }
        }
    }

}

