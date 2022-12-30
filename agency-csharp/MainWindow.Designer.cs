namespace agency_csharp
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.info_tabPage = new System.Windows.Forms.TabControl();
            this.employess_tab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.search_grid_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.change_btn = new System.Windows.Forms.Button();
            this.clients_tab = new System.Windows.Forms.TabPage();
            this.organizations_tab = new System.Windows.Forms.TabPage();
            this.vacamcy_tab = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sadasdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.info_tabPage.SuspendLayout();
            this.employess_tab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.personality_data_gb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // info_tabPage
            // 
            this.info_tabPage.Controls.Add(this.employess_tab);
            this.info_tabPage.Controls.Add(this.clients_tab);
            this.info_tabPage.Controls.Add(this.organizations_tab);
            this.info_tabPage.Controls.Add(this.vacamcy_tab);
            this.info_tabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info_tabPage.Location = new System.Drawing.Point(0, 24);
            this.info_tabPage.Name = "info_tabPage";
            this.info_tabPage.SelectedIndex = 0;
            this.info_tabPage.Size = new System.Drawing.Size(1116, 750);
            this.info_tabPage.TabIndex = 0;
            // 
            // employess_tab
            // 
            this.employess_tab.AllowDrop = true;
            this.employess_tab.BackColor = System.Drawing.Color.White;
            this.employess_tab.Controls.Add(this.groupBox2);
            this.employess_tab.Controls.Add(this.dataGridView1);
            this.employess_tab.Controls.Add(this.personality_data_gb);
            this.employess_tab.Controls.Add(this.groupBox1);
            this.employess_tab.Location = new System.Drawing.Point(4, 24);
            this.employess_tab.Name = "employess_tab";
            this.employess_tab.Padding = new System.Windows.Forms.Padding(3);
            this.employess_tab.Size = new System.Drawing.Size(1108, 722);
            this.employess_tab.TabIndex = 0;
            this.employess_tab.Text = "Сотрудники";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox2.Controls.Add(this.refresh_btn);
            this.groupBox2.Controls.Add(this.search_grid_btn);
            this.groupBox2.Controls.Add(this.clear_btn);
            this.groupBox2.Controls.Add(this.search_tb);
            this.groupBox2.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.groupBox2.Location = new System.Drawing.Point(371, 568);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(709, 100);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление";
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.refresh_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_btn.Image = ((System.Drawing.Image)(resources.GetObject("refresh_btn.Image")));
            this.refresh_btn.Location = new System.Drawing.Point(365, 34);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(55, 52);
            this.refresh_btn.TabIndex = 17;
            this.refresh_btn.UseVisualStyleBackColor = false;
            // 
            // search_grid_btn
            // 
            this.search_grid_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.search_grid_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_grid_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.search_grid_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_grid_btn.Image = ((System.Drawing.Image)(resources.GetObject("search_grid_btn.Image")));
            this.search_grid_btn.Location = new System.Drawing.Point(426, 34);
            this.search_grid_btn.Name = "search_grid_btn";
            this.search_grid_btn.Size = new System.Drawing.Size(48, 52);
            this.search_grid_btn.TabIndex = 17;
            this.search_grid_btn.UseVisualStyleBackColor = false;
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.Image = ((System.Drawing.Image)(resources.GetObject("clear_btn.Image")));
            this.clear_btn.Location = new System.Drawing.Point(311, 34);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(48, 52);
            this.clear_btn.TabIndex = 17;
            this.clear_btn.UseVisualStyleBackColor = false;
            // 
            // search_tb
            // 
            this.search_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.search_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.search_tb.Location = new System.Drawing.Point(480, 40);
            this.search_tb.Multiline = true;
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(212, 35);
            this.search_tb.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(371, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(714, 537);
            this.dataGridView1.TabIndex = 22;
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
            this.personality_data_gb.Location = new System.Drawing.Point(35, 15);
            this.personality_data_gb.Name = "personality_data_gb";
            this.personality_data_gb.Size = new System.Drawing.Size(296, 395);
            this.personality_data_gb.TabIndex = 21;
            this.personality_data_gb.TabStop = false;
            this.personality_data_gb.Text = "Персональные данные";
            // 
            // number_tb
            // 
            this.number_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.number_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.number_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number_tb.Location = new System.Drawing.Point(41, 259);
            this.number_tb.Multiline = true;
            this.number_tb.Name = "number_tb";
            this.number_tb.Size = new System.Drawing.Size(212, 35);
            this.number_tb.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(41, 41);
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
            this.mail_tb.Location = new System.Drawing.Point(41, 328);
            this.mail_tb.Multiline = true;
            this.mail_tb.Name = "mail_tb";
            this.mail_tb.Size = new System.Drawing.Size(212, 35);
            this.mail_tb.TabIndex = 8;
            // 
            // name_tb
            // 
            this.name_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.name_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name_tb.Location = new System.Drawing.Point(41, 66);
            this.name_tb.Multiline = true;
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(212, 35);
            this.name_tb.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(41, 234);
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
            this.label7.Location = new System.Drawing.Point(41, 303);
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
            this.surname_tb.Location = new System.Drawing.Point(41, 129);
            this.surname_tb.Multiline = true;
            this.surname_tb.Name = "surname_tb";
            this.surname_tb.Size = new System.Drawing.Size(212, 35);
            this.surname_tb.TabIndex = 8;
            // 
            // thirdname_tb
            // 
            this.thirdname_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.thirdname_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.thirdname_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.thirdname_tb.Location = new System.Drawing.Point(41, 193);
            this.thirdname_tb.Multiline = true;
            this.thirdname_tb.Name = "thirdname_tb";
            this.thirdname_tb.Size = new System.Drawing.Size(212, 35);
            this.thirdname_tb.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(41, 168);
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
            this.label4.Location = new System.Drawing.Point(41, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Фамилия";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.add_btn);
            this.groupBox1.Controls.Add(this.delete_btn);
            this.groupBox1.Controls.Add(this.save_btn);
            this.groupBox1.Controls.Add(this.change_btn);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.groupBox1.Location = new System.Drawing.Point(35, 431);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 237);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Панель управления";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(34, 170);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(43, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(34, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(34, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
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
            this.add_btn.Location = new System.Drawing.Point(83, 41);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(174, 37);
            this.add_btn.TabIndex = 18;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = false;
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.delete_btn.Location = new System.Drawing.Point(83, 84);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(174, 37);
            this.delete_btn.TabIndex = 18;
            this.delete_btn.Text = "Удалить";
            this.delete_btn.UseVisualStyleBackColor = false;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.save_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.save_btn.Location = new System.Drawing.Point(83, 170);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(174, 37);
            this.save_btn.TabIndex = 18;
            this.save_btn.Text = "Сохранить";
            this.save_btn.UseVisualStyleBackColor = false;
            // 
            // change_btn
            // 
            this.change_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.change_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.change_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.change_btn.FlatAppearance.BorderSize = 0;
            this.change_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_btn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.change_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.change_btn.Location = new System.Drawing.Point(83, 127);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(174, 37);
            this.change_btn.TabIndex = 18;
            this.change_btn.Text = "Изменить";
            this.change_btn.UseVisualStyleBackColor = false;
            // 
            // clients_tab
            // 
            this.clients_tab.Location = new System.Drawing.Point(4, 24);
            this.clients_tab.Name = "clients_tab";
            this.clients_tab.Padding = new System.Windows.Forms.Padding(3);
            this.clients_tab.Size = new System.Drawing.Size(1108, 722);
            this.clients_tab.TabIndex = 1;
            this.clients_tab.Text = "Клиенты";
            // 
            // organizations_tab
            // 
            this.organizations_tab.Location = new System.Drawing.Point(4, 24);
            this.organizations_tab.Name = "organizations_tab";
            this.organizations_tab.Size = new System.Drawing.Size(1108, 722);
            this.organizations_tab.TabIndex = 2;
            this.organizations_tab.Text = "Организации";
            // 
            // vacamcy_tab
            // 
            this.vacamcy_tab.Location = new System.Drawing.Point(4, 24);
            this.vacamcy_tab.Name = "vacamcy_tab";
            this.vacamcy_tab.Size = new System.Drawing.Size(1108, 722);
            this.vacamcy_tab.TabIndex = 3;
            this.vacamcy_tab.Text = "Вакансии";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sadasdToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1116, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sadasdToolStripMenuItem
            // 
            this.sadasdToolStripMenuItem.Name = "sadasdToolStripMenuItem";
            this.sadasdToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.sadasdToolStripMenuItem.Text = "Файл";
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 752);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1116, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 774);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.info_tabPage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.info_tabPage.ResumeLayout(false);
            this.employess_tab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.personality_data_gb.ResumeLayout(false);
            this.personality_data_gb.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl info_tabPage;
        private TabPage employess_tab;
        private TabPage clients_tab;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sadasdToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private TabPage organizations_tab;
        private TabPage vacamcy_tab;
        private Button clear_btn;
        private Button add_btn;
        private GroupBox groupBox1;
        private Button delete_btn;
        private Button save_btn;
        private Button change_btn;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
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
        private Button refresh_btn;
        private Button search_grid_btn;
        private TextBox search_tb;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ToolStripMenuItem информацияToolStripMenuItem;
    }
}