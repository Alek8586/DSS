using System;
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

            comboBoxSupplierType.SelectedIndex = 0;
            comboBoxQMS.SelectedIndex = 0;

            groupBoxSearchingResult.Visible = false;
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
            }

        }

        private void buttonListboxSelectedCriteriaOneStepHigher_Click(object sender, EventArgs e)
        {
            //if (listBoxSelectedCriteria.Items.Count > 0)
            //{
            //    if (listBoxSelectedCriteria.TopIndex != listBoxSelectedCriteria.SelectedIndex)
            //    {
            //        listBoxSelectedCriteria.TopIndex = listBoxSelectedCriteria.SelectedIndex;
            //    }
            //}
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
            /*
             * Считываем все колонки из таблицы Поставщики
             * Оставляем только параметры оценивания
            */
            dbConnection = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "database.db; Version=3");
            dbConnection.Open();

            SQLiteCommand listUsers = dbConnection.CreateCommand();
            listUsers.CommandText = "pragma table_info(Suppliers)";

            using (var sqlCommand = listUsers.ExecuteReader())
            {
                while (sqlCommand.Read())
                {
                    listBoxAllCriteria.Items.Add(sqlCommand[1].ToString());
                    listBoxAllCriteria.Items.Remove("ID");
                    listBoxAllCriteria.Items.Remove("Name");
                    listBoxAllCriteria.Items.Remove("Class");
                    listBoxAllCriteria.Items.Remove("QMS");
                }
            }
            dbConnection.Close();
        }

        private void SelectionOfTheSupplier()
        {
            /*
             * Рассчет рейтинга каждого поставщика:
             * * Заполнение списка поставщиков с экспертными оценками
             * * Присвоение выбранному критерию веса
             * * Рассчет удельного значения каждого критерия
             * * Рассчет рейтинга поставщика по каждому критерию
             * * Сортировка по убыванию
             * * Передача данных в форму решения по выбору поставщика
            */

            //Заполнение списка поставщиков с экспертными оценками
            dbConnection = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "database.db; Version=3");
            dbConnection.Open();

            SQLiteCommand sqlSuppliersList = dbConnection.CreateCommand();
            sqlSuppliersList.CommandText = "Select * from Suppliers";

            SQLiteDataReader sqlReader = sqlSuppliersList.ExecuteReader();

            /*
             * ВНИМАНИЕ! КОСТЫЛИ!
             * Считаем количество строк в таблице Поставщики
            */
            SQLiteCommand sqlSuppliersCount = dbConnection.CreateCommand();
            sqlSuppliersCount.CommandText = "Select count(*) from Suppliers";
            SQLiteDataReader sqlReader1 = sqlSuppliersCount.ExecuteReader();
            int rowscount = 0;

            using (sqlReader1)
            {
                if (sqlReader1.HasRows)
                {
                    while (sqlReader1.Read())
                    {
                        rowscount = Convert.ToInt32(sqlReader1[0]);
                    }
                }
            }
            /*
             * ВНИМАНИЕ! КОНЕЦ КОСТЫЛЕЙ!
            */

            string[,] listOfTheSuppliers = new string[rowscount, sqlReader.FieldCount];

            using (sqlReader)
            {
                if (sqlReader.HasRows)
                {
                    int i = 0;
                    while (sqlReader.Read())
                    {
                        for (int k = 0; k < listOfTheSuppliers.GetLength(1); k++)
                        {
                            listOfTheSuppliers[i, k] = sqlReader[k].ToString();
                        }
                        i++;
                    }
                }
            }
            dbConnection.Close();

            //Присвоение выбранному критерию веса
            int countOfSelectedCriteria = listBoxSelectedCriteria.Items.Count;
            double MaterialQuality = 0;
            double Price = 0;
            double TimeOfDelivery = 0;
            double LocationRemoteness = 0;
            double Flexibility = 0;
            double WarrantyService = 0;

            if (listBoxSelectedCriteria.Items.Contains("MaterialQuality"))
            {
                MaterialQuality = countOfSelectedCriteria - listBoxSelectedCriteria.Items.IndexOf("MaterialQuality");
            }
            else MaterialQuality = 0;
            if (listBoxSelectedCriteria.Items.Contains("Price"))
            {
                Price = countOfSelectedCriteria - listBoxSelectedCriteria.Items.IndexOf("Price");
            }
            else Price = 0;
            if (listBoxSelectedCriteria.Items.Contains("TimeOfDelivery"))
            {
                TimeOfDelivery = countOfSelectedCriteria - listBoxSelectedCriteria.Items.IndexOf("TimeOfDelivery");
            }
            else TimeOfDelivery = 0;
            if (listBoxSelectedCriteria.Items.Contains("LocationRemoteness"))
            {
                LocationRemoteness = countOfSelectedCriteria - listBoxSelectedCriteria.Items.IndexOf("LocationRemoteness");
            }
            else LocationRemoteness = 0;
            if (listBoxSelectedCriteria.Items.Contains("Flexibility"))
            {
                Flexibility = countOfSelectedCriteria - listBoxSelectedCriteria.Items.IndexOf("Flexibility");
            }
            else Flexibility = 0;
            if (listBoxSelectedCriteria.Items.Contains("WarrantyService"))
            {
                WarrantyService = countOfSelectedCriteria - listBoxSelectedCriteria.Items.IndexOf("WarrantyService");
            }
            else WarrantyService = 0;

            int summOfWeightOfAllCriteria = Convert.ToInt32(MaterialQuality + Price + TimeOfDelivery + LocationRemoteness + Flexibility + WarrantyService);

            //Рассчет удельного значения каждого критерия
            MaterialQuality /= summOfWeightOfAllCriteria;
            Price /= summOfWeightOfAllCriteria;
            TimeOfDelivery /= summOfWeightOfAllCriteria;
            LocationRemoteness /= summOfWeightOfAllCriteria;
            Flexibility /= summOfWeightOfAllCriteria;
            WarrantyService /= summOfWeightOfAllCriteria;

            //Проверка записи данных в экземпляр класса
            //MessageBox.Show(MaterialQuality.ToString() + ", " + Price.ToString() + ", " + TimeOfDelivery.ToString() + ", " + LocationRemoteness.ToString() + ", " + Flexibility.ToString() + ", " + WarrantyService.ToString());

            //Рассчет рейтинга поставщика по каждому критерию
            List<RatingOfTheSuppliers> ratingOfTheSuppliers = new List<RatingOfTheSuppliers>();

            for (int i = 0; i < rowscount; i++)
            {
                RatingOfTheSuppliers rating = new RatingOfTheSuppliers();

                rating.ID = Convert.ToInt32(listOfTheSuppliers[i, 0]);
                rating.Name = listOfTheSuppliers[i, 1];
                rating.Class = listOfTheSuppliers[i, 2];
                rating.QMS = Convert.ToBoolean(listOfTheSuppliers[i, 3]);
                rating.MaterialQuality = Convert.ToDouble(listOfTheSuppliers[i, 4]) * MaterialQuality;
                rating.Price = Convert.ToDouble(listOfTheSuppliers[i, 5]) * Price;
                rating.TimeOfDelivery = Convert.ToDouble(listOfTheSuppliers[i, 6]) * TimeOfDelivery;
                rating.LocationRemoteness = Convert.ToDouble(listOfTheSuppliers[i, 7]) * LocationRemoteness;
                rating.Flexibility = Convert.ToDouble(listOfTheSuppliers[i, 8]) * Flexibility;
                rating.WarrantyService = Convert.ToDouble(listOfTheSuppliers[i, 9]) * WarrantyService;

                ratingOfTheSuppliers.Add(rating);

                //Проверка работы
                //MessageBox.Show(raiting.ID.ToString() + ", " + raiting.Name.ToString() + ", " + raiting.Class.ToString() + ", " + raiting.MaterialQuality.ToString() + ", " + raiting.Price.ToString() + ", " + raiting.TimeOfDelivery.ToString() + ", " + raiting.LocationRemoteness.ToString() + ", " + raiting.Flexibility.ToString() + ", " + raiting.WarrantyService.ToString());
            }

            //Расчет итоговой оценки по показателям
            foreach (var overallRating in ratingOfTheSuppliers)
            {
                overallRating.TotalGrade = Math.Round(overallRating.MaterialQuality + overallRating.Price + overallRating.TimeOfDelivery + overallRating.LocationRemoteness + overallRating.Flexibility + WarrantyService, 2);

                //MessageBox.Show(overallRating.ID.ToString() + ", " + overallRating.Name.ToString() + ", " + overallRating.TotalGrade.ToString(), "Результат выборки", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            //Сортировка полученных данных по убыванию
            ratingOfTheSuppliers.Sort((a, b) => (b.TotalGrade.CompareTo(a.TotalGrade)));

            //Проверка вывода
            groupBoxSearchingResult.Visible = true;
            listBoxSearchingResult.Items.Clear();

            foreach (var item in ratingOfTheSuppliers)
            {
                //Проверка работы
                //MessageBox.Show(item.ID.ToString() + ", " + item.Name.ToString() + ", " + item.TotalGrade.ToString(), "Результат выборки", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                listBoxSearchingResult.Items.Add(item.Name.ToString());
                if (listBoxSearchingResult.Items.Count > 2)
                {
                    break;
                }
            }
        }
    }
}
