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
    public partial class CheckUpdates : Form
    {
        public CheckUpdates()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;

                bool result = CheckUpdate();

                if (result)
                {
                    checkUpdates_btn.Text = "Обновление в наличии!";
                    checkUpdates_btn.BackColor = Color.FromArgb(26, 188, 156);
                }
                else
                {
                    checkUpdates_btn.Text = "Обновлений нет!";
                    checkUpdates_btn.BackColor = Color.FromArgb(231, 76, 60);
                }

            }
            else if (progressBar1.Value > 1 && progressBar1.Value < 99)
            {
                checkUpdates_btn.Text = "Проверка обновления...";
                progressBar1.Increment(1);
            }
            else
            {
                checkUpdates_btn.BackColor = Color.FromArgb(26, 188, 156);
                checkUpdates_btn.Text = "Проверить обновления";
                progressBar1.Increment(1);
            }
        }

        private void checkUpdates_btn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            if (checkUpdates_btn.Text == "Обновление в наличии!")
            {
                // TODO: произвести скачивание и установку обновления
            }

            if (checkUpdates_btn.Text == "Обновлений нет!")
            {
                Close();
            }
        }

        private Boolean CheckUpdate()
        {
            // TODO: сделать проверку на обновления с гитхаба
            return false;
        }

        private void CheckUpdates_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;
        }
    }
}
