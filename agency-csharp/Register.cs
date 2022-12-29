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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Form login = new Login();
            login.Show();

            Close();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
