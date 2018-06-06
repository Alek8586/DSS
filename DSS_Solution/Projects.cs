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
            string[] projectData = new string[dataGridViewProjects.CurrentRow.Cells.Count];

            EditProject AddProjectForm = new EditProject(projectData);
            AddProjectForm.Owner = this;
            AddProjectForm.ShowDialog();
        }

        private void buttonEditProject_Click(object sender, EventArgs e)
        {
            EditRecord();
        }

        private void buttonDeleteProject_Click(object sender, EventArgs e)
        {
            DeleteProject();
        }

        private void buttonSelectionSupplier_Click(object sender, EventArgs e)
        {
            SelectSupplier selectSupplierForm = new SelectSupplier();
            selectSupplierForm.Owner = this;
            selectSupplierForm.ShowDialog();
        }

        private void buttonToFormAdminMode_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewProjects_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditRecord();
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

                using (var sql = listProjects.ExecuteReader())
                {
                    while (sql.Read())
                    {
                        dataGridViewProjects.Rows.Add(sql[0].ToString(), sql[1].ToString(), sql[2].ToString(), sql[3].ToString(), sql[4].ToString(), sql[5].ToString(), sql[6].ToString(), sql[7].ToString(), sql[8].ToString());
                    }
                }
                dbConnection.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: \n\n" + ex.Message);
            }
        }

        private void EditRecord()
        {
            //Передаем данные строки DGV в поля формы редактирования

            string[] projectData = new string[dataGridViewProjects.CurrentRow.Cells.Count];
            for (int i = 0; i < dataGridViewProjects.CurrentRow.Cells.Count; i++)
            {
                projectData[i] = dataGridViewProjects.CurrentRow.Cells[i].Value.ToString();
            }

            EditProject EditProjectForm = new EditProject(projectData);
            EditProjectForm.Owner = this;
            EditProjectForm.ShowDialog();
        }

        private void DeleteProject()
        {
            SQLiteCommand sqlCommand = dbConnection.CreateCommand();
            sqlCommand.CommandText = "Delete from Projects where ID=@ID";
            sqlCommand.Parameters.Add("@ID", DbType.Int32).Value = dataGridViewProjects.CurrentRow.Cells[0].Value;
            try
            {
                //Удаление записи из таблицы в ДБ
                dbConnection.Open();
                sqlCommand.ExecuteNonQuery();
                dbConnection.Close();

                //Удаление строки в DGV при выбранной ячейке
                foreach (DataGridViewCell cell in dataGridViewProjects.SelectedCells)
                {
                    dataGridViewProjects.Rows.RemoveAt(cell.RowIndex);

                    if (cell.RowIndex < 0) break;
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: \n\n" + ex.Message);
            }
        }
    }
}