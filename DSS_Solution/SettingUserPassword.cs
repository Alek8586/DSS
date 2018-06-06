using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace DSS
{
    public partial class SettingUserPassword : Form
    {
        private SQLiteConnection dbConnection;

        public SettingUserPassword()
        {
            InitializeComponent();
        }

        private void buttonSetNewPassword_Click(object sender, EventArgs e)
        {
            SetNewPassword();

        }

        private void buttonCancelSetNewPassword_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetNewPassword()
        {
            FormLogIn formLogIn = this.Owner as FormLogIn;
            string login = formLogIn.textBoxLogInPassword.Text;
            string password = formLogIn.textBoxLogInPassword.Text;

            if (textBoxCurrentPassword.Text.Equals(password))
            {
                if (textBoxNewPassword.Text.Equals(textBoxConfirmNewPassword.Text))
                {
                    HashString hashString = new HashString();
                    hashString.s = hashString.GetHashString(textBoxNewPassword.Text);

                    dbConnection = new SQLiteConnection("Data Source = " + Application.StartupPath + "\\database.db; Version=3");
                    dbConnection.Open();
                    SQLiteCommand sqlCommand = dbConnection.CreateCommand();
                    sqlCommand.CommandText = "Update Users set Password = '" + hashString.s + "' where Login = '" + login + "'";
                    sqlCommand.ExecuteNonQuery();
                    dbConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Неправльно введен текущий пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //textBoxCurrentPassword.BorderStyle;
            }
        }
    }
}
