using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Data.SqlClient;

namespace agency_csharp
{
    public partial class Report : Form
    {
        Database database = new Database();

        Excel.Application xlApp;
        Excel.Worksheet xlSheet;
        Excel.Range xlSheetRange;

        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        // -------------------------------------------

        private DataTable GetData(string query)
        {
            DataTable dt = new DataTable();

            try
            {
                SqlCommand comm = new SqlCommand(query, database.getConnection());

                database.openConnection();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }
            return dt;
        }

        // Освобождаем ресуры
        void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show(ex.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                GC.Collect();
            }
        }

        // -------------------------------------------

        private void export_btn_Click(object sender, EventArgs e)
        {
            database.openConnection();

            toolStripStatusLabel1.Text = "Пожалуйста, подождите немного - сейчас выполняется операция экспорта данных.";
            toolStripProgressBar1.Value = 1;

            xlApp = new Excel.Application();
            toolStripProgressBar1.Value = 5;

            try
            {
                //добавляем книгу
                xlApp.Workbooks.Add(Type.Missing);

                //делаем временно неактивным документ
                xlApp.Interactive = false;
                xlApp.EnableEvents = false;
                toolStripProgressBar1.Value = 10;

                //выбираем лист на котором будем работать (Лист 1)
                xlSheet = (Excel.Worksheet)xlApp.Sheets[1];
                //Название листа
                xlSheet.Name = "Данные сотрудников";

                //Выгрузка данных
                DataTable dt = GetData(@"SELECT id_pk_employee, id_fk_user, u_name, u_surname, u_patronymic, u_phoneNumber FROM Employee inner join Users U on U.id_pk_user = Employee.id_fk_user");

                int collInd = 0;
                int rowInd = 0;
                string data = "";

                //называем колонки
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    data = dt.Columns[i].ColumnName.ToString();
                    xlSheet.Cells[1, i + 1] = data;

                    //выделяем первую строку
                    xlSheetRange = xlSheet.get_Range("A1:Z1", Type.Missing);

                    //делаем полужирный текст и перенос слов
                    xlSheetRange.WrapText = true;
                    xlSheetRange.Font.Bold = true;
                }

                toolStripProgressBar1.Value = 30;

                xlSheet.Cells[1, 1] = "ID сотрудника";
                xlSheet.Cells[1, 2] = "ID пользователя";
                xlSheet.Cells[1, 3] = "Имя";
                xlSheet.Cells[1, 4] = "Фамилия";
                xlSheet.Cells[1, 5] = "Отчество";
                xlSheet.Cells[1, 6] = "Номер телефона";

                //заполняем строки
                for (rowInd = 0; rowInd < dt.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dt.Columns.Count; collInd++)
                    {
                        data = dt.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet.Cells[rowInd + 2, collInd + 1] = data;
                    }
                }

                toolStripProgressBar1.Value = 50;

                //выбираем всю область данных
                xlSheetRange = xlSheet.UsedRange;

                //выравниваем строки и колонки по их содержимому
                xlSheetRange.Columns.AutoFit();
                xlSheetRange.Rows.AutoFit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //Показываем ексель
                xlApp.Visible = true;

                xlApp.Interactive = true;
                xlApp.ScreenUpdating = true;
                xlApp.UserControl = true;

                toolStripProgressBar1.Value = 70;

                //Отсоединяемся от Excel
                releaseObject(xlSheetRange);
                releaseObject(xlSheet);
                releaseObject(xlApp);

                toolStripProgressBar1.Value = 90;
            }

            database.closeConnection();
            toolStripStatusLabel1.Text = "Операция завершена. Отчёт сгенерирован.";
            toolStripProgressBar1.Value = 100;
        }

        private void responses_exp_btn_Click(object sender, EventArgs e)
        {
            database.openConnection();

            toolStripStatusLabel1.Text = "Пожалуйста, подождите немного - сейчас выполняется операция экспорта данных.";
            toolStripProgressBar1.Value = 1;

            xlApp = new Excel.Application();
            toolStripProgressBar1.Value = 5;

            try
            {
                //добавляем книгу
                xlApp.Workbooks.Add(Type.Missing);

                //делаем временно неактивным документ
                xlApp.Interactive = false;
                xlApp.EnableEvents = false;
                toolStripProgressBar1.Value = 10;

                //выбираем лист на котором будем работать (Лист 1)
                xlSheet = (Excel.Worksheet)xlApp.Sheets[1];
                //Название листа
                xlSheet.Name = "Данные по откликам";

                //Выгрузка данных
                DataTable dt = GetData(@"select id_pk_response, id_fk_user, u_name, u_surname, u_patronymic, u_phoneNumber from UserResponse inner join Users U on U.id_pk_user = UserResponse.id_fk_user;");
                DataTable dtCount = GetData(@"select count(id_pk_response) from UserResponse;");

                int collInd = 0;
                int rowInd = 0;
                string data = "";

                //называем колонки
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    data = dt.Columns[i].ColumnName.ToString();
                    xlSheet.Cells[1, i + 1] = data;

                    //выделяем первую строку
                    xlSheetRange = xlSheet.get_Range("A1:Z1", Type.Missing);

                    //делаем полужирный текст и перенос слов
                    xlSheetRange.WrapText = true;
                    xlSheetRange.Font.Bold = true;
                }

                toolStripProgressBar1.Value = 30;

                xlSheet.Cells[1, 1] = "ID Отклика";
                xlSheet.Cells[1, 2] = "ID пользователя";
                xlSheet.Cells[1, 3] = "Имя";
                xlSheet.Cells[1, 4] = "Фамилия";
                xlSheet.Cells[1, 5] = "Отчество";
                xlSheet.Cells[1, 6] = "Номер телефона";
                
                xlSheet.Cells[1, 8] = "Общее количество откликов";

                //заполняем строки для главного запроса
                for (rowInd = 0; rowInd < dt.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dt.Columns.Count; collInd++)
                    {
                        data = dt.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet.Cells[rowInd + 2, collInd + 1] = data;
                    }
                }

                //заполняем строки для запроса на количество
                for (rowInd = 0; rowInd < dtCount.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dtCount.Columns.Count; collInd++)
                    {
                        data = dtCount.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet.Cells[2, 8] = data;
                    }
                }

                toolStripProgressBar1.Value = 50;

                //выбираем всю область данных
                xlSheetRange = xlSheet.UsedRange;

                //выравниваем строки и колонки по их содержимому
                xlSheetRange.Columns.AutoFit();
                xlSheetRange.Rows.AutoFit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //Показываем ексель
                xlApp.Visible = true;

                xlApp.Interactive = true;
                xlApp.ScreenUpdating = true;
                xlApp.UserControl = true;

                toolStripProgressBar1.Value = 70;

                //Отсоединяемся от Excel
                releaseObject(xlSheetRange);
                releaseObject(xlSheet);
                releaseObject(xlApp);

                toolStripProgressBar1.Value = 90;
            }

            database.closeConnection();
            toolStripStatusLabel1.Text = "Операция завершена. Отчёт сгенерирован.";
            toolStripProgressBar1.Value = 100;
        }

        private void conract_exp_btn_Click(object sender, EventArgs e)
        {
            database.openConnection();

            toolStripStatusLabel1.Text = "Пожалуйста, подождите немного - сейчас выполняется операция экспорта данных.";
            toolStripProgressBar1.Value = 1;

            xlApp = new Excel.Application();
            toolStripProgressBar1.Value = 5;

            try
            {
                //добавляем книгу
                xlApp.Workbooks.Add(Type.Missing);

                //делаем временно неактивным документ
                xlApp.Interactive = false;
                xlApp.EnableEvents = false;
                toolStripProgressBar1.Value = 10;

                //выбираем лист на котором будем работать (Лист 1)
                xlSheet = (Excel.Worksheet)xlApp.Sheets[1];
                //Название листа
                xlSheet.Name = "Данные контрактов";

                //Выгрузка данных
                DataTable dt = GetData(@"select id_pk_contract, c_conditions, c_createdAt, E.u_name, E.u_surname, C.u_name, C.u_surname, cs_status from ContractStatus, Contracts inner join Employee Emp on Contracts.c_fk_employee = Emp.id_pk_employee inner join Client Cli on Cli.id_pk_client = Contracts.c_fk_client inner join Users C on C.id_pk_user = Cli.id_user inner join Users E on E.id_pk_user = Emp.id_fk_user where c_fk_status = ContractStatus.id_pk_status;");

                int collInd = 0;
                int rowInd = 0;
                string data = "";

                //называем колонки
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    data = dt.Columns[i].ColumnName.ToString();
                    xlSheet.Cells[1, i + 1] = data;

                    //выделяем первую строку
                    xlSheetRange = xlSheet.get_Range("A1:Z1", Type.Missing);

                    //делаем полужирный текст и перенос слов
                    xlSheetRange.WrapText = true;
                    xlSheetRange.Font.Bold = true;
                }

                toolStripProgressBar1.Value = 40;

                xlSheet.Cells[1, 1] = "ID Контракта";
                xlSheet.Cells[1, 2] = "Условия контракта";
                xlSheet.Cells[1, 3] = "Дата заключения";
                xlSheet.Cells[1, 4] = "Имя агента";
                xlSheet.Cells[1, 5] = "Фамилия агента";
                xlSheet.Cells[1, 6] = "Имя клиента";
                xlSheet.Cells[1, 7] = "Фамилия клиента";
                xlSheet.Cells[1, 8] = "Статус контракта";

                //заполняем строки
                for (rowInd = 0; rowInd < dt.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dt.Columns.Count; collInd++)
                    {
                        data = dt.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet.Cells[rowInd + 2, collInd + 1] = data;
                    }
                }

                toolStripProgressBar1.Value = 50;

                //выбираем всю область данных
                xlSheetRange = xlSheet.UsedRange;

                //выравниваем строки и колонки по их содержимому
                xlSheetRange.Columns.AutoFit();
                xlSheetRange.Rows.AutoFit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //Показываем ексель
                xlApp.Visible = true;

                xlApp.Interactive = true;
                xlApp.ScreenUpdating = true;
                xlApp.UserControl = true;

                toolStripProgressBar1.Value = 70;

                //Отсоединяемся от Excel
                releaseObject(xlSheetRange);
                releaseObject(xlSheet);
                releaseObject(xlApp);

                toolStripProgressBar1.Value = 90;
            }

            database.closeConnection();
            toolStripStatusLabel1.Text = "Операция завершена. Отчёт сгенерирован.";
            toolStripProgressBar1.Value = 100;
        }
    }
}
