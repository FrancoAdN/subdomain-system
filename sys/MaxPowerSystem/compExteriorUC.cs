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
    public partial class compExteriorUC : UserControl
    {
        private List<Detalle> productos = new List<Detalle>();

        internal List<Detalle> Productos { get => productos; set => productos = value; }
        public compExteriorUC()
        {
            InitializeComponent();
        }

        private void BoxRefOrd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(BoxRefOrd.Text))
            {
                CantBox.Enabled = false;
                DescBox.Enabled = false;
                UnitPrBox.Enabled = false;
                agregarProd.Enabled = false;
            }
            else
            {
                CantBox.Enabled = true;
                DescBox.Enabled = true;
                UnitPrBox.Enabled = true;
                agregarProd.Enabled = true;
            }
        }

        private void createBuyO(object sender, MouseEventArgs e)
        {
            object temp = @"C:\Users\User\Desktop\sys\MaxPowerSystem\static\temp_compra_ext.docx";
            object SaveAs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MaxPowerSystem\MaxPowerSystem\Orden de compra exterior\test_comp_ext.docx";
            if ((Productos.Count > 0 || !string.IsNullOrEmpty(BoxRefOrd.Text)) &&
               !string.IsNullOrEmpty(EntBox.Text) &&
               !string.IsNullOrEmpty(combInco.Text) &&
               !string.IsNullOrEmpty(combMon.Text) &&
               !string.IsNullOrEmpty(maxPlBox.Text))
            {
                Form1 F1 = new Form1();

                int precio = 0;
                if (Productos.Count > 0)
                {
                    
                    foreach (Detalle d in Productos)
                    {
                        int n;
                        bool isNumber = int.TryParse(d.Total, out n);
                        if (isNumber)
                            precio += n;
                    }
                    
                    Productos.Add(new Detalle("Cant.", "Descripción", "Precio unitario (" + combMon.Text +")", "Precio Total (" + combMon.Text + ")"));
                    
                    try
                    {
                        F1.CreateTableWord(temp, SaveAs, Productos, 1);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al generar el archivo (Cod. 4)");
                    }
                    Productos.Clear();
                }else
                {
                    Console.WriteLine("AGREGAR DESDE BASE DE DATOS");
                }
                



                List<Files> data = new List<Files>();
                data.Add(new Files(EntBox.Text, "<empresa>"));
                data.Add(new Files(precio.ToString() + " "+ combMon.Text, "<total>"));
                data.Add(new Files(BoxRefOrd.Text, "<ref>"));
                data.Add(new Files(combInco.Text, "<inco>"));
                data.Add(new Files(combMon.Text, "<moneda>"));
                data.Add(new Files(maxPlBox.Text, "<dias>"));
                bool done = false;

                try
                {
                    done = F1.CreateWordDocument(SaveAs, SaveAs, data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el archivo (Cod. 4)");
                }
                

                if (done)
                {
                    EntBox.Text = "";
                    maxPlBox.Text = "";
                    BoxRefOrd.Text = "";
                    combInco.Text = "";
                    combMon.Text = "";

                    BoxRefOrd.Enabled = true;
                    CantBox.Enabled = true;
                    DescBox.Enabled = true;
                    UnitPrBox.Enabled = true;
                    agregarProd.Enabled = true;

                }

            }
            else
            {
                MessageBox.Show("Todo los campos deben estar completos");
            }


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
                BoxRefOrd.Enabled = false;
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

  
    }
}
