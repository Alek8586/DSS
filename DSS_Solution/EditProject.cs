using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DSS
{
    public partial class EditProject : Form
    {
        private SQLiteConnection dbConnection;

        public EditProject(string[] data)
        {
            InitializeComponent();

            //Заполняем поля при изменении данных проекта
            textBoxProjectName.Text = data[1];
            textBoxProjectMainContract.Text = data[2];
            textBoxProjectManager.Text = data[3];
            textBoxProjectChiefDesigner.Text = data[4];
            textBoxProjectSupplierName.Text = data[5];
            textBoxProjectDeliveryTime.Text = data[6];
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
            
            if (textBoxProjectName.Text != ""/* && comboBoxProjectRole.SelectedItem.ToString() != ""*/)
            {
                try
                {
                    SQLiteCommand setProject = dbConnection.CreateCommand();
                    if (textBoxProjectChiefDesigner.Text != "" && textBoxProjectSupplierName.Text != "")
                    {
                        setProject.CommandText = "Update Projects set MainContract = @MainContract, ProjectManager = @ProjectManager, ChiefDesigner = @ChiefDesigner, SupplierName = @SupplierName, DeliveryTime = @DeliveryTime where ProjectName = @ProjectName";
                        setProject.Parameters.Add("@ProjectName", DbType.String).Value = textBoxProjectName.Text;
                        setProject.Parameters.Add("@MainContract", DbType.String).Value = textBoxProjectMainContract.Text;
                        setProject.Parameters.Add("@ProjectManager", DbType.String).Value = textBoxProjectManager.Text;
                        setProject.Parameters.Add("@ChiefDesigner", DbType.String).Value = textBoxProjectChiefDesigner.Text;
                        setProject.Parameters.Add("@SupplierName", DbType.String).Value = textBoxProjectSupplierName.Text;
                        setProject.Parameters.Add("@DeliveryTime", DbType.String).Value = textBoxProjectDeliveryTime.Text;
                    }
                    else
                    {
                        setProject.CommandText = "Insert into Projects(ProjectName, MainContract, ProjectManager, ChiefDesigner, SupplierName, DeliveryTime) values (@ProjectName, @MainContract, @ProjectManager, @ChiefDesigner, @SupplierName, @DeliveryTime)";
                        setProject.Parameters.Add("@ProjectName", DbType.String).Value = textBoxProjectName.Text;
                        setProject.Parameters.Add("@MainContract", DbType.String).Value = textBoxProjectMainContract.Text;
                        setProject.Parameters.Add("@ProjectManager", DbType.String).Value = textBoxProjectManager.Text;
                        setProject.Parameters.Add("@ChiefDesigner", DbType.String).Value = textBoxProjectChiefDesigner.Text;
                        setProject.Parameters.Add("@SupplierName", DbType.String).Value = textBoxProjectSupplierName.Text;
                        setProject.Parameters.Add("@DeliveryTime", DbType.String).Value = textBoxProjectDeliveryTime.Text;
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

                    textBoxProjectName.Clear();
                    textBoxProjectMainContract.Clear();
                    textBoxProjectManager.Clear();
                    textBoxProjectChiefDesigner.Clear();
                    textBoxProjectSupplierName.Clear();
                    textBoxProjectDeliveryTime.Clear();
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
            SelectSupplier selectSupplierForm = new SelectSupplier();
            selectSupplierForm.Owner = this;
            selectSupplierForm.ShowDialog();
        }
    }
}
