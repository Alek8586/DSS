using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DSS
{
    public partial class EditProject : Form
    {
        private SQLiteConnection dbConnection;

        string projectID = string.Empty;

        public EditProject(string[] projectData)
        {
            InitializeComponent();

            if (projectData != null || projectData.Length != 0)
            {
                //Заполняем поля при изменении данных проекта
                projectID = projectData[0];
                textBoxProjectName.Text = projectData[1];
                textBoxProjectMainContract.Text = projectData[2];
                textBoxProjectShippingDate.Text = projectData[3];
                textBoxProjectManager.Text = projectData[4];
                textBoxProjectChiefDesigner.Text = projectData[5];
                textBoxProjectSupplier.Text = projectData[6];
                comboBoxProjectOfficer.Text = projectData[7];
                comboBoxProjectStatus.Text = projectData[8];
            }
            if (projectID != null) buttonSave.Visible = false;
        }

        private void EditProject_Load(object sender, EventArgs e)
        {
            dbConnection = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\database.db; Version=3");
            dbConnection.Open();

            FillComboBoxProjectOfficer();
            FillComboBoxProjectStatus();
        }

        private void textBoxProjectSupplier_DoubleClick(object sender, EventArgs e)
        {
            SelectSupplier();
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

        private void FillComboBoxProjectOfficer()
        {
            SQLiteCommand sqlCommand = dbConnection.CreateCommand();
            sqlCommand.CommandText = "Select * from Users where Role = 'Оператор' order by [Fullname]";
            SQLiteDataReader sqlReader = sqlCommand.ExecuteReader();

            using (sqlReader)
            {
                if (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        comboBoxProjectOfficer.Items.Add(sqlReader["Fullname"]);
                    }
                }
            }
        }

        private void FillComboBoxProjectStatus()
        {
            SQLiteCommand sqlCommand = dbConnection.CreateCommand();
            sqlCommand.CommandText = "Select * from ProjectStatus order by [Name]";
            SQLiteDataReader sqlReader = sqlCommand.ExecuteReader();

            using (sqlReader)
            {
                if (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        comboBoxProjectStatus.Items.Add(sqlReader["Name"]);
                    }
                }
            }
        }

        private void setProject()
        {            
            if (textBoxProjectName.Text != "")
            {
                try
                {
                    SQLiteCommand setProject = dbConnection.CreateCommand();
                    if (projectID != null)
                    {
                        setProject.CommandText = "Update Projects set MainContract = @MainContract, ShippingDate = @ShippingDate, ProjectManager = @ProjectManager, ChiefDesigner = @ChiefDesigner, Supplier = @Supplier, ProjectOfficer = @ProjectOfficer, Status = @Status where Name = @ProjectName";
                        setProject.Parameters.Add("@ProjectName", DbType.String).Value = textBoxProjectName.Text;
                        setProject.Parameters.Add("@MainContract", DbType.String).Value = textBoxProjectMainContract.Text;
                        setProject.Parameters.Add("@ShippingDate", DbType.String).Value = textBoxProjectShippingDate.Text;
                        setProject.Parameters.Add("@ProjectManager", DbType.String).Value = textBoxProjectManager.Text;
                        setProject.Parameters.Add("@ChiefDesigner", DbType.String).Value = textBoxProjectChiefDesigner.Text;
                        setProject.Parameters.Add("@Supplier", DbType.String).Value = textBoxProjectSupplier.Text;
                        setProject.Parameters.Add("@ProjectOfficer", DbType.String).Value = comboBoxProjectOfficer.Text;
                        setProject.Parameters.Add("@Status", DbType.String).Value = comboBoxProjectStatus.Text;
                    }
                    else
                    {
                        setProject.CommandText = "Insert into Projects(Name, MainContract, ShippingDate, ProjectManager, ChiefDesigner, Supplier, ProjectOfficer, Status) values (@ProjectName, @MainContract, @ShippingDate, @ProjectManager, @ChiefDesigner, @Supplier, @ProjectOfficer, @Status)";
                        setProject.Parameters.Add("@ProjectName", DbType.String).Value = textBoxProjectName.Text;
                        setProject.Parameters.Add("@MainContract", DbType.String).Value = textBoxProjectMainContract.Text;
                        setProject.Parameters.Add("@ShippingDate", DbType.String).Value = textBoxProjectShippingDate.Text;
                        setProject.Parameters.Add("@ProjectManager", DbType.String).Value = textBoxProjectManager.Text;
                        setProject.Parameters.Add("@ChiefDesigner", DbType.String).Value = textBoxProjectChiefDesigner.Text;
                        setProject.Parameters.Add("@Supplier", DbType.String).Value = textBoxProjectSupplier.Text;
                        setProject.Parameters.Add("@ProjectOfficer", DbType.String).Value = comboBoxProjectOfficer.Text;
                        setProject.Parameters.Add("@Status", DbType.String).Value = comboBoxProjectStatus.Text;
                    }
                    setProject.ExecuteNonQuery();

                    textBoxProjectName.Clear();
                    textBoxProjectMainContract.Clear();
                    textBoxProjectShippingDate.Clear();
                    textBoxProjectManager.Clear();
                    textBoxProjectChiefDesigner.Clear();
                    textBoxProjectSupplier.Clear();

                    Projects main = this.Owner as Projects;
                    if (main != null)
                    {
                        //Обновление таблицы с информацией о проектах
                        main.dataGridViewProjects.Rows.Clear();
                        main.ListOfProjects();
                    }
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
            string sample = textBoxProjectSupplier.Text;

            SelectSupplier selectSupplierForm = new SelectSupplier();
            selectSupplierForm.Owner = this;
            selectSupplierForm.ShowDialog();
        }
    }
}
