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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.compArticulosUC1 = new MaxPowerSystem.compArticulosUC();
            this.agregarArtUC1 = new MaxPowerSystem.agregarArtUC();
<<<<<<< HEAD
=======
            this.artProvUC1 = new MaxPowerSystem.artProvUC();
>>>>>>> f20159896b464afdfbf0f7961a90edb0a2ba5124
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 521);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "AAAAAAAA";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(141, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(763, 82);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.agregarArtUC1);
            this.panel2.Controls.Add(this.compArticulosUC1);
            this.panel2.Controls.Add(this.agregarArtUC1);
            this.panel2.Controls.Add(this.artProvUC1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(141, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 439);
            this.panel2.TabIndex = 2;
            // 
            // compArticulosUC1
            // 
            this.compArticulosUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compArticulosUC1.Location = new System.Drawing.Point(0, 0);
            this.compArticulosUC1.Name = "compArticulosUC1";
            this.compArticulosUC1.Size = new System.Drawing.Size(763, 439);
            this.compArticulosUC1.TabIndex = 0;
            // 
            // agregarArtUC1
            // 
            this.agregarArtUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agregarArtUC1.Location = new System.Drawing.Point(0, 0);
            this.agregarArtUC1.Name = "agregarArtUC1";
<<<<<<< HEAD
            this.agregarArtUC1.Size = new System.Drawing.Size(763, 439);
            this.agregarArtUC1.TabIndex = 1;
            // 
=======
            this.agregarArtUC1.Orden = null;
            this.agregarArtUC1.Size = new System.Drawing.Size(763, 439);
            this.agregarArtUC1.TabIndex = 1;
            // 
            // artProvUC1
            // 
            this.artProvUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artProvUC1.Location = new System.Drawing.Point(0, 0);
            this.artProvUC1.Name = "artProvUC1";
            this.artProvUC1.Size = new System.Drawing.Size(763, 439);
            this.artProvUC1.TabIndex = 2;
            // 
>>>>>>> f20159896b464afdfbf0f7961a90edb0a2ba5124
            // FormArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 521);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(920, 560);
            this.MinimumSize = new System.Drawing.Size(920, 560);
            this.Name = "FormArticulos";
            this.Text = "FormArticulos";
            this.Load += new System.EventHandler(this.FormArticulos_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private compArticulosUC compArticulosUC1;
        private agregarArtUC agregarArtUC1;
<<<<<<< HEAD
=======
        public artProvUC artProvUC1;
>>>>>>> f20159896b464afdfbf0f7961a90edb0a2ba5124
    }
}