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
            this.clientStatus_cb = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.profession_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.education_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.birth_tb = new System.Windows.Forms.TextBox();
            this.sex_cb = new System.Windows.Forms.ComboBox();
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
            this.add_btn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.add_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.add_btn.Location = new System.Drawing.Point(23, 40);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(158, 46);
            this.add_btn.TabIndex = 19;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox4.Controls.Add(this.sex_cb);
            this.groupBox4.Controls.Add(this.clientStatus_cb);
            this.groupBox4.Controls.Add(this.birth_tb);
            this.groupBox4.Controls.Add(this.education_tb);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.profession_tb);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.clientNum_tb);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.clientName_tb);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.clientSur_tb);
            this.groupBox4.Controls.Add(this.clientPat_tb);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Font = new System.Drawing.Font("Montserrat", 10F);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.groupBox4.Location = new System.Drawing.Point(303, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(334, 499);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Персональные данные";
            // 
            // clientNum_tb
            // 
            this.clientNum_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.clientNum_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientNum_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.clientNum_tb.Location = new System.Drawing.Point(27, 229);
            this.clientNum_tb.Multiline = true;
            this.clientNum_tb.Name = "clientNum_tb";
            this.clientNum_tb.Size = new System.Drawing.Size(282, 30);
            this.clientNum_tb.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(27, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Имя";
            // 
            // clientName_tb
            // 
            this.clientName_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.clientName_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientName_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.clientName_tb.Location = new System.Drawing.Point(27, 60);
            this.clientName_tb.Multiline = true;
            this.clientName_tb.Name = "clientName_tb";
            this.clientName_tb.Size = new System.Drawing.Size(164, 30);
            this.clientName_tb.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label8.Location = new System.Drawing.Point(27, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 22);
            this.label8.TabIndex = 9;
            this.label8.Text = "Контактный номер";
            // 
            // clientSur_tb
            // 
            this.clientSur_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.clientSur_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientSur_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.clientSur_tb.Location = new System.Drawing.Point(27, 117);
            this.clientSur_tb.Multiline = true;
            this.clientSur_tb.Name = "clientSur_tb";
            this.clientSur_tb.Size = new System.Drawing.Size(282, 30);
            this.clientSur_tb.TabIndex = 8;
            // 
            // clientPat_tb
            // 
            this.clientPat_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.clientPat_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientPat_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.clientPat_tb.Location = new System.Drawing.Point(27, 173);
            this.clientPat_tb.Multiline = true;
            this.clientPat_tb.Name = "clientPat_tb";
            this.clientPat_tb.Size = new System.Drawing.Size(282, 30);
            this.clientPat_tb.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label10.Location = new System.Drawing.Point(27, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 22);
            this.label10.TabIndex = 9;
            this.label10.Text = "Отчество";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label11.Location = new System.Drawing.Point(27, 93);
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
            this.groupBox12.Font = new System.Drawing.Font("Montserrat", 10F);
            this.groupBox12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.groupBox12.Location = new System.Drawing.Point(10, 10);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(287, 501);
            this.groupBox12.TabIndex = 27;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Данные адреса";
            // 
            // adressApartment_tb
            // 
            this.adressApartment_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.adressApartment_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressApartment_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.adressApartment_tb.Location = new System.Drawing.Point(33, 288);
            this.adressApartment_tb.Multiline = true;
            this.adressApartment_tb.Name = "adressApartment_tb";
            this.adressApartment_tb.Size = new System.Drawing.Size(233, 30);
            this.adressApartment_tb.TabIndex = 8;
            // 
            // adressBuilding_tb
            // 
            this.adressBuilding_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.adressBuilding_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressBuilding_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.adressBuilding_tb.Location = new System.Drawing.Point(33, 231);
            this.adressBuilding_tb.Multiline = true;
            this.adressBuilding_tb.Name = "adressBuilding_tb";
            this.adressBuilding_tb.Size = new System.Drawing.Size(233, 30);
            this.adressBuilding_tb.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Регион";
            // 
            // adressRegion_tb
            // 
            this.adressRegion_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.adressRegion_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressRegion_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.adressRegion_tb.Location = new System.Drawing.Point(33, 62);
            this.adressRegion_tb.Multiline = true;
            this.adressRegion_tb.Name = "adressRegion_tb";
            this.adressRegion_tb.Size = new System.Drawing.Size(233, 30);
            this.adressRegion_tb.TabIndex = 8;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label22.Location = new System.Drawing.Point(33, 265);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 22);
            this.label22.TabIndex = 9;
            this.label22.Text = "Квартира";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label9.Location = new System.Drawing.Point(33, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "Строение";
            // 
            // adressCity_tb
            // 
            this.adressCity_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.adressCity_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressCity_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.adressCity_tb.Location = new System.Drawing.Point(33, 119);
            this.adressCity_tb.Multiline = true;
            this.adressCity_tb.Name = "adressCity_tb";
            this.adressCity_tb.Size = new System.Drawing.Size(233, 30);
            this.adressCity_tb.TabIndex = 8;
            // 
            // adressStreet_tb
            // 
            this.adressStreet_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.adressStreet_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressStreet_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.adressStreet_tb.Location = new System.Drawing.Point(33, 175);
            this.adressStreet_tb.Multiline = true;
            this.adressStreet_tb.Name = "adressStreet_tb";
            this.adressStreet_tb.Size = new System.Drawing.Size(233, 30);
            this.adressStreet_tb.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label15.Location = new System.Drawing.Point(33, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 22);
            this.label15.TabIndex = 9;
            this.label15.Text = "Улица";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label16.Location = new System.Drawing.Point(33, 96);
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
            this.cancel_btn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.cancel_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cancel_btn.Location = new System.Drawing.Point(201, 40);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(158, 46);
            this.cancel_btn.TabIndex = 28;
            this.cancel_btn.Text = "Отмена";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.add_btn);
            this.groupBox1.Controls.Add(this.cancel_btn);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.groupBox1.Location = new System.Drawing.Point(139, 530);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 106);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // clientStatus_cb
            // 
            this.clientStatus_cb.AutoSize = true;
            this.clientStatus_cb.Location = new System.Drawing.Point(27, 276);
            this.clientStatus_cb.Name = "clientStatus_cb";
            this.clientStatus_cb.Size = new System.Drawing.Size(204, 24);
            this.clientStatus_cb.TabIndex = 11;
            this.clientStatus_cb.Text = "Является соискателем?";
            this.clientStatus_cb.UseVisualStyleBackColor = true;
            this.clientStatus_cb.CheckedChanged += new System.EventHandler(this.clientStatus_cb_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(27, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Профессия";
            // 
            // profession_tb
            // 
            this.profession_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.profession_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.profession_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.profession_tb.Location = new System.Drawing.Point(27, 329);
            this.profession_tb.Multiline = true;
            this.profession_tb.Name = "profession_tb";
            this.profession_tb.Size = new System.Drawing.Size(282, 30);
            this.profession_tb.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(27, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Образование";
            // 
            // education_tb
            // 
            this.education_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.education_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.education_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.education_tb.Location = new System.Drawing.Point(27, 389);
            this.education_tb.Multiline = true;
            this.education_tb.Name = "education_tb";
            this.education_tb.Size = new System.Drawing.Size(282, 30);
            this.education_tb.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(27, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Пол";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(172, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Возраст";
            // 
            // birth_tb
            // 
            this.birth_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.birth_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.birth_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.birth_tb.Location = new System.Drawing.Point(172, 444);
            this.birth_tb.Multiline = true;
            this.birth_tb.Name = "birth_tb";
            this.birth_tb.Size = new System.Drawing.Size(137, 30);
            this.birth_tb.TabIndex = 8;
            // 
            // sex_cb
            // 
            this.sex_cb.FormattingEnabled = true;
            this.sex_cb.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.sex_cb.Location = new System.Drawing.Point(27, 448);
            this.sex_cb.Name = "sex_cb";
            this.sex_cb.Size = new System.Drawing.Size(139, 26);
            this.sex_cb.TabIndex = 12;
            // 
            // ClientAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 648);
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
        private CheckBox clientStatus_cb;
        private TextBox profession_tb;
        private Label label3;
        private ComboBox sex_cb;
        private TextBox birth_tb;
        private TextBox education_tb;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}