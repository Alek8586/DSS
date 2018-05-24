using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DSS
{
    public partial class EditSupplier : Form
    {
        private SQLiteConnection dbConnection;

        public EditSupplier(string[] supplierData)
        {
            InitializeComponent();

            //Заполняем поля при изменении данных проекта
            textBoxSupplierName.Text = supplierData[1];
            textBoxProjectMainContract.Text = supplierData[2];
            textBoxSupplierQMS.Text = supplierData[3];
            textBoxSupplierMaterialQuality.Text = supplierData[4];
            textBoxSupplierPrice.Text = supplierData[5];
            textBoxSupplierTimeOfDelivery.Text = supplierData[6];
            textBoxSupplierLocationRemoteness.Text = supplierData[7];
            textBoxSupplierFlexibility.Text = supplierData[8];
            textBoxSupplierFlexibility.Text = supplierData[9];
        }

        private void AddProject_Load(object sender, EventArgs e)
        {
            dbConnection = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "database.db; Version=3");
            dbConnection.Open();            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            setSupplier();
        }

        private void buttonSaveAndClose_Click(object sender, EventArgs e)
        {
            setSupplier();
            this.Close();
        }

        private void buttonBackToProjectsForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setSupplier()
        {
            
            if (textBoxSupplierName.Text != ""/* && comboBoxProjectRole.SelectedItem.ToString() != ""*/)
            {
                try
                {
                    SQLiteCommand setProject = dbConnection.CreateCommand();
                    if (textBoxSupplierMaterialQuality.Text != "" && textBoxSupplierPrice.Text != "")
                    {
                        setProject.CommandText = "Update Projects set MainContract = @MainContract, ProjectManager = @ProjectManager, ChiefDesigner = @ChiefDesigner, SupplierName = @SupplierName, DeliveryTime = @DeliveryTime where ProjectName = @ProjectName";
                        setProject.Parameters.Add("@ProjectName", DbType.String).Value = textBoxSupplierName.Text;
                        setProject.Parameters.Add("@MainContract", DbType.String).Value = textBoxProjectMainContract.Text;
                        setProject.Parameters.Add("@ProjectManager", DbType.String).Value = textBoxSupplierQMS.Text;
                        setProject.Parameters.Add("@ChiefDesigner", DbType.String).Value = textBoxSupplierMaterialQuality.Text;
                        setProject.Parameters.Add("@SupplierName", DbType.String).Value = textBoxSupplierPrice.Text;
                        setProject.Parameters.Add("@DeliveryTime", DbType.String).Value = textBoxSupplierTimeOfDelivery.Text;
                    }
                    else
                    {
                        setProject.CommandText = "Insert into Projects(ProjectName, MainContract, ProjectManager, ChiefDesigner, SupplierName, DeliveryTime) values (@ProjectName, @MainContract, @ProjectManager, @ChiefDesigner, @SupplierName, @DeliveryTime)";
                        setProject.Parameters.Add("@ProjectName", DbType.String).Value = textBoxSupplierName.Text;
                        setProject.Parameters.Add("@MainContract", DbType.String).Value = textBoxProjectMainContract.Text;
                        setProject.Parameters.Add("@ProjectManager", DbType.String).Value = textBoxSupplierQMS.Text;
                        setProject.Parameters.Add("@ChiefDesigner", DbType.String).Value = textBoxSupplierMaterialQuality.Text;
                        setProject.Parameters.Add("@SupplierName", DbType.String).Value = textBoxSupplierPrice.Text;
                        setProject.Parameters.Add("@DeliveryTime", DbType.String).Value = textBoxSupplierTimeOfDelivery.Text;
                    }
                    setProject.ExecuteNonQuery();

                    Projects main = this.Owner as Projects;
                    if (main != null)
                    {
                        //Обновление таблицы с информацией о проектах
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

                    textBoxSupplierName.Clear();
                    textBoxProjectMainContract.Clear();
                    textBoxSupplierQMS.Clear();
                    textBoxSupplierMaterialQuality.Clear();
                    textBoxSupplierPrice.Clear();
                    textBoxSupplierTimeOfDelivery.Clear();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }
    }
}
