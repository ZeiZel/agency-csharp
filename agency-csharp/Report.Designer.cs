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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.contracts_tab = new System.Windows.Forms.TabPage();
            this.responses_tab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.contracts_tab);
            this.tabControl1.Controls.Add(this.responses_tab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(843, 533);
            this.tabControl1.TabIndex = 0;
            // 
            // contracts_tab
            // 
            this.contracts_tab.Location = new System.Drawing.Point(4, 24);
            this.contracts_tab.Name = "contracts_tab";
            this.contracts_tab.Padding = new System.Windows.Forms.Padding(3);
            this.contracts_tab.Size = new System.Drawing.Size(835, 505);
            this.contracts_tab.TabIndex = 0;
            this.contracts_tab.Text = "Контракты";
            this.contracts_tab.UseVisualStyleBackColor = true;
            // 
            // responses_tab
            // 
            this.responses_tab.Location = new System.Drawing.Point(4, 24);
            this.responses_tab.Name = "responses_tab";
            this.responses_tab.Padding = new System.Windows.Forms.Padding(3);
            this.responses_tab.Size = new System.Drawing.Size(835, 505);
            this.responses_tab.TabIndex = 1;
            this.responses_tab.Text = "Заявки";
            this.responses_tab.UseVisualStyleBackColor = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 533);
            this.Controls.Add(this.tabControl1);
            this.Name = "Report";
            this.Text = "Report";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Report_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage contracts_tab;
        private TabPage responses_tab;
    }
}