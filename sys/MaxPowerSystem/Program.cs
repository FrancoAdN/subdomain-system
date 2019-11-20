using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxPowerSystem
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            string doc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MaxPowerSystem";
            if (!Directory.Exists(doc))
            {
                
                Directory.CreateDirectory(doc + @"\MaxPowerSystem\Asistencia Técnica");
                Directory.CreateDirectory(doc + @"\MaxPowerSystem\Reparación de laboratorio");
                Directory.CreateDirectory(doc + @"\MaxPowerSystem\Venta de productos");
                Directory.CreateDirectory(doc + @"\MaxPowerSystem\Orden de compra exterior");
                Directory.CreateDirectory(doc + @"\MaxPowerSystem\Orden de compra nacional");
                /*Directory.CreateDirectory(doc + @"\MaxPowerSystem\Cotización");
                Directory.CreateDirectory(doc + @"\MaxPowerSystem\Facturación");
                Directory.CreateDirectory(doc + @"\MaxPowerSystem\Cobranzas");
                Directory.CreateDirectory(doc + @"\MaxPowerSystem\Finanzas");*/


            }
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
<<<<<<< HEAD
            Application.Run(new Form1());
=======
            //Application.Run(new Form1());
            Application.Run(new FormArticulos());
>>>>>>> b78a56a9d154b0f4ad156ca4972178baefc6ba77
        }
    }
}
