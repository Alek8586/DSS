using System;
using System.Data;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace DSS
{
    public partial class EditUser : Form
    {
        private SQLiteConnection dbConnection;

        public EditUser(string[] data)
        {
            InitializeComponent();

            //Заполняем поля при изменении данных пользователя
            textBoxUserFullname.Text = data[1];
            textBoxUserPost.Text = data[2];
            textBoxUserLogin.Text = data[3];
            textBoxUserPassword.Text = data[4];
            comboBoxUserRole.SelectedItem = data[5];
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            dbConnection = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "database.db; Version=3");
            dbConnection.Open();            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            setUser();
        }

        private void buttonSaveAndClose_Click(object sender, EventArgs e)
        {
            setUser();
            this.Close();
        }

        private void buttonBackToUsersForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setUser()
        {
            
            if (textBoxUserLogin.Text != "" && comboBoxUserRole.SelectedItem.ToString() != "")
            {
                try
                {
                    //Задаем стандартный пароль 
                    if (textBoxUserPassword.Text == "")
                    {
                        string defaultPassword = "Password1";
                        textBoxUserPassword.Text = GetHashStirng(defaultPassword);
                    }
                    else textBoxUserPassword.Text = GetHashStirng(textBoxUserPassword.Text);                    
                    
                    SQLiteCommand setUser = dbConnection.CreateCommand();
                    if (textBoxUserPost.Text != "" && textBoxUserFullname.Text != "")
                    {
                        setUser.CommandText = "Update Users set Fullname = @Fullname, Post = @Post, Password = @Password, Role = @Role, Etc = @Etc where Login = @Login";
                        setUser.Parameters.Add("@Fullname", DbType.String).Value = textBoxUserFullname.Text;
                        setUser.Parameters.Add("@Post", DbType.String).Value = textBoxUserPost.Text;
                        setUser.Parameters.Add("@Login", DbType.String).Value = textBoxUserLogin.Text;
                        setUser.Parameters.Add("@Password", DbType.String).Value = textBoxUserPassword.Text;
                        setUser.Parameters.Add("@Role", DbType.String).Value = comboBoxUserRole.SelectedItem;
                    }
                    else
                    {
                        setUser.CommandText = "Insert into Users(Fullname, Post, Login, Password, Role, Etc) values (@Fullname, @Post, @Login, @Password, @Role, @Etc)";
                        setUser.Parameters.Add("@Fullname", DbType.String).Value = textBoxUserFullname.Text;
                        setUser.Parameters.Add("@Post", DbType.String).Value = textBoxUserPost.Text;
                        setUser.Parameters.Add("@Login", DbType.String).Value = textBoxUserLogin.Text;
                        setUser.Parameters.Add("@Password", DbType.String).Value = textBoxUserPassword.Text;
                        setUser.Parameters.Add("@Role", DbType.String).Value = comboBoxUserRole.SelectedItem;
                    }
                    setUser.ExecuteNonQuery();

                    Users main = this.Owner as Users;
                    if (main != null)
                    {
                        //Обновление таблицы с информацией о пользователях
                        try
                        {
                            main.dataGridViewUsers.Rows.Clear();
                            main.ListOfUsers();
                        }
                        catch (SQLiteException ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }

                    textBoxUserFullname.Clear();
                    textBoxUserPost.Clear();
                    textBoxUserLogin.Clear();
                    textBoxUserPassword.Clear();
                    comboBoxUserRole.ResetText();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        private string GetHashStirng(string defaultPassword)
        {
            //Хеширование вводимого пароля через MD5
            //Переводим строку пароля в байт-массив
            byte[] bytes = Encoding.Unicode.GetBytes(textBoxUserPassword.Text);
            //создаем обеъкт для получения средств шифрования
            MD5CryptoServiceProvider cryptoServiceProvider = new MD5CryptoServiceProvider();
            //высчитываем хеш-представление в байтах
            byte[] byteHash = cryptoServiceProvider.ComputeHash(bytes);
            string MD5Hash = string.Empty;
            //формируем одну цельную строку из массива
            foreach (byte b in byteHash)
            {
                MD5Hash += string.Format("{0:x2}", b);
            }
            return MD5Hash;
        }
    }
}