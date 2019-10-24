namespace MaxPowerSystem
{
    partial class compExteriorUC
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
            this.buttonWordFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.combInco = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.combMon = new System.Windows.Forms.ComboBox();
            this.BoxRefOrd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maxPlBox
            // 
            this.maxPlBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.maxPlBox.Location = new System.Drawing.Point(216, 243);
            this.maxPlBox.Multiline = true;
            this.maxPlBox.Name = "maxPlBox";
            this.maxPlBox.Size = new System.Drawing.Size(88, 25);
            this.maxPlBox.TabIndex = 49;
            this.maxPlBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxPlBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.notNumberCheck);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.Location = new System.Drawing.Point(16, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 18);
            this.label8.TabIndex = 50;
            this.label8.Text = "Plazo máximo de entrega:";
            // 
            // agregarProd
            // 
            this.agregarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.agregarProd.Location = new System.Drawing.Point(554, 187);
            this.agregarProd.Name = "agregarProd";
            this.agregarProd.Size = new System.Drawing.Size(129, 29);
            this.agregarProd.TabIndex = 48;
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
            this.label7.Size = new System.Drawing.Size(132, 18);
            this.label7.TabIndex = 47;
            this.label7.Text = "Detalle de compra:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.90278F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.09722F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.Controls.Add(this.DescBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CantBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.UnitPrBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(459, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.82888F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.17112F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(359, 135);
            this.tableLayoutPanel1.TabIndex = 46;
            // 
            // DescBox
            // 
            this.DescBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.DescBox.Location = new System.Drawing.Point(77, 51);
            this.DescBox.Multiline = true;
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(159, 81);
            this.DescBox.TabIndex = 34;
            // 
            // CantBox
            // 
            this.CantBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CantBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CantBox.Location = new System.Drawing.Point(3, 51);
            this.CantBox.Multiline = true;
            this.CantBox.Name = "CantBox";
            this.CantBox.Size = new System.Drawing.Size(68, 81);
            this.CantBox.TabIndex = 33;
            this.CantBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CantBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.notNumberCheck);
            // 
            // UnitPrBox
            // 
            this.UnitPrBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnitPrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.UnitPrBox.Location = new System.Drawing.Point(242, 51);
            this.UnitPrBox.Multiline = true;
            this.UnitPrBox.Name = "UnitPrBox";
            this.UnitPrBox.Size = new System.Drawing.Size(114, 81);
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
            this.label3.Size = new System.Drawing.Size(68, 48);
            this.label3.TabIndex = 35;
            this.label3.Text = "Cantidad";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(77, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 48);
            this.label4.TabIndex = 36;
            this.label4.Text = "Descripción";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(242, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 48);
            this.label6.TabIndex = 37;
            this.label6.Text = "Precio Unitario";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EntBox
            // 
            this.EntBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.EntBox.Location = new System.Drawing.Point(19, 40);
            this.EntBox.Multiline = true;
            this.EntBox.Name = "EntBox";
            this.EntBox.Size = new System.Drawing.Size(285, 25);
            this.EntBox.TabIndex = 45;
            // 
            // buttonWordFile
            // 
            this.buttonWordFile.AutoSize = true;
            this.buttonWordFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonWordFile.Location = new System.Drawing.Point(311, 296);
            this.buttonWordFile.Name = "buttonWordFile";
            this.buttonWordFile.Size = new System.Drawing.Size(203, 31);
            this.buttonWordFile.TabIndex = 51;
            this.buttonWordFile.Text = "Generar compra al exterior";
            this.buttonWordFile.UseVisualStyleBackColor = true;
            this.buttonWordFile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.createBuyO);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 44;
            this.label1.Text = "Empresa:";
            // 
            // combInco
            // 
            this.combInco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combInco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.combInco.FormattingEnabled = true;
            this.combInco.Items.AddRange(new object[] {
            "EXW, Ex Works",
            "FCA, Free Carrier",
            "FAS, Free Alongside Ship",
            "FOB, Free On Board",
            "CFR, Cost and Freight",
            "CIF, Cost Insurance and Freight",
            "CPT, Carrier Paid To",
            "CIP, Carriage and Insurance Paid To",
            "DAT, Delivered At Terminal",
            "DAP, Delivered At Place",
            "DDP, Delivered Duty Paid"});
            this.combInco.Location = new System.Drawing.Point(92, 109);
            this.combInco.Name = "combInco";
            this.combInco.Size = new System.Drawing.Size(212, 26);
            this.combInco.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(16, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 55;
            this.label5.Text = "Incoterm:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label9.Location = new System.Drawing.Point(16, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 18);
            this.label9.TabIndex = 57;
            this.label9.Text = "Moneda:";
            // 
            // combMon
            // 
            this.combMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.combMon.FormattingEnabled = true;
            this.combMon.Items.AddRange(new object[] {
            "USD",
            "EUROS",
            "PESOS ARGENTINOS",
            "LIBRA ESTERLINA",
            "REAL BRASILEÑO"});
            this.combMon.Location = new System.Drawing.Point(92, 184);
            this.combMon.Name = "combMon";
            this.combMon.Size = new System.Drawing.Size(212, 26);
            this.combMon.TabIndex = 56;
            // 
            // BoxRefOrd
            // 
            this.BoxRefOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.BoxRefOrd.Location = new System.Drawing.Point(607, 246);
            this.BoxRefOrd.Multiline = true;
            this.BoxRefOrd.Name = "BoxRefOrd";
            this.BoxRefOrd.Size = new System.Drawing.Size(204, 25);
            this.BoxRefOrd.TabIndex = 58;
            this.BoxRefOrd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxRefOrd_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label10.Location = new System.Drawing.Point(456, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 18);
            this.label10.TabIndex = 59;
            this.label10.Text = "Referencia de orden:";
            // 
            // compExteriorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BoxRefOrd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.combMon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combInco);
            this.Controls.Add(this.maxPlBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.agregarProd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.EntBox);
            this.Controls.Add(this.buttonWordFile);
            this.Controls.Add(this.label1);
            this.Name = "compExteriorUC";
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
        private System.Windows.Forms.Button buttonWordFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combInco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combMon;
        private System.Windows.Forms.TextBox BoxRefOrd;
        private System.Windows.Forms.Label label10;
    }
}
