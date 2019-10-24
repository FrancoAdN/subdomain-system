using System;

namespace MaxPowerSystem
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.ATButton = new System.Windows.Forms.Button();
            this.RLButton = new System.Windows.Forms.Button();
            this.VPButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.OCNButton = new System.Windows.Forms.Button();
            this.OCEButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.OACButton = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newSearch = new System.Windows.Forms.Button();
            this.ordConfUC1 = new MaxPowerSystem.OrdConfUC();
            this.compNacUC1 = new MaxPowerSystem.compNacUC();
            this.compExteriorUC1 = new MaxPowerSystem.compExteriorUC();
            this.repProdUC1 = new MaxPowerSystem.repProdUC();
            this.ventaProdUC1 = new MaxPowerSystem.ventaProdUC();
            this.uploadDataBaseUC1 = new MaxPowerSystem.uploadDataBaseUC();
            this.tecAsistUC1 = new MaxPowerSystem.tecAsistUC();
            this.viewDataBaseUC1 = new MaxPowerSystem.viewDataBaseUC();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(this.button1);
            flowLayoutPanel1.Controls.Add(this.button2);
            flowLayoutPanel1.Controls.Add(this.button8);
            flowLayoutPanel1.Controls.Add(this.ATButton);
            flowLayoutPanel1.Controls.Add(this.RLButton);
            flowLayoutPanel1.Controls.Add(this.VPButton);
            flowLayoutPanel1.Controls.Add(this.button3);
            flowLayoutPanel1.Controls.Add(this.OCNButton);
            flowLayoutPanel1.Controls.Add(this.OCEButton);
            flowLayoutPanel1.Controls.Add(this.button4);
            flowLayoutPanel1.Controls.Add(this.button5);
            flowLayoutPanel1.Controls.Add(this.button6);
            flowLayoutPanel1.Controls.Add(this.OACButton);
            flowLayoutPanel1.Controls.Add(this.button9);
            flowLayoutPanel1.Controls.Add(this.button10);
            flowLayoutPanel1.Controls.Add(this.button11);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(200, 561);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Base de datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button2.Location = new System.Drawing.Point(3, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 28);
            this.button2.TabIndex = 0;
            this.button2.Text = "Empresas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button8.Location = new System.Drawing.Point(3, 71);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(197, 30);
            this.button8.TabIndex = 6;
            this.button8.Text = "Cotizaciones";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.showMen);
            // 
            // ATButton
            // 
            this.ATButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATButton.Location = new System.Drawing.Point(11, 107);
            this.ATButton.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ATButton.Name = "ATButton";
            this.ATButton.Size = new System.Drawing.Size(177, 28);
            this.ATButton.TabIndex = 1;
            this.ATButton.Text = "Asistencia técnica";
            this.ATButton.UseVisualStyleBackColor = true;
            this.ATButton.Visible = false;
            this.ATButton.Click += new System.EventHandler(this.Button3_Click);
            // 
            // RLButton
            // 
            this.RLButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLButton.Location = new System.Drawing.Point(11, 141);
            this.RLButton.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.RLButton.Name = "RLButton";
            this.RLButton.Size = new System.Drawing.Size(177, 28);
            this.RLButton.TabIndex = 2;
            this.RLButton.Text = "Reparación de laboratorio";
            this.RLButton.UseVisualStyleBackColor = true;
            this.RLButton.Visible = false;
            this.RLButton.Click += new System.EventHandler(this.Button4_Click);
            // 
            // VPButton
            // 
            this.VPButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VPButton.Location = new System.Drawing.Point(11, 175);
            this.VPButton.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.VPButton.Name = "VPButton";
            this.VPButton.Size = new System.Drawing.Size(177, 28);
            this.VPButton.TabIndex = 3;
            this.VPButton.Text = "Venta de productos";
            this.VPButton.UseVisualStyleBackColor = true;
            this.VPButton.Visible = false;
            this.VPButton.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button3.Location = new System.Drawing.Point(3, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 30);
            this.button3.TabIndex = 7;
            this.button3.Text = "Orden de compra";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.showMenComp);
            // 
            // OCNButton
            // 
            this.OCNButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OCNButton.Location = new System.Drawing.Point(11, 245);
            this.OCNButton.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.OCNButton.Name = "OCNButton";
            this.OCNButton.Size = new System.Drawing.Size(177, 28);
            this.OCNButton.TabIndex = 5;
            this.OCNButton.Text = "Nacional";
            this.OCNButton.UseVisualStyleBackColor = true;
            this.OCNButton.Visible = false;
            this.OCNButton.Click += new System.EventHandler(this.Button7_Click);
            // 
            // OCEButton
            // 
            this.OCEButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OCEButton.Location = new System.Drawing.Point(11, 279);
            this.OCEButton.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.OCEButton.Name = "OCEButton";
            this.OCEButton.Size = new System.Drawing.Size(177, 28);
            this.OCEButton.TabIndex = 4;
            this.OCEButton.Text = "Exterior";
            this.OCEButton.UseVisualStyleBackColor = true;
            this.OCEButton.Visible = false;
            this.OCEButton.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button4.Location = new System.Drawing.Point(3, 313);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 30);
            this.button4.TabIndex = 8;
            this.button4.Text = "Solicitudes";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(11, 349);
            this.button5.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(177, 28);
            this.button5.TabIndex = 10;
            this.button5.Text = "Clientes";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(11, 383);
            this.button6.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(177, 28);
            this.button6.TabIndex = 9;
            this.button6.Text = "Proveedores";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            // 
            // OACButton
            // 
            this.OACButton.AutoSize = true;
            this.OACButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.OACButton.Location = new System.Drawing.Point(3, 417);
            this.OACButton.Name = "OACButton";
            this.OACButton.Size = new System.Drawing.Size(197, 30);
            this.OACButton.TabIndex = 11;
            this.OACButton.Text = "Consulta de ordenes";
            this.OACButton.UseVisualStyleBackColor = true;
            this.OACButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OACButton_MouseClick);
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button9.Location = new System.Drawing.Point(3, 453);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(197, 30);
            this.button9.TabIndex = 12;
            this.button9.Text = "Finanzas";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.AutoSize = true;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button10.Location = new System.Drawing.Point(3, 489);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(197, 30);
            this.button10.TabIndex = 13;
            this.button10.Text = "Facturación";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.AutoSize = true;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button11.Location = new System.Drawing.Point(3, 525);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(197, 30);
            this.button11.TabIndex = 14;
            this.button11.Text = "Notificaciones";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.newSearch);
            this.panel1.Controls.Add(this.ordConfUC1);
            this.panel1.Controls.Add(this.compNacUC1);
            this.panel1.Controls.Add(this.compExteriorUC1);
            this.panel1.Controls.Add(this.repProdUC1);
            this.panel1.Controls.Add(this.ventaProdUC1);
            this.panel1.Controls.Add(this.uploadDataBaseUC1);
            this.panel1.Controls.Add(this.tecAsistUC1);
            this.panel1.Controls.Add(this.viewDataBaseUC1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 561);
            this.panel1.TabIndex = 0;
            // 
            // newSearch
            // 
            this.newSearch.Image = ((System.Drawing.Image)(resources.GetObject("newSearch.Image")));
            this.newSearch.Location = new System.Drawing.Point(598, 5);
            this.newSearch.Name = "newSearch";
            this.newSearch.Size = new System.Drawing.Size(31, 26);
            this.newSearch.TabIndex = 8;
            this.newSearch.UseVisualStyleBackColor = true;
            this.newSearch.Visible = false;
            // 
            // ordConfUC1
            // 
            this.ordConfUC1.Location = new System.Drawing.Point(3, 0);
            this.ordConfUC1.Name = "ordConfUC1";
            this.ordConfUC1.Size = new System.Drawing.Size(978, 561);
            this.ordConfUC1.TabIndex = 7;
            // 
            // compNacUC1
            // 
            this.compNacUC1.Location = new System.Drawing.Point(0, -4);
            this.compNacUC1.Name = "compNacUC1";
            this.compNacUC1.Size = new System.Drawing.Size(984, 333);
            this.compNacUC1.TabIndex = 6;
            // 
            // compExteriorUC1
            // 
            this.compExteriorUC1.Location = new System.Drawing.Point(0, -5);
            this.compExteriorUC1.Name = "compExteriorUC1";
            this.compExteriorUC1.Size = new System.Drawing.Size(981, 333);
            this.compExteriorUC1.TabIndex = 5;
            // 
            // repProdUC1
            // 
            this.repProdUC1.Location = new System.Drawing.Point(0, -5);
            this.repProdUC1.Name = "repProdUC1";
            this.repProdUC1.Size = new System.Drawing.Size(981, 333);
            this.repProdUC1.TabIndex = 4;
            // 
            // ventaProdUC1
            // 
            this.ventaProdUC1.Location = new System.Drawing.Point(0, 0);
            this.ventaProdUC1.Name = "ventaProdUC1";
            this.ventaProdUC1.Size = new System.Drawing.Size(981, 333);
            this.ventaProdUC1.TabIndex = 3;
            // 
            // uploadDataBaseUC1
            // 
            this.uploadDataBaseUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uploadDataBaseUC1.Location = new System.Drawing.Point(0, 0);
            this.uploadDataBaseUC1.Name = "uploadDataBaseUC1";
            this.uploadDataBaseUC1.Size = new System.Drawing.Size(984, 561);
            this.uploadDataBaseUC1.TabIndex = 2;
            this.uploadDataBaseUC1.Load += new System.EventHandler(this.UploadDataBaseUC1_Load);
            // 
            // tecAsistUC1
            // 
            this.tecAsistUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tecAsistUC1.Location = new System.Drawing.Point(0, 0);
            this.tecAsistUC1.Name = "tecAsistUC1";
            this.tecAsistUC1.Size = new System.Drawing.Size(984, 561);
            this.tecAsistUC1.TabIndex = 1;
            // 
            // viewDataBaseUC1
            // 
            this.viewDataBaseUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewDataBaseUC1.Location = new System.Drawing.Point(0, 0);
            this.viewDataBaseUC1.Name = "viewDataBaseUC1";
            this.viewDataBaseUC1.Size = new System.Drawing.Size(984, 561);
            this.viewDataBaseUC1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(flowLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.MinimumSize = new System.Drawing.Size(1200, 364);
            this.Name = "Form1";
            this.Text = "MaxPower System";
            this.Load += new System.EventHandler(this.Form1_Load);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void UploadDataBaseUC1_Load(object sender, EventArgs e)
        {
            
        }



        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ATButton;
        private System.Windows.Forms.Button RLButton;
        private System.Windows.Forms.Button VPButton;
        private System.Windows.Forms.Button OCEButton;
        private System.Windows.Forms.Button OCNButton;
        private viewDataBaseUC viewDataBaseUC1;
        private uploadDataBaseUC uploadDataBaseUC1;
        private tecAsistUC tecAsistUC1;
        private ventaProdUC ventaProdUC1;
        private repProdUC repProdUC1;
        private compExteriorUC compExteriorUC1;
        private compNacUC compNacUC1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button OACButton;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private OrdConfUC ordConfUC1;
        private System.Windows.Forms.Button newSearch;
    }
}

