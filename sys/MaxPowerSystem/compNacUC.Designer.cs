namespace MaxPowerSystem
{
    partial class compNacUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(compNacUC));
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
            this.buttonWordFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.combMon = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combForm = new System.Windows.Forms.ComboBox();
            this.maxPlBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxRefOrd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // agregarProd
            // 
            this.agregarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.agregarProd.ForeColor = System.Drawing.Color.Black;
            this.agregarProd.Location = new System.Drawing.Point(533, 228);
            this.agregarProd.Name = "agregarProd";
            this.agregarProd.Size = new System.Drawing.Size(129, 29);
            this.agregarProd.TabIndex = 64;
            this.agregarProd.Text = "Agregar producto";
            this.agregarProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarProd.UseVisualStyleBackColor = true;
            this.agregarProd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addProduct);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(435, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 18);
            this.label7.TabIndex = 63;
            this.label7.Text = "Detalle de compra:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.90278F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.09722F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel1.Controls.Add(this.DescBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CantBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.UnitPrBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(438, 84);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.82888F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.17112F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(359, 135);
            this.tableLayoutPanel1.TabIndex = 62;
            // 
            // DescBox
            // 
            this.DescBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.DescBox.Location = new System.Drawing.Point(75, 51);
            this.DescBox.Multiline = true;
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(154, 81);
            this.DescBox.TabIndex = 34;
            // 
            // CantBox
            // 
            this.CantBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CantBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CantBox.Location = new System.Drawing.Point(3, 51);
            this.CantBox.Multiline = true;
            this.CantBox.Name = "CantBox";
            this.CantBox.Size = new System.Drawing.Size(66, 81);
            this.CantBox.TabIndex = 33;
            this.CantBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CantBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.notNumberCheck);
            // 
            // UnitPrBox
            // 
            this.UnitPrBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnitPrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.UnitPrBox.Location = new System.Drawing.Point(235, 51);
            this.UnitPrBox.Multiline = true;
            this.UnitPrBox.Name = "UnitPrBox";
            this.UnitPrBox.Size = new System.Drawing.Size(121, 81);
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
            this.label3.Size = new System.Drawing.Size(66, 48);
            this.label3.TabIndex = 35;
            this.label3.Text = "Cantidad";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(75, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 48);
            this.label4.TabIndex = 36;
            this.label4.Text = "Descripción";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(235, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 48);
            this.label6.TabIndex = 37;
            this.label6.Text = "Precio Unitario";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EntBox
            // 
            this.EntBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.EntBox.Location = new System.Drawing.Point(60, 68);
            this.EntBox.Multiline = true;
            this.EntBox.Name = "EntBox";
            this.EntBox.Size = new System.Drawing.Size(285, 25);
            this.EntBox.TabIndex = 61;
            // 
            // buttonWordFile
            // 
            this.buttonWordFile.AutoSize = true;
            this.buttonWordFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWordFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonWordFile.ForeColor = System.Drawing.Color.Black;
            this.buttonWordFile.Location = new System.Drawing.Point(280, 340);
            this.buttonWordFile.Name = "buttonWordFile";
            this.buttonWordFile.Size = new System.Drawing.Size(203, 31);
            this.buttonWordFile.TabIndex = 67;
            this.buttonWordFile.Text = "Generar compra nacional";
            this.buttonWordFile.UseVisualStyleBackColor = true;
            this.buttonWordFile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.genWord);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 60;
            this.label1.Text = "Empresa:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 221);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 113;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(15, 172);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.TabIndex = 112;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(15, 112);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 111;
            this.pictureBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(57, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 18);
            this.label9.TabIndex = 110;
            this.label9.Text = "Moneda:";
            // 
            // combMon
            // 
            this.combMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.combMon.FormattingEnabled = true;
            this.combMon.Items.AddRange(new object[] {
            "USD",
            "EUROS",
            "ARS"});
            this.combMon.Location = new System.Drawing.Point(133, 178);
            this.combMon.Name = "combMon";
            this.combMon.Size = new System.Drawing.Size(212, 26);
            this.combMon.TabIndex = 109;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(57, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 18);
            this.label5.TabIndex = 108;
            this.label5.Text = "Forma de pago:";
            // 
            // combForm
            // 
            this.combForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.combForm.FormattingEnabled = true;
            this.combForm.Items.AddRange(new object[] {
            "Cheque 30 días",
            "Cheque 15 días",
            "Transferencia bancaria",
            "Contado efectivo"});
            this.combForm.Location = new System.Drawing.Point(60, 133);
            this.combForm.Name = "combForm";
            this.combForm.Size = new System.Drawing.Size(285, 26);
            this.combForm.TabIndex = 107;
            // 
            // maxPlBox
            // 
            this.maxPlBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.maxPlBox.Location = new System.Drawing.Point(257, 228);
            this.maxPlBox.Multiline = true;
            this.maxPlBox.Name = "maxPlBox";
            this.maxPlBox.Size = new System.Drawing.Size(88, 25);
            this.maxPlBox.TabIndex = 105;
            this.maxPlBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(57, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 18);
            this.label8.TabIndex = 106;
            this.label8.Text = "Plazo máximo de entrega:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 114;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(240, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 23);
            this.label2.TabIndex = 116;
            this.label2.Text = "Orden de compra Nacional";
            // 
            // BoxRefOrd
            // 
            this.BoxRefOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxRefOrd.Location = new System.Drawing.Point(208, 279);
            this.BoxRefOrd.Name = "BoxRefOrd";
            this.BoxRefOrd.Size = new System.Drawing.Size(137, 24);
            this.BoxRefOrd.TabIndex = 119;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(57, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 18);
            this.label10.TabIndex = 120;
            this.label10.Text = "Referencia de orden:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Location = new System.Drawing.Point(15, 275);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.TabIndex = 121;
            this.pictureBox5.TabStop = false;
            // 
            // compNacUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BoxRefOrd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.combMon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combForm);
            this.Controls.Add(this.maxPlBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.agregarProd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.EntBox);
            this.Controls.Add(this.buttonWordFile);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "compNacUC";
            this.Size = new System.Drawing.Size(920, 400);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button buttonWordFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combMon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combForm;
        private System.Windows.Forms.TextBox maxPlBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BoxRefOrd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}
