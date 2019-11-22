namespace MaxPowerSystem
{
    partial class FormArticulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.compArticulosUC1 = new MaxPowerSystem.compArticulosUC();
            this.agregarArtUC1 = new MaxPowerSystem.agregarArtUC();
            this.artProvUC1 = new MaxPowerSystem.artProvUC();
            this.uploadDataBaseUC1 = new MaxPowerSystem.uploadDataBaseUC();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uploadDataBaseUC1);
            this.panel2.Controls.Add(this.compArticulosUC1);
            this.panel2.Controls.Add(this.agregarArtUC1);
            this.panel2.Controls.Add(this.artProvUC1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 521);
            this.panel2.TabIndex = 2;
            // 
            // compArticulosUC1
            // 
            this.compArticulosUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compArticulosUC1.Location = new System.Drawing.Point(0, 0);
            this.compArticulosUC1.Name = "compArticulosUC1";
            this.compArticulosUC1.Size = new System.Drawing.Size(904, 521);
            this.compArticulosUC1.TabIndex = 0;
            // 
            // agregarArtUC1
            // 
            this.agregarArtUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agregarArtUC1.Location = new System.Drawing.Point(0, 0);
            this.agregarArtUC1.Name = "agregarArtUC1";
            this.agregarArtUC1.Orden = null;
            this.agregarArtUC1.Size = new System.Drawing.Size(904, 521);
            this.agregarArtUC1.TabIndex = 1;
            // 
            // artProvUC1
            // 
            this.artProvUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artProvUC1.Location = new System.Drawing.Point(0, 0);
            this.artProvUC1.Name = "artProvUC1";
            this.artProvUC1.Size = new System.Drawing.Size(904, 521);
            this.artProvUC1.TabIndex = 2;
            // 
            // uploadDataBaseUC1
            // 
            this.uploadDataBaseUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uploadDataBaseUC1.Location = new System.Drawing.Point(0, 0);
            this.uploadDataBaseUC1.Name = "uploadDataBaseUC1";
            this.uploadDataBaseUC1.Size = new System.Drawing.Size(904, 521);
            this.uploadDataBaseUC1.TabIndex = 3;
            // 
            // FormArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 521);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(920, 560);
            this.MinimumSize = new System.Drawing.Size(920, 560);
            this.Name = "FormArticulos";
            this.Text = "FormArticulos";
            this.Load += new System.EventHandler(this.FormArticulos_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private compArticulosUC compArticulosUC1;
        private agregarArtUC agregarArtUC1;
        public artProvUC artProvUC1;
        private uploadDataBaseUC uploadDataBaseUC1;
    }
}