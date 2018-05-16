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


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
