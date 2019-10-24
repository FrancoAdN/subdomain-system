namespace MaxPowerSystem
{
    partial class dbVentProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dbVentProd));
            this.labPmde = new System.Windows.Forms.Label();
            this.labMon = new System.Windows.Forms.Label();
            this.labInco = new System.Windows.Forms.Label();
            this.labEnt = new System.Windows.Forms.Label();
            this.entLab = new System.Windows.Forms.Label();
            this.edmLab = new System.Windows.Forms.Label();
            this.cdpLab = new System.Windows.Forms.Label();
            this.pmdeLab = new System.Windows.Forms.Label();
            this.labDate = new System.Windows.Forms.Label();
            this.labOrden = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labPrec = new System.Windows.Forms.Label();
            this.labP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labPmde
            // 
            this.labPmde.AutoSize = true;
            this.labPmde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPmde.Location = new System.Drawing.Point(14, 277);
            this.labPmde.Name = "labPmde";
            this.labPmde.Size = new System.Drawing.Size(204, 18);
            this.labPmde.TabIndex = 10;
            this.labPmde.Text = "Plazo máximo de entrega:";
            // 
            // labMon
            // 
            this.labMon.AutoSize = true;
            this.labMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMon.Location = new System.Drawing.Point(14, 185);
            this.labMon.Name = "labMon";
            this.labMon.Size = new System.Drawing.Size(172, 18);
            this.labMon.TabIndex = 9;
            this.labMon.Text = "Condiciones de pago:";
            // 
            // labInco
            // 
            this.labInco.AutoSize = true;
            this.labInco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInco.Location = new System.Drawing.Point(14, 70);
            this.labInco.Name = "labInco";
            this.labInco.Size = new System.Drawing.Size(163, 18);
            this.labInco.TabIndex = 8;
            this.labInco.Text = "Entrega del material:";
            // 
            // labEnt
            // 
            this.labEnt.AutoSize = true;
            this.labEnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEnt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labEnt.Location = new System.Drawing.Point(14, 20);
            this.labEnt.Name = "labEnt";
            this.labEnt.Size = new System.Drawing.Size(80, 18);
            this.labEnt.TabIndex = 7;
            this.labEnt.Text = "Empresa:";
            // 
            // entLab
            // 
            this.entLab.AutoSize = true;
            this.entLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.entLab.Location = new System.Drawing.Point(14, 38);
            this.entLab.Name = "entLab";
            this.entLab.Size = new System.Drawing.Size(0, 18);
            this.entLab.TabIndex = 11;
            this.entLab.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ent_click);
            // 
            // edmLab
            // 
            this.edmLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.edmLab.Location = new System.Drawing.Point(14, 88);
            this.edmLab.Name = "edmLab";
            this.edmLab.Size = new System.Drawing.Size(214, 97);
            this.edmLab.TabIndex = 12;
            this.edmLab.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edm_click);
            // 
            // cdpLab
            // 
            this.cdpLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cdpLab.Location = new System.Drawing.Point(14, 203);
            this.cdpLab.Name = "cdpLab";
            this.cdpLab.Size = new System.Drawing.Size(195, 65);
            this.cdpLab.TabIndex = 13;
            this.cdpLab.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cdp_click);
            // 
            // pmdeLab
            // 
            this.pmdeLab.AutoSize = true;
            this.pmdeLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.pmdeLab.Location = new System.Drawing.Point(14, 295);
            this.pmdeLab.Name = "pmdeLab";
            this.pmdeLab.Size = new System.Drawing.Size(0, 18);
            this.pmdeLab.TabIndex = 14;
            this.pmdeLab.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pmde_click);
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDate.Location = new System.Drawing.Point(730, 280);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(110, 18);
            this.labDate.TabIndex = 15;
            this.labDate.Text = "DD/MM/AAAA";
            this.labDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.date_click);
            // 
            // labOrden
            // 
            this.labOrden.AutoSize = true;
            this.labOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOrden.ForeColor = System.Drawing.Color.Red;
            this.labOrden.Location = new System.Drawing.Point(245, 0);
            this.labOrden.Name = "labOrden";
            this.labOrden.Size = new System.Drawing.Size(0, 24);
            this.labOrden.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(841, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 35);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.regen_file);
            // 
            // labPrec
            // 
            this.labPrec.AutoSize = true;
            this.labPrec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPrec.Location = new System.Drawing.Point(441, 277);
            this.labPrec.Name = "labPrec";
            this.labPrec.Size = new System.Drawing.Size(105, 18);
            this.labPrec.TabIndex = 18;
            this.labPrec.Text = "Precio Total:";
            // 
            // labP
            // 
            this.labP.AutoSize = true;
            this.labP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labP.Location = new System.Drawing.Point(552, 277);
            this.labP.Name = "labP";
            this.labP.Size = new System.Drawing.Size(0, 18);
            this.labP.TabIndex = 19;
            // 
            // dbVentProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.labP);
            this.Controls.Add(this.labPrec);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labOrden);
            this.Controls.Add(this.labDate);
            this.Controls.Add(this.pmdeLab);
            this.Controls.Add(this.cdpLab);
            this.Controls.Add(this.edmLab);
            this.Controls.Add(this.entLab);
            this.Controls.Add(this.labPmde);
            this.Controls.Add(this.labMon);
            this.Controls.Add(this.labInco);
            this.Controls.Add(this.labEnt);
            this.Name = "dbVentProd";
            this.Size = new System.Drawing.Size(920, 330);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labPmde;
        private System.Windows.Forms.Label labMon;
        private System.Windows.Forms.Label labInco;
        private System.Windows.Forms.Label labEnt;
        private System.Windows.Forms.Label entLab;
        private System.Windows.Forms.Label edmLab;
        private System.Windows.Forms.Label cdpLab;
        private System.Windows.Forms.Label pmdeLab;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Label labOrden;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labPrec;
        private System.Windows.Forms.Label labP;
    }
}
