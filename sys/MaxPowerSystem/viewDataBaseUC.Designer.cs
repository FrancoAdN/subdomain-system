﻿namespace MaxPowerSystem
{
    partial class viewDataBaseUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewDataBaseUC));
            this.cmbDb = new System.Windows.Forms.ComboBox();
            this.countPanel = new System.Windows.Forms.TableLayoutPanel();
            this.leftBut = new System.Windows.Forms.Button();
            this.leftLab = new System.Windows.Forms.Label();
            this.rightLab = new System.Windows.Forms.Label();
            this.rightBut = new System.Windows.Forms.Button();
            this.ordLab = new System.Windows.Forms.Label();
            this.ordBox = new System.Windows.Forms.TextBox();
            this.entBox = new System.Windows.Forms.TextBox();
            this.labEnt = new System.Windows.Forms.Label();
            this.cuitBox = new System.Windows.Forms.TextBox();
            this.labCuit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbOrd = new System.Windows.Forms.PictureBox();
            this.pbCuit = new System.Windows.Forms.PictureBox();
            this.pbEnt = new System.Windows.Forms.PictureBox();
            this.newSearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dbSolicitudesUC1 = new MaxPowerSystem.dbSolicitudesUC();
            this.dbEnterprise1 = new MaxPowerSystem.dbEnterprise();
            this.dbVentProd1 = new MaxPowerSystem.dbVentProd();
            this.dbOrdExt1 = new MaxPowerSystem.dbOrdExt();
            this.dbTecAsist1 = new MaxPowerSystem.dbTecAsist();
            this.countPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnt)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDb
            // 
            this.cmbDb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbDb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbDb.FormattingEnabled = true;
            this.cmbDb.Items.AddRange(new object[] {
            "Empresas",
            "Solicitudes",
            "Cot. Asistencia técnica",
            "Cot. Reparación de laboratorio",
            "Cot. Venta de productos",
            "Orden de compra exterior",
            "Orden de compra nacional",
            "(seleccionar)"});
            this.cmbDb.Location = new System.Drawing.Point(321, 25);
            this.cmbDb.Name = "cmbDb";
            this.cmbDb.Size = new System.Drawing.Size(210, 26);
            this.cmbDb.TabIndex = 0;
            this.cmbDb.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // countPanel
            // 
            this.countPanel.BackColor = System.Drawing.Color.Transparent;
            this.countPanel.ColumnCount = 4;
            this.countPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.76191F));
            this.countPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.23809F));
            this.countPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.countPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.countPanel.Controls.Add(this.leftBut, 0, 0);
            this.countPanel.Controls.Add(this.leftLab, 1, 0);
            this.countPanel.Controls.Add(this.rightLab, 2, 0);
            this.countPanel.Controls.Add(this.rightBut, 3, 0);
            this.countPanel.Location = new System.Drawing.Point(348, 454);
            this.countPanel.Name = "countPanel";
            this.countPanel.RowCount = 1;
            this.countPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.countPanel.Size = new System.Drawing.Size(166, 30);
            this.countPanel.TabIndex = 1;
            this.countPanel.Visible = false;
            // 
            // leftBut
            // 
            this.leftBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftBut.ForeColor = System.Drawing.Color.Black;
            this.leftBut.Location = new System.Drawing.Point(3, 3);
            this.leftBut.Name = "leftBut";
            this.leftBut.Size = new System.Drawing.Size(40, 24);
            this.leftBut.TabIndex = 0;
            this.leftBut.Text = "<";
            this.leftBut.UseVisualStyleBackColor = true;
            this.leftBut.Visible = false;
            this.leftBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.antReg);
            // 
            // leftLab
            // 
            this.leftLab.AutoSize = true;
            this.leftLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftLab.Location = new System.Drawing.Point(49, 0);
            this.leftLab.Name = "leftLab";
            this.leftLab.Size = new System.Drawing.Size(32, 30);
            this.leftLab.TabIndex = 1;
            this.leftLab.Text = "0";
            this.leftLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.leftLab.Visible = false;
            // 
            // rightLab
            // 
            this.rightLab.AutoSize = true;
            this.rightLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightLab.Location = new System.Drawing.Point(87, 0);
            this.rightLab.Name = "rightLab";
            this.rightLab.Size = new System.Drawing.Size(34, 30);
            this.rightLab.TabIndex = 2;
            this.rightLab.Text = "0";
            this.rightLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rightLab.Visible = false;
            // 
            // rightBut
            // 
            this.rightBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightBut.ForeColor = System.Drawing.Color.Black;
            this.rightBut.Location = new System.Drawing.Point(127, 3);
            this.rightBut.Name = "rightBut";
            this.rightBut.Size = new System.Drawing.Size(36, 24);
            this.rightBut.TabIndex = 3;
            this.rightBut.Text = ">";
            this.rightBut.UseVisualStyleBackColor = true;
            this.rightBut.Visible = false;
            this.rightBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RightBut_MouseClick);
            // 
            // ordLab
            // 
            this.ordLab.AutoSize = true;
            this.ordLab.BackColor = System.Drawing.Color.Transparent;
            this.ordLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordLab.ForeColor = System.Drawing.Color.White;
            this.ordLab.Location = new System.Drawing.Point(50, 139);
            this.ordLab.Name = "ordLab";
            this.ordLab.Size = new System.Drawing.Size(59, 18);
            this.ordLab.TabIndex = 4;
            this.ordLab.Text = "Orden:";
            // 
            // ordBox
            // 
            this.ordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ordBox.Location = new System.Drawing.Point(131, 139);
            this.ordBox.Name = "ordBox";
            this.ordBox.Size = new System.Drawing.Size(144, 23);
            this.ordBox.TabIndex = 5;
            this.ordBox.TextChanged += new System.EventHandler(this.OrdBox_TextChanged);
            // 
            // entBox
            // 
            this.entBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.entBox.Location = new System.Drawing.Point(131, 177);
            this.entBox.Name = "entBox";
            this.entBox.Size = new System.Drawing.Size(144, 23);
            this.entBox.TabIndex = 7;
            this.entBox.TextChanged += new System.EventHandler(this.EntBox_TextChanged);
            // 
            // labEnt
            // 
            this.labEnt.AutoSize = true;
            this.labEnt.BackColor = System.Drawing.Color.Transparent;
            this.labEnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEnt.ForeColor = System.Drawing.Color.White;
            this.labEnt.Location = new System.Drawing.Point(50, 177);
            this.labEnt.Name = "labEnt";
            this.labEnt.Size = new System.Drawing.Size(80, 18);
            this.labEnt.TabIndex = 6;
            this.labEnt.Text = "Empresa:";
            // 
            // cuitBox
            // 
            this.cuitBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cuitBox.Location = new System.Drawing.Point(131, 217);
            this.cuitBox.Name = "cuitBox";
            this.cuitBox.Size = new System.Drawing.Size(144, 23);
            this.cuitBox.TabIndex = 9;
            this.cuitBox.TextChanged += new System.EventHandler(this.CuitBox_TextChanged);
            this.cuitBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox3_KeyPress);
            // 
            // labCuit
            // 
            this.labCuit.AutoSize = true;
            this.labCuit.BackColor = System.Drawing.Color.Transparent;
            this.labCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCuit.ForeColor = System.Drawing.Color.White;
            this.labCuit.Location = new System.Drawing.Point(50, 217);
            this.labCuit.Name = "labCuit";
            this.labCuit.Size = new System.Drawing.Size(74, 18);
            this.labCuit.TabIndex = 8;
            this.labCuit.Text = "Cuit/cuil:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Buscar por:";
            // 
            // pbOrd
            // 
            this.pbOrd.BackColor = System.Drawing.Color.Transparent;
            this.pbOrd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbOrd.BackgroundImage")));
            this.pbOrd.Location = new System.Drawing.Point(15, 130);
            this.pbOrd.Name = "pbOrd";
            this.pbOrd.Size = new System.Drawing.Size(32, 32);
            this.pbOrd.TabIndex = 33;
            this.pbOrd.TabStop = false;
            // 
            // pbCuit
            // 
            this.pbCuit.BackColor = System.Drawing.Color.Transparent;
            this.pbCuit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCuit.BackgroundImage")));
            this.pbCuit.Location = new System.Drawing.Point(15, 208);
            this.pbCuit.Name = "pbCuit";
            this.pbCuit.Size = new System.Drawing.Size(32, 32);
            this.pbCuit.TabIndex = 32;
            this.pbCuit.TabStop = false;
            // 
            // pbEnt
            // 
            this.pbEnt.BackColor = System.Drawing.Color.Transparent;
            this.pbEnt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbEnt.BackgroundImage")));
            this.pbEnt.Location = new System.Drawing.Point(15, 170);
            this.pbEnt.Name = "pbEnt";
            this.pbEnt.Size = new System.Drawing.Size(32, 32);
            this.pbEnt.TabIndex = 31;
            this.pbEnt.TabStop = false;
            // 
            // newSearch
            // 
            this.newSearch.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.newSearch.Image = ((System.Drawing.Image)(resources.GetObject("newSearch.Image")));
            this.newSearch.Location = new System.Drawing.Point(548, 25);
            this.newSearch.Name = "newSearch";
            this.newSearch.Size = new System.Drawing.Size(31, 27);
            this.newSearch.TabIndex = 3;
            this.newSearch.UseVisualStyleBackColor = true;
            this.newSearch.Visible = false;
            this.newSearch.Click += new System.EventHandler(this.new_Search);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(893, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 31);
            this.button1.TabIndex = 35;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // dbSolicitudesUC1
            // 
            this.dbSolicitudesUC1.BackColor = System.Drawing.Color.Transparent;
            this.dbSolicitudesUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dbSolicitudesUC1.BackgroundImage")));
            this.dbSolicitudesUC1.ForeColor = System.Drawing.Color.White;
            this.dbSolicitudesUC1.Location = new System.Drawing.Point(0, 58);
            this.dbSolicitudesUC1.Name = "dbSolicitudesUC1";
            this.dbSolicitudesUC1.Size = new System.Drawing.Size(997, 328);
            this.dbSolicitudesUC1.TabIndex = 34;
            // 
            // dbEnterprise1
            // 
            this.dbEnterprise1.BackColor = System.Drawing.Color.Transparent;
            this.dbEnterprise1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dbEnterprise1.BackgroundImage")));
            this.dbEnterprise1.ForeColor = System.Drawing.Color.White;
            this.dbEnterprise1.Location = new System.Drawing.Point(0, 56);
            this.dbEnterprise1.Name = "dbEnterprise1";
            this.dbEnterprise1.Size = new System.Drawing.Size(997, 333);
            this.dbEnterprise1.TabIndex = 14;
            // 
            // dbVentProd1
            // 
            this.dbVentProd1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dbVentProd1.BackgroundImage")));
            this.dbVentProd1.ForeColor = System.Drawing.Color.White;
            this.dbVentProd1.Location = new System.Drawing.Point(0, 56);
            this.dbVentProd1.Name = "dbVentProd1";
            this.dbVentProd1.Size = new System.Drawing.Size(997, 343);
            this.dbVentProd1.TabIndex = 12;
            // 
            // dbOrdExt1
            // 
            this.dbOrdExt1.BackColor = System.Drawing.Color.Transparent;
            this.dbOrdExt1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dbOrdExt1.BackgroundImage")));
            this.dbOrdExt1.ForeColor = System.Drawing.Color.White;
            this.dbOrdExt1.Location = new System.Drawing.Point(0, 56);
            this.dbOrdExt1.Name = "dbOrdExt1";
            this.dbOrdExt1.Size = new System.Drawing.Size(997, 330);
            this.dbOrdExt1.TabIndex = 11;
            // 
            // dbTecAsist1
            // 
            this.dbTecAsist1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dbTecAsist1.BackgroundImage")));
            this.dbTecAsist1.ForeColor = System.Drawing.Color.White;
            this.dbTecAsist1.Location = new System.Drawing.Point(0, 56);
            this.dbTecAsist1.Name = "dbTecAsist1";
            this.dbTecAsist1.Size = new System.Drawing.Size(997, 377);
            this.dbTecAsist1.TabIndex = 10;
            // 
            // viewDataBaseUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dbSolicitudesUC1);
            this.Controls.Add(this.pbOrd);
            this.Controls.Add(this.pbCuit);
            this.Controls.Add(this.pbEnt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbEnterprise1);
            this.Controls.Add(this.dbVentProd1);
            this.Controls.Add(this.dbOrdExt1);
            this.Controls.Add(this.dbTecAsist1);
            this.Controls.Add(this.cuitBox);
            this.Controls.Add(this.labCuit);
            this.Controls.Add(this.entBox);
            this.Controls.Add(this.labEnt);
            this.Controls.Add(this.ordBox);
            this.Controls.Add(this.ordLab);
            this.Controls.Add(this.newSearch);
            this.Controls.Add(this.countPanel);
            this.Controls.Add(this.cmbDb);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "viewDataBaseUC";
            this.Size = new System.Drawing.Size(1000, 539);
            this.countPanel.ResumeLayout(false);
            this.countPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDb;
        private System.Windows.Forms.TableLayoutPanel countPanel;
        private System.Windows.Forms.Button leftBut;
        private System.Windows.Forms.Label leftLab;
        private System.Windows.Forms.Label rightLab;
        private System.Windows.Forms.Button rightBut;
        private System.Windows.Forms.Button newSearch;
        private System.Windows.Forms.Label ordLab;
        private System.Windows.Forms.TextBox ordBox;
        private System.Windows.Forms.TextBox entBox;
        private System.Windows.Forms.Label labEnt;
        private System.Windows.Forms.TextBox cuitBox;
        private System.Windows.Forms.Label labCuit;
        private dbTecAsist dbTecAsist1;
        private dbOrdExt dbOrdExt1;
        private dbVentProd dbVentProd1;
        private dbEnterprise dbEnterprise1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbEnt;
        private System.Windows.Forms.PictureBox pbCuit;
        private System.Windows.Forms.PictureBox pbOrd;
        private dbSolicitudesUC dbSolicitudesUC1;
        private System.Windows.Forms.Button button1;
    }


}
