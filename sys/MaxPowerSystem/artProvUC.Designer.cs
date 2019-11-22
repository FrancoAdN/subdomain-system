namespace MaxPowerSystem
{
    partial class artProvUC
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labProd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboProv = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.boxCant = new System.Windows.Forms.TextBox();
            this.boxPrecio = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sigBut = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto:";
            // 
            // labProd
            // 
            this.labProd.AutoSize = true;
            this.labProd.Location = new System.Drawing.Point(74, 18);
            this.labProd.Name = "labProd";
            this.labProd.Size = new System.Drawing.Size(35, 13);
            this.labProd.TabIndex = 1;
            this.labProd.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Proveedores:";
            // 
            // comboProv
            // 
            this.comboProv.FormattingEnabled = true;
            this.comboProv.Location = new System.Drawing.Point(77, 56);
            this.comboProv.Name = "comboProv";
            this.comboProv.Size = new System.Drawing.Size(272, 21);
            this.comboProv.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Plazo:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(620, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(528, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // boxCant
            // 
            this.boxCant.Location = new System.Drawing.Point(273, 112);
            this.boxCant.Name = "boxCant";
            this.boxCant.Size = new System.Drawing.Size(76, 20);
            this.boxCant.TabIndex = 10;
            this.boxCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNum);
            // 
            // boxPrecio
            // 
            this.boxPrecio.Location = new System.Drawing.Point(77, 114);
            this.boxPrecio.Name = "boxPrecio";
            this.boxPrecio.Size = new System.Drawing.Size(84, 20);
            this.boxPrecio.TabIndex = 14;
            this.boxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNum);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(432, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Agregar Proveedor";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(5, 162);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(741, 226);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Proveedor";
            this.columnHeader1.Width = 369;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Precio";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 189;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Plazo de entrega";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 179;
            // 
            // sigBut
            // 
            this.sigBut.Enabled = false;
            this.sigBut.Location = new System.Drawing.Point(671, 404);
            this.sigBut.Name = "sigBut";
            this.sigBut.Size = new System.Drawing.Size(75, 23);
            this.sigBut.TabIndex = 18;
            this.sigBut.Text = "Siguiente >";
            this.sigBut.UseVisualStyleBackColor = true;
            this.sigBut.Click += new System.EventHandler(this.SigBut_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(579, 404);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = "< Atrás";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // artProvUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sigBut);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.boxPrecio);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boxCant);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboProv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labProd);
            this.Controls.Add(this.label1);
            this.Name = "artProvUC";
            this.Size = new System.Drawing.Size(763, 439);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboProv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox boxCant;
        private System.Windows.Forms.TextBox boxPrecio;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button sigBut;
        private System.Windows.Forms.Button button6;
    }
}
