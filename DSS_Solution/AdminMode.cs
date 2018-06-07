﻿using System;
using System.Windows.Forms;
using System.IO;

namespace DSS
{
    public partial class AdminMode : Form
    {
        public AdminMode()
        {
            InitializeComponent();
        }

        private void buttonToUsersForm_Click(object sender, EventArgs e)
        {
            Users UsersForm = new Users();
            UsersForm.Show();
        }

        private void buttonToSuplliersForm_Click(object sender, EventArgs e)
        {
            Suppliers SuppliersForm = new Suppliers();
            SuppliersForm.Show();
        }

        private void buttonProjects_Click(object sender, EventArgs e)
        {
            Projects ProjectsForm = new Projects();
            ProjectsForm.Show();
        }

        private void buttonUserPost_Click(object sender, EventArgs e)
        {
            EditUserPost editUserPost = new EditUserPost();
            editUserPost.ShowDialog();
        }

        private void buttonBackupDB_Click(object sender, EventArgs e)
        {
            /*
             * Резервирование методом копирования исходного файла
             * Сделать дефолтной путь к сохранению бэкапа базы
             * Добавить маску для имени файла бэкапа
            */
            SaveFileDialog saveDB = new SaveFileDialog();
            string backupFileName = "database_" + DateTime.Now.ToString("yyyy.MM.dd").Replace(".", "") + ".dbbackup";
            string sourceDBFile = Application.StartupPath + "\\database.db";
            string backupDBFile = Path.Combine(Application.StartupPath + "\\backup", backupFileName);

            saveDB.InitialDirectory = Application.StartupPath + "\\backup";
            saveDB.FileName = backupFileName;
            saveDB.Filter = "Database backup file(*.dbbackup)|*.dbbackup";

            if (saveDB.ShowDialog(this) == DialogResult.OK)
            {
                File.Copy(sourceDBFile, backupDBFile, true);
            }
        }

        private void buttonRestoreDB_Click(object sender, EventArgs e)
        {
            /*
             * Восстановление базы данных
            */
            OpenFileDialog restoreDB = new OpenFileDialog();

            string backupPathDBFile = Application.StartupPath + "\\backup";

            restoreDB.InitialDirectory = backupPathDBFile;
            restoreDB.Filter = "Database backup file(*.dbbackup)|*.dbbackup";

            if (restoreDB.ShowDialog(this) == DialogResult.OK)
            {
                string backupFileName = Path.GetFileName(Application.StartupPath + "\\backup\\" + restoreDB.FileName);
                string backupDBFile = Application.StartupPath + "\\backup\\" + backupFileName;
                string restoreDBFile = Application.StartupPath + "\\database.db";

                File.Copy(backupDBFile, restoreDBFile, true);
            }
        }

        private void buttonToLogInForm_Click(object sender, EventArgs e)
        {
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void FormAdminMode_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
