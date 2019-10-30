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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDb2 = new System.Windows.Forms.ComboBox();
            this.newSearch = new System.Windows.Forms.Button();
            this.ordBox = new System.Windows.Forms.TextBox();
            this.dbOrdConf1 = new MaxPowerSystem.dbOrdConf();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orden:";
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
            this.cmbDb2.Location = new System.Drawing.Point(325, 5);
            this.cmbDb2.Name = "cmbDb2";
            this.cmbDb2.Size = new System.Drawing.Size(210, 26);
            this.cmbDb2.TabIndex = 2;
            this.cmbDb2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // newSearch
            // 
            this.newSearch.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.newSearch.Image = ((System.Drawing.Image)(resources.GetObject("newSearch.Image")));
            this.newSearch.Location = new System.Drawing.Point(577, 5);
            this.newSearch.Name = "newSearch";
            this.newSearch.Size = new System.Drawing.Size(31, 27);
            this.newSearch.TabIndex = 4;
            this.newSearch.UseVisualStyleBackColor = true;
            this.newSearch.Visible = false;
            // 
            // ordBox
            // 
            this.ordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ordBox.Location = new System.Drawing.Point(163, 81);
            this.ordBox.Name = "ordBox";
            this.ordBox.Size = new System.Drawing.Size(189, 24);
            this.ordBox.TabIndex = 5;
            // 
            // dbOrdConf1
            // 
            this.dbOrdConf1.Location = new System.Drawing.Point(3, 56);
            this.dbOrdConf1.Name = "dbOrdConf1";
            this.dbOrdConf1.Size = new System.Drawing.Size(978, 524);
            this.dbOrdConf1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Buscar por:";
            // 
            // OrdConfUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dbOrdConf1);
            this.Controls.Add(this.ordBox);
            this.Controls.Add(this.newSearch);
            this.Controls.Add(this.cmbDb2);
            this.Controls.Add(this.label1);
            this.Name = "OrdConfUC";
            this.Size = new System.Drawing.Size(978, 333);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDb2;
        private System.Windows.Forms.Button newSearch;
        private System.Windows.Forms.TextBox ordBox;
        private dbOrdConf dbOrdConf1;
        private System.Windows.Forms.Label label2;
    }
}
