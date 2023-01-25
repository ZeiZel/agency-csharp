using System.ComponentModel;

namespace agency_csharp;

partial class Workers
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Workers));
            this.workers_dgv = new System.Windows.Forms.DataGridView();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.vacSearch_btn = new System.Windows.Forms.Button();
            this.vacClrear_btn = new System.Windows.Forms.Button();
            this.vacSearch_tb = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.profession_tb = new System.Windows.Forms.TextBox();
            this.sex_tb = new System.Windows.Forms.TextBox();
            this.age_tb = new System.Windows.Forms.TextBox();
            this.docsEducation_tb = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clientID_tb = new System.Windows.Forms.TextBox();
            this.clientName_tb = new System.Windows.Forms.TextBox();
            this.clientSur_tb = new System.Windows.Forms.TextBox();
            this.clientPat_tb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.workers_dgv)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // workers_dgv
            // 
            this.workers_dgv.AllowUserToAddRows = false;
            this.workers_dgv.AllowUserToDeleteRows = false;
            this.workers_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workers_dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.workers_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workers_dgv.Location = new System.Drawing.Point(394, 12);
            this.workers_dgv.Name = "workers_dgv";
            this.workers_dgv.ReadOnly = true;
            this.workers_dgv.Size = new System.Drawing.Size(862, 642);
            this.workers_dgv.TabIndex = 0;
            this.workers_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.workers_dgv_CellClick);
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
            this.groupBox9.Location = new System.Drawing.Point(12, 564);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(376, 90);
            this.groupBox9.TabIndex = 33;
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
            this.vacSearch_tb.Size = new System.Drawing.Size(209, 30);
            this.vacSearch_tb.TabIndex = 8;
            this.vacSearch_tb.TextChanged += new System.EventHandler(this.vacSearch_tb_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.profession_tb);
            this.groupBox2.Controls.Add(this.sex_tb);
            this.groupBox2.Controls.Add(this.age_tb);
            this.groupBox2.Controls.Add(this.docsEducation_tb);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 225);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные документов";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label13.Location = new System.Drawing.Point(29, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Профессия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(29, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Возраст";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(183, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Пол";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label9.Location = new System.Drawing.Point(29, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Образование";
            // 
            // profession_tb
            // 
            this.profession_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.profession_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.profession_tb.Enabled = false;
            this.profession_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.profession_tb.Location = new System.Drawing.Point(29, 119);
            this.profession_tb.Multiline = true;
            this.profession_tb.Name = "profession_tb";
            this.profession_tb.Size = new System.Drawing.Size(309, 30);
            this.profession_tb.TabIndex = 8;
            // 
            // sex_tb
            // 
            this.sex_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.sex_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sex_tb.Enabled = false;
            this.sex_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.sex_tb.Location = new System.Drawing.Point(187, 63);
            this.sex_tb.Multiline = true;
            this.sex_tb.Name = "sex_tb";
            this.sex_tb.Size = new System.Drawing.Size(151, 30);
            this.sex_tb.TabIndex = 8;
            // 
            // age_tb
            // 
            this.age_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.age_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.age_tb.Enabled = false;
            this.age_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.age_tb.Location = new System.Drawing.Point(29, 63);
            this.age_tb.Multiline = true;
            this.age_tb.Name = "age_tb";
            this.age_tb.Size = new System.Drawing.Size(152, 30);
            this.age_tb.TabIndex = 8;
            // 
            // docsEducation_tb
            // 
            this.docsEducation_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.docsEducation_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.docsEducation_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.docsEducation_tb.Location = new System.Drawing.Point(29, 176);
            this.docsEducation_tb.Multiline = true;
            this.docsEducation_tb.Name = "docsEducation_tb";
            this.docsEducation_tb.Size = new System.Drawing.Size(309, 30);
            this.docsEducation_tb.TabIndex = 8;
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
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(370, 268);
            this.groupBox4.TabIndex = 35;
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
            this.label2.Location = new System.Drawing.Point(33, 82);
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
            this.clientID_tb.Size = new System.Drawing.Size(148, 30);
            this.clientID_tb.TabIndex = 8;
            // 
            // clientName_tb
            // 
            this.clientName_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.clientName_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientName_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.clientName_tb.Location = new System.Drawing.Point(33, 105);
            this.clientName_tb.Multiline = true;
            this.clientName_tb.Name = "clientName_tb";
            this.clientName_tb.Size = new System.Drawing.Size(305, 30);
            this.clientName_tb.TabIndex = 8;
            // 
            // clientSur_tb
            // 
            this.clientSur_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.clientSur_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientSur_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.clientSur_tb.Location = new System.Drawing.Point(33, 164);
            this.clientSur_tb.Multiline = true;
            this.clientSur_tb.Name = "clientSur_tb";
            this.clientSur_tb.Size = new System.Drawing.Size(305, 30);
            this.clientSur_tb.TabIndex = 8;
            // 
            // clientPat_tb
            // 
            this.clientPat_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.clientPat_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientPat_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.clientPat_tb.Location = new System.Drawing.Point(33, 218);
            this.clientPat_tb.Multiline = true;
            this.clientPat_tb.Name = "clientPat_tb";
            this.clientPat_tb.Size = new System.Drawing.Size(305, 30);
            this.clientPat_tb.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label10.Location = new System.Drawing.Point(33, 197);
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
            this.label11.Location = new System.Drawing.Point(33, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Фамилия";
            // 
            // Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 666);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.workers_dgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Workers";
            this.Text = "Соискатели";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Workers_FormClosed);
            this.Load += new System.EventHandler(this.Workers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workers_dgv)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

    }

    private System.Windows.Forms.DataGridView workers_dgv;

    #endregion

    private GroupBox groupBox9;
    private Button refresh_btn;
    private Button vacSearch_btn;
    private Button vacClrear_btn;
    private TextBox vacSearch_tb;
    private GroupBox groupBox2;
    private Label label13;
    private TextBox profession_tb;
    private GroupBox groupBox4;
    private Label label19;
    private Label label2;
    private TextBox clientID_tb;
    private TextBox clientName_tb;
    private TextBox clientSur_tb;
    private TextBox clientPat_tb;
    private Label label10;
    private Label label11;
    private Label label3;
    private Label label1;
    private Label label9;
    private TextBox sex_tb;
    private TextBox age_tb;
    private TextBox docsEducation_tb;
}