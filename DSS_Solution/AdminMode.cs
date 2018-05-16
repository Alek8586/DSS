using System;
using System.IO;
using System.Windows.Forms;

namespace DSS
{
    public partial class FormAdminMode : Form
    {
        public FormAdminMode()
        {
            InitializeComponent();
        }

        private void buttonBackupDB_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDB = new SaveFileDialog();
            /*
             * Резервирование методом копирования сходного файла
             * Сделать дефолтной путь к сохранению бэкапа базы
             * Добавить маску для имени файла бэкапа
            */
            string fileName = "database.db";
            string sourcePathDBFile = AppDomain.CurrentDomain.BaseDirectory;
            string backupPathDBFile = AppDomain.CurrentDomain.BaseDirectory + "backup";
            string date = DateTime.Now.ToString("yyyy.MM.dd");
            string backupFileName = "database_" + date.Replace(".", "");
            string soursePath = Path.Combine(sourcePathDBFile, fileName);
            string backupPath = Path.Combine(backupPathDBFile, backupFileName);

            saveDB.InitialDirectory = backupPathDBFile;
            saveDB.FileName = backupFileName;
            saveDB.Filter = "Database backup file(*.dbbackup)|*.dbbackup";

            saveDB.ShowDialog();
            File.Copy(soursePath, backupPath, true);
        }

        private void buttonRestoreDB_Click(object sender, EventArgs e)
        {
            OpenFileDialog restoreDB = new OpenFileDialog();
            /*
             * Выбирать соответсвующий файл для вооставления основной базы
            */
            string fileName = "database.db1";
            string sourcePathDBFile = AppDomain.CurrentDomain.BaseDirectory;
            string backupPathDBFile = AppDomain.CurrentDomain.BaseDirectory + "backup";
            string date = DateTime.Now.ToString("yyyy.MM.dd");
            string backupFileName = "database_" + date.Replace(".", "");
            string soursePath = Path.Combine(sourcePathDBFile, fileName);
            string backupPath = Path.Combine(backupPathDBFile, backupFileName);

            restoreDB.InitialDirectory = backupPathDBFile;
            //restoreDB.FileName = backupFileName;
            restoreDB.Filter = "Database backup file(*.dbbackup)|*.dbbackup";

            restoreDB.ShowDialog();
            File.Copy(backupPath, soursePath, true);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
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

        private void buttonToLogInForm_Click(object sender, EventArgs e)
        {
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.Show();
            this.Hide();
        }

        private void FormAdminMode_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
