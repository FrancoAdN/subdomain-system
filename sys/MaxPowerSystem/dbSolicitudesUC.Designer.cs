namespace MaxPowerSystem
{
    partial class dbSolicitudesUC
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
            this.labOrd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labProc = new System.Windows.Forms.Label();
            this.labDesc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labCli = new System.Windows.Forms.Label();
            this.labDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labOrd
            // 
            this.labOrd.AutoSize = true;
            this.labOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOrd.Location = new System.Drawing.Point(431, 12);
            this.labOrd.Name = "labOrd";
            this.labOrd.Size = new System.Drawing.Size(60, 24);
            this.labOrd.TabIndex = 0;
            this.labOrd.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Procedencia:";
            // 
            // labProc
            // 
            this.labProc.AutoSize = true;
            this.labProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProc.Location = new System.Drawing.Point(203, 54);
            this.labProc.Name = "labProc";
            this.labProc.Size = new System.Drawing.Size(46, 18);
            this.labProc.TabIndex = 2;
            this.labProc.Text = "label3";
            // 
            // labDesc
            // 
            this.labDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDesc.Location = new System.Drawing.Point(203, 154);
            this.labDesc.Name = "labDesc";
            this.labDesc.Size = new System.Drawing.Size(526, 119);
            this.labDesc.TabIndex = 3;
            this.labDesc.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripción:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cliente:";
            // 
            // labCli
            // 
            this.labCli.AutoSize = true;
            this.labCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCli.Location = new System.Drawing.Point(203, 96);
            this.labCli.Name = "labCli";
            this.labCli.Size = new System.Drawing.Size(46, 18);
            this.labCli.TabIndex = 6;
            this.labCli.Text = "label3";
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDate.Location = new System.Drawing.Point(777, 291);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(52, 18);
            this.labDate.TabIndex = 7;
            this.labDate.Text = "label3";
            // 
            // dbSolicitudesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labDate);
            this.Controls.Add(this.labCli);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labDesc);
            this.Controls.Add(this.labProc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labOrd);
            this.Name = "dbSolicitudesUC";
            this.Size = new System.Drawing.Size(920, 330);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labOrd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labProc;
        private System.Windows.Forms.Label labDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labCli;
        private System.Windows.Forms.Label labDate;
    }
}
