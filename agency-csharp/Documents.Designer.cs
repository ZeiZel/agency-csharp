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
    partial class Documents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Documents));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clientID_tb = new System.Windows.Forms.TextBox();
            this.clientName_tb = new System.Windows.Forms.TextBox();
            this.clientSur_tb = new System.Windows.Forms.TextBox();
            this.clientPat_tb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passportSex_cb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passportSeries_tb = new System.Windows.Forms.TextBox();
            this.passportNumber_tb = new System.Windows.Forms.TextBox();
            this.passportBirth_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passportId_tb = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.docsID_tb = new System.Windows.Forms.TextBox();
            this.docsEducation_tb = new System.Windows.Forms.TextBox();
            this.docsTIN_tb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.passportSave_btn = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passportAdd_btn = new System.Windows.Forms.Button();
            this.passportChange_btn = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.adressApartment_tb = new System.Windows.Forms.TextBox();
            this.adressBuilding_tb = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.adressRegion_tb = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.adressID_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.adressCity_tb = new System.Windows.Forms.TextBox();
            this.adressStreet_tb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.passport_dgv = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.passportRefresh_btn = new System.Windows.Forms.Button();
            this.passportSearch_btn = new System.Windows.Forms.Button();
            this.passportClear_btn = new System.Windows.Forms.Button();
            this.passportSearch_tb = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passport_dgv)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.clientID_tb);
            this.groupBox4.Controls.Add(this.clientName_tb);
            this.groupBox4.Controls.Add(this.clientSur_tb);
            this.groupBox4.Controls.Add(this.clientPat_tb);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.groupBox4.Location = new System.Drawing.Point(451, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(339, 268);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Персональные данные";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label19.Location = new System.Drawing.Point(33, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(148, 20);
            this.label19.TabIndex = 10;
            this.label19.Text = "Идентификатор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(33, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Имя";
            // 
            // clientID_tb
            // 
            this.clientID_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.clientID_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientID_tb.Enabled = false;
            this.clientID_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.clientID_tb.Location = new System.Drawing.Point(33, 49);
            this.clientID_tb.Multiline = true;
            this.clientID_tb.Name = "clientID_tb";
            this.clientID_tb.Size = new System.Drawing.Size(129, 30);
            this.clientID_tb.TabIndex = 8;
            // 
            // clientName_tb
            // 
            this.clientName_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.clientName_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientName_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.clientName_tb.Location = new System.Drawing.Point(33, 103);
            this.clientName_tb.Multiline = true;
            this.clientName_tb.Name = "clientName_tb";
            this.clientName_tb.Size = new System.Drawing.Size(274, 30);
            this.clientName_tb.TabIndex = 8;
            // 
            // clientSur_tb
            // 
            this.clientSur_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.clientSur_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientSur_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.clientSur_tb.Location = new System.Drawing.Point(33, 158);
            this.clientSur_tb.Multiline = true;
            this.clientSur_tb.Name = "clientSur_tb";
            this.clientSur_tb.Size = new System.Drawing.Size(274, 30);
            this.clientSur_tb.TabIndex = 8;
            // 
            // clientPat_tb
            // 
            this.clientPat_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.clientPat_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientPat_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.clientPat_tb.Location = new System.Drawing.Point(33, 213);
            this.clientPat_tb.Multiline = true;
            this.clientPat_tb.Name = "clientPat_tb";
            this.clientPat_tb.Size = new System.Drawing.Size(274, 30);
            this.clientPat_tb.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label10.Location = new System.Drawing.Point(33, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Отчество";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label11.Location = new System.Drawing.Point(33, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Фамилия";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox1.Controls.Add(this.passportSex_cb);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.passportSeries_tb);
            this.groupBox1.Controls.Add(this.passportNumber_tb);
            this.groupBox1.Controls.Add(this.passportBirth_tb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.passportId_tb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 232);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Паспортные данные";
            // 
            // passportSex_cb
            // 
            this.passportSex_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.passportSex_cb.FormattingEnabled = true;
            this.passportSex_cb.Items.AddRange(new object[] {
            "Женский",
            "Мужской"});
            this.passportSex_cb.Location = new System.Drawing.Point(33, 172);
            this.passportSex_cb.Name = "passportSex_cb";
            this.passportSex_cb.Size = new System.Drawing.Size(115, 28);
            this.passportSex_cb.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label8.Location = new System.Drawing.Point(170, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Серия";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label15.Location = new System.Drawing.Point(33, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 20);
            this.label15.TabIndex = 14;
            this.label15.Text = "Номер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(153, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(33, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Пол";
            // 
            // passportSeries_tb
            // 
            this.passportSeries_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.passportSeries_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passportSeries_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.passportSeries_tb.Location = new System.Drawing.Point(170, 103);
            this.passportSeries_tb.Multiline = true;
            this.passportSeries_tb.Name = "passportSeries_tb";
            this.passportSeries_tb.Size = new System.Drawing.Size(143, 30);
            this.passportSeries_tb.TabIndex = 11;
            // 
            // passportNumber_tb
            // 
            this.passportNumber_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.passportNumber_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passportNumber_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.passportNumber_tb.Location = new System.Drawing.Point(33, 103);
            this.passportNumber_tb.Multiline = true;
            this.passportNumber_tb.Name = "passportNumber_tb";
            this.passportNumber_tb.Size = new System.Drawing.Size(129, 30);
            this.passportNumber_tb.TabIndex = 12;
            // 
            // passportBirth_tb
            // 
            this.passportBirth_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.passportBirth_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passportBirth_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.passportBirth_tb.Location = new System.Drawing.Point(153, 172);
            this.passportBirth_tb.Multiline = true;
            this.passportBirth_tb.Name = "passportBirth_tb";
            this.passportBirth_tb.Size = new System.Drawing.Size(159, 30);
            this.passportBirth_tb.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Идентификатор";
            // 
            // passportId_tb
            // 
            this.passportId_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.passportId_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passportId_tb.Enabled = false;
            this.passportId_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.passportId_tb.Location = new System.Drawing.Point(33, 49);
            this.passportId_tb.Multiline = true;
            this.passportId_tb.Name = "passportId_tb";
            this.passportId_tb.Size = new System.Drawing.Size(279, 30);
            this.passportId_tb.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.docsID_tb);
            this.groupBox2.Controls.Add(this.docsEducation_tb);
            this.groupBox2.Controls.Add(this.docsTIN_tb);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.groupBox2.Location = new System.Drawing.Point(10, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 232);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные документов";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(33, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Идентификатор";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label9.Location = new System.Drawing.Point(33, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Образование";
            // 
            // docsID_tb
            // 
            this.docsID_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.docsID_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.docsID_tb.Enabled = false;
            this.docsID_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.docsID_tb.Location = new System.Drawing.Point(33, 62);
            this.docsID_tb.Multiline = true;
            this.docsID_tb.Name = "docsID_tb";
            this.docsID_tb.Size = new System.Drawing.Size(279, 30);
            this.docsID_tb.TabIndex = 8;
            // 
            // docsEducation_tb
            // 
            this.docsEducation_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.docsEducation_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.docsEducation_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.docsEducation_tb.Location = new System.Drawing.Point(33, 117);
            this.docsEducation_tb.Multiline = true;
            this.docsEducation_tb.Name = "docsEducation_tb";
            this.docsEducation_tb.Size = new System.Drawing.Size(279, 30);
            this.docsEducation_tb.TabIndex = 8;
            // 
            // docsTIN_tb
            // 
            this.docsTIN_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.docsTIN_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.docsTIN_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.docsTIN_tb.Location = new System.Drawing.Point(33, 172);
            this.docsTIN_tb.Multiline = true;
            this.docsTIN_tb.Name = "docsTIN_tb";
            this.docsTIN_tb.Size = new System.Drawing.Size(279, 30);
            this.docsTIN_tb.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label14.Location = new System.Drawing.Point(33, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "ИНН";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox5.Controls.Add(this.pictureBox5);
            this.groupBox5.Controls.Add(this.passportSave_btn);
            this.groupBox5.Controls.Add(this.pictureBox8);
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Controls.Add(this.passportAdd_btn);
            this.groupBox5.Controls.Add(this.passportChange_btn);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.groupBox5.Location = new System.Drawing.Point(484, 291);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(274, 195);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Панель управления";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(42, 140);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 38);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // passportSave_btn
            // 
            this.passportSave_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.passportSave_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passportSave_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.passportSave_btn.FlatAppearance.BorderSize = 0;
            this.passportSave_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passportSave_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.passportSave_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passportSave_btn.Location = new System.Drawing.Point(84, 140);
            this.passportSave_btn.Name = "passportSave_btn";
            this.passportSave_btn.Size = new System.Drawing.Size(149, 38);
            this.passportSave_btn.TabIndex = 21;
            this.passportSave_btn.Text = "Сохранить";
            this.passportSave_btn.UseVisualStyleBackColor = false;
            this.passportSave_btn.Click += new System.EventHandler(this.clientSave_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(42, 85);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(37, 38);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 20;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // passportAdd_btn
            // 
            this.passportAdd_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.passportAdd_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passportAdd_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.passportAdd_btn.FlatAppearance.BorderSize = 0;
            this.passportAdd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passportAdd_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.passportAdd_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passportAdd_btn.Location = new System.Drawing.Point(84, 30);
            this.passportAdd_btn.Name = "passportAdd_btn";
            this.passportAdd_btn.Size = new System.Drawing.Size(149, 38);
            this.passportAdd_btn.TabIndex = 18;
            this.passportAdd_btn.Text = "Добавить";
            this.passportAdd_btn.UseVisualStyleBackColor = false;
            this.passportAdd_btn.Click += new System.EventHandler(this.passportAdd_btn_Click);
            // 
            // passportChange_btn
            // 
            this.passportChange_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.passportChange_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passportChange_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.passportChange_btn.FlatAppearance.BorderSize = 0;
            this.passportChange_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passportChange_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.passportChange_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passportChange_btn.Location = new System.Drawing.Point(84, 85);
            this.passportChange_btn.Name = "passportChange_btn";
            this.passportChange_btn.Size = new System.Drawing.Size(149, 38);
            this.passportChange_btn.TabIndex = 18;
            this.passportChange_btn.Text = "Изменить";
            this.passportChange_btn.UseVisualStyleBackColor = false;
            this.passportChange_btn.Click += new System.EventHandler(this.passportChange_btn_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox12.Controls.Add(this.adressApartment_tb);
            this.groupBox12.Controls.Add(this.adressBuilding_tb);
            this.groupBox12.Controls.Add(this.label20);
            this.groupBox12.Controls.Add(this.label5);
            this.groupBox12.Controls.Add(this.adressRegion_tb);
            this.groupBox12.Controls.Add(this.label22);
            this.groupBox12.Controls.Add(this.adressID_tb);
            this.groupBox12.Controls.Add(this.label6);
            this.groupBox12.Controls.Add(this.adressCity_tb);
            this.groupBox12.Controls.Add(this.adressStreet_tb);
            this.groupBox12.Controls.Add(this.label12);
            this.groupBox12.Controls.Add(this.label16);
            this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.groupBox12.Location = new System.Drawing.Point(881, 10);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(373, 322);
            this.groupBox12.TabIndex = 29;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Данные адреса";
            // 
            // adressApartment_tb
            // 
            this.adressApartment_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.adressApartment_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressApartment_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.adressApartment_tb.Location = new System.Drawing.Point(193, 270);
            this.adressApartment_tb.Multiline = true;
            this.adressApartment_tb.Name = "adressApartment_tb";
            this.adressApartment_tb.Size = new System.Drawing.Size(151, 30);
            this.adressApartment_tb.TabIndex = 8;
            // 
            // adressBuilding_tb
            // 
            this.adressBuilding_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.adressBuilding_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressBuilding_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.adressBuilding_tb.Location = new System.Drawing.Point(37, 270);
            this.adressBuilding_tb.Multiline = true;
            this.adressBuilding_tb.Name = "adressBuilding_tb";
            this.adressBuilding_tb.Size = new System.Drawing.Size(151, 30);
            this.adressBuilding_tb.TabIndex = 8;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label20.Location = new System.Drawing.Point(37, 27);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(148, 20);
            this.label20.TabIndex = 10;
            this.label20.Text = "Идентификатор";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(37, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Регион";
            // 
            // adressRegion_tb
            // 
            this.adressRegion_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.adressRegion_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressRegion_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.adressRegion_tb.Location = new System.Drawing.Point(37, 103);
            this.adressRegion_tb.Multiline = true;
            this.adressRegion_tb.Name = "adressRegion_tb";
            this.adressRegion_tb.Size = new System.Drawing.Size(307, 30);
            this.adressRegion_tb.TabIndex = 8;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label22.Location = new System.Drawing.Point(193, 249);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(90, 20);
            this.label22.TabIndex = 9;
            this.label22.Text = "Квартира";
            // 
            // adressID_tb
            // 
            this.adressID_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.adressID_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressID_tb.Enabled = false;
            this.adressID_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.adressID_tb.Location = new System.Drawing.Point(37, 49);
            this.adressID_tb.Multiline = true;
            this.adressID_tb.Name = "adressID_tb";
            this.adressID_tb.Size = new System.Drawing.Size(151, 30);
            this.adressID_tb.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(37, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Строение";
            // 
            // adressCity_tb
            // 
            this.adressCity_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.adressCity_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressCity_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.adressCity_tb.Location = new System.Drawing.Point(37, 158);
            this.adressCity_tb.Multiline = true;
            this.adressCity_tb.Name = "adressCity_tb";
            this.adressCity_tb.Size = new System.Drawing.Size(307, 30);
            this.adressCity_tb.TabIndex = 8;
            // 
            // adressStreet_tb
            // 
            this.adressStreet_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.adressStreet_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressStreet_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.adressStreet_tb.Location = new System.Drawing.Point(37, 213);
            this.adressStreet_tb.Multiline = true;
            this.adressStreet_tb.Name = "adressStreet_tb";
            this.adressStreet_tb.Size = new System.Drawing.Size(307, 30);
            this.adressStreet_tb.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label12.Location = new System.Drawing.Point(37, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Улица";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label16.Location = new System.Drawing.Point(37, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(166, 20);
            this.label16.TabIndex = 9;
            this.label16.Text = "Населённый пункт";
            // 
            // passport_dgv
            // 
            this.passport_dgv.AllowUserToAddRows = false;
            this.passport_dgv.AllowUserToDeleteRows = false;
            this.passport_dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.passport_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passport_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.passport_dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.passport_dgv.Location = new System.Drawing.Point(10, 504);
            this.passport_dgv.Name = "passport_dgv";
            this.passport_dgv.ReadOnly = true;
            this.passport_dgv.RowTemplate.Height = 25;
            this.passport_dgv.Size = new System.Drawing.Size(1244, 183);
            this.passport_dgv.TabIndex = 30;
            this.passport_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.passport_dgv_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox3.Controls.Add(this.passportRefresh_btn);
            this.groupBox3.Controls.Add(this.passportSearch_btn);
            this.groupBox3.Controls.Add(this.passportClear_btn);
            this.groupBox3.Controls.Add(this.passportSearch_tb);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.groupBox3.Location = new System.Drawing.Point(881, 400);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 87);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Управление";
            // 
            // passportRefresh_btn
            // 
            this.passportRefresh_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.passportRefresh_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passportRefresh_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.passportRefresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passportRefresh_btn.Image = ((System.Drawing.Image)(resources.GetObject("passportRefresh_btn.Image")));
            this.passportRefresh_btn.Location = new System.Drawing.Point(67, 29);
            this.passportRefresh_btn.Name = "passportRefresh_btn";
            this.passportRefresh_btn.Size = new System.Drawing.Size(47, 45);
            this.passportRefresh_btn.TabIndex = 17;
            this.passportRefresh_btn.UseVisualStyleBackColor = false;
            this.passportRefresh_btn.Click += new System.EventHandler(this.passportRefresh_btn_Click);
            // 
            // passportSearch_btn
            // 
            this.passportSearch_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.passportSearch_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passportSearch_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.passportSearch_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passportSearch_btn.Image = ((System.Drawing.Image)(resources.GetObject("passportSearch_btn.Image")));
            this.passportSearch_btn.Location = new System.Drawing.Point(119, 29);
            this.passportSearch_btn.Name = "passportSearch_btn";
            this.passportSearch_btn.Size = new System.Drawing.Size(41, 45);
            this.passportSearch_btn.TabIndex = 17;
            this.passportSearch_btn.UseVisualStyleBackColor = false;
            this.passportSearch_btn.Click += new System.EventHandler(this.passportSearch_btn_Click);
            // 
            // passportClear_btn
            // 
            this.passportClear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.passportClear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passportClear_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.passportClear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passportClear_btn.Image = ((System.Drawing.Image)(resources.GetObject("passportClear_btn.Image")));
            this.passportClear_btn.Location = new System.Drawing.Point(21, 29);
            this.passportClear_btn.Name = "passportClear_btn";
            this.passportClear_btn.Size = new System.Drawing.Size(41, 45);
            this.passportClear_btn.TabIndex = 17;
            this.passportClear_btn.UseVisualStyleBackColor = false;
            this.passportClear_btn.Click += new System.EventHandler(this.passportClear_btn_Click);
            // 
            // passportSearch_tb
            // 
            this.passportSearch_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.passportSearch_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passportSearch_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.passportSearch_tb.Location = new System.Drawing.Point(165, 35);
            this.passportSearch_tb.Multiline = true;
            this.passportSearch_tb.Name = "passportSearch_tb";
            this.passportSearch_tb.Size = new System.Drawing.Size(162, 30);
            this.passportSearch_tb.TabIndex = 8;
            this.passportSearch_tb.TextChanged += new System.EventHandler(this.passportSearch_tb_TextChanged);
            // 
            // Documents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 703);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.passport_dgv);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Documents";
            this.Text = "Документы";
            this.Load += new System.EventHandler(this.Documents_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passport_dgv)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox4;
        private Label label19;
        private Label label2;
        private TextBox clientID_tb;
        private TextBox clientName_tb;
        private TextBox clientSur_tb;
        private TextBox clientPat_tb;
        private Label label10;
        private Label label11;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label7;
        private Label label9;
        private TextBox docsID_tb;
        private TextBox docsEducation_tb;
        private TextBox docsTIN_tb;
        private Label label14;
        private GroupBox groupBox5;
        private Button passportChange_btn;
        private Label label8;
        private Label label15;
        private Label label4;
        private Label label3;
        private TextBox passportSeries_tb;
        private TextBox passportNumber_tb;
        private TextBox passportBirth_tb;
        private GroupBox groupBox12;
        private TextBox adressApartment_tb;
        private TextBox adressBuilding_tb;
        private Label label20;
        private Label label5;
        private TextBox adressRegion_tb;
        private Label label22;
        private TextBox adressID_tb;
        private Label label6;
        private TextBox adressCity_tb;
        private TextBox adressStreet_tb;
        private Label label12;
        private Label label16;
        private PictureBox pictureBox1;
        private Button passportAdd_btn;
        private PictureBox pictureBox8;
        private Label label1;
        private TextBox passportId_tb;
        private DataGridView passport_dgv;
        private GroupBox groupBox3;
        private Button passportRefresh_btn;
        private Button passportSearch_btn;
        private Button passportClear_btn;
        private TextBox passportSearch_tb;
        private ComboBox passportSex_cb;
        private PictureBox pictureBox5;
        private Button passportSave_btn;
    }
}