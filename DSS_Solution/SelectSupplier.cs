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
            try
            {
                if (listBoxAllCriterions.SelectedItem != null)
                {
                    AddCriterion();
                }
                else
                {
                    listBoxAllCriterions.SetSelected(listBoxAllCriterions.TopIndex, true);
                    AddCriterion();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonRemoveCriterion_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxSelectedCriteria.SelectedItem != null)
                {
                    RemoveCriterion();
                }
                else
                {
                    listBoxSelectedCriteria.SetSelected(listBoxAllCriterions.TopIndex, true);
                    RemoveCriterion();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonSelectionOfTheSupplier_Click(object sender, EventArgs e)
        {
            if (listBoxSelectedCriteria.Items.Count > 0)
            {
                SelectionOfTheSupplier();
            }

        }

        private void buttonBackToFormEditProject_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         private void AddCriterion()
        {
            listBoxSelectedCriteria.Items.Add(listBoxAllCriterions.SelectedItem);
            listBoxAllCriterions.Items.Remove(listBoxAllCriterions.SelectedItem);
        }

        private void RemoveCriterion()
        {
            listBoxAllCriterions.Items.Add(listBoxSelectedCriteria.SelectedItem);
            listBoxSelectedCriteria.Items.Remove(listBoxSelectedCriteria.SelectedItem);
        }

       private string SelectionOfTheSupplier()
        {
            //Заполняем массив выбранными критериями
            int countOfSelectedCriteria = listBoxSelectedCriteria.Items.Count;
            int[] selectedCriteria = new int[countOfSelectedCriteria];
            double[] weightOfTheCriterion = new double[countOfSelectedCriteria];
            int summOfWeightOfAllCriteria = 0;

            for (int i = 0; i < selectedCriteria.Length; i++)
            {
                selectedCriteria[i] = listBoxSelectedCriteria.Items.IndexOf(listBoxSelectedCriteria.Items[i].ToString());
                weightOfTheCriterion[i] = countOfSelectedCriteria;
                summOfWeightOfAllCriteria += countOfSelectedCriteria;
                countOfSelectedCriteria--;
            }

            /*
             * Рассчет удельного веса каждого критерия
             * Оценивание веса каждого выбранного показателя в общей совокупности показателей
            */
            //double[] unitWeightOfTheCriterion = new double[weightOfTheCriterion.Length];            

            //for (int i = 0; i < unitWeightOfTheCriterion.Length; i++)
            //{
            //    unitWeightOfTheCriterion[i] = weightOfTheCriterion[i] / summOfWeightOfAllCriteria;
            //    //MessageBox.Show(Math.Round(unitWeightOfTheCriterion[i], 1).ToString(), "Внимание!");
            //}

            string[,] unitWeightOfTheCriterion = new string[listBoxSelectedCriteria.Items.Count, 2];
            for (int i = 0; i < unitWeightOfTheCriterion.GetLength(0); i++)
            {
                for (int k = 0; k < unitWeightOfTheCriterion.GetLength(1); k++)
                {
                    unitWeightOfTheCriterion[i, k] = listBoxSelectedCriteria.Items[i].ToString();
                    unitWeightOfTheCriterion[i, k + 1] = Convert.ToString(weightOfTheCriterion[i] / summOfWeightOfAllCriteria);

                    MessageBox.Show(unitWeightOfTheCriterion[i, k].ToString() + " = " + unitWeightOfTheCriterion[i, k + 1].ToString());
                }
            }

            //Рассчет рейтинга каждого поставщика
            dbConnection = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "database.db; Version=3");
            dbConnection.Open();

            SQLiteCommand listProjects = dbConnection.CreateCommand();
            listProjects.CommandText = "Select * from Suppliers";
            SQLiteDataReader sql = listProjects.ExecuteReader();

            string[,] supplierslist = new string[/*sql.StepCount, sql.FieldCount*/ 10, sql.FieldCount];

            for (int i = 0; i < supplierslist.GetLength(0); i++)
            {
                while (sql.Read())
                {
                    for (int k = 0; k < supplierslist.GetLength(1); k++)
                    {
                        supplierslist[i, k] = sql[k].ToString();
                    }
                }
            }
            sql.Close();
            dbConnection.Close();

            string[,] ratingOfSuppler = new string[listBoxSelectedCriteria.Items.Count, supplierslist.GetLength(0)];
            for (int i = 0; i < ratingOfSuppler.GetLength(0); i++)
            {
                for (int k = 0; k < ratingOfSuppler.GetLength(1); k++)
                {
                    
                }
            }



            //Сравнение полученных результатов


            return null;
        }

        private string listOfSupplier()
        {
            try
            {
            //    dbConnection = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "database.db; Version=3");
            //    dbConnection.Open();

            //    SQLiteCommand listProjects = dbConnection.CreateCommand();
            //    listProjects.CommandText = "Select * from Suppliers";
            //    SQLiteDataReader sql = listProjects.ExecuteReader();

            //    string[,] supplierslist = new string[/*sql.StepCount, sql.FieldCount*/ 10, sql.FieldCount];

            //    for (int i = 0; i < supplierslist.GetLength(0); i++)
            //    {
            //        while (sql.Read())
            //        {
            //            for (int k = 0; k < supplierslist.GetLength(1); k++)
            //            {
            //                supplierslist[i, k] = sql[k].ToString();
            //            }
            //        }
            //    }
            //    sql.Close();
            //    dbConnection.Close(); 
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return null;
        }
    }
}