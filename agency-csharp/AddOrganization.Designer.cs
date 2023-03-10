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
    partial class AddOrganization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrganization));
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.orgClient_tb = new System.Windows.Forms.TextBox();
            this.orgNum_tb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.orgMail_tb = new System.Windows.Forms.TextBox();
            this.orgName_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.orgAdd_btn = new System.Windows.Forms.Button();
            this.orgDel_btn = new System.Windows.Forms.Button();
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
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox7.Controls.Add(this.orgClient_tb);
            this.groupBox7.Controls.Add(this.orgNum_tb);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.orgMail_tb);
            this.groupBox7.Controls.Add(this.orgName_tb);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.groupBox7.Location = new System.Drawing.Point(287, 18);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(254, 346);
            this.groupBox7.TabIndex = 30;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Персональные данные";
            // 
            // orgClient_tb
            // 
            this.orgClient_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.orgClient_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orgClient_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.orgClient_tb.Location = new System.Drawing.Point(41, 120);
            this.orgClient_tb.Multiline = true;
            this.orgClient_tb.Name = "orgClient_tb";
            this.orgClient_tb.Size = new System.Drawing.Size(182, 30);
            this.orgClient_tb.TabIndex = 8;
            // 
            // orgNum_tb
            // 
            this.orgNum_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.orgNum_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orgNum_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.orgNum_tb.Location = new System.Drawing.Point(41, 177);
            this.orgNum_tb.Multiline = true;
            this.orgNum_tb.Name = "orgNum_tb";
            this.orgNum_tb.Size = new System.Drawing.Size(182, 30);
            this.orgNum_tb.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label12.Location = new System.Drawing.Point(41, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Наименование";
            // 
            // orgMail_tb
            // 
            this.orgMail_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.orgMail_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orgMail_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.orgMail_tb.Location = new System.Drawing.Point(41, 237);
            this.orgMail_tb.Multiline = true;
            this.orgMail_tb.Name = "orgMail_tb";
            this.orgMail_tb.Size = new System.Drawing.Size(182, 30);
            this.orgMail_tb.TabIndex = 8;
            // 
            // orgName_tb
            // 
            this.orgName_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.orgName_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orgName_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.orgName_tb.Location = new System.Drawing.Point(41, 62);
            this.orgName_tb.Multiline = true;
            this.orgName_tb.Name = "orgName_tb";
            this.orgName_tb.Size = new System.Drawing.Size(182, 30);
            this.orgName_tb.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(41, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Представитель";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label13.Location = new System.Drawing.Point(41, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(168, 20);
            this.label13.TabIndex = 9;
            this.label13.Text = "Контактный номер";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label14.Location = new System.Drawing.Point(41, 215);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "Почта";
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox8.Controls.Add(this.orgAdd_btn);
            this.groupBox8.Controls.Add(this.orgDel_btn);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.groupBox8.Location = new System.Drawing.Point(100, 377);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(351, 108);
            this.groupBox8.TabIndex = 31;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Панель управления";
            // 
            // orgAdd_btn
            // 
            this.orgAdd_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.orgAdd_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orgAdd_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.orgAdd_btn.FlatAppearance.BorderSize = 0;
            this.orgAdd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orgAdd_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.orgAdd_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.orgAdd_btn.Location = new System.Drawing.Point(9, 29);
            this.orgAdd_btn.Name = "orgAdd_btn";
            this.orgAdd_btn.Size = new System.Drawing.Size(158, 56);
            this.orgAdd_btn.TabIndex = 18;
            this.orgAdd_btn.Text = "Добавить";
            this.orgAdd_btn.UseVisualStyleBackColor = false;
            this.orgAdd_btn.Click += new System.EventHandler(this.orgAdd_btn_Click);
            // 
            // orgDel_btn
            // 
            this.orgDel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.orgDel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orgDel_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.orgDel_btn.FlatAppearance.BorderSize = 0;
            this.orgDel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orgDel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.orgDel_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.orgDel_btn.Location = new System.Drawing.Point(185, 29);
            this.orgDel_btn.Name = "orgDel_btn";
            this.orgDel_btn.Size = new System.Drawing.Size(158, 56);
            this.orgDel_btn.TabIndex = 18;
            this.orgDel_btn.Text = "Отмена";
            this.orgDel_btn.UseVisualStyleBackColor = false;
            this.orgDel_btn.Click += new System.EventHandler(this.orgDel_btn_Click);
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
            this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.groupBox12.Location = new System.Drawing.Point(10, 18);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(254, 346);
            this.groupBox12.TabIndex = 32;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Данные адреса";
            // 
            // adressApartment_tb
            // 
            this.adressApartment_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.adressApartment_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressApartment_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.adressApartment_tb.Location = new System.Drawing.Point(33, 288);
            this.adressApartment_tb.Multiline = true;
            this.adressApartment_tb.Name = "adressApartment_tb";
            this.adressApartment_tb.Size = new System.Drawing.Size(182, 30);
            this.adressApartment_tb.TabIndex = 8;
            // 
            // adressBuilding_tb
            // 
            this.adressBuilding_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.adressBuilding_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressBuilding_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.adressBuilding_tb.Location = new System.Drawing.Point(33, 231);
            this.adressBuilding_tb.Multiline = true;
            this.adressBuilding_tb.Name = "adressBuilding_tb";
            this.adressBuilding_tb.Size = new System.Drawing.Size(182, 30);
            this.adressBuilding_tb.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Регион";
            // 
            // adressRegion_tb
            // 
            this.adressRegion_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.adressRegion_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressRegion_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.adressRegion_tb.Location = new System.Drawing.Point(33, 62);
            this.adressRegion_tb.Multiline = true;
            this.adressRegion_tb.Name = "adressRegion_tb";
            this.adressRegion_tb.Size = new System.Drawing.Size(182, 30);
            this.adressRegion_tb.TabIndex = 8;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label22.Location = new System.Drawing.Point(33, 265);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(90, 20);
            this.label22.TabIndex = 9;
            this.label22.Text = "Квартира";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label9.Location = new System.Drawing.Point(33, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Строение";
            // 
            // adressCity_tb
            // 
            this.adressCity_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.adressCity_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressCity_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.adressCity_tb.Location = new System.Drawing.Point(33, 119);
            this.adressCity_tb.Multiline = true;
            this.adressCity_tb.Name = "adressCity_tb";
            this.adressCity_tb.Size = new System.Drawing.Size(182, 30);
            this.adressCity_tb.TabIndex = 8;
            // 
            // adressStreet_tb
            // 
            this.adressStreet_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.adressStreet_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressStreet_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.adressStreet_tb.Location = new System.Drawing.Point(33, 175);
            this.adressStreet_tb.Multiline = true;
            this.adressStreet_tb.Name = "adressStreet_tb";
            this.adressStreet_tb.Size = new System.Drawing.Size(182, 30);
            this.adressStreet_tb.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label15.Location = new System.Drawing.Point(33, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 20);
            this.label15.TabIndex = 9;
            this.label15.Text = "Улица";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label16.Location = new System.Drawing.Point(33, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(166, 20);
            this.label16.TabIndex = 9;
            this.label16.Text = "Населённый пункт";
            // 
            // AddOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 507);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddOrganization";
            this.Text = "Добавить организацию";
            this.Load += new System.EventHandler(this.AddOrganization_Load);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox7;
        private TextBox orgNum_tb;
        private Label label12;
        private TextBox orgMail_tb;
        private TextBox orgName_tb;
        private Label label13;
        private Label label14;
        private GroupBox groupBox8;
        private Button orgAdd_btn;
        private Button orgDel_btn;
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
        private TextBox orgClient_tb;
        private Label label2;
    }
}