using System;
using System.Data.SQLite;
using System.Windows.Forms;


namespace DSS
{
    public partial class Projects : Form
    {
        private SQLiteConnection dbConnection;

        public Projects()
        {
            InitializeComponent();
        }

        private void Projects_Load(object sender, EventArgs e)
        {
            dbConnection = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "database.db; Version=3");
            dbConnection.Open();
        }

        private void buttonToFormLogIn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSelectSupplier_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSelectProject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //
            switch ("")
            {
                case "":
                    {


                        break;
                    }
            }
        }

        private void comboBoxSelectProject_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dbConnection.State == System.Data.ConnectionState.Open)
                {
                    //Выборка списка поставщиков
                    SQLiteCommand suppliersList = dbConnection.CreateCommand();
                    suppliersList.CommandText = "select * from Projects";
                    SQLiteDataReader dataReader = suppliersList.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            comboBoxSelectProject.Items.Add(dataReader["Name"].ToString());
                            comboBoxSelectProject.DisplayMember = dataReader["Name"].ToString();
                            comboBoxSelectProject.ValueMember = dataReader["ID"].ToString();

                            //switch ("" + dataReader["ID"])
                            //{
                            //    case "1":
                            //        {
                            //            textBoxMainContract.Text = dataReader["MainContract"].ToString();

                            //            break;
                            //        }
                            //}
                        }
                        dataReader.Close();

                        //switch ("" + dataReader["ID"])
                        //{
                        //    case "КБСМ":
                        //        {
                        //            MessageBox.Show("КБСМ");

                        //            break;
                        //        }
                        //    case "Зарядье":
                        //        {
                        //            MessageBox.Show("Зарядье");

                        //            break;
                        //        }
                        //}
                    }
                    else MessageBox.Show("Таблица проектов пуста!");
                }
                else MessageBox.Show("Нет соединения с базой данных. Проверьте подключение.");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
