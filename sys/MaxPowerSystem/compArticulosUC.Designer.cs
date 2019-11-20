namespace MaxPowerSystem
{
    partial class compArticulosUC
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
            this.label9 = new System.Windows.Forms.Label();
            this.combMon = new System.Windows.Forms.ComboBox();
            this.labEnt = new System.Windows.Forms.Label();
            this.resEnt = new System.Windows.Forms.Label();
            this.resDesc = new System.Windows.Forms.Label();
            this.labDesc = new System.Windows.Forms.Label();
            this.butAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label9.Location = new System.Drawing.Point(203, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 18);
            this.label9.TabIndex = 112;
            this.label9.Text = "Orden:";
            // 
            // combMon
            // 
            this.combMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.combMon.FormattingEnabled = true;
            this.combMon.Items.AddRange(new object[] {
            "USD",
            "EUROS",
            "ARS"});
            this.combMon.Location = new System.Drawing.Point(279, 42);
            this.combMon.Name = "combMon";
            this.combMon.Size = new System.Drawing.Size(265, 26);
            this.combMon.TabIndex = 111;
            // 
            // labEnt
            // 
            this.labEnt.AutoSize = true;
            this.labEnt.Location = new System.Drawing.Point(74, 116);
            this.labEnt.Name = "labEnt";
            this.labEnt.Size = new System.Drawing.Size(51, 13);
            this.labEnt.TabIndex = 113;
            this.labEnt.Text = "Empresa:";
            this.labEnt.Visible = false;
            // 
            // resEnt
            // 
            this.resEnt.AutoSize = true;
            this.resEnt.Location = new System.Drawing.Point(158, 116);
            this.resEnt.Name = "resEnt";
            this.resEnt.Size = new System.Drawing.Size(35, 13);
            this.resEnt.TabIndex = 114;
            this.resEnt.Text = "label2";
            this.resEnt.Visible = false;
            // 
            // resDesc
            // 
            this.resDesc.AutoSize = true;
            this.resDesc.Location = new System.Drawing.Point(158, 160);
            this.resDesc.Name = "resDesc";
            this.resDesc.Size = new System.Drawing.Size(35, 13);
            this.resDesc.TabIndex = 116;
            this.resDesc.Text = "label3";
            this.resDesc.Visible = false;
            // 
            // labDesc
            // 
            this.labDesc.AutoSize = true;
            this.labDesc.Location = new System.Drawing.Point(74, 160);
            this.labDesc.Name = "labDesc";
            this.labDesc.Size = new System.Drawing.Size(66, 13);
            this.labDesc.TabIndex = 115;
            this.labDesc.Text = "Descripción:";
            this.labDesc.Visible = false;
            // 
            // butAccept
            // 
            this.butAccept.Location = new System.Drawing.Point(358, 393);
            this.butAccept.Name = "butAccept";
            this.butAccept.Size = new System.Drawing.Size(75, 23);
            this.butAccept.TabIndex = 117;
            this.butAccept.Text = "Aceptar";
            this.butAccept.UseVisualStyleBackColor = true;
            this.butAccept.Visible = false;
            // 
            // compArticulosUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.butAccept);
            this.Controls.Add(this.resDesc);
            this.Controls.Add(this.labDesc);
            this.Controls.Add(this.resEnt);
            this.Controls.Add(this.labEnt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.combMon);
            this.Name = "compArticulosUC";
            this.Size = new System.Drawing.Size(763, 439);
            this.Load += new System.EventHandler(this.CompArticulosUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combMon;
        private System.Windows.Forms.Label labEnt;
        private System.Windows.Forms.Label resEnt;
        private System.Windows.Forms.Label resDesc;
        private System.Windows.Forms.Label labDesc;
        private System.Windows.Forms.Button butAccept;
    }
}
