﻿namespace agency_csharp
{
    partial class CheckUpdates
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
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.checkUpdates_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(33, 76);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(257, 36);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // checkUpdates_btn
            // 
            this.checkUpdates_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.checkUpdates_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkUpdates_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.checkUpdates_btn.FlatAppearance.BorderSize = 0;
            this.checkUpdates_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkUpdates_btn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkUpdates_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.checkUpdates_btn.Location = new System.Drawing.Point(41, 137);
            this.checkUpdates_btn.Name = "checkUpdates_btn";
            this.checkUpdates_btn.Size = new System.Drawing.Size(240, 36);
            this.checkUpdates_btn.TabIndex = 20;
            this.checkUpdates_btn.Text = "Проверить обновления";
            this.checkUpdates_btn.UseVisualStyleBackColor = false;
            this.checkUpdates_btn.Click += new System.EventHandler(this.checkUpdates_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(59, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 22);
            this.label7.TabIndex = 21;
            this.label7.Text = "Проверка обновления";
            // 
            // CheckUpdates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(326, 209);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkUpdates_btn);
            this.Controls.Add(this.progressBar1);
            this.Name = "CheckUpdates";
            this.Text = "Обновление";
            this.Load += new System.EventHandler(this.CheckUpdates_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBar progressBar1;
        private Button checkUpdates_btn;
        private System.Windows.Forms.Timer timer1;
        private Label label7;
    }
}