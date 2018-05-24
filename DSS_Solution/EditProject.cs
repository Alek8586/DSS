﻿using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DSS
{
    public partial class EditProject : Form
    {
        private SQLiteConnection dbConnection;

        public EditProject(string[] projectData)
        {
            InitializeComponent();

            //Заполняем поля при изменении данных проекта
            textBoxProjectName.Text = projectData[1];
            textBoxProjectMainContract.Text = projectData[2];
            textBoxProjectShippingDate.Text = projectData[3];
            textBoxProjectManager.Text = projectData[4];
            textBoxProjectChiefDesigner.Text = projectData[5];
            textBoxProjectSupplier.Text = projectData[6];
            textBoxProjectOfficer.Text = projectData[7];
            textBoxProjectStatus.Text = projectData[8];
        }

        private void EditProject_Load(object sender, EventArgs e)
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
                    if (textBoxProjectManager.Text != "" && textBoxProjectChiefDesigner.Text != "")
                    {
                        setProject.CommandText = "Update Projects set MainContract = @MainContract, ProjectManager = @ProjectManager, ChiefDesigner = @ChiefDesigner, SupplierName = @SupplierName, DeliveryTime = @DeliveryTime where ProjectName = @ProjectName";
                        setProject.Parameters.Add("@ProjectName", DbType.String).Value = textBoxProjectName.Text;
                        setProject.Parameters.Add("@MainContract", DbType.String).Value = textBoxProjectMainContract.Text;
                        setProject.Parameters.Add("@ProjectManager", DbType.String).Value = textBoxProjectShippingDate.Text;
                        setProject.Parameters.Add("@ChiefDesigner", DbType.String).Value = textBoxProjectManager.Text;
                        setProject.Parameters.Add("@SupplierName", DbType.String).Value = textBoxProjectChiefDesigner.Text;
                        setProject.Parameters.Add("@DeliveryTime", DbType.String).Value = textBoxProjectSupplier.Text;
                    }
                    else
                    {
                        setProject.CommandText = "Insert into Projects(ProjectName, MainContract, ProjectManager, ChiefDesigner, SupplierName, DeliveryTime) values (@ProjectName, @MainContract, @ProjectManager, @ChiefDesigner, @SupplierName, @DeliveryTime)";
                        setProject.Parameters.Add("@ProjectName", DbType.String).Value = textBoxProjectName.Text;
                        setProject.Parameters.Add("@MainContract", DbType.String).Value = textBoxProjectMainContract.Text;
                        setProject.Parameters.Add("@ProjectManager", DbType.String).Value = textBoxProjectShippingDate.Text;
                        setProject.Parameters.Add("@ChiefDesigner", DbType.String).Value = textBoxProjectManager.Text;
                        setProject.Parameters.Add("@SupplierName", DbType.String).Value = textBoxProjectChiefDesigner.Text;
                        setProject.Parameters.Add("@DeliveryTime", DbType.String).Value = textBoxProjectSupplier.Text;
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

                    textBoxProjectName.Clear();
                    textBoxProjectMainContract.Clear();
                    textBoxProjectShippingDate.Clear();
                    textBoxProjectManager.Clear();
                    textBoxProjectChiefDesigner.Clear();
                    textBoxProjectSupplier.Clear();
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
