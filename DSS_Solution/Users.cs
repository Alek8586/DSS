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
            ListOfUsers();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            EditUser AddUserForm = new EditUser(null);
            AddUserForm.Owner = this;
            AddUserForm.ShowDialog();
            //if (AddUserForm.ShowDialog(this) == DialogResult.OK)
            //{
            //    RefreshUsersList();
            //}
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            string sample = "!";
            EditUser EditUserForm = new EditUser(sample);
            EditUserForm.Owner = this;
            /*
             * Передаем данные строки в поля формы
            */


            EditUserForm.ShowDialog();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd = dbConnection.CreateCommand();
            cmd.CommandText = "Delete from Users where ID=@id";
            cmd.Parameters.Add("@id", DbType.UInt16).Value = dataGridViewUsers.CurrentRow.Cells[0].Value;
            try
            {
                dbConnection.Open();
                cmd.ExecuteNonQuery();
                dbConnection.Close();

                foreach (DataGridViewCell cell in dataGridViewUsers.SelectedCells)
                {
                    dataGridViewUsers.Rows.RemoveAt(cell.RowIndex);
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonToFormAdminMode_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ////ДЛЯ ТЕСТА
        //private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    buttonEditUser.Text = dataGridViewUsers.CurrentRow.Cells[0].Value.ToString();
        //}

        public void ListOfUsers()
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
                    dataGridViewUsers.Rows.Add(sql[0].ToString(), sql[1].ToString(), sql[2].ToString(), sql[3].ToString(), sql[4].ToString(), sql[5].ToString(), sql[6].ToString());
                }
                sql.Close();
                dbConnection.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
