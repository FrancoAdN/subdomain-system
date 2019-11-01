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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tecAsistUC));
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
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.combMon = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(50, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(50, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(50, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(50, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Forma de pago:";
            // 
            // boxEnterprise
            // 
            this.boxEnterprise.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.boxEnterprise.Location = new System.Drawing.Point(171, 20);
            this.boxEnterprise.Name = "boxEnterprise";
            this.boxEnterprise.Size = new System.Drawing.Size(212, 24);
            this.boxEnterprise.TabIndex = 4;
            // 
            // boxAsist
            // 
            this.boxAsist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.boxAsist.Location = new System.Drawing.Point(171, 101);
            this.boxAsist.Multiline = true;
            this.boxAsist.Name = "boxAsist";
            this.boxAsist.Size = new System.Drawing.Size(212, 91);
            this.boxAsist.TabIndex = 5;
            // 
            // boxPrice
            // 
            this.boxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.boxPrice.Location = new System.Drawing.Point(171, 269);
            this.boxPrice.Name = "boxPrice";
            this.boxPrice.Size = new System.Drawing.Size(212, 24);
            this.boxPrice.TabIndex = 6;
            this.boxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxPrice_KeyPress);
            // 
            // boxForm
            // 
            this.boxForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.boxForm.Location = new System.Drawing.Point(171, 317);
            this.boxForm.Name = "boxForm";
            this.boxForm.Size = new System.Drawing.Size(212, 24);
            this.boxForm.TabIndex = 7;
            // 
            // labPor
            // 
            this.labPor.AutoSize = true;
            this.labPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labPor.Location = new System.Drawing.Point(514, 23);
            this.labPor.Name = "labPor";
            this.labPor.Size = new System.Drawing.Size(32, 18);
            this.labPor.TabIndex = 8;
            this.labPor.Text = "Por";
            // 
            // boxDays
            // 
            this.boxDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.boxDays.Location = new System.Drawing.Point(552, 20);
            this.boxDays.Name = "boxDays";
            this.boxDays.Size = new System.Drawing.Size(27, 24);
            this.boxDays.TabIndex = 9;
            this.boxDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxDays_KeyPress);
            // 
            // labDay
            // 
            this.labDay.AutoSize = true;
            this.labDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labDay.Location = new System.Drawing.Point(585, 23);
            this.labDay.Name = "labDay";
            this.labDay.Size = new System.Drawing.Size(55, 18);
            this.labDay.TabIndex = 10;
            this.labDay.Text = "días de";
            // 
            // boxHours
            // 
            this.boxHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.boxHours.Location = new System.Drawing.Point(646, 20);
            this.boxHours.Name = "boxHours";
            this.boxHours.Size = new System.Drawing.Size(25, 24);
            this.boxHours.TabIndex = 11;
            this.boxHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxHours_KeyPress);
            // 
            // labAsist
            // 
            this.labAsist.AutoSize = true;
            this.labAsist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labAsist.Location = new System.Drawing.Point(677, 23);
            this.labAsist.Name = "labAsist";
            this.labAsist.Size = new System.Drawing.Size(270, 18);
            this.labAsist.TabIndex = 12;
            this.labAsist.Text = "hs de Asistencia técnica de un ingeniero";
            // 
            // labTec
            // 
            this.labTec.AutoSize = true;
            this.labTec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labTec.Location = new System.Drawing.Point(677, 57);
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
            this.labForAsist.Location = new System.Drawing.Point(770, 57);
            this.labForAsist.Name = "labForAsist";
            this.labForAsist.Size = new System.Drawing.Size(173, 18);
            this.labForAsist.TabIndex = 14;
            this.labForAsist.Text = "para la asistencia técnica";
            // 
            // boxDetalle
            // 
            this.boxDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.boxDetalle.Location = new System.Drawing.Point(475, 101);
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
            this.buttonWordFile.Location = new System.Drawing.Point(390, 355);
            this.buttonWordFile.Name = "buttonWordFile";
            this.buttonWordFile.Size = new System.Drawing.Size(193, 31);
            this.buttonWordFile.TabIndex = 16;
            this.buttonWordFile.Text = "Generar asistencia técnica";
            this.buttonWordFile.UseVisualStyleBackColor = true;
            this.buttonWordFile.Click += new System.EventHandler(this.ButtonWordFile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(50, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Referencia:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox1.Location = new System.Drawing.Point(171, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 24);
            this.textBox1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 261);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(8, 312);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label9.Location = new System.Drawing.Point(50, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 18);
            this.label9.TabIndex = 73;
            this.label9.Text = "Moneda:";
            // 
            // combMon
            // 
            this.combMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.combMon.FormattingEnabled = true;
            this.combMon.Items.AddRange(new object[] {
            "USD",
            "ARS"});
            this.combMon.Location = new System.Drawing.Point(171, 220);
            this.combMon.Name = "combMon";
            this.combMon.Size = new System.Drawing.Size(212, 26);
            this.combMon.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(50, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 74;
            this.label6.Text = "Asistencia:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(8, 216);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.TabIndex = 75;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Location = new System.Drawing.Point(8, 60);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.TabIndex = 76;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.Location = new System.Drawing.Point(8, 108);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.TabIndex = 77;
            this.pictureBox6.TabStop = false;
            // 
            // tecAsistUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.combMon);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
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
            this.Size = new System.Drawing.Size(981, 400);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combMon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}
