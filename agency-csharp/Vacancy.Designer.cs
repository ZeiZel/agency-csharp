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
    partial class Vacancy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vacancy));
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.adressApartment_tb = new System.Windows.Forms.TextBox();
            this.adressBuilding_tb = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.adressRegion_tb = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.adressId_tb = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.adressCity_tb = new System.Windows.Forms.TextBox();
            this.adressStreet_tb = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.vacSearch_btn = new System.Windows.Forms.Button();
            this.vacClrear_btn = new System.Windows.Forms.Button();
            this.vacSearch_tb = new System.Windows.Forms.TextBox();
            this.vacancy_dgv = new System.Windows.Forms.DataGridView();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.vacNum_tb = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.vacancyID_tb = new System.Windows.Forms.TextBox();
            this.vacOrgName_tb = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.vacName_tb = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userStatus_tstb = new System.Windows.Forms.ToolStripTextBox();
            this.response_btn = new System.Windows.Forms.Button();
            this.groupBox14.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vacancy_dgv)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox14
            // 
            this.groupBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox14.Controls.Add(this.adressApartment_tb);
            this.groupBox14.Controls.Add(this.adressBuilding_tb);
            this.groupBox14.Controls.Add(this.label29);
            this.groupBox14.Controls.Add(this.label30);
            this.groupBox14.Controls.Add(this.adressRegion_tb);
            this.groupBox14.Controls.Add(this.label31);
            this.groupBox14.Controls.Add(this.adressId_tb);
            this.groupBox14.Controls.Add(this.label32);
            this.groupBox14.Controls.Add(this.adressCity_tb);
            this.groupBox14.Controls.Add(this.adressStreet_tb);
            this.groupBox14.Controls.Add(this.label33);
            this.groupBox14.Controls.Add(this.label34);
            this.groupBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.groupBox14.Location = new System.Drawing.Point(32, 323);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(254, 388);
            this.groupBox14.TabIndex = 33;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Данные адреса";
            // 
            // adressApartment_tb
            // 
            this.adressApartment_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.adressApartment_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressApartment_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.adressApartment_tb.Location = new System.Drawing.Point(37, 332);
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
            this.adressBuilding_tb.Location = new System.Drawing.Point(37, 270);
            this.adressBuilding_tb.Multiline = true;
            this.adressBuilding_tb.Name = "adressBuilding_tb";
            this.adressBuilding_tb.Size = new System.Drawing.Size(182, 30);
            this.adressBuilding_tb.TabIndex = 8;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label29.Location = new System.Drawing.Point(37, 27);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(148, 20);
            this.label29.TabIndex = 10;
            this.label29.Text = "Идентификатор";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label30.Location = new System.Drawing.Point(37, 81);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(68, 20);
            this.label30.TabIndex = 10;
            this.label30.Text = "Регион";
            // 
            // adressRegion_tb
            // 
            this.adressRegion_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.adressRegion_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressRegion_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.adressRegion_tb.Location = new System.Drawing.Point(37, 103);
            this.adressRegion_tb.Multiline = true;
            this.adressRegion_tb.Name = "adressRegion_tb";
            this.adressRegion_tb.Size = new System.Drawing.Size(182, 30);
            this.adressRegion_tb.TabIndex = 8;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label31.Location = new System.Drawing.Point(37, 310);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(90, 20);
            this.label31.TabIndex = 9;
            this.label31.Text = "Квартира";
            // 
            // adressId_tb
            // 
            this.adressId_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.adressId_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressId_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.adressId_tb.Location = new System.Drawing.Point(37, 49);
            this.adressId_tb.Multiline = true;
            this.adressId_tb.Name = "adressId_tb";
            this.adressId_tb.Size = new System.Drawing.Size(182, 30);
            this.adressId_tb.TabIndex = 8;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label32.Location = new System.Drawing.Point(37, 249);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(91, 20);
            this.label32.TabIndex = 9;
            this.label32.Text = "Строение";
            // 
            // adressCity_tb
            // 
            this.adressCity_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.adressCity_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressCity_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.adressCity_tb.Location = new System.Drawing.Point(37, 158);
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
            this.adressStreet_tb.Location = new System.Drawing.Point(37, 213);
            this.adressStreet_tb.Multiline = true;
            this.adressStreet_tb.Name = "adressStreet_tb";
            this.adressStreet_tb.Size = new System.Drawing.Size(182, 30);
            this.adressStreet_tb.TabIndex = 8;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label33.Location = new System.Drawing.Point(37, 192);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(61, 20);
            this.label33.TabIndex = 9;
            this.label33.Text = "Улица";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label34.Location = new System.Drawing.Point(37, 136);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(166, 20);
            this.label34.TabIndex = 9;
            this.label34.Text = "Населённый пункт";
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox9.Controls.Add(this.refresh_btn);
            this.groupBox9.Controls.Add(this.vacSearch_btn);
            this.groupBox9.Controls.Add(this.vacClrear_btn);
            this.groupBox9.Controls.Add(this.vacSearch_tb);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.groupBox9.Location = new System.Drawing.Point(357, 426);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(350, 90);
            this.groupBox9.TabIndex = 32;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Управление";
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.refresh_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_btn.Image = ((System.Drawing.Image)(resources.GetObject("refresh_btn.Image")));
            this.refresh_btn.Location = new System.Drawing.Point(62, 30);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(47, 45);
            this.refresh_btn.TabIndex = 17;
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // vacSearch_btn
            // 
            this.vacSearch_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.vacSearch_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vacSearch_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.vacSearch_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vacSearch_btn.Image = ((System.Drawing.Image)(resources.GetObject("vacSearch_btn.Image")));
            this.vacSearch_btn.Location = new System.Drawing.Point(114, 30);
            this.vacSearch_btn.Name = "vacSearch_btn";
            this.vacSearch_btn.Size = new System.Drawing.Size(41, 45);
            this.vacSearch_btn.TabIndex = 17;
            this.vacSearch_btn.UseVisualStyleBackColor = false;
            this.vacSearch_btn.Click += new System.EventHandler(this.vacSearch_btn_Click);
            // 
            // vacClrear_btn
            // 
            this.vacClrear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.vacClrear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vacClrear_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.vacClrear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vacClrear_btn.Image = ((System.Drawing.Image)(resources.GetObject("vacClrear_btn.Image")));
            this.vacClrear_btn.Location = new System.Drawing.Point(15, 30);
            this.vacClrear_btn.Name = "vacClrear_btn";
            this.vacClrear_btn.Size = new System.Drawing.Size(41, 45);
            this.vacClrear_btn.TabIndex = 17;
            this.vacClrear_btn.UseVisualStyleBackColor = false;
            this.vacClrear_btn.Click += new System.EventHandler(this.vacClrear_btn_Click);
            // 
            // vacSearch_tb
            // 
            this.vacSearch_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.vacSearch_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vacSearch_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.vacSearch_tb.Location = new System.Drawing.Point(161, 36);
            this.vacSearch_tb.Multiline = true;
            this.vacSearch_tb.Name = "vacSearch_tb";
            this.vacSearch_tb.Size = new System.Drawing.Size(175, 30);
            this.vacSearch_tb.TabIndex = 8;
            this.vacSearch_tb.TextChanged += new System.EventHandler(this.vacSearch_tb_TextChanged);
            // 
            // vacancy_dgv
            // 
            this.vacancy_dgv.AllowUserToAddRows = false;
            this.vacancy_dgv.AllowUserToDeleteRows = false;
            this.vacancy_dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.vacancy_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vacancy_dgv.Location = new System.Drawing.Point(357, 40);
            this.vacancy_dgv.Name = "vacancy_dgv";
            this.vacancy_dgv.ReadOnly = true;
            this.vacancy_dgv.RowTemplate.Height = 25;
            this.vacancy_dgv.Size = new System.Drawing.Size(910, 367);
            this.vacancy_dgv.TabIndex = 31;
            this.vacancy_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vacancy_dgv_CellClick);
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox10.Controls.Add(this.vacNum_tb);
            this.groupBox10.Controls.Add(this.label35);
            this.groupBox10.Controls.Add(this.label17);
            this.groupBox10.Controls.Add(this.vacancyID_tb);
            this.groupBox10.Controls.Add(this.vacOrgName_tb);
            this.groupBox10.Controls.Add(this.label18);
            this.groupBox10.Controls.Add(this.vacName_tb);
            this.groupBox10.Controls.Add(this.label21);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.groupBox10.Location = new System.Drawing.Point(32, 40);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(254, 278);
            this.groupBox10.TabIndex = 30;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Персональные данные";
            // 
            // vacNum_tb
            // 
            this.vacNum_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.vacNum_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vacNum_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.vacNum_tb.Location = new System.Drawing.Point(29, 220);
            this.vacNum_tb.Multiline = true;
            this.vacNum_tb.Name = "vacNum_tb";
            this.vacNum_tb.Size = new System.Drawing.Size(182, 30);
            this.vacNum_tb.TabIndex = 8;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label35.Location = new System.Drawing.Point(29, 27);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(148, 20);
            this.label35.TabIndex = 10;
            this.label35.Text = "Идентификатор";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label17.Location = new System.Drawing.Point(29, 81);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 20);
            this.label17.TabIndex = 10;
            this.label17.Text = "Организация";
            // 
            // vacancyID_tb
            // 
            this.vacancyID_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.vacancyID_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vacancyID_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.vacancyID_tb.Location = new System.Drawing.Point(29, 49);
            this.vacancyID_tb.Multiline = true;
            this.vacancyID_tb.Name = "vacancyID_tb";
            this.vacancyID_tb.Size = new System.Drawing.Size(182, 30);
            this.vacancyID_tb.TabIndex = 8;
            // 
            // vacOrgName_tb
            // 
            this.vacOrgName_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.vacOrgName_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vacOrgName_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.vacOrgName_tb.Location = new System.Drawing.Point(29, 103);
            this.vacOrgName_tb.Multiline = true;
            this.vacOrgName_tb.Name = "vacOrgName_tb";
            this.vacOrgName_tb.Size = new System.Drawing.Size(182, 30);
            this.vacOrgName_tb.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label18.Location = new System.Drawing.Point(29, 198);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(168, 20);
            this.label18.TabIndex = 9;
            this.label18.Text = "Контактный номер";
            // 
            // vacName_tb
            // 
            this.vacName_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.vacName_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vacName_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.vacName_tb.Location = new System.Drawing.Point(29, 158);
            this.vacName_tb.Multiline = true;
            this.vacName_tb.Name = "vacName_tb";
            this.vacName_tb.Size = new System.Drawing.Size(182, 30);
            this.vacName_tb.TabIndex = 8;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label21.Location = new System.Drawing.Point(29, 136);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 20);
            this.label21.TabIndex = 9;
            this.label21.Text = "Должность";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияToolStripMenuItem,
            this.userStatus_tstb});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1293, 27);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.обновленияToolStripMenuItem});
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(93, 23);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // обновленияToolStripMenuItem
            // 
            this.обновленияToolStripMenuItem.Name = "обновленияToolStripMenuItem";
            this.обновленияToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.обновленияToolStripMenuItem.Text = "Проверить обновления";
            this.обновленияToolStripMenuItem.Click += new System.EventHandler(this.обновленияToolStripMenuItem_Click);
            // 
            // userStatus_tstb
            // 
            this.userStatus_tstb.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.userStatus_tstb.Enabled = false;
            this.userStatus_tstb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userStatus_tstb.Name = "userStatus_tstb";
            this.userStatus_tstb.Size = new System.Drawing.Size(129, 23);
            this.userStatus_tstb.Click += new System.EventHandler(this.userStatus_tstb_Click);
            // 
            // response_btn
            // 
            this.response_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.response_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.response_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.response_btn.FlatAppearance.BorderSize = 0;
            this.response_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.response_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.response_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.response_btn.Location = new System.Drawing.Point(735, 434);
            this.response_btn.Name = "response_btn";
            this.response_btn.Size = new System.Drawing.Size(153, 75);
            this.response_btn.TabIndex = 35;
            this.response_btn.Text = "Откликнуться на вакансию";
            this.response_btn.UseVisualStyleBackColor = false;
            this.response_btn.Click += new System.EventHandler(this.response_btn_Click);
            // 
            // Vacancy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1293, 741);
            this.Controls.Add(this.response_btn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox14);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.vacancy_dgv);
            this.Controls.Add(this.groupBox10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vacancy";
            this.Text = "Вакансия";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Vacancy_FormClosed);
            this.Load += new System.EventHandler(this.Vacancy_Load);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vacancy_dgv)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox14;
        private TextBox adressApartment_tb;
        private TextBox adressBuilding_tb;
        private Label label29;
        private Label label30;
        private TextBox adressRegion_tb;
        private Label label31;
        private TextBox adressId_tb;
        private Label label32;
        private TextBox adressCity_tb;
        private TextBox adressStreet_tb;
        private Label label33;
        private Label label34;
        private GroupBox groupBox9;
        private Button refresh_btn;
        private Button vacSearch_btn;
        private Button vacClrear_btn;
        private TextBox vacSearch_tb;
        private DataGridView vacancy_dgv;
        private GroupBox groupBox10;
        private TextBox vacNum_tb;
        private Label label35;
        private Label label17;
        private TextBox vacancyID_tb;
        private TextBox vacOrgName_tb;
        private Label label18;
        private TextBox vacName_tb;
        private Label label21;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem информацияToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem обновленияToolStripMenuItem;
        private ToolStripTextBox userStatus_tstb;
        private Button response_btn;
    }
}