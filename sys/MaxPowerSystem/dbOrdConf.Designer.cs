namespace MaxPowerSystem
{
    partial class dbOrdConf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dbOrdConf));
            this.button1 = new System.Windows.Forms.Button();
            this.labDate = new System.Windows.Forms.Label();
            this.labOrden = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(601, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 35);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDate.Location = new System.Drawing.Point(490, 299);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(110, 18);
            this.labDate.TabIndex = 21;
            this.labDate.Text = "DD/MM/AAAA";
            this.labDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labOrden
            // 
            this.labOrden.AutoSize = true;
            this.labOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOrden.ForeColor = System.Drawing.Color.Red;
            this.labOrden.Location = new System.Drawing.Point(245, 0);
            this.labOrden.Name = "labOrden";
            this.labOrden.Size = new System.Drawing.Size(0, 24);
            this.labOrden.TabIndex = 23;
            // 
            // dbOrdConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labOrden);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labDate);
            this.Name = "dbOrdConf";
            this.Size = new System.Drawing.Size(656, 333);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Label labOrden;
    }
}
