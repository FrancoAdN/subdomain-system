using System;

namespace MaxPowerSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pwdBox = new System.Windows.Forms.TextBox();
            this.usrBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.passwordPB = new System.Windows.Forms.PictureBox();
            this.userPB = new System.Windows.Forms.PictureBox();
            this.logoPB = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(17)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 42);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "MaxPower System";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(17)))), ((int)(((byte)(10)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(17)))), ((int)(((byte)(10)))));
            this.button2.Location = new System.Drawing.Point(275, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 32);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button2_MouseClick);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(313, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button1_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pwdBox);
            this.panel2.Controls.Add(this.usrBox);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.passwordPB);
            this.panel2.Controls.Add(this.userPB);
            this.panel2.Controls.Add(this.logoPB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 334);
            this.panel2.TabIndex = 1;
            // 
            // pwdBox
            // 
            this.pwdBox.AcceptsReturn = true;
            this.pwdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdBox.Location = new System.Drawing.Point(89, 214);
            this.pwdBox.Name = "pwdBox";
            this.pwdBox.Size = new System.Drawing.Size(197, 26);
            this.pwdBox.TabIndex = 5;
            this.pwdBox.GotFocus += new System.EventHandler(this.OnFocusPWD);
            this.pwdBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_KeyPress);
            this.pwdBox.LostFocus += new System.EventHandler(this.LostFocusPWD);
            // 
            // usrBox
            // 
            this.usrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrBox.Location = new System.Drawing.Point(89, 173);
            this.usrBox.Name = "usrBox";
            this.usrBox.Size = new System.Drawing.Size(197, 26);
            this.usrBox.TabIndex = 4;
            this.usrBox.GotFocus += new System.EventHandler(this.TextGotFocus);
            this.usrBox.LostFocus += new System.EventHandler(this.TextLostFocus);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(17)))), ((int)(((byte)(10)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(85, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "Iniciar Sesión";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ValLogin);
            // 
            // passwordPB
            // 
            this.passwordPB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passwordPB.BackgroundImage")));
            this.passwordPB.Location = new System.Drawing.Point(49, 208);
            this.passwordPB.Name = "passwordPB";
            this.passwordPB.Size = new System.Drawing.Size(32, 32);
            this.passwordPB.TabIndex = 2;
            this.passwordPB.TabStop = false;
            // 
            // userPB
            // 
            this.userPB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userPB.BackgroundImage")));
            this.userPB.Location = new System.Drawing.Point(49, 170);
            this.userPB.Name = "userPB";
            this.userPB.Size = new System.Drawing.Size(32, 32);
            this.userPB.TabIndex = 1;
            this.userPB.TabStop = false;
            // 
            // logoPB
            // 
            this.logoPB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPB.BackgroundImage")));
            this.logoPB.Location = new System.Drawing.Point(136, 29);
            this.logoPB.Name = "logoPB";
            this.logoPB.Size = new System.Drawing.Size(98, 92);
            this.logoPB.TabIndex = 0;
            this.logoPB.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Inicio de sesión";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 376);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pwdBox;
        private System.Windows.Forms.TextBox usrBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox passwordPB;
        private System.Windows.Forms.PictureBox userPB;
        private System.Windows.Forms.PictureBox logoPB;
        private System.Windows.Forms.Label label2;
    }
}