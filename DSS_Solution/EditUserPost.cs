using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSS
{
    public partial class EditUserPost : Form
    {
        private SQLiteConnection dbConnection;

        public EditUserPost()
        {
            InitializeComponent();
        }

        private void EditUserPost_Load(object sender, EventArgs e)
        {
            dbConnection = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\database.db; Version=3");
            dbConnection.Open();

            SQLiteCommand sqlCommand = dbConnection.CreateCommand();
            sqlCommand.CommandText = "Select * from UserPost";
            SQLiteDataReader sqlReader = sqlCommand.ExecuteReader();

            using (sqlReader)
            {
                if (sqlReader.HasRows)
                {
                    try
                    {
                        while (sqlReader.Read())
                        {
                            dataGridView1.Rows.Add(sqlReader[0], sqlReader[1]);
                        }
                    }
                    catch (SQLiteException ex)
                    {
                        NotifyIcon notifyIconError = new NotifyIcon();
                        notifyIconError.BalloonTipTitle = "Ошибка";
                        notifyIconError.BalloonTipText = "Текст ошибки: " + ex;
                        notifyIconError.BalloonTipIcon = ToolTipIcon.Error;
                        notifyIconError.Icon = this.Icon;
                        notifyIconError.Visible = true;
                        notifyIconError.ShowBalloonTip(500);
                    }
                }
            }

            dbConnection.Close();

            button4.Visible = false;
            button5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Добавить новую запись в конце списка            

            dataGridView1.CurrentCell = dataGridView1[1, dataGridView1.RowCount - 1];
            //dataGridView1[0, dataGridView1.RowCount - 1].Value = Convert.ToInt32(dataGridView1[0, dataGridView1.RowCount - 2].Value) + 1;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            button4.Visible = true;
            button5.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Редактировать выбранную ячейку

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Удалить выбранную запись
            DeleteRecord();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Сохранить изменения
            dbConnection = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\database.db; Version=3");
            dbConnection.Open();

            SQLiteCommand sqlClearTable = dbConnection.CreateCommand();

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                sqlClearTable.CommandText = "Delete from UserPost where ID = @ID";
                sqlClearTable.Parameters.Add("@ID", DbType.Int32).Value = Convert.ToInt32(dataGridView1[0, i].Value);

                sqlClearTable.ExecuteNonQuery();
            }

            SQLiteCommand sqlCommandAddRecords = dbConnection.CreateCommand();

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                sqlCommandAddRecords.CommandText = "Insert into UserPost (Name) values (@Name)";
                sqlCommandAddRecords.Parameters.Add("@Name", DbType.String).Value = dataGridView1[1, i].Value;

                sqlCommandAddRecords.ExecuteNonQuery();
            }

            NotifyIcon notifyIconAddNewRecord = new NotifyIcon();
            notifyIconAddNewRecord.BalloonTipTitle = "Уведомление";
            notifyIconAddNewRecord.BalloonTipText = "Запись успешно добавлена в базу данных";
            notifyIconAddNewRecord.BalloonTipIcon = ToolTipIcon.Info;
            notifyIconAddNewRecord.Icon = this.Icon;
            notifyIconAddNewRecord.Visible = true;
            notifyIconAddNewRecord.ShowBalloonTip(500);

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;

            button4.Visible = false;
            button5.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Отменить изменения

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;

            button4.Visible = false;
            button5.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Выход из формы

            dbConnection.Close();
            this.Close();
        }

        private void EditRecord()
        {

        }

        private void DeleteRecord()
        {
            SQLiteCommand sqlCommand = dbConnection.CreateCommand();
            sqlCommand.CommandText = "Delete from UserPost where ID=@ID";
            sqlCommand.Parameters.Add("@ID", DbType.UInt16).Value = dataGridView1.CurrentRow.Cells[0].Value;
            try
            {
                //Удаление записи из таблицы в ДБ
                dbConnection.Open();
                sqlCommand.ExecuteNonQuery();
                dbConnection.Close();

                //Удаление строки в DGV при выбранной ячейке
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    dataGridView1.Rows.RemoveAt(cell.RowIndex);

                    if (cell.RowIndex < 0) break;
                }

                NotifyIcon notifyIconRemoveRecord = new NotifyIcon();
                notifyIconRemoveRecord.BalloonTipTitle = "Уведомление";
                notifyIconRemoveRecord.BalloonTipText = "Запись успешно удалена из базы данных";
                notifyIconRemoveRecord.BalloonTipIcon = ToolTipIcon.Info;
                notifyIconRemoveRecord.Icon = this.Icon;
                notifyIconRemoveRecord.Visible = true;
                notifyIconRemoveRecord.ShowBalloonTip(500);
            }
            catch (SQLiteException ex)
            {
                NotifyIcon notifyIconError = new NotifyIcon();
                notifyIconError.BalloonTipTitle = "Ошибка";
                notifyIconError.BalloonTipText = "Текст ошибки: " + ex;
                notifyIconError.BalloonTipIcon = ToolTipIcon.Error;
                notifyIconError.Icon = this.Icon;
                notifyIconError.Visible = true;
                notifyIconError.ShowBalloonTip(500);
            }
        }

    }
}
