using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DSS
{
    public partial class EditUser : Form
    {
        private SQLiteConnection dbConnection;

        string userID = string.Empty;

        public EditUser(string[] userData)
        {
            InitializeComponent();

            if (userData != null || userData.Length != 0)
            {
                //Заполняем поля при изменении данных пользователя
                userID = userData[0];
                textBoxUserFullname.Text = userData[1];
                textBoxUserPost.Text = userData[2];
                textBoxUserLogin.Text = userData[3];
                textBoxUserPassword.Text = userData[4];
                comboBoxUserRole.SelectedItem = userData[5];
            }
            if (userID != null) buttonSave.Visible = false;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            dbConnection = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\database.db; Version=3");
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
            if (textBoxUserLogin.Text != string.Empty && comboBoxUserRole.SelectedItem.ToString() != string.Empty)
            {
                try
                {
                    //Установка стандартного пароля, если строка с паролем не заполнена
                    HashString hashString = new HashString();
                    if (textBoxUserPassword.Text == string.Empty)
                    {
                        textBoxUserPassword.Text = hashString.GetHashString("password1");
                    }
                    else textBoxUserPassword.Text = hashString.GetHashString(textBoxUserPassword.Text);

                    SQLiteCommand setUser = dbConnection.CreateCommand();
                    if (userID != null)
                    {
                        setUser.CommandText = "Update Users set Fullname = @Fullname, Post = @Post, Password = @Password, Role = @Role where Login = @Login";
                        setUser.Parameters.Add("@Fullname", DbType.String).Value = textBoxUserFullname.Text;
                        setUser.Parameters.Add("@Post", DbType.String).Value = textBoxUserPost.Text;
                        setUser.Parameters.Add("@Login", DbType.String).Value = textBoxUserLogin.Text;
                        setUser.Parameters.Add("@Password", DbType.String).Value = textBoxUserPassword.Text;
                        setUser.Parameters.Add("@Role", DbType.String).Value = comboBoxUserRole.SelectedItem;
                    }
                    else
                    {
                        setUser.CommandText = "Insert into Users(Fullname, Post, Login, Password, Role) values (@Fullname, @Post, @Login, @Password, @Role)";
                        setUser.Parameters.Add("@Fullname", DbType.String).Value = textBoxUserFullname.Text;
                        setUser.Parameters.Add("@Post", DbType.String).Value = textBoxUserPost.Text;
                        setUser.Parameters.Add("@Login", DbType.String).Value = textBoxUserLogin.Text;
                        setUser.Parameters.Add("@Password", DbType.String).Value = textBoxUserPassword.Text;
                        setUser.Parameters.Add("@Role", DbType.String).Value = comboBoxUserRole.SelectedItem;
                    }
                    setUser.ExecuteNonQuery();

                    textBoxUserFullname.ResetText();
                    textBoxUserPost.ResetText();
                    textBoxUserLogin.ResetText();
                    textBoxUserPassword.ResetText();
                    comboBoxUserRole.ResetText();

                    Users main = this.Owner as Users;
                    if (main != null)
                    {
                        //Обновление таблицы с информацией о пользователях
                        main.dataGridViewUsers.Rows.Clear();
                        main.ListOfUsers();
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Ошибка: \n\n" + ex.Message);
                }
            }
        }
    }
}