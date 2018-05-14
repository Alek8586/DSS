using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;


namespace DSS
{
    public partial class Suppliers : Form
    {
        private SQLiteConnection dbConnection;

        public Suppliers()
        {
            InitializeComponent();

        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            try
            {
                dbConnection = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "database.db; Version=3");
                dbConnection.Open();

                SQLiteCommand listSuppliers = dbConnection.CreateCommand();
                listSuppliers.CommandText = "Select * from Suppliers";
                SQLiteDataReader sql = listSuppliers.ExecuteReader();

                dataGridViewSuppliers.Columns["ID"].ReadOnly = true;

                while (sql.Read())
                {
                    dataGridViewSuppliers.Rows.Add(sql[0].ToString(), sql[1].ToString(), sql[2].ToString(), sql[3].ToString(), sql[4].ToString(), sql[5].ToString(), sql[6].ToString());
                }
                sql.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonAddSupplier_Click(object sender, EventArgs e)
        {
            dataGridViewSuppliers.CurrentCell = dataGridViewSuppliers[0, dataGridViewSuppliers.Rows.Count - 1];
            dataGridViewSuppliers.BeginEdit(true);
        }

        private void buttonEditSupplier_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteSupplier_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteCommand setSupplier = dbConnection.CreateCommand();
                setSupplier.CommandText = "Insert into Users(Login, Role, Password, Fullname, Etc) values (@Login, @Role, @Password, @Fullname, @Etc)";
                if (dataGridViewSuppliers.CurrentRow.Cells[0].Value == null)
                {
                    setSupplier.Parameters.Add("@Login", DbType.String).Value = "";
                }
                else setSupplier.Parameters.Add("@Login", DbType.String).Value = dataGridViewSuppliers.CurrentRow.Cells[0].Value.ToString();

                if (dataGridViewSuppliers.CurrentRow.Cells[1].Value == null)
                {
                    setSupplier.Parameters.Add("@Role", DbType.String).Value = "";
                }
                else setSupplier.Parameters.Add("@Role", DbType.String).Value = dataGridViewSuppliers.CurrentRow.Cells[1].Value.ToString();

                if (dataGridViewSuppliers.CurrentRow.Cells[2].Value == null)
                {
                    setSupplier.Parameters.Add("@Password", DbType.String).Value = "";
                }
                else setSupplier.Parameters.Add("@Password", DbType.String).Value = dataGridViewSuppliers.CurrentRow.Cells[2].Value.ToString();

                if (dataGridViewSuppliers.CurrentRow.Cells[3].Value == null)
                {
                    setSupplier.Parameters.Add("@Fullname", DbType.String).Value = "";
                }
                else setSupplier.Parameters.Add("@Fullname", DbType.String).Value = dataGridViewSuppliers.CurrentRow.Cells[3].Value.ToString();

                if (dataGridViewSuppliers.CurrentRow.Cells[4].Value == null)
                {
                    setSupplier.Parameters.Add("@Etc", DbType.String).Value = "";
                }
                else setSupplier.Parameters.Add("@Etc", DbType.String).Value = dataGridViewSuppliers.CurrentRow.Cells[4].Value.ToString();

                setSupplier.ExecuteNonQuery();
                dataGridViewSuppliers.Update();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonSaveAndExit_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteCommand setSupplier = dbConnection.CreateCommand();
                setSupplier.CommandText = "Insert into Users(Login, Role, Password, Fullname, Etc) values (@Login, @Role, @Password, @Fullname, @Etc)";
                if (dataGridViewSuppliers.CurrentRow.Cells[0].Value == null)
                {
                    setSupplier.Parameters.Add("@Login", DbType.String).Value = "";
                }
                else setSupplier.Parameters.Add("@Login", DbType.String).Value = dataGridViewSuppliers.CurrentRow.Cells[0].Value.ToString();

                if (dataGridViewSuppliers.CurrentRow.Cells[1].Value == null)
                {
                    setSupplier.Parameters.Add("@Role", DbType.String).Value = "";
                }
                else setSupplier.Parameters.Add("@Role", DbType.String).Value = dataGridViewSuppliers.CurrentRow.Cells[1].Value.ToString();

                if (dataGridViewSuppliers.CurrentRow.Cells[2].Value == null)
                {
                    setSupplier.Parameters.Add("@Password", DbType.String).Value = "";
                }
                else setSupplier.Parameters.Add("@Password", DbType.String).Value = dataGridViewSuppliers.CurrentRow.Cells[2].Value.ToString();

                if (dataGridViewSuppliers.CurrentRow.Cells[3].Value == null)
                {
                    setSupplier.Parameters.Add("@Fullname", DbType.String).Value = "";
                }
                else setSupplier.Parameters.Add("@Fullname", DbType.String).Value = dataGridViewSuppliers.CurrentRow.Cells[3].Value.ToString();

                if (dataGridViewSuppliers.CurrentRow.Cells[4].Value == null)
                {
                    setSupplier.Parameters.Add("@Etc", DbType.String).Value = "";
                }
                else setSupplier.Parameters.Add("@Etc", DbType.String).Value = dataGridViewSuppliers.CurrentRow.Cells[4].Value.ToString();

                setSupplier.ExecuteNonQuery();
                dataGridViewSuppliers.Update();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            this.Close();
            dbConnection.Close();
        }

        private void buttonToFormAdminMode_Click(object sender, EventArgs e)
        {
            this.Close();
            dbConnection.Close();
        }
    }
}
