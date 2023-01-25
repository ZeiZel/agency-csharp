
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agency_csharp
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.LoginBtn = new System.Windows.Forms.Button();
            this.login_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.register_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openedEye_pb = new System.Windows.Forms.PictureBox();
            this.closedEye_pb = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.org_btn = new System.Windows.Forms.Button();
            this.worker_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openedEye_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closedEye_pb)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.LoginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LoginBtn.Location = new System.Drawing.Point(75, 338);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(143, 52);
            this.LoginBtn.TabIndex = 0;
            this.LoginBtn.Text = "Вход";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // login_tb
            // 
            this.login_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.login_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.login_tb.Location = new System.Drawing.Point(75, 164);
            this.login_tb.Multiline = true;
            this.login_tb.Name = "login_tb";
            this.login_tb.Size = new System.Drawing.Size(292, 36);
            this.login_tb.TabIndex = 1;
            // 
            // password_tb
            // 
            this.password_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.password_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.password_tb.Location = new System.Drawing.Point(75, 260);
            this.password_tb.Multiline = true;
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(292, 36);
            this.password_tb.TabIndex = 1;
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.register_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.register_btn.FlatAppearance.BorderSize = 0;
            this.register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_btn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.register_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.register_btn.Location = new System.Drawing.Point(224, 338);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(143, 52);
            this.register_btn.TabIndex = 0;
            this.register_btn.Text = "Регистрация";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(701, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(75, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(75, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // openedEye_pb
            // 
            this.openedEye_pb.Image = ((System.Drawing.Image)(resources.GetObject("openedEye_pb.Image")));
            this.openedEye_pb.Location = new System.Drawing.Point(381, 260);
            this.openedEye_pb.Name = "openedEye_pb";
            this.openedEye_pb.Size = new System.Drawing.Size(35, 35);
            this.openedEye_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.openedEye_pb.TabIndex = 4;
            this.openedEye_pb.TabStop = false;
            this.openedEye_pb.Click += new System.EventHandler(this.openedEye_pb_Click);
            // 
            // closedEye_pb
            // 
            this.closedEye_pb.Image = ((System.Drawing.Image)(resources.GetObject("closedEye_pb.Image")));
            this.closedEye_pb.Location = new System.Drawing.Point(381, 260);
            this.closedEye_pb.Name = "closedEye_pb";
            this.closedEye_pb.Size = new System.Drawing.Size(35, 35);
            this.closedEye_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closedEye_pb.TabIndex = 4;
            this.closedEye_pb.TabStop = false;
            this.closedEye_pb.Click += new System.EventHandler(this.closedEye_pb_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(381, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 50);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.LoginBtn);
            this.panel1.Controls.Add(this.closedEye_pb);
            this.panel1.Controls.Add(this.org_btn);
            this.panel1.Controls.Add(this.worker_btn);
            this.panel1.Controls.Add(this.register_btn);
            this.panel1.Controls.Add(this.openedEye_pb);
            this.panel1.Controls.Add(this.login_tb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.password_tb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 600);
            this.panel1.TabIndex = 7;
            // 
            // org_btn
            // 
            this.org_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.org_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.org_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.org_btn.FlatAppearance.BorderSize = 0;
            this.org_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.org_btn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.org_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.org_btn.Location = new System.Drawing.Point(152, 510);
            this.org_btn.Name = "org_btn";
            this.org_btn.Size = new System.Drawing.Size(143, 52);
            this.org_btn.TabIndex = 0;
            this.org_btn.Text = "Организация";
            this.org_btn.UseVisualStyleBackColor = false;
            this.org_btn.Click += new System.EventHandler(this.org_btn_Click);
            // 
            // worker_btn
            // 
            this.worker_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.worker_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.worker_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.worker_btn.FlatAppearance.BorderSize = 0;
            this.worker_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.worker_btn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.worker_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.worker_btn.Location = new System.Drawing.Point(152, 452);
            this.worker_btn.Name = "worker_btn";
            this.worker_btn.Size = new System.Drawing.Size(143, 52);
            this.worker_btn.TabIndex = 0;
            this.worker_btn.Text = "Соискатель";
            this.worker_btn.UseVisualStyleBackColor = false;
            this.worker_btn.Click += new System.EventHandler(this.worker_btn_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openedEye_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closedEye_pb)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button worker_btn;
        private System.Windows.Forms.Button org_btn;

        #endregion

        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox login_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Button register_btn;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Label label2;
        private System.Windows.Forms.PictureBox openedEye_pb;
        private System.Windows.Forms.PictureBox closedEye_pb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}