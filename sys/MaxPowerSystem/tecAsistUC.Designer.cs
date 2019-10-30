using System;

namespace MaxPowerSystem
{
    partial class tecAsistUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxEnterprise = new System.Windows.Forms.TextBox();
            this.boxAsist = new System.Windows.Forms.TextBox();
            this.boxPrice = new System.Windows.Forms.TextBox();
            this.boxForm = new System.Windows.Forms.TextBox();
            this.labPor = new System.Windows.Forms.Label();
            this.boxDays = new System.Windows.Forms.TextBox();
            this.labDay = new System.Windows.Forms.Label();
            this.boxHours = new System.Windows.Forms.TextBox();
            this.labAsist = new System.Windows.Forms.Label();
            this.labTec = new System.Windows.Forms.Label();
            this.labForAsist = new System.Windows.Forms.Label();
            this.boxDetalle = new System.Windows.Forms.TextBox();
            this.buttonWordFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(17, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Asistencia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(17, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio (ARS):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(17, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Forma de pago:";
            // 
            // boxEnterprise
            // 
            this.boxEnterprise.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.boxEnterprise.Location = new System.Drawing.Point(166, 20);
            this.boxEnterprise.Name = "boxEnterprise";
            this.boxEnterprise.Size = new System.Drawing.Size(180, 24);
            this.boxEnterprise.TabIndex = 4;
            // 
            // boxAsist
            // 
            this.boxAsist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.boxAsist.Location = new System.Drawing.Point(166, 78);
            this.boxAsist.Multiline = true;
            this.boxAsist.Name = "boxAsist";
            this.boxAsist.Size = new System.Drawing.Size(180, 91);
            this.boxAsist.TabIndex = 5;
            // 
            // boxPrice
            // 
            this.boxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.boxPrice.Location = new System.Drawing.Point(166, 203);
            this.boxPrice.Name = "boxPrice";
            this.boxPrice.Size = new System.Drawing.Size(180, 24);
            this.boxPrice.TabIndex = 6;
            this.boxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxPrice_KeyPress);
            // 
            // boxForm
            // 
            this.boxForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.boxForm.Location = new System.Drawing.Point(166, 251);
            this.boxForm.Name = "boxForm";
            this.boxForm.Size = new System.Drawing.Size(180, 24);
            this.boxForm.TabIndex = 7;
            // 
            // labPor
            // 
            this.labPor.AutoSize = true;
            this.labPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labPor.Location = new System.Drawing.Point(420, 23);
            this.labPor.Name = "labPor";
            this.labPor.Size = new System.Drawing.Size(32, 18);
            this.labPor.TabIndex = 8;
            this.labPor.Text = "Por";
            // 
            // boxDays
            // 
            this.boxDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.boxDays.Location = new System.Drawing.Point(458, 20);
            this.boxDays.Name = "boxDays";
            this.boxDays.Size = new System.Drawing.Size(27, 24);
            this.boxDays.TabIndex = 9;
            this.boxDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxDays_KeyPress);
            // 
            // labDay
            // 
            this.labDay.AutoSize = true;
            this.labDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labDay.Location = new System.Drawing.Point(491, 23);
            this.labDay.Name = "labDay";
            this.labDay.Size = new System.Drawing.Size(55, 18);
            this.labDay.TabIndex = 10;
            this.labDay.Text = "días de";
            // 
            // boxHours
            // 
            this.boxHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.boxHours.Location = new System.Drawing.Point(552, 20);
            this.boxHours.Name = "boxHours";
            this.boxHours.Size = new System.Drawing.Size(25, 24);
            this.boxHours.TabIndex = 11;
            this.boxHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxHours_KeyPress);
            // 
            // labAsist
            // 
            this.labAsist.AutoSize = true;
            this.labAsist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labAsist.Location = new System.Drawing.Point(583, 23);
            this.labAsist.Name = "labAsist";
            this.labAsist.Size = new System.Drawing.Size(270, 18);
            this.labAsist.TabIndex = 12;
            this.labAsist.Text = "hs de Asistencia técnica de un ingeniero";
            // 
            // labTec
            // 
            this.labTec.AutoSize = true;
            this.labTec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labTec.Location = new System.Drawing.Point(583, 57);
            this.labTec.Name = "labTec";
            this.labTec.Size = new System.Drawing.Size(98, 18);
            this.labTec.TabIndex = 13;
            this.labTec.Text = "especializado";
            this.labTec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labForAsist
            // 
            this.labForAsist.AutoSize = true;
            this.labForAsist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labForAsist.Location = new System.Drawing.Point(676, 57);
            this.labForAsist.Name = "labForAsist";
            this.labForAsist.Size = new System.Drawing.Size(173, 18);
            this.labForAsist.TabIndex = 14;
            this.labForAsist.Text = "para la asistencia técnica";
            // 
            // boxDetalle
            // 
            this.boxDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.boxDetalle.Location = new System.Drawing.Point(381, 101);
            this.boxDetalle.Multiline = true;
            this.boxDetalle.Name = "boxDetalle";
            this.boxDetalle.Size = new System.Drawing.Size(472, 174);
            this.boxDetalle.TabIndex = 15;
            // 
            // buttonWordFile
            // 
            this.buttonWordFile.AutoSize = true;
            this.buttonWordFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWordFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonWordFile.Location = new System.Drawing.Point(381, 311);
            this.buttonWordFile.Name = "buttonWordFile";
            this.buttonWordFile.Size = new System.Drawing.Size(142, 31);
            this.buttonWordFile.TabIndex = 16;
            this.buttonWordFile.Text = "Generar asistencia";
            this.buttonWordFile.UseVisualStyleBackColor = true;
            this.buttonWordFile.Click += new System.EventHandler(this.ButtonWordFile_Click);
            // 
            // tecAsistUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonWordFile);
            this.Controls.Add(this.boxDetalle);
            this.Controls.Add(this.labForAsist);
            this.Controls.Add(this.labTec);
            this.Controls.Add(this.labAsist);
            this.Controls.Add(this.boxHours);
            this.Controls.Add(this.labDay);
            this.Controls.Add(this.boxDays);
            this.Controls.Add(this.labPor);
            this.Controls.Add(this.boxForm);
            this.Controls.Add(this.boxPrice);
            this.Controls.Add(this.boxAsist);
            this.Controls.Add(this.boxEnterprise);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "tecAsistUC";
            this.Size = new System.Drawing.Size(920, 359);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxEnterprise;
        private System.Windows.Forms.TextBox boxAsist;
        private System.Windows.Forms.TextBox boxPrice;
        private System.Windows.Forms.TextBox boxForm;
        private System.Windows.Forms.Label labPor;
        private System.Windows.Forms.TextBox boxDays;
        private System.Windows.Forms.Label labDay;
        private System.Windows.Forms.TextBox boxHours;
        private System.Windows.Forms.Label labAsist;
        private System.Windows.Forms.Label labTec;
        private System.Windows.Forms.Label labForAsist;
        private System.Windows.Forms.TextBox boxDetalle;
        private System.Windows.Forms.Button buttonWordFile;
    }
}
