﻿using System;

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
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.ATButton = new System.Windows.Forms.Button();
            this.RLButton = new System.Windows.Forms.Button();
            this.VPButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.OCNButton = new System.Windows.Forms.Button();
            this.OCEButton = new System.Windows.Forms.Button();
            this.OACButton = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button7 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.compNacUC1 = new MaxPowerSystem.compNacUC();
            this.compExteriorUC1 = new MaxPowerSystem.compExteriorUC();
            this.repProdUC1 = new MaxPowerSystem.repProdUC();
            this.ventaProdUC1 = new MaxPowerSystem.ventaProdUC();
            this.tecAsistUC1 = new MaxPowerSystem.tecAsistUC();
            this.viewDataBaseUC1 = new MaxPowerSystem.viewDataBaseUC();
            this.uploadDataBaseUC1 = new MaxPowerSystem.uploadDataBaseUC();
            this.ordConfUC1 = new MaxPowerSystem.OrdConfUC();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            flowLayoutPanel1.Controls.Add(this.button1);
            flowLayoutPanel1.Controls.Add(this.button4);
            flowLayoutPanel1.Controls.Add(this.button2);
            flowLayoutPanel1.Controls.Add(this.button6);
            flowLayoutPanel1.Controls.Add(this.button5);
            flowLayoutPanel1.Controls.Add(this.button8);
            flowLayoutPanel1.Controls.Add(this.ATButton);
            flowLayoutPanel1.Controls.Add(this.RLButton);
            flowLayoutPanel1.Controls.Add(this.VPButton);
            flowLayoutPanel1.Controls.Add(this.button3);
            flowLayoutPanel1.Controls.Add(this.OCNButton);
            flowLayoutPanel1.Controls.Add(this.OCEButton);
            flowLayoutPanel1.Controls.Add(this.OACButton);
            flowLayoutPanel1.Controls.Add(this.button9);
            flowLayoutPanel1.Controls.Add(this.button10);
            flowLayoutPanel1.Controls.Add(this.button11);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            flowLayoutPanel1.ForeColor = System.Drawing.Color.Transparent;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(200, 561);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(17)))), ((int)(((byte)(10)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 70);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 70, 0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 98);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 30);
            this.button4.TabIndex = 8;
            this.button4.Text = "Solicitudes ";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 128);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 28);
            this.button2.TabIndex = 0;
            this.button2.Text = "Empresas";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(0, 156);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(197, 26);
            this.button6.TabIndex = 9;
            this.button6.Text = "Proveedores";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.UseWaitCursor = true;
            this.button6.Visible = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(0, 182);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 26);
            this.button5.TabIndex = 10;
            this.button5.Text = "Clientes";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(0, 208);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(197, 32);
            this.button8.TabIndex = 6;
            this.button8.Text = "Cotizaciones";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.showMen);
            // 
            // ATButton
            // 
            this.ATButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ATButton.FlatAppearance.BorderSize = 0;
            this.ATButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ATButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ATButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ATButton.Location = new System.Drawing.Point(0, 240);
            this.ATButton.Margin = new System.Windows.Forms.Padding(0);
            this.ATButton.Name = "ATButton";
            this.ATButton.Size = new System.Drawing.Size(197, 26);
            this.ATButton.TabIndex = 1;
            this.ATButton.Text = "Asistencia técnica";
            this.ATButton.UseVisualStyleBackColor = false;
            this.ATButton.Visible = false;
            this.ATButton.Click += new System.EventHandler(this.Button3_Click);
            // 
            // RLButton
            // 
            this.RLButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RLButton.FlatAppearance.BorderSize = 0;
            this.RLButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RLButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RLButton.Location = new System.Drawing.Point(0, 266);
            this.RLButton.Margin = new System.Windows.Forms.Padding(0);
            this.RLButton.Name = "RLButton";
            this.RLButton.Size = new System.Drawing.Size(197, 26);
            this.RLButton.TabIndex = 2;
            this.RLButton.Text = "Reparación de laboratorio";
            this.RLButton.UseVisualStyleBackColor = false;
            this.RLButton.Visible = false;
            this.RLButton.Click += new System.EventHandler(this.Button4_Click);
            // 
            // VPButton
            // 
            this.VPButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.VPButton.FlatAppearance.BorderSize = 0;
            this.VPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VPButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VPButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.VPButton.Location = new System.Drawing.Point(0, 292);
            this.VPButton.Margin = new System.Windows.Forms.Padding(0);
            this.VPButton.Name = "VPButton";
            this.VPButton.Size = new System.Drawing.Size(197, 26);
            this.VPButton.TabIndex = 3;
            this.VPButton.Text = "Venta de productos";
            this.VPButton.UseVisualStyleBackColor = false;
            this.VPButton.Visible = false;
            this.VPButton.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 318);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 32);
            this.button3.TabIndex = 7;
            this.button3.Text = "Orden de compra";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.showMenComp);
            // 
            // OCNButton
            // 
            this.OCNButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.OCNButton.FlatAppearance.BorderSize = 0;
            this.OCNButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OCNButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OCNButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OCNButton.Location = new System.Drawing.Point(0, 350);
            this.OCNButton.Margin = new System.Windows.Forms.Padding(0);
            this.OCNButton.Name = "OCNButton";
            this.OCNButton.Size = new System.Drawing.Size(197, 26);
            this.OCNButton.TabIndex = 5;
            this.OCNButton.Text = "Nacional";
            this.OCNButton.UseVisualStyleBackColor = false;
            this.OCNButton.Visible = false;
            this.OCNButton.Click += new System.EventHandler(this.Button7_Click);
            // 
            // OCEButton
            // 
            this.OCEButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.OCEButton.FlatAppearance.BorderSize = 0;
            this.OCEButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OCEButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OCEButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OCEButton.Location = new System.Drawing.Point(0, 376);
            this.OCEButton.Margin = new System.Windows.Forms.Padding(0);
            this.OCEButton.Name = "OCEButton";
            this.OCEButton.Size = new System.Drawing.Size(197, 26);
            this.OCEButton.TabIndex = 4;
            this.OCEButton.Text = "Exterior";
            this.OCEButton.UseVisualStyleBackColor = false;
            this.OCEButton.Visible = false;
            this.OCEButton.Click += new System.EventHandler(this.Button6_Click);
            // 
            // OACButton
            // 
            this.OACButton.AutoSize = true;
            this.OACButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OACButton.FlatAppearance.BorderSize = 0;
            this.OACButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OACButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OACButton.ForeColor = System.Drawing.Color.White;
            this.OACButton.Location = new System.Drawing.Point(0, 402);
            this.OACButton.Margin = new System.Windows.Forms.Padding(0);
            this.OACButton.Name = "OACButton";
            this.OACButton.Size = new System.Drawing.Size(197, 32);
            this.OACButton.TabIndex = 11;
            this.OACButton.Text = "Consulta de ordenes";
            this.OACButton.UseVisualStyleBackColor = false;
            this.OACButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OACButton_MouseClick);
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(0, 434);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(197, 32);
            this.button9.TabIndex = 12;
            this.button9.Text = "Finanzas";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.AutoSize = true;
            this.button10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(0, 466);
            this.button10.Margin = new System.Windows.Forms.Padding(0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(197, 32);
            this.button10.TabIndex = 13;
            this.button10.Text = "Facturación";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.AutoSize = true;
            this.button11.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(0, 498);
            this.button11.Margin = new System.Windows.Forms.Padding(0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(197, 32);
            this.button11.TabIndex = 14;
            this.button11.Text = "Notificaciones";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.compNacUC1);
            this.panel1.Controls.Add(this.compExteriorUC1);
            this.panel1.Controls.Add(this.repProdUC1);
            this.panel1.Controls.Add(this.ventaProdUC1);
            this.panel1.Controls.Add(this.tecAsistUC1);
            this.panel1.Controls.Add(this.viewDataBaseUC1);
            this.panel1.Controls.Add(this.uploadDataBaseUC1);
            this.panel1.Controls.Add(this.ordConfUC1);
            this.panel1.Location = new System.Drawing.Point(200, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 561);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.flowLayoutPanel3.Controls.Add(this.button7);
            this.flowLayoutPanel3.Controls.Add(this.panel2);
            this.flowLayoutPanel3.Controls.Add(this.panel3);
            this.flowLayoutPanel3.Controls.Add(this.panel4);
            this.flowLayoutPanel3.Controls.Add(this.panel5);
            this.flowLayoutPanel3.Controls.Add(this.panel6);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1187, 70);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(1115, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(69, 62);
            this.button7.TabIndex = 8;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(909, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 67);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(703, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 67);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(497, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 67);
            this.panel4.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(291, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 67);
            this.panel5.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(12, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(273, 67);
            this.panel6.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.No;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(56, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Menu";
            // 
            // compNacUC1
            // 
            this.compNacUC1.Location = new System.Drawing.Point(3, 28);
            this.compNacUC1.Name = "compNacUC1";
            this.compNacUC1.Size = new System.Drawing.Size(984, 400);
            this.compNacUC1.TabIndex = 6;
            // 
            // compExteriorUC1
            // 
            this.compExteriorUC1.Location = new System.Drawing.Point(3, 28);
            this.compExteriorUC1.Name = "compExteriorUC1";
            this.compExteriorUC1.Size = new System.Drawing.Size(981, 400);
            this.compExteriorUC1.TabIndex = 5;
            // 
            // repProdUC1
            // 
            this.repProdUC1.Location = new System.Drawing.Point(3, 28);
            this.repProdUC1.Name = "repProdUC1";
            this.repProdUC1.Size = new System.Drawing.Size(981, 400);
            this.repProdUC1.TabIndex = 4;
            // 
            // ventaProdUC1
            // 
            this.ventaProdUC1.Location = new System.Drawing.Point(3, 28);
            this.ventaProdUC1.Name = "ventaProdUC1";
            this.ventaProdUC1.Size = new System.Drawing.Size(981, 400);
            this.ventaProdUC1.TabIndex = 3;
            // 
            // tecAsistUC1
            // 
            this.tecAsistUC1.Location = new System.Drawing.Point(3, 28);
            this.tecAsistUC1.Name = "tecAsistUC1";
            this.tecAsistUC1.Size = new System.Drawing.Size(984, 561);
            this.tecAsistUC1.TabIndex = 1;
            // 
            // viewDataBaseUC1
            // 
            this.viewDataBaseUC1.Location = new System.Drawing.Point(3, 10);
            this.viewDataBaseUC1.Name = "viewDataBaseUC1";
            this.viewDataBaseUC1.Size = new System.Drawing.Size(984, 561);
            this.viewDataBaseUC1.TabIndex = 0;
            // 
            // uploadDataBaseUC1
            // 
            this.uploadDataBaseUC1.Location = new System.Drawing.Point(15, 28);
            this.uploadDataBaseUC1.Name = "uploadDataBaseUC1";
            this.uploadDataBaseUC1.Size = new System.Drawing.Size(984, 561);
            this.uploadDataBaseUC1.TabIndex = 2;
            this.uploadDataBaseUC1.Load += new System.EventHandler(this.UploadDataBaseUC1_Load);
            // 
            // ordConfUC1
            // 
            this.ordConfUC1.Location = new System.Drawing.Point(3, 28);
            this.ordConfUC1.Name = "ordConfUC1";
            this.ordConfUC1.Size = new System.Drawing.Size(978, 561);
            this.ordConfUC1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(flowLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 726);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "Form1";
            this.Text = "MaxPower System";
            this.Load += new System.EventHandler(this.Form1_Load);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void UploadDataBaseUC1_Load(object sender, EventArgs e)
        {
            
        }



        #endregion

        private System.Windows.Forms.Panel panel1;
        private viewDataBaseUC viewDataBaseUC1;
        private uploadDataBaseUC uploadDataBaseUC1;
        private tecAsistUC tecAsistUC1;
        private ventaProdUC ventaProdUC1;
        private repProdUC repProdUC1;
        private compExteriorUC compExteriorUC1;
        private compNacUC compNacUC1;
        private OrdConfUC ordConfUC1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button OACButton;
        private System.Windows.Forms.Button OCEButton;
        private System.Windows.Forms.Button OCNButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button VPButton;
        private System.Windows.Forms.Button RLButton;
        private System.Windows.Forms.Button ATButton;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

