using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSS
{
    public partial class SelectSupplier : Form
    {
        private SQLiteConnection dbConnection;

        public SelectSupplier()
        {
            InitializeComponent();
        }

        private void SelectSupplier_Load(object sender, EventArgs e)
        {
            dbConnection = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "database.db; Version=3");
            dbConnection.Open();

            SQLiteCommand listUsers = dbConnection.CreateCommand();
            listUsers.CommandText = "pragma table_info(Suppliers)";
            SQLiteDataReader sql = listUsers.ExecuteReader();

            while (sql.Read())
            {
                listBoxAllCriterions.Items.Add(sql[1].ToString());
                listBoxAllCriterions.Items.Remove("ID");
                listBoxAllCriterions.Items.Remove("Name");
            }
            sql.Close();

            dbConnection.Close();
        }

        private void buttonAddСriterion_Click(object sender, EventArgs e)
        {
            if (listBoxAllCriterions.SelectedItem != null)
            {
                try
                {
                    listBoxSelectedCriterions.Items.Add(listBoxAllCriterions.SelectedItem);
                    listBoxAllCriterions.Items.Remove(listBoxAllCriterions.SelectedItem);
                }
                catch
                {

                }
            }
        }

        private void buttonRemoveCriterion_Click(object sender, EventArgs e)
        {
            if (listBoxSelectedCriterions.SelectedItem != null)
            {
                try
                {
                    listBoxAllCriterions.Items.Add(listBoxSelectedCriterions.SelectedItem);
                    listBoxSelectedCriterions.Items.Remove(listBoxSelectedCriterions.SelectedItem);
                }
                catch
                {

                }
            }            
        }
    }
}