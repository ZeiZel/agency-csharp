namespace agency_csharp
{
    partial class EmployeeRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeRegister));
            this.register_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.login_data_gb = new System.Windows.Forms.GroupBox();
            this.login_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.personality_data_gb = new System.Windows.Forms.GroupBox();
            this.number_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mail_tb = new System.Windows.Forms.TextBox();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.surname_tb = new System.Windows.Forms.TextBox();
            this.thirdname_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.login_data_gb.SuspendLayout();
            this.personality_data_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.register_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.register_btn.FlatAppearance.BorderSize = 0;
            this.register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_btn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.register_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.register_btn.Location = new System.Drawing.Point(287, 260);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(261, 52);
            this.register_btn.TabIndex = 17;
            this.register_btn.Text = "Регистрация пользователя";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.clear_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.Image = ((System.Drawing.Image)(resources.GetObject("clear_btn.Image")));
            this.clear_btn.Location = new System.Drawing.Point(575, 260);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(57, 52);
            this.clear_btn.TabIndex = 20;
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // login_data_gb
            // 
            this.login_data_gb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.login_data_gb.Controls.Add(this.login_tb);
            this.login_data_gb.Controls.Add(this.password_tb);
            this.login_data_gb.Controls.Add(this.label1);
            this.login_data_gb.Controls.Add(this.label2);
            this.login_data_gb.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_data_gb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.login_data_gb.Location = new System.Drawing.Point(738, 32);
            this.login_data_gb.Name = "login_data_gb";
            this.login_data_gb.Size = new System.Drawing.Size(248, 200);
            this.login_data_gb.TabIndex = 18;
            this.login_data_gb.TabStop = false;
            this.login_data_gb.Text = "Данные для входа";
            // 
            // login_tb
            // 
            this.login_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.login_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_tb.Location = new System.Drawing.Point(16, 61);
            this.login_tb.Multiline = true;
            this.login_tb.Name = "login_tb";
            this.login_tb.Size = new System.Drawing.Size(212, 34);
            this.login_tb.TabIndex = 8;
            // 
            // password_tb
            // 
            this.password_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.password_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password_tb.Location = new System.Drawing.Point(16, 134);
            this.password_tb.Multiline = true;
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(212, 34);
            this.password_tb.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(16, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Пароль";
            // 
            // personality_data_gb
            // 
            this.personality_data_gb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.personality_data_gb.Controls.Add(this.number_tb);
            this.personality_data_gb.Controls.Add(this.label3);
            this.personality_data_gb.Controls.Add(this.mail_tb);
            this.personality_data_gb.Controls.Add(this.name_tb);
            this.personality_data_gb.Controls.Add(this.label6);
            this.personality_data_gb.Controls.Add(this.label7);
            this.personality_data_gb.Controls.Add(this.surname_tb);
            this.personality_data_gb.Controls.Add(this.thirdname_tb);
            this.personality_data_gb.Controls.Add(this.label5);
            this.personality_data_gb.Controls.Add(this.label4);
            this.personality_data_gb.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.personality_data_gb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.personality_data_gb.Location = new System.Drawing.Point(22, 32);
            this.personality_data_gb.Name = "personality_data_gb";
            this.personality_data_gb.Size = new System.Drawing.Size(699, 200);
            this.personality_data_gb.TabIndex = 19;
            this.personality_data_gb.TabStop = false;
            this.personality_data_gb.Text = "Персональные данные";
            // 
            // number_tb
            // 
            this.number_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.number_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.number_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number_tb.Location = new System.Drawing.Point(16, 134);
            this.number_tb.Multiline = true;
            this.number_tb.Name = "number_tb";
            this.number_tb.Size = new System.Drawing.Size(212, 34);
            this.number_tb.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(13, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Имя";
            // 
            // mail_tb
            // 
            this.mail_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.mail_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mail_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mail_tb.Location = new System.Drawing.Point(245, 134);
            this.mail_tb.Multiline = true;
            this.mail_tb.Name = "mail_tb";
            this.mail_tb.Size = new System.Drawing.Size(212, 34);
            this.mail_tb.TabIndex = 8;
            // 
            // name_tb
            // 
            this.name_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.name_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name_tb.Location = new System.Drawing.Point(16, 61);
            this.name_tb.Multiline = true;
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(212, 34);
            this.name_tb.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(16, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Контактный номер";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(245, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Почта";
            // 
            // surname_tb
            // 
            this.surname_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.surname_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surname_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.surname_tb.Location = new System.Drawing.Point(245, 61);
            this.surname_tb.Multiline = true;
            this.surname_tb.Name = "surname_tb";
            this.surname_tb.Size = new System.Drawing.Size(212, 34);
            this.surname_tb.TabIndex = 8;
            // 
            // thirdname_tb
            // 
            this.thirdname_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.thirdname_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.thirdname_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.thirdname_tb.Location = new System.Drawing.Point(471, 61);
            this.thirdname_tb.Multiline = true;
            this.thirdname_tb.Name = "thirdname_tb";
            this.thirdname_tb.Size = new System.Drawing.Size(212, 34);
            this.thirdname_tb.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(471, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(242, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Фамилия";
            // 
            // EmployeeRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 349);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.login_data_gb);
            this.Controls.Add(this.personality_data_gb);
            this.Name = "EmployeeRegister";
            this.Text = "EmployeeRegister";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeRegister_FormClosed);
            this.Load += new System.EventHandler(this.EmployeeRegister_Load);
            this.login_data_gb.ResumeLayout(false);
            this.login_data_gb.PerformLayout();
            this.personality_data_gb.ResumeLayout(false);
            this.personality_data_gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button register_btn;
        private Button clear_btn;
        private GroupBox login_data_gb;
        private TextBox login_tb;
        private TextBox password_tb;
        private Label label1;
        private Label label2;
        private GroupBox personality_data_gb;
        private TextBox number_tb;
        private Label label3;
        private TextBox mail_tb;
        private TextBox name_tb;
        private Label label6;
        private Label label7;
        private TextBox surname_tb;
        private TextBox thirdname_tb;
        private Label label5;
        private Label label4;
    }
}