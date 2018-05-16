using System;
using System.Data;
using System.Data.SQLite;
//using System.Security.Cryptography;
//using System.Text;
using System.Windows.Forms;

namespace DSS
{
    public partial class EditProject : Form
    {
        private SQLiteConnection dbConnection;

        public EditProject(string[] data)
        {
            InitializeComponent();

            //Заполняем поля при изменении данных пользователя
            //textBoxProjectFullname.Text = data[1];
            //textBoxProjectPost.Text = data[2];
            //textBoxProjectLogin.Text = data[3];
            //textBoxProjectPassword.Text = data[4];
            //comboBoxProjectRole.SelectedItem = data[5];
            //textBoxProjectEtc.Text = data[6];
        }

        private void AddProject_Load(object sender, EventArgs e)
        {
            dbConnection = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "database.db; Version=3");
            dbConnection.Open();            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            setProject();
        }

        private void buttonSaveAndClose_Click(object sender, EventArgs e)
        {
            setProject();
            this.Close();
        }

        private void buttonBackToProjectsForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSelectSupplier_Click(object sender, EventArgs e)
        {
            SelectSupplier();
        }


        private void setProject()
        {
            
            if (textBoxProjectLogin.Text != "" && comboBoxProjectRole.SelectedItem.ToString() != "")
            {
                try
                {
                    SQLiteCommand setProject = dbConnection.CreateCommand();
                    if (textBoxProjectPost.Text != "" && textBoxProjectFullname.Text != "")
                    {
                        setProject.CommandText = "Update Projects set Fullname = @Fullname, Post = @Post, Password = @Password, Role = @Role, Etc = @Etc where Login = @Login";
                        setProject.Parameters.Add("@Fullname", DbType.String).Value = textBoxProjectFullname.Text;
                        setProject.Parameters.Add("@Post", DbType.String).Value = textBoxProjectPost.Text;
                        setProject.Parameters.Add("@Login", DbType.String).Value = textBoxProjectLogin.Text;
                        setProject.Parameters.Add("@Password", DbType.String).Value = textBoxProjectPassword.Text;
                        setProject.Parameters.Add("@Role", DbType.UInt16).Value = comboBoxProjectRole.SelectedItem;
                        setProject.Parameters.Add("@Etc", DbType.String).Value = textBoxProjectEtc.Text;
                    }
                    else
                    {
                        setProject.CommandText = "Insert into Projects(Fullname, Post, Login, Password, Role, Etc) values (@Fullname, @Post, @Login, @Password, @Role, @Etc)";
                        setProject.Parameters.Add("@Fullname", DbType.String).Value = textBoxProjectFullname.Text;
                        setProject.Parameters.Add("@Post", DbType.String).Value = textBoxProjectPost.Text;
                        setProject.Parameters.Add("@Login", DbType.String).Value = textBoxProjectLogin.Text;
                        setProject.Parameters.Add("@Password", DbType.String).Value = textBoxProjectPassword.Text;
                        setProject.Parameters.Add("@Role", DbType.UInt16).Value = comboBoxProjectRole.SelectedItem;
                        setProject.Parameters.Add("@Etc", DbType.String).Value = textBoxProjectEtc.Text;
                    }
                    setProject.ExecuteNonQuery();

                    Projects main = this.Owner as Projects;
                    if (main != null)
                    {
                        //Обновление таблицы с информацией о пользователях
                        try
                        {
                            main.dataGridViewProjects.Rows.Clear();
                            main.ListOfProjects();
                        }
                        catch (SQLiteException ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }

                    textBoxProjectFullname.Clear();
                    textBoxProjectPost.Clear();
                    textBoxProjectLogin.Clear();
                    textBoxProjectPassword.Clear();
                    comboBoxProjectRole.ResetText();
                    textBoxProjectEtc.Clear();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        //Подбор поставщика
        private void SelectSupplier()
        {

        }
    }
}
