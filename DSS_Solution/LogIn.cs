using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Text;
using System.Security.Cryptography;
using System.Drawing;

namespace DSS
{
    public partial class FormLogIn : Form
    {
        private SQLiteConnection dbConnection;

        public FormLogIn()
        {
            InitializeComponent();
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {
            dbConnection = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "database.db; Version=3");
            dbConnection.Open();

            if (dbConnection.State == ConnectionState.Open)
            {
                toolStripConnectionStatusLabel.Text = "Подключено к БД";
                toolStripConnectionStatusLabel.ForeColor = Color.Green;
            }
            else
            {
                toolStripConnectionStatusLabel.Text = "Нет подключения к БД";
                toolStripConnectionStatusLabel.ForeColor = Color.Red;
            }
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxLogInUsername.Text != "")
                {
                    SQLiteCommand command = dbConnection.CreateCommand();
                    command.CommandText = "select * from Users";

                    SQLiteDataReader dataReader = command.ExecuteReader();

                    ////Хеширование вводимого пароля через MD5
                    ////Переводим строку пароля в байт-массив
                    //byte[] bytes = Encoding.Unicode.GetBytes(textBoxLogInPassword.Text.ToString());
                    ////создаем обеъкт для получения средств шифрования
                    //MD5CryptoServiceProvider cryptoServiceProvider = new MD5CryptoServiceProvider();
                    ////высчитываем хеш-представление в байтах
                    //byte[] byteHash = cryptoServiceProvider.ComputeHash(bytes);
                    //string MD5Hash = string.Empty;
                    ////формируем одну цельную строку из массива
                    //foreach (byte b in byteHash)
                    //{
                    //    MD5Hash += string.Format("{0:x2", b);
                    //}

                    //GetHashStirng();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            if (textBoxLogInUsername.Text.Equals(dataReader["Login"]) && textBoxLogInPassword.Text.Equals(dataReader["Password"]))
                            {

                                textBoxLogInUsername.Clear();
                                textBoxLogInPassword.Clear();

                                switch ("" + dataReader["Role"])
                                {
                                    case "1":
                                        {
                                            FormAdminMode AdminMode = new FormAdminMode();
                                            AdminMode.Show();
                                            this.Hide();

                                            break;
                                        }
                                    case "2":
                                        {
                                            FormOperatorMode OperatorMode = new FormOperatorMode();
                                            OperatorMode.Show();
                                            this.Hide();

                                            break;
                                        }
                                }
                            }
                            else
                            {
                                labelUsernamePassword.Text = "Неверное имя пользователя и/или пароль";

                                break;                                                                
                            }
                        }
                        dataReader.Close();
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Нет подключения к БД!" + ex.Message);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            dbConnection.Close();
            Application.Exit();            
        }

        private void buttonHardReset_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteCommand command = dbConnection.CreateCommand();
                command.CommandText = "update Users set Password=''";
                command.ExecuteNonQuery();

                textBoxLogInUsername.Clear();
                textBoxLogInPassword.Clear();
                MessageBox.Show("Программа сброшена!");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Нет подклбюччения к БД!" + ex.Message);
            }
        }

        private void buttonSetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxLogInUsername.Text != "" && textBoxLogInPassword.Text != "")
                {
                    SQLiteCommand cmd = dbConnection.CreateCommand();
                    cmd.CommandText = "update Users set Password='" + textBoxLogInPassword.Text + "' where Login = '" + textBoxLogInUsername.Text + "'";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Пароль '" + textBoxLogInPassword.Text + "' для пользователя '" + textBoxLogInUsername.Text + "' задан");
                }
                else MessageBox.Show("Введи имя и пароль, имбицил!");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Нет подклбючения к БД!" + ex.Message);
            }
        }

        private void FormLogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            dbConnection.Close();
            Application.Exit();
        }

        //public string GetHashStirng()
        //{
        //    //Хеширование вводимого пароля через MD5
        //    //Переводим строку пароля в байт-массив
        //    byte[] bytes = Encoding.Unicode.GetBytes(textBoxLogInPassword.Text.ToString());
        //    //создаем обеъкт для получения средств шифрования
        //    MD5CryptoServiceProvider cryptoServiceProvider = new MD5CryptoServiceProvider();
        //    //высчитываем хеш-представление в байтах
        //    byte[] byteHash = cryptoServiceProvider.ComputeHash(bytes);
        //    string MD5Hash = string.Empty;
        //    //формируем одну цельную строку из массива
        //    foreach (byte b in byteHash)
        //    {
        //        MD5Hash += string.Format("{0:x2", b);
        //    }
        //    return MD5Hash;
        //}
    }
}