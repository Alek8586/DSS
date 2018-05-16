using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DSS
{
    public partial class Projects : Form
    {
        private SQLiteConnection dbConnection;

        public Projects()
        {
            InitializeComponent();
        }

        private void Projects_Load(object sender, EventArgs e)
        {
            ListOfProjects();
        }

        private void buttonAddProject_Click(object sender, EventArgs e)
        {
            EditProject AddProjectForm = new EditProject(null);
            AddProjectForm.Owner = this;
            AddProjectForm.ShowDialog();
        }

        private void buttonEditProject_Click(object sender, EventArgs e)
        {
            //Передаем данные строки в поля формы
            string[] sample = new string[dataGridViewProjects.CurrentRow.Cells.Count];
            for (int i = 0; i < dataGridViewProjects.CurrentRow.Cells.Count; i++)
            {
                sample[i] = dataGridViewProjects.CurrentRow.Cells[i].Value.ToString();
            }

            EditProject EditProjectForm = new EditProject(sample);
            EditProjectForm.Owner = this;
            EditProjectForm.ShowDialog();
        }

        private void buttonDeleteProject_Click(object sender, EventArgs e)
        {
            DeleteProject();
        }

        private void buttonToFormAdminMode_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ListOfProjects()
        {
            //Заполнение таблицы с информацией о пользователях
            try
            {
                dbConnection = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "database.db; Version=3");
                dbConnection.Open();

                SQLiteCommand listProjects = dbConnection.CreateCommand();
                listProjects.CommandText = "Select * from Projects";
                SQLiteDataReader sql = listProjects.ExecuteReader();

                while (sql.Read())
                {
                    dataGridViewProjects.Rows.Add(sql[0].ToString(), sql[1].ToString(), sql[2].ToString(), sql[3].ToString(), sql[4].ToString(), sql[5].ToString(), sql[6].ToString());
                }
                sql.Close();
                dbConnection.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DeleteProject()
        {
            SQLiteCommand cmd = dbConnection.CreateCommand();
            cmd.CommandText = "Delete from Projects where ID=@id";
            cmd.Parameters.Add("@id", DbType.UInt16).Value = dataGridViewProjects.CurrentRow.Cells[0].Value;
            try
            {
                //Удаление записи из таблицы в ДБ
                dbConnection.Open();
                cmd.ExecuteNonQuery();
                dbConnection.Close();

                //Удаление строки в DGV при выбранной ячейке
                foreach (DataGridViewCell cell in dataGridViewProjects.SelectedCells)
                {
                    dataGridViewProjects.Rows.RemoveAt(cell.RowIndex);
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}