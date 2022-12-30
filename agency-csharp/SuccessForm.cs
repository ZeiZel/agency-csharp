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
    public partial class SuccessForm : Form
    {
        public SuccessForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            Form login = new Login();
            login.Show();
            Close();
        }

        private void SuccessForm_Load(object sender, EventArgs e)
        {

        }
    }
}
