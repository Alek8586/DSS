using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DSS
{
    public partial class Users : Form
    {
        private SQLiteConnection dbConnection;

        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            //Заполнение таблицы с информацией о пользователях
            try
            {
                dbConnection = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "database.db; Version=3");
                dbConnection.Open();

                SQLiteCommand listUsers = dbConnection.CreateCommand();
                listUsers.CommandText = "Select * from Users";
                SQLiteDataReader sql = listUsers.ExecuteReader();

                while (sql.Read())
                {
                    dataGridViewUsers.Rows.Add(sql[0].ToString(), sql[1].ToString(), sql[2].ToString(), sql[3].ToString(), sql[4].ToString(), sql[5].ToString());
                }
                sql.Close();
                dbConnection.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            //Добавление новой записи пользователя
            //Выделение последней строки под запись
            //dataGridViewUsers.CurrentCell = dataGridViewUsers[1, dataGridViewUsers.Rows.Count - 1];
            //dataGridViewUsers.BeginEdit(true);  

            EditUser AddUserForm = new EditUser();
            AddUserForm.Owner = this;
            AddUserForm.ShowDialog();
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            EditUser AddUserForm = new EditUser();
            AddUserForm.Owner = this;

            /*
             * Передаем данные строки в поля формы
            */


            AddUserForm.ShowDialog();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridViewUsers.SelectedCells)
            {
                dataGridViewUsers.Rows.RemoveAt(cell.RowIndex);
            }
            try
            {
                SQLiteCommand cmd = dbConnection.CreateCommand();
                cmd.CommandText = "Delete from Users where ID=@id";
                cmd.Parameters.Add("@id", DbType.String).Value = dataGridViewUsers.CurrentRow.Cells[0].Value.ToString();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //private void buttonSave_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        SQLiteCommand setUser = dbConnection.CreateCommand();
        //        setUser.CommandText = "Insert into Users(Login, Role, Password, Fullname, Etc) values (@Login, @Role, @Password, @Fullname, @Etc)";
        //        if (dataGridViewUsers.CurrentRow.Cells[0].Value == null)
        //        {
        //            setUser.Parameters.Add("@Login", DbType.String).Value = "";
        //        }
        //        else setUser.Parameters.Add("@Login", DbType.String).Value = dataGridViewUsers.CurrentRow.Cells[0].Value.ToString();

        //        if (dataGridViewUsers.CurrentRow.Cells[1].Value == null)
        //        {
        //            setUser.Parameters.Add("@Role", DbType.String).Value = "";
        //        }
        //        else setUser.Parameters.Add("@Role", DbType.String).Value = dataGridViewUsers.CurrentRow.Cells[1].Value.ToString();

        //        if (dataGridViewUsers.CurrentRow.Cells[2].Value == null)
        //        {
        //            setUser.Parameters.Add("@Password", DbType.String).Value = "";
        //        }
        //        else setUser.Parameters.Add("@Password", DbType.String).Value = dataGridViewUsers.CurrentRow.Cells[2].Value.ToString();

        //        if (dataGridViewUsers.CurrentRow.Cells[3].Value == null)
        //        {
        //            setUser.Parameters.Add("@Fullname", DbType.String).Value = "";
        //        }
        //        else setUser.Parameters.Add("@Fullname", DbType.String).Value = dataGridViewUsers.CurrentRow.Cells[3].Value.ToString();

        //        if (dataGridViewUsers.CurrentRow.Cells[4].Value == null)
        //        {
        //            setUser.Parameters.Add("@Etc", DbType.String).Value = "";
        //        }
        //        else setUser.Parameters.Add("@Etc", DbType.String).Value = dataGridViewUsers.CurrentRow.Cells[4].Value.ToString();

        //        setUser.ExecuteNonQuery();
        //        dataGridViewUsers.Update();
        //        dbConnection.Close();
        //    }
        //    catch (SQLiteException ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);
        //    }
        //}

        //private void buttonSaveAndExit_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        SQLiteCommand setUser = dbConnection.CreateCommand();
        //        setUser.CommandText = "Insert into Users(Login, Role, Password, Fullname, Etc) values (@Login, @Role, @Password, @Fullname, @Etc)";
        //        if (dataGridViewUsers.CurrentRow.Cells[0].Value == null)
        //        {
        //            setUser.Parameters.Add("@Login", DbType.String).Value = "";
        //        }
        //        else setUser.Parameters.Add("@Login", DbType.String).Value = dataGridViewUsers.CurrentRow.Cells[0].Value.ToString();

        //        if (dataGridViewUsers.CurrentRow.Cells[1].Value == null)
        //        {
        //            setUser.Parameters.Add("@Role", DbType.String).Value = "";
        //        }
        //        else setUser.Parameters.Add("@Role", DbType.String).Value = dataGridViewUsers.CurrentRow.Cells[1].Value.ToString();

        //        if (dataGridViewUsers.CurrentRow.Cells[2].Value == null)
        //        {
        //            setUser.Parameters.Add("@Password", DbType.String).Value = "";
        //        }
        //        else setUser.Parameters.Add("@Password", DbType.String).Value = dataGridViewUsers.CurrentRow.Cells[2].Value.ToString();

        //        if (dataGridViewUsers.CurrentRow.Cells[3].Value == null)
        //        {
        //            setUser.Parameters.Add("@Fullname", DbType.String).Value = "";
        //        }
        //        else setUser.Parameters.Add("@Fullname", DbType.String).Value = dataGridViewUsers.CurrentRow.Cells[3].Value.ToString();

        //        if (dataGridViewUsers.CurrentRow.Cells[4].Value == null)
        //        {
        //            setUser.Parameters.Add("@Etc", DbType.String).Value = "";
        //        }
        //        else setUser.Parameters.Add("@Etc", DbType.String).Value = dataGridViewUsers.CurrentRow.Cells[4].Value.ToString();

        //        setUser.ExecuteNonQuery();
        //        dataGridViewUsers.Update();
        //    }
        //    catch (SQLiteException ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);
        //    }

        //    this.Close();
        //    dbConnection.Close();
        //}

        private void buttonToFormAdminMode_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //ДЛЯ ТЕСТА
        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonEditUser.Text = dataGridViewUsers.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
