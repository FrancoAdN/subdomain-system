namespace MaxPowerSystem
{
    partial class repProdUC
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
            this.maxPlBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.agregarProd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DescBox = new System.Windows.Forms.TextBox();
            this.CantBox = new System.Windows.Forms.TextBox();
            this.UnitPrBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EntBox = new System.Windows.Forms.TextBox();
            this.PayBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonWordFile = new System.Windows.Forms.Button();
            this.EntregaBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maxPlBox
            // 
            this.maxPlBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.maxPlBox.Location = new System.Drawing.Point(216, 251);
            this.maxPlBox.Multiline = true;
            this.maxPlBox.Name = "maxPlBox";
            this.maxPlBox.Size = new System.Drawing.Size(88, 25);
            this.maxPlBox.TabIndex = 53;
            this.maxPlBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxPlBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.notNumberCheck);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.Location = new System.Drawing.Point(16, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 18);
            this.label8.TabIndex = 54;
            this.label8.Text = "Plazo máximo de entrega:";
            // 
            // agregarProd
            // 
            this.agregarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.agregarProd.Location = new System.Drawing.Point(554, 187);
            this.agregarProd.Name = "agregarProd";
            this.agregarProd.Size = new System.Drawing.Size(129, 29);
            this.agregarProd.TabIndex = 50;
            this.agregarProd.Text = "Agregar producto";
            this.agregarProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarProd.UseVisualStyleBackColor = true;
            this.agregarProd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addProduct);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label7.Location = new System.Drawing.Point(456, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 18);
            this.label7.TabIndex = 49;
            this.label7.Text = "Detalle de venta:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.90278F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.09722F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.Controls.Add(this.DescBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CantBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.UnitPrBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(459, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.82888F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.17112F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(359, 135);
            this.tableLayoutPanel1.TabIndex = 48;
            // 
            // DescBox
            // 
            this.DescBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.DescBox.Location = new System.Drawing.Point(79, 51);
            this.DescBox.Multiline = true;
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(164, 81);
            this.DescBox.TabIndex = 34;
            // 
            // CantBox
            // 
            this.CantBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CantBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CantBox.Location = new System.Drawing.Point(3, 51);
            this.CantBox.Multiline = true;
            this.CantBox.Name = "CantBox";
            this.CantBox.Size = new System.Drawing.Size(70, 81);
            this.CantBox.TabIndex = 33;
            this.CantBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CantBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.notNumberCheck);
            // 
            // UnitPrBox
            // 
            this.UnitPrBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnitPrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.UnitPrBox.Location = new System.Drawing.Point(249, 51);
            this.UnitPrBox.Multiline = true;
            this.UnitPrBox.Name = "UnitPrBox";
            this.UnitPrBox.Size = new System.Drawing.Size(107, 81);
            this.UnitPrBox.TabIndex = 35;
            this.UnitPrBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UnitPrBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.notNumberCheck);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 48);
            this.label3.TabIndex = 35;
            this.label3.Text = "Cantidad";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(79, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 48);
            this.label4.TabIndex = 36;
            this.label4.Text = "Descripción";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(249, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 48);
            this.label6.TabIndex = 37;
            this.label6.Text = "Precio Unitario (USD)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EntBox
            // 
            this.EntBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.EntBox.Location = new System.Drawing.Point(19, 38);
            this.EntBox.Multiline = true;
            this.EntBox.Name = "EntBox";
            this.EntBox.Size = new System.Drawing.Size(285, 25);
            this.EntBox.TabIndex = 47;
            // 
            // PayBox
            // 
            this.PayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.PayBox.Location = new System.Drawing.Point(19, 187);
            this.PayBox.Multiline = true;
            this.PayBox.Name = "PayBox";
            this.PayBox.Size = new System.Drawing.Size(285, 48);
            this.PayBox.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(16, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 18);
            this.label5.TabIndex = 46;
            this.label5.Text = "Condiciones de pago:";
            // 
            // buttonWordFile
            // 
            this.buttonWordFile.AutoSize = true;
            this.buttonWordFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonWordFile.Location = new System.Drawing.Point(311, 296);
            this.buttonWordFile.Name = "buttonWordFile";
            this.buttonWordFile.Size = new System.Drawing.Size(238, 31);
            this.buttonWordFile.TabIndex = 55;
            this.buttonWordFile.Text = "Generar cotización de reparación";
            this.buttonWordFile.UseVisualStyleBackColor = true;
            this.buttonWordFile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.genWord);
            // 
            // EntregaBox
            // 
            this.EntregaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.EntregaBox.Location = new System.Drawing.Point(19, 100);
            this.EntregaBox.Multiline = true;
            this.EntregaBox.Name = "EntregaBox";
            this.EntregaBox.Size = new System.Drawing.Size(285, 48);
            this.EntregaBox.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 18);
            this.label2.TabIndex = 45;
            this.label2.Text = "Entrega del material:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 44;
            this.label1.Text = "Empresa:";
            // 
            // repProdUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.maxPlBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.agregarProd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.EntBox);
            this.Controls.Add(this.PayBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonWordFile);
            this.Controls.Add(this.EntregaBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "repProdUC";
            this.Size = new System.Drawing.Size(920, 330);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox maxPlBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button agregarProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox DescBox;
        private System.Windows.Forms.TextBox CantBox;
        private System.Windows.Forms.TextBox UnitPrBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EntBox;
        private System.Windows.Forms.TextBox PayBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonWordFile;
        private System.Windows.Forms.TextBox EntregaBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
