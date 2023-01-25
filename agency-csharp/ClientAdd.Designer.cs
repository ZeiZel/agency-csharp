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
    partial class ClientAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientAdd));
            this.add_btn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.clientNum_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clientName_tb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.clientSur_tb = new System.Windows.Forms.TextBox();
            this.clientPat_tb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.adressApartment_tb = new System.Windows.Forms.TextBox();
            this.adressBuilding_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adressRegion_tb = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.adressCity_tb = new System.Windows.Forms.TextBox();
            this.adressStreet_tb = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.add_btn.Location = new System.Drawing.Point(24, 22);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(184, 53);
            this.add_btn.TabIndex = 19;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox4.Controls.Add(this.clientNum_tb);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.clientName_tb);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.clientSur_tb);
            this.groupBox4.Controls.Add(this.clientPat_tb);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.groupBox4.Location = new System.Drawing.Point(339, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(275, 399);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Персональные данные";
            // 
            // clientNum_tb
            // 
            this.clientNum_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.clientNum_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientNum_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clientNum_tb.Location = new System.Drawing.Point(31, 330);
            this.clientNum_tb.Multiline = true;
            this.clientNum_tb.Name = "clientNum_tb";
            this.clientNum_tb.Size = new System.Drawing.Size(212, 35);
            this.clientNum_tb.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(31, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Имя";
            // 
            // clientName_tb
            // 
            this.clientName_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.clientName_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientName_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clientName_tb.Location = new System.Drawing.Point(31, 81);
            this.clientName_tb.Multiline = true;
            this.clientName_tb.Name = "clientName_tb";
            this.clientName_tb.Size = new System.Drawing.Size(212, 35);
            this.clientName_tb.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label8.Location = new System.Drawing.Point(31, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 22);
            this.label8.TabIndex = 9;
            this.label8.Text = "Контактный номер";
            // 
            // clientSur_tb
            // 
            this.clientSur_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.clientSur_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientSur_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clientSur_tb.Location = new System.Drawing.Point(31, 164);
            this.clientSur_tb.Multiline = true;
            this.clientSur_tb.Name = "clientSur_tb";
            this.clientSur_tb.Size = new System.Drawing.Size(212, 35);
            this.clientSur_tb.TabIndex = 8;
            // 
            // clientPat_tb
            // 
            this.clientPat_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.clientPat_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientPat_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clientPat_tb.Location = new System.Drawing.Point(31, 247);
            this.clientPat_tb.Multiline = true;
            this.clientPat_tb.Name = "clientPat_tb";
            this.clientPat_tb.Size = new System.Drawing.Size(212, 35);
            this.clientPat_tb.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label10.Location = new System.Drawing.Point(31, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 22);
            this.label10.TabIndex = 9;
            this.label10.Text = "Отчество";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label11.Location = new System.Drawing.Point(31, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 22);
            this.label11.TabIndex = 9;
            this.label11.Text = "Фамилия";
            // 
            // groupBox12
            // 
            this.groupBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox12.Controls.Add(this.adressApartment_tb);
            this.groupBox12.Controls.Add(this.adressBuilding_tb);
            this.groupBox12.Controls.Add(this.label1);
            this.groupBox12.Controls.Add(this.adressRegion_tb);
            this.groupBox12.Controls.Add(this.label22);
            this.groupBox12.Controls.Add(this.label9);
            this.groupBox12.Controls.Add(this.adressCity_tb);
            this.groupBox12.Controls.Add(this.adressStreet_tb);
            this.groupBox12.Controls.Add(this.label15);
            this.groupBox12.Controls.Add(this.label16);
            this.groupBox12.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.groupBox12.Location = new System.Drawing.Point(12, 12);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(296, 399);
            this.groupBox12.TabIndex = 27;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Данные адреса";
            // 
            // adressApartment_tb
            // 
            this.adressApartment_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.adressApartment_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressApartment_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adressApartment_tb.Location = new System.Drawing.Point(38, 332);
            this.adressApartment_tb.Multiline = true;
            this.adressApartment_tb.Name = "adressApartment_tb";
            this.adressApartment_tb.Size = new System.Drawing.Size(212, 35);
            this.adressApartment_tb.TabIndex = 8;
            // 
            // adressBuilding_tb
            // 
            this.adressBuilding_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.adressBuilding_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressBuilding_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adressBuilding_tb.Location = new System.Drawing.Point(38, 267);
            this.adressBuilding_tb.Multiline = true;
            this.adressBuilding_tb.Name = "adressBuilding_tb";
            this.adressBuilding_tb.Size = new System.Drawing.Size(212, 35);
            this.adressBuilding_tb.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(38, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Регион";
            // 
            // adressRegion_tb
            // 
            this.adressRegion_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.adressRegion_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressRegion_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adressRegion_tb.Location = new System.Drawing.Point(38, 72);
            this.adressRegion_tb.Multiline = true;
            this.adressRegion_tb.Name = "adressRegion_tb";
            this.adressRegion_tb.Size = new System.Drawing.Size(212, 35);
            this.adressRegion_tb.TabIndex = 8;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label22.Location = new System.Drawing.Point(38, 306);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 22);
            this.label22.TabIndex = 9;
            this.label22.Text = "Квартира";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label9.Location = new System.Drawing.Point(38, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "Строение";
            // 
            // adressCity_tb
            // 
            this.adressCity_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.adressCity_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressCity_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adressCity_tb.Location = new System.Drawing.Point(38, 137);
            this.adressCity_tb.Multiline = true;
            this.adressCity_tb.Name = "adressCity_tb";
            this.adressCity_tb.Size = new System.Drawing.Size(212, 35);
            this.adressCity_tb.TabIndex = 8;
            // 
            // adressStreet_tb
            // 
            this.adressStreet_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.adressStreet_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressStreet_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adressStreet_tb.Location = new System.Drawing.Point(38, 202);
            this.adressStreet_tb.Multiline = true;
            this.adressStreet_tb.Name = "adressStreet_tb";
            this.adressStreet_tb.Size = new System.Drawing.Size(212, 35);
            this.adressStreet_tb.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label15.Location = new System.Drawing.Point(38, 176);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 22);
            this.label15.TabIndex = 9;
            this.label15.Text = "Улица";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label16.Location = new System.Drawing.Point(38, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(176, 22);
            this.label16.TabIndex = 9;
            this.label16.Text = "Населённый пункт";
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancel_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cancel_btn.Location = new System.Drawing.Point(232, 22);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(184, 53);
            this.cancel_btn.TabIndex = 28;
            this.cancel_btn.Text = "Отмена";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.add_btn);
            this.groupBox1.Controls.Add(this.cancel_btn);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.groupBox1.Location = new System.Drawing.Point(93, 442);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 90);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // ClientAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 566);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientAdd";
            this.Text = "Добавить клиента";
            this.Load += new System.EventHandler(this.ClientAdd_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button add_btn;
        private GroupBox groupBox4;
        private TextBox clientNum_tb;
        private Label label2;
        private TextBox clientName_tb;
        private Label label8;
        private TextBox clientSur_tb;
        private TextBox clientPat_tb;
        private Label label10;
        private Label label11;
        private GroupBox groupBox12;
        private TextBox adressApartment_tb;
        private TextBox adressBuilding_tb;
        private Label label1;
        private TextBox adressRegion_tb;
        private Label label22;
        private Label label9;
        private TextBox adressCity_tb;
        private TextBox adressStreet_tb;
        private Label label15;
        private Label label16;
        private Button cancel_btn;
        private GroupBox groupBox1;
    }
}