using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

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
            ListOfSuppliers();
        }

        private void buttonAddSupplier_Click(object sender, EventArgs e)
        {
            string[] supplierData = new string[dataGridViewSuppliers.CurrentRow.Cells.Count];

            EditSupplier EditSupplierForm = new EditSupplier(supplierData);
            EditSupplierForm.Owner = this;
            EditSupplierForm.ShowDialog();
        }

        private void buttonEditSupplier_Click(object sender, EventArgs e)
        {
            EditRecord();
        }

        private void buttonDeleteSupplier_Click(object sender, EventArgs e)
        {
            DeleteSupplier();
        }

        private void buttonToFormAdminMode_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewSuppliers_DoubleClick(object sender, EventArgs e)
        {
            EditRecord();
        }

        public void ListOfSuppliers()
        {
            try
            {
                dbConnection = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "database.db; Version=3");
                dbConnection.Open();

                SQLiteCommand listSuppliers = dbConnection.CreateCommand();
                listSuppliers.CommandText = "Select * from Suppliers";

                using (var sqlReader = listSuppliers.ExecuteReader())

                    while (sqlReader.Read())
                    {
                        dataGridViewSuppliers.Rows.Add(sqlReader[0].ToString(), sqlReader[1].ToString(), sqlReader[2], sqlReader[3].ToString(), sqlReader[4].ToString(), sqlReader[5].ToString(), sqlReader[6].ToString(), sqlReader[7].ToString(), sqlReader[8].ToString(), sqlReader[9].ToString());
                    }
                dbConnection.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void EditRecord()
        {
            //Передаем данные строки в поля формы
            string[] supplierData = new string[dataGridViewSuppliers.CurrentRow.Cells.Count];
            for (int i = 0; i < dataGridViewSuppliers.CurrentRow.Cells.Count; i++)
            {
                supplierData[i] = dataGridViewSuppliers.CurrentRow.Cells[i].Value.ToString();
            }

            EditSupplier EditSupplierForm = new EditSupplier(supplierData);
            EditSupplierForm.Owner = this;
            EditSupplierForm.ShowDialog();

        }

        private void DeleteSupplier()
        {
            SQLiteCommand cmd = dbConnection.CreateCommand();
            cmd.CommandText = "Delete from Suppliers where ID=@id";
            cmd.Parameters.Add("@id", DbType.Int32).Value = dataGridViewSuppliers.CurrentRow.Cells[0].Value;
            try
            {
                //Удаление записи из таблицы в ДБ
                dbConnection.Open();
                cmd.ExecuteNonQuery();
                dbConnection.Close();

                //Удаление строки в DGV при выбранной ячейке
                foreach (DataGridViewCell cell in dataGridViewSuppliers.SelectedCells)
                {
                    dataGridViewSuppliers.Rows.RemoveAt(cell.RowIndex);

                    if (cell.RowIndex < 0) break;
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
