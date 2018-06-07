using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

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
            dbConnection = new SQLiteConnection("Data Source = " + Application.StartupPath + "\\database.db; Version=3");
            dbConnection.Open();

            if (File.Exists(Application.StartupPath + "\\database.db") == true && dbConnection.State == ConnectionState.Open)
            {
                toolStripConnectionStatusLabel.Text = "Подключено к БД";
                toolStripConnectionStatusLabel.ForeColor = Color.Green;

                //Временно для тестирования. По окончанию - удалить.
                textBoxLogInUsername.Text = "Admin";
                textBoxLogInPassword.Text = "12345";
                //Временно для тестирования. По окончанию - удалить.
            }
            else
            {
                toolStripConnectionStatusLabel.Text = "Нет подключения к БД";
                toolStripConnectionStatusLabel.ForeColor = Color.Red;
            }
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            HashString hashString = new HashString();
            hashString.s = hashString.GetHashString(textBoxLogInPassword.Text);

            if (textBoxLogInUsername.Text != "")
            {
                try
                {
                    SQLiteCommand command = dbConnection.CreateCommand();
                    command.CommandText = "select * from Users";

                    using (var sqlReader = command.ExecuteReader())
                    {
                        if (sqlReader.HasRows)
                        {
                            while (sqlReader.Read())
                            {
                                if (textBoxLogInUsername.Text.Equals(sqlReader["Login"]) && hashString.s.Equals(sqlReader["Password"]))
                                {
                                    switch (sqlReader["Role"])
                                    {
                                        case "Администратор":
                                            {
                                                AdminMode AdminMode = new AdminMode();
                                                AdminMode.Show();
                                                this.Hide();
                                                break;
                                            }
                                        case "Оператор":
                                            {
                                                //if (textBoxLogInPassword.Text.Equals("password1"))
                                                //{
                                                //    var passwordMessage = MessageBox.Show("В целях безопасности рекомендуется сменить стандартный пароль.", "Предупреждение!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                                                //    if (passwordMessage == DialogResult.OK)
                                                //    {
                                                //        //dbConnection.Close();

                                                //        SettingUserPassword settingUserPassword = new SettingUserPassword();
                                                //        settingUserPassword.Owner = this;
                                                //        settingUserPassword.ShowDialog();
                                                //    }
                                                //    else
                                                //    {
                                                //        //OperatorMode OperatorMode = new OperatorMode();
                                                //        //OperatorMode.Show();
                                                //    }

                                                //}
                                                //if (textBoxLogInPassword.Text.Equals(string.Empty))
                                                //{
                                                //    var passwordMessage = MessageBox.Show("В целях безопасности рекомендуется установить пароль.", "Предупреждение!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                                //}


                                                OperatorMode OperatorMode = new OperatorMode();
                                                OperatorMode.Show();

                                                this.Hide();
                                                break;
                                            }
                                    }
                                    textBoxLogInUsername.Clear();
                                    textBoxLogInPassword.Clear();
                                }
                                else
                                {
                                    labelUsernamePassword.Text = "Неверное имя пользователя и/или пароль";
                                }
                            }
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Ошибка: \n\n" + ex.Message);
                }
            }
            else labelUsernamePassword.Text = "Введите логин";
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
                HashString hashString = new HashString();
                hashString.s = hashString.GetHashString("");

                SQLiteCommand sqlCommand = dbConnection.CreateCommand();
                sqlCommand.CommandText = "Update Users set Password = @Password";
                sqlCommand.Parameters.Add("@Password", DbType.String).Value = hashString.s;

                sqlCommand.ExecuteNonQuery();

                textBoxLogInUsername.Clear();
                textBoxLogInPassword.Clear();
                MessageBox.Show("Программа сброшена!");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: \n\n" + ex.Message);
            }
        }

        private void buttonSetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxLogInUsername.Text != "" && textBoxLogInPassword.Text != "")
                {
                    SQLiteCommand cmd = dbConnection.CreateCommand();
                    cmd.CommandText = "Update Users set Password='" + textBoxLogInPassword.Text + "' where Login = '" + textBoxLogInUsername.Text + "'";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Пароль '" + textBoxLogInPassword.Text + "' для пользователя '" + textBoxLogInUsername.Text + "' задан");
                }
                else MessageBox.Show("Введите пароль!");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: \n\n" + ex.Message);
            }
        }

        private void FormLogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            dbConnection.Close();
            Application.Exit();
        }
    }
}