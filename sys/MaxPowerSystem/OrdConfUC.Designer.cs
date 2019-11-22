namespace MaxPowerSystem
{
    partial class OrdConfUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdConfUC));
            this.cmbDb2 = new System.Windows.Forms.ComboBox();
            this.newSearch = new System.Windows.Forms.Button();
            this.ordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.infoOrd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dbOrdConf1 = new MaxPowerSystem.dbOrdConf();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDb2
            // 
            this.cmbDb2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbDb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDb2.DropDownWidth = 210;
            this.cmbDb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbDb2.FormattingEnabled = true;
            this.cmbDb2.ItemHeight = 18;
            this.cmbDb2.Items.AddRange(new object[] {
            "Ordenes confirmadas",
            "Ordenes sin confirmar",
            "(seleccionar)"});
            this.cmbDb2.Location = new System.Drawing.Point(350, 15);
            this.cmbDb2.Name = "cmbDb2";
            this.cmbDb2.Size = new System.Drawing.Size(210, 26);
            this.cmbDb2.TabIndex = 83;
            // 
            // newSearch
            // 
            this.newSearch.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.newSearch.Image = ((System.Drawing.Image)(resources.GetObject("newSearch.Image")));
            this.newSearch.Location = new System.Drawing.Point(566, 15);
            this.newSearch.Name = "newSearch";
            this.newSearch.Size = new System.Drawing.Size(31, 27);
            this.newSearch.TabIndex = 84;
            this.newSearch.UseVisualStyleBackColor = true;
            this.newSearch.Visible = false;
            // 
            // ordBox
            // 
            this.ordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ordBox.Location = new System.Drawing.Point(177, 88);
            this.ordBox.Name = "ordBox";
            this.ordBox.Size = new System.Drawing.Size(189, 24);
            this.ordBox.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 86;
            this.label2.Text = "Buscar por:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // infoOrd
            // 
            this.infoOrd.BackColor = System.Drawing.Color.Transparent;
            this.infoOrd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("infoOrd.BackgroundImage")));
            this.infoOrd.Location = new System.Drawing.Point(894, 15);
            this.infoOrd.Name = "infoOrd";
            this.infoOrd.Size = new System.Drawing.Size(34, 31);
            this.infoOrd.TabIndex = 88;
            this.infoOrd.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orden:";
            // 
            // dbOrdConf1
            // 
            this.dbOrdConf1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dbOrdConf1.BackgroundImage")));
            this.dbOrdConf1.ForeColor = System.Drawing.Color.White;
            this.dbOrdConf1.Location = new System.Drawing.Point(0, 47);
            this.dbOrdConf1.Name = "dbOrdConf1";
            this.dbOrdConf1.Size = new System.Drawing.Size(978, 489);
            this.dbOrdConf1.TabIndex = 6;
            // 
            // OrdConfUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.dbOrdConf1);
            this.Controls.Add(this.infoOrd);
            this.Controls.Add(this.newSearch);
            this.Controls.Add(this.ordBox);
            this.Controls.Add(this.cmbDb2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrdConfUC";
            this.Size = new System.Drawing.Size(978, 333);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private dbOrdConf dbOrdConf1;
        private System.Windows.Forms.ComboBox cmbDb2;
        private System.Windows.Forms.Button newSearch;
        private System.Windows.Forms.TextBox ordBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button infoOrd;
        private System.Windows.Forms.Label label1;
    }
}
