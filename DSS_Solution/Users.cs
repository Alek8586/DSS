﻿using System;
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
            string[] userData = new string[dataGridViewUsers.CurrentRow.Cells.Count];

            EditUser AddUserForm = new EditUser(userData);
            AddUserForm.Owner = this;
            AddUserForm.ShowDialog();
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            EditRecord();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void buttonToFormAdminMode_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void dataGridViewUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditRecord();
        }

        public void ListOfUsers()
        {
            //Заполнение таблицы с информацией о пользователях
            try
            {
                dbConnection = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\database.db; Version=3");
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

        private void EditRecord()
        {
            //Передаем данные строки DGV в поля формы редактирования
            string[] userData = new string[dataGridViewUsers.CurrentRow.Cells.Count];
            for (int i = 0; i < dataGridViewUsers.CurrentRow.Cells.Count; i++)
            {
                userData[i] = dataGridViewUsers.CurrentRow.Cells[i].Value.ToString();
            }

            EditUser EditUserForm = new EditUser(userData);
            EditUserForm.Owner = this;
            EditUserForm.ShowDialog();

        }

        private void DeleteUser()
        {
            SQLiteCommand cmd = dbConnection.CreateCommand();
            cmd.CommandText = "Delete from Users where ID=@id";
            cmd.Parameters.Add("@id", DbType.UInt16).Value = dataGridViewUsers.CurrentRow.Cells[0].Value;
            try
            {
                //Удаление записи из таблицы в ДБ
                dbConnection.Open();
                cmd.ExecuteNonQuery();
                dbConnection.Close();

                //Удаление строки в DGV при выбранной ячейке
                foreach (DataGridViewCell cell in dataGridViewUsers.SelectedCells)
                {
                    dataGridViewUsers.Rows.RemoveAt(cell.RowIndex);

                    if (cell.RowIndex < 0) break;
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
