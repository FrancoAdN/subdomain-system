namespace MaxPowerSystem
{
    partial class agregarArtUC
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.productoCombo = new System.Windows.Forms.ComboBox();
            this.boxCant = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.boxDetalle = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tArtCombo = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Art.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cant.:";
            // 
            // productoCombo
            // 
            this.productoCombo.DropDownHeight = 13;
            this.productoCombo.DropDownWidth = 270;
            this.productoCombo.FormattingEnabled = true;
            this.productoCombo.IntegralHeight = false;
            this.productoCombo.Location = new System.Drawing.Point(373, 72);
            this.productoCombo.Name = "productoCombo";
            this.productoCombo.Size = new System.Drawing.Size(270, 21);
            this.productoCombo.TabIndex = 5;
            this.productoCombo.Enter += new System.EventHandler(this.ProductoCombo_Enter);
            this.productoCombo.Leave += new System.EventHandler(this.ProductoCombo_Leave);
            // 
            // boxCant
            // 
            this.boxCant.Location = new System.Drawing.Point(374, 116);
            this.boxCant.Name = "boxCant";
            this.boxCant.Size = new System.Drawing.Size(63, 20);
            this.boxCant.TabIndex = 6;
            this.boxCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(556, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(648, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Detalle:";
            // 
            // boxDetalle
            // 
            this.boxDetalle.Location = new System.Drawing.Point(89, 116);
            this.boxDetalle.Multiline = true;
            this.boxDetalle.Name = "boxDetalle";
            this.boxDetalle.Size = new System.Drawing.Size(209, 20);
            this.boxDetalle.TabIndex = 11;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(9, 183);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(741, 212);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tipo";
            this.columnHeader1.Width = 154;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Producto";
            this.columnHeader2.Width = 500;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cantidad";
            this.columnHeader3.Width = 83;
            // 
            // tArtCombo
            // 
            this.tArtCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tArtCombo.FormattingEnabled = true;
            this.tArtCombo.Items.AddRange(new object[] {
            "Eléctricos",
            "Electrónicos",
            "Seguridad"});
            this.tArtCombo.Location = new System.Drawing.Point(89, 72);
            this.tArtCombo.Name = "tArtCombo";
            this.tArtCombo.Size = new System.Drawing.Size(209, 21);
            this.tArtCombo.TabIndex = 13;
            this.tArtCombo.SelectedIndexChanged += new System.EventHandler(this.TArtCombo_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(675, 407);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Siguiente >";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(594, 407);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "< Atras";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Agregar Productos";
            // 
            // agregarArtUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tArtCombo);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.boxDetalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boxCant);
            this.Controls.Add(this.productoCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "agregarArtUC";
            this.Size = new System.Drawing.Size(763, 439);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox productoCombo;
        private System.Windows.Forms.TextBox boxCant;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxDetalle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox tArtCombo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
    }
}
