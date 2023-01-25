using Microsoft.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agency_csharp;

public partial class Workers : Form
{
    private readonly CheckUser _user;
    Database database = new Database();
    int selectedRow;

    private readonly string refreshWorkersQuery = @"
        select id_user, u_name, u_surname, u_patronymic, w_birth, w_sex, w_profession, w_education from Client
            inner join Users U on U.id_pk_user = Client.id_user
            inner join Workers W on Client.id_pk_client = W.id_fk_client
    ";    

    public Workers(CheckUser user)
    {
        _user = user;

        StartPosition = FormStartPosition.CenterScreen;

        InitializeComponent();

        CreateColumns(workers_dgv);
        RefreshDataGrid(
            workers_dgv,
            refreshWorkersQuery
        );
    }

    private void ReadSingleRow(DataGridView dgv, IDataRecord record)
    {
        dgv.Rows.Add(
            record.GetInt32(0),
            record.GetString(1),
            record.GetString(2),
            record.GetString(3),
            record.GetString(4),
            record.GetString(5),
            record.GetString(6),
            record.GetString(7)
        );
    }

    private void CreateColumns(DataGridView dgv)
    {
        dgv.Columns.Add("id_user", "Id соискателя");
        dgv.Columns.Add("u_name", "Имя");
        dgv.Columns.Add("u_surname", "Фамилия");
        dgv.Columns.Add("u_patronymic", "Отчество");
        dgv.Columns.Add("w_birth", "Дата рождения");
        dgv.Columns.Add("w_sex", "Пол");
        dgv.Columns.Add("w_profession", "Профессия");
        dgv.Columns.Add("w_education", "Образование");
    }

    private void RefreshDataGrid(DataGridView dgv, string query)
    {
        dgv.Rows.Clear();

        SqlCommand command = new SqlCommand(query, database.getConnection());

        database.openConnection();

        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            ReadSingleRow(dgv, reader);
        }

        reader.Close();

        database.closeConnection();
    }

    private void Search(DataGridView dgv, string query)
    {
        dgv.Rows.Clear();

        SqlCommand command = new SqlCommand(query, database.getConnection());

        database.openConnection();

        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            ReadSingleRow(dgv, reader);
        }

        reader.Close();
        database.closeConnection();
    }

    private void ClearFields()
    {
        clientID_tb.Text = "";
        clientName_tb.Text = "";
        clientSur_tb.Text = "";
        clientPat_tb.Text = "";

        age_tb.Text = "";
        sex_tb.Text = "";
        profession_tb.Text = "";
        docsEducation_tb.Text = "";
    }

    private void Workers_Load(object sender, EventArgs e)
    {

    }

    private void workers_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        selectedRow = e.RowIndex;

        // проверка e.Row проводится для того, чтобы не выводилась ошибка выхода из диапазона
        if (e.RowIndex >= 0)
        {
            DataGridViewRow row = workers_dgv.Rows[selectedRow];

            clientID_tb.Text = row.Cells[0].Value.ToString();
            clientName_tb.Text = row.Cells[1].Value.ToString();
            clientSur_tb.Text = row.Cells[2].Value.ToString();
            clientPat_tb.Text = row.Cells[3].Value.ToString();

            age_tb.Text = row.Cells[4].Value.ToString();
            sex_tb.Text = row.Cells[5].Value.ToString();
            profession_tb.Text = row.Cells[6].Value.ToString();
            docsEducation_tb.Text = row.Cells[7].Value.ToString();
        }
    }

    private void vacClrear_btn_Click(object sender, EventArgs e)
    {
        ClearFields();
    }

    private void refresh_btn_Click(object sender, EventArgs e)
    {
        RefreshDataGrid(workers_dgv, refreshWorkersQuery);
    }

    private void vacSearch_btn_Click(object sender, EventArgs e)
    {
        Search(
            workers_dgv,
            @$"
                select id_user, u_name, u_surname, u_patronymic, w_birth, w_sex, w_profession, w_education from Client
                    inner join Users U on U.id_pk_user = Client.id_user
                    inner join Workers W on Client.id_pk_client = W.id_fk_client
                where concat(id_user, u_name, u_surname, u_patronymic, w_birth, w_sex, w_profession, w_education) like '%{vacSearch_tb.Text}%'"
        );
    }

    private void vacSearch_tb_TextChanged(object sender, EventArgs e)
    {
        Search(
            workers_dgv,
            @$"
                select id_user, u_name, u_surname, u_patronymic, w_birth, w_sex, w_profession, w_education from Client
                    inner join Users U on U.id_pk_user = Client.id_user
                    inner join Workers W on Client.id_pk_client = W.id_fk_client
                where concat(id_user, u_name, u_surname, u_patronymic, w_birth, w_sex, w_profession, w_education) like '%{vacSearch_tb.Text}%'"
        );
    }

    private void Workers_FormClosed(object sender, FormClosedEventArgs e)
    {
        Form login = new Login();
        login.Show();
        this.Hide();
    }
}