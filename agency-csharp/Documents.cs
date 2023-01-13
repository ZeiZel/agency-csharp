using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace agency_csharp
{
    public partial class Documents : Form
    {
        private readonly string _name;
        private readonly string _surname;
        private readonly string _patronymic;
        private readonly string _identity;

        public Documents(string name, string surname, string patronymic, string identity)
        {
            this._name = name;
            this._surname = surname;
            this._patronymic = patronymic;
            this._identity = identity;

            InitializeComponent();
        }

        private void Documents_Load(object sender, EventArgs e)
        {
            clientID_tb.Text = _identity;
            clientName_tb.Text = _name;
            clientSur_tb.Text = _surname;
            clientPat_tb.Text = _patronymic;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данные успешно добавлены клиенту!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
