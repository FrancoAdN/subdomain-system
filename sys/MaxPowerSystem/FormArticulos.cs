﻿using System;
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
        public static string _orden;
        
        public static string Orden
        {
            get // this makes you to access value in form2
            {
                return _orden;
            }
            set // this makes you to change value in form2
            {
                _orden = value;
            }
        }

        public static int _index;

        public static int Index
        {
            get // this makes you to access value in form2
            {
                return _index;
            }
            set // this makes you to change value in form2
            {
                _index = value;
            }
        }
        public static class ListArt
        {
            static List<Articulo> _list; // Static List instance

            static ListArt()
            {
                //
                // Allocate the list.
                //
                _list = new List<Articulo>();
            }

            public static void Record(dynamic a)
            {
                //
                // Record this value in the list.
                //
                _list.Add(new Articulo(a.tipo, a.producto, a.cantidad));
            }

            public static void Display()
            {
                //
                // Write out the results.
                //
                foreach (var value in _list)
                {
                    Console.WriteLine(value.tipo);
                    Console.WriteLine(value.producto);
                    Console.WriteLine(value.cantidad);
                }
            }
            public static object GetArticulos()
            {
                return _list;
            }
            public static void SetArticulos(object ar)
            {
                _list = (List<Articulo>)ar;
            }
        }

        public FormArticulos()
        {
            InitializeComponent();
        }

        private void FormArticulos_Load(object sender, EventArgs e)
        {
            artProvUC1.Hide();
            compArticulosUC1.Show();
            compArticulosUC1.BringToFront();
        }

        public void setOrd()
        {

            agregarArtUC1.Show();
            agregarArtUC1.BringToFront();

        }

        public void openProv()
        {
            artProvUC1.setValues();
            artProvUC1.Show();
            artProvUC1.BringToFront();
        }

    }
}
