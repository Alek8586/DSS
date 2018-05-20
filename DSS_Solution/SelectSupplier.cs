using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
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
            ListOfTheCriteria();
        }

        private void buttonAddСriterion_Click(object sender, EventArgs e)
        {
            try
            {
            if (listBoxAllCriteria.SelectedItem != null)
            {
                AddCriterion();
            }
            else
            {
                listBoxAllCriteria.SetSelected(listBoxAllCriteria.TopIndex, true);
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
                    listBoxSelectedCriteria.SetSelected(listBoxAllCriteria.TopIndex, true);
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

                ResultOfTheSelection ResultOfTheSelectionForm = new ResultOfTheSelection();
                ResultOfTheSelectionForm.Owner = this;
                ResultOfTheSelectionForm.ShowDialog();

            }

        }

        private void buttonListboxSelectedCriteriaOneStepHigher_Click(object sender, EventArgs e)
        {
            if (listBoxSelectedCriteria.Items.Count > 0)
            {
                if (listBoxSelectedCriteria.TopIndex != listBoxSelectedCriteria.SelectedIndex)
                {
                    listBoxSelectedCriteria.TopIndex = listBoxSelectedCriteria.SelectedIndex;
                }
            }
        }

        private void buttonListboxSelectedCriteriaOneStepBelow_Click(object sender, EventArgs e)
        {

        }


        private void buttonBackToFormEditProject_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         private void AddCriterion()
        {
            listBoxSelectedCriteria.Items.Add(listBoxAllCriteria.SelectedItem);
            listBoxAllCriteria.Items.Remove(listBoxAllCriteria.SelectedItem);
        }

        private void RemoveCriterion()
        {
            listBoxAllCriteria.Items.Add(listBoxSelectedCriteria.SelectedItem);
            listBoxSelectedCriteria.Items.Remove(listBoxSelectedCriteria.SelectedItem);
        }

        private void ListOfTheCriteria()
        {
            dbConnection = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "database.db; Version=3");
            dbConnection.Open();

            SQLiteCommand listUsers = dbConnection.CreateCommand();
            listUsers.CommandText = "pragma table_info(Suppliers)";
            SQLiteDataReader sqlCommand = listUsers.ExecuteReader();

            using (sqlCommand)
            {
                while (sqlCommand.Read())
                {
                    listBoxAllCriteria.Items.Add(sqlCommand[1].ToString());
                    listBoxAllCriteria.Items.Remove("ID");
                    listBoxAllCriteria.Items.Remove("Name");
                }

            }
            dbConnection.Close();
        }

        private void SelectionOfTheSupplier()
        {
            /*
             * Рассчет рейтинга каждого поставщика:
             * * Рассчет удельного веса каждого критерия
            */

            dbConnection = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "database.db; Version=3");
            dbConnection.Open();

            SQLiteCommand sqlSuppliersList = dbConnection.CreateCommand();
            sqlSuppliersList.CommandText = "Select * from Suppliers";

            List<ListOfTheSuppliers> listOfTheSuppliers = new List<ListOfTheSuppliers>();
            ListOfTheSuppliers suplliers = new ListOfTheSuppliers();

            using (var sqlReader = sqlSuppliersList.ExecuteReader())
            {
                while (sqlReader.Read())
                {
                    
                    suplliers.ID = Convert.ToInt32(sqlReader["ID"].ToString());
                    suplliers.Name = sqlReader["Name"].ToString();
                    suplliers.Class = Convert.ToInt32(sqlReader["Class"].ToString());
                    suplliers.MaterialQuality = Convert.ToInt32(sqlReader["MaterialQuality"].ToString());
                    suplliers.Price = Convert.ToInt32(sqlReader["Price"].ToString());
                    suplliers.TimeOfDelivery = Convert.ToInt32(sqlReader["TimeOfDelivery"].ToString());
                    suplliers.Reliability = Convert.ToInt32(sqlReader["Reliability"].ToString());

                    listOfTheSuppliers.Add(suplliers);

                    MessageBox.Show(suplliers.ID.ToString() + " - " + suplliers.Name.ToString() + " - " + suplliers.Class.ToString() + " - " + suplliers.MaterialQuality.ToString() + " - " + suplliers.Price.ToString() + " - " + suplliers.TimeOfDelivery.ToString() + " - " + suplliers.Reliability.ToString(), "ВНИМАНИЕ! Спасибо за внимание!");

                }
            }

            dbConnection.Close();

            //Выводит последнюю запись!
            foreach (ListOfTheSuppliers i in listOfTheSuppliers)
            {
                MessageBox.Show(i.ID.ToString() + ", " + i.Name.ToString() + ", " + i.Class.ToString() + ", " + i.MaterialQuality.ToString() + ", " + i.Price.ToString() + ", " + i.TimeOfDelivery.ToString() + ", " + i.Reliability.ToString());
            }

            List<UnitWeightOfTheCriteria> unitWeightOfTheCriteria = new List<UnitWeightOfTheCriteria>();
            UnitWeightOfTheCriteria unitWeight = new UnitWeightOfTheCriteria();

            int countOfSelectedCriteria = listBoxSelectedCriteria.Items.Count;
            int summOfWeightOfAllCriteria = 0;
            for (int i = 0; i < listOfTheSuppliers.Count; i++)
            {
                if (listBoxSelectedCriteria.Items.Contains("Class"))
                {
                    unitWeight.Class = countOfSelectedCriteria - listBoxSelectedCriteria.Items.IndexOf("Class");
                }
                else unitWeight.Class = 0;
                if (listBoxSelectedCriteria.Items.Contains("MaterialQuality"))
                {
                    unitWeight.MaterialQuality = countOfSelectedCriteria - listBoxSelectedCriteria.Items.IndexOf("MaterialQuality");
                }
                else unitWeight.MaterialQuality = 0;
                if (listBoxSelectedCriteria.Items.Contains("Price"))
                {
                    unitWeight.Price = countOfSelectedCriteria - listBoxSelectedCriteria.Items.IndexOf("Price");
                }
                else unitWeight.Price = 0;
                if (listBoxSelectedCriteria.Items.Contains("TimeOfDelivery"))
                {
                    unitWeight.TimeOfDelivery = countOfSelectedCriteria - listBoxSelectedCriteria.Items.IndexOf("TimeOfDelivery");
                }
                else unitWeight.TimeOfDelivery = 0;
                if (listBoxSelectedCriteria.Items.Contains("Reliability"))
                {
                    unitWeight.Reliability = countOfSelectedCriteria - listBoxSelectedCriteria.Items.IndexOf("Reliability");
                }
                else unitWeight.Reliability = 0;

                summOfWeightOfAllCriteria = Convert.ToInt32(unitWeight.Class + unitWeight.MaterialQuality + unitWeight.Price + unitWeight.TimeOfDelivery + unitWeight.Reliability);

                unitWeight.Class /= summOfWeightOfAllCriteria;
                unitWeight.MaterialQuality /= summOfWeightOfAllCriteria;
                unitWeight.Price /= summOfWeightOfAllCriteria;
                unitWeight.TimeOfDelivery /= summOfWeightOfAllCriteria;
                unitWeight.Reliability /= summOfWeightOfAllCriteria;

                unitWeightOfTheCriteria.Add(unitWeight);
            }

            //MessageBox.Show(listOfTheSuppliers.Count.ToString());

            //MessageBox.Show("Class = " + unitWeight.Class.ToString() + " \nMatrialQuality = " + unitWeight.MaterialQuality.ToString() + " \nPrice = " + unitWeight.Price.ToString() + " \nTimeOfDelivery = " + unitWeight.TimeOfDelivery.ToString() + " \nReliability = " + unitWeight.Reliability.ToString() + " \nСумма всех критериев = " + summOfWeightOfAllCriteria.ToString());

            List<RaitingOfTheSuppliers> raitingOfTheSuppliers = new List<RaitingOfTheSuppliers>();
            RaitingOfTheSuppliers raiting = new RaitingOfTheSuppliers();

            for (int i = 0; i < unitWeightOfTheCriteria.Count; i++)
            {
                raiting.ID = suplliers.ID;
                raiting.Name = suplliers.Name;
                raiting.Class = suplliers.Class * unitWeight.Class;
                raiting.MaterialQuality = suplliers.MaterialQuality * unitWeight.MaterialQuality;
                raiting.Price = suplliers.Price * unitWeight.Price;
                raiting.TimeOfDelivery = suplliers.TimeOfDelivery * unitWeight.TimeOfDelivery;
                raiting.Reliability = suplliers.Reliability * unitWeight.Reliability;

                raitingOfTheSuppliers.Add(raiting);

                raitingOfTheSuppliers.Sort(delegate (RaitingOfTheSuppliers raitingOfTheSuppliers1, RaitingOfTheSuppliers raitingOfTheSuppliers2) { return raitingOfTheSuppliers1.ID.CompareTo(raitingOfTheSuppliers2.ID); });

            }
                //MessageBox.Show("ID = " + raiting.ID.ToString() + "\nName= " + raiting.Name.ToString() + "\nClass = " + raiting.Class.ToString() + " \nMatrialQuality = " + raiting.MaterialQuality.ToString() + "\nPrice = " + raiting.Price.ToString() + "\nTimeOfDelivery = " + raiting.TimeOfDelivery.ToString() + "\nReliability = " + raiting.Reliability.ToString() + "\nСумма всех критериев = " + summOfWeightOfAllCriteria.ToString());
        }
    }
}