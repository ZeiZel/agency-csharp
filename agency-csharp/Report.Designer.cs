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
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.conract_exp_btn = new System.Windows.Forms.Button();
            this.responses_exp_btn = new System.Windows.Forms.Button();
            this.export_btn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // conract_exp_btn
            // 
            this.conract_exp_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.conract_exp_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.conract_exp_btn.FlatAppearance.BorderSize = 0;
            this.conract_exp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conract_exp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.conract_exp_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.conract_exp_btn.Location = new System.Drawing.Point(117, 120);
            this.conract_exp_btn.Name = "conract_exp_btn";
            this.conract_exp_btn.Size = new System.Drawing.Size(170, 55);
            this.conract_exp_btn.TabIndex = 21;
            this.conract_exp_btn.Text = "Экспортировать контракты";
            this.conract_exp_btn.UseVisualStyleBackColor = false;
            this.conract_exp_btn.Click += new System.EventHandler(this.conract_exp_btn_Click);
            // 
            // responses_exp_btn
            // 
            this.responses_exp_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.responses_exp_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.responses_exp_btn.FlatAppearance.BorderSize = 0;
            this.responses_exp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.responses_exp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.responses_exp_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.responses_exp_btn.Location = new System.Drawing.Point(117, 54);
            this.responses_exp_btn.Name = "responses_exp_btn";
            this.responses_exp_btn.Size = new System.Drawing.Size(170, 55);
            this.responses_exp_btn.TabIndex = 21;
            this.responses_exp_btn.Text = "Экспортировать заявки";
            this.responses_exp_btn.UseVisualStyleBackColor = false;
            this.responses_exp_btn.Click += new System.EventHandler(this.responses_exp_btn_Click);
            // 
            // export_btn
            // 
            this.export_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.export_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.export_btn.FlatAppearance.BorderSize = 0;
            this.export_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.export_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.export_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.export_btn.Location = new System.Drawing.Point(117, 187);
            this.export_btn.Name = "export_btn";
            this.export_btn.Size = new System.Drawing.Size(170, 55);
            this.export_btn.TabIndex = 19;
            this.export_btn.Text = "Экспортировать сотрудников";
            this.export_btn.UseVisualStyleBackColor = false;
            this.export_btn.Click += new System.EventHandler(this.export_btn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 296);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(416, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(86, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(206, 17);
            this.toolStripStatusLabel1.Text = "Тут реализуется экспорт отчётности";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(416, 318);
            this.Controls.Add(this.conract_exp_btn);
            this.Controls.Add(this.responses_exp_btn);
            this.Controls.Add(this.export_btn);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report";
            this.Text = "Отчётность";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Report_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button export_btn;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button conract_exp_btn;
        private Button responses_exp_btn;
    }
}