﻿namespace MaxPowerSystem
{
    partial class dbTecAsist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dbTecAsist));
            this.labFdp = new System.Windows.Forms.Label();
            this.labPrec = new System.Windows.Forms.Label();
            this.labType = new System.Windows.Forms.Label();
            this.labEnt = new System.Windows.Forms.Label();
            this.labDate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.entLab = new System.Windows.Forms.Label();
            this.labTdAsist = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.fdpLab = new System.Windows.Forms.Label();
            this.labDet = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labOrden = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labFdp
            // 
            this.labFdp.AutoSize = true;
            this.labFdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFdp.Location = new System.Drawing.Point(14, 189);
            this.labFdp.Name = "labFdp";
            this.labFdp.Size = new System.Drawing.Size(127, 18);
            this.labFdp.TabIndex = 10;
            this.labFdp.Text = "Forma de pago:";
            // 
            // labPrec
            // 
            this.labPrec.AutoSize = true;
            this.labPrec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPrec.Location = new System.Drawing.Point(14, 163);
            this.labPrec.Name = "labPrec";
            this.labPrec.Size = new System.Drawing.Size(112, 18);
            this.labPrec.TabIndex = 9;
            this.labPrec.Text = "Precio (ARS):";
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labType.Location = new System.Drawing.Point(14, 70);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(150, 18);
            this.labType.TabIndex = 8;
            this.labType.Text = "Tipo de asistencia:";
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
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDate.Location = new System.Drawing.Point(489, 217);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(110, 18);
            this.labDate.TabIndex = 19;
            this.labDate.Text = "DD/MM/AAAA";
            this.labDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(600, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 35);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.reg_file);
            // 
            // entLab
            // 
            this.entLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.entLab.Location = new System.Drawing.Point(14, 41);
            this.entLab.Name = "entLab";
            this.entLab.Size = new System.Drawing.Size(316, 29);
            this.entLab.TabIndex = 21;
            this.entLab.Text = "label1";
            // 
            // labTdAsist
            // 
            this.labTdAsist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labTdAsist.Location = new System.Drawing.Point(14, 91);
            this.labTdAsist.Name = "labTdAsist";
            this.labTdAsist.Size = new System.Drawing.Size(316, 72);
            this.labTdAsist.TabIndex = 22;
            this.labTdAsist.Text = "label2";
            // 
            // labPrice
            // 
            this.labPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labPrice.Location = new System.Drawing.Point(132, 163);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(198, 21);
            this.labPrice.TabIndex = 23;
            this.labPrice.Text = "label3";
            // 
            // fdpLab
            // 
            this.fdpLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.fdpLab.Location = new System.Drawing.Point(14, 209);
            this.fdpLab.Name = "fdpLab";
            this.fdpLab.Size = new System.Drawing.Size(316, 21);
            this.fdpLab.TabIndex = 24;
            this.fdpLab.Text = "label4";
            // 
            // labDet
            // 
            this.labDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labDet.Location = new System.Drawing.Point(336, 41);
            this.labDet.Name = "labDet";
            this.labDet.Size = new System.Drawing.Size(316, 149);
            this.labDet.TabIndex = 26;
            this.labDet.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(454, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "Detalle:";
            // 
            // labOrden
            // 
            this.labOrden.AutoSize = true;
            this.labOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOrden.ForeColor = System.Drawing.Color.Red;
            this.labOrden.Location = new System.Drawing.Point(245, 0);
            this.labOrden.Name = "labOrden";
            this.labOrden.Size = new System.Drawing.Size(0, 24);
            this.labOrden.TabIndex = 27;
            // 
            // dbTecAsist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labOrden);
            this.Controls.Add(this.labDet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fdpLab);
            this.Controls.Add(this.labPrice);
            this.Controls.Add(this.labTdAsist);
            this.Controls.Add(this.entLab);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labDate);
            this.Controls.Add(this.labFdp);
            this.Controls.Add(this.labPrec);
            this.Controls.Add(this.labType);
            this.Controls.Add(this.labEnt);
            this.Name = "dbTecAsist";
            this.Size = new System.Drawing.Size(656, 245);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labFdp;
        private System.Windows.Forms.Label labPrec;
        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.Label labEnt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Label entLab;
        private System.Windows.Forms.Label labTdAsist;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Label fdpLab;
        private System.Windows.Forms.Label labDet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labOrden;
    }
}