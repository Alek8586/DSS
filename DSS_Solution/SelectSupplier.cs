using System;
using System.Collections.Generic;
using System.Data;
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


            dbConnection = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "database.db; Version=3");
            dbConnection.Open();

            SQLiteCommand sqlSuppliersList = dbConnection.CreateCommand();
            sqlSuppliersList.CommandText = "Select Name from Suppliers";
            SQLiteDataReader sqlReader = sqlSuppliersList.ExecuteReader();

            using (sqlReader)
            {
                if (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        listBoxListOfTheSuppliers.Items.Add(sqlReader["Name"]);
                    }
                }
            }
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
            if (listBoxSelectedCriteria.Items.Count > 0)
            {
                if (listBoxSelectedCriteria.SelectedIndex != listBoxSelectedCriteria.TopIndex && listBoxSelectedCriteria.SelectedIndex != listBoxSelectedCriteria.Items.Count)
                {
                    listBoxSelectedCriteria.Items.Insert(listBoxSelectedCriteria.SelectedIndex++, listBoxSelectedCriteria.SelectedItem);
                    listBoxSelectedCriteria.Items.Remove(listBoxSelectedCriteria.SelectedItem);
                }
            }
        }

        private void buttonListboxSelectedCriteriaOneStepBelow_Click(object sender, EventArgs e)
        {

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

        private void listBoxAllCriteria_DoubleClick(object sender, EventArgs e)
        {
            listBoxSelectedCriteria.Items.Add(listBoxAllCriteria.SelectedItem);
            listBoxAllCriteria.Items.Remove(listBoxAllCriteria.SelectedItem);
        }

        private void listBoxSelectedCriteria_DoubleClick(object sender, EventArgs e)
        {
            listBoxAllCriteria.Items.Add(listBoxSelectedCriteria.SelectedItem);
            listBoxSelectedCriteria.Items.Remove(listBoxSelectedCriteria.SelectedItem);
        }

        private void listBoxSearchingResult_DoubleClick(object sender, EventArgs e)
        {
            SupplierRecordToProject();
        }

        private void listBoxListOfTheSuppliers_MouseClick(object sender, MouseEventArgs e)
        {
            SupplierRecordToProject();
        }

        private void buttonSelectSupplierToProject_Click(object sender, EventArgs e)
        {
            SupplierRecordToProject();
        }

        private void buttonMannualySelectionSupplier_Click(object sender, EventArgs e)
        {
            SupplierRecordToProject();
        }

        private void buttonBackToFormEditProject_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void ListOfTheCriteria()
        {
            /*
             * Считываем все колонки из таблицы Поставщики
             * Оставляем только параметры оценивания
            */

            //dbConnection = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "database.db; Version=3");
            //dbConnection.Open();

            //SQLiteCommand listUsers = dbConnection.CreateCommand();
            //listUsers.CommandText = "pragma table_info(Suppliers)";

            //using (var sqlCommand = listUsers.ExecuteReader())
            //{
            //    while (sqlCommand.Read())
            //    {
            //        listBoxAllCriteria.Items.Add(sqlCommand[1].ToString());
            //        listBoxAllCriteria.Items.Remove("ID");
            //        listBoxAllCriteria.Items.Remove("Name");
            //        listBoxAllCriteria.Items.Remove("Type");
            //        listBoxAllCriteria.Items.Remove("QMS");
            //    }
            //}
            //dbConnection.Close();

            listBoxAllCriteria.Items.Add("Качество изделий");
            listBoxAllCriteria.Items.Add("Цены");
            listBoxAllCriteria.Items.Add("Сроки поставки");
            listBoxAllCriteria.Items.Add("Географическая удаленность");
            listBoxAllCriteria.Items.Add("Гибкость");
            listBoxAllCriteria.Items.Add("Гарантийная служба");
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
            dbConnection = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\database.db; Version=3");
            dbConnection.Open();

            SQLiteCommand sqlSuppliersList = dbConnection.CreateCommand();

            if (comboBoxSupplierType.SelectedIndex != 0 && comboBoxQMS.SelectedIndex != 0)
            {
                sqlSuppliersList.CommandText = "Select * from Suppliers where Type = @Type and QMS = @QMS";
                sqlSuppliersList.Parameters.Add("@Type", DbType.String).Value = comboBoxSupplierType.SelectedItem;
                
                if (comboBoxQMS.SelectedIndex == 1)
                {
                    sqlSuppliersList.Parameters.Add("@QMS", DbType.String).Value = "true";
                }
                else if (comboBoxQMS.SelectedIndex == 2)
                {
                    sqlSuppliersList.Parameters.Add("@QMS", DbType.String).Value = "false";
                }
            }
            else if (comboBoxSupplierType.SelectedIndex != 0 && comboBoxQMS.SelectedIndex == 0)
            {
                sqlSuppliersList.CommandText = "Select * from Suppliers where Type = @Type";
                sqlSuppliersList.Parameters.Add("@Type", DbType.String).Value = comboBoxSupplierType.SelectedItem;
            }
            else if (comboBoxSupplierType.SelectedIndex == 0 && comboBoxQMS.SelectedIndex != 0)
            {
                sqlSuppliersList.CommandText = "Select * from Suppliers where QMS = @QMS";

                if (comboBoxQMS.SelectedIndex == 1)
                {
                    sqlSuppliersList.Parameters.Add("@QMS", DbType.String).Value = "true";
                }
                else if (comboBoxQMS.SelectedIndex == 2)
                {
                    sqlSuppliersList.Parameters.Add("@QMS", DbType.String).Value = "false";
                }
            }
            else if (comboBoxSupplierType.SelectedIndex == 0 && comboBoxQMS.SelectedIndex == 0)
            {
                sqlSuppliersList.CommandText = "Select * from Suppliers";
            }

            SQLiteDataReader sqlReader = sqlSuppliersList.ExecuteReader();

            /*
             * ВНИМАНИЕ! КОСТЫЛИ!
             * Считаем количество строк в таблице Поставщики
            */
            SQLiteCommand sqlSuppliersCount = dbConnection.CreateCommand();
            if (comboBoxSupplierType.SelectedIndex != 0 && comboBoxQMS.SelectedIndex != 0)
            {
                sqlSuppliersCount.CommandText = "Select count(*) from Suppliers where Type = @Type and QMS = @QMS";
                sqlSuppliersCount.Parameters.Add("@Type", DbType.String).Value = comboBoxSupplierType.SelectedItem;

                if (comboBoxQMS.SelectedIndex == 1)
                {
                    sqlSuppliersCount.Parameters.Add("@QMS", DbType.String).Value = "true";
                }
                else if (comboBoxQMS.SelectedIndex == 2)
                {
                    sqlSuppliersCount.Parameters.Add("@QMS", DbType.String).Value = "false";
                }
            }
            else if (comboBoxSupplierType.SelectedIndex != 0 && comboBoxQMS.SelectedIndex == 0)
            {
                sqlSuppliersCount.CommandText = "Select count(*) from Suppliers where Type = @Type";
                sqlSuppliersCount.Parameters.Add("@Type", DbType.String).Value = comboBoxSupplierType.SelectedItem;
            }
            else if (comboBoxSupplierType.SelectedIndex == 0 && comboBoxQMS.SelectedIndex != 0)
            {
                sqlSuppliersCount.CommandText = "Select count(*) from Suppliers where QMS = @QMS";

                if (comboBoxQMS.SelectedIndex == 1)
                {
                    sqlSuppliersCount.Parameters.Add("@QMS", DbType.String).Value = "true";
                }
                else if (comboBoxQMS.SelectedIndex == 2)
                {
                    sqlSuppliersCount.Parameters.Add("@QMS", DbType.String).Value = "false";
                }
            }
            else if (comboBoxSupplierType.SelectedIndex == 0 && comboBoxQMS.SelectedIndex == 0)
            {
                sqlSuppliersCount.CommandText = "Select count(*) from Suppliers";
            }
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

            if (listBoxSelectedCriteria.Items.Contains("Качество изделий"))
            {
                MaterialQuality = countOfSelectedCriteria - listBoxSelectedCriteria.Items.IndexOf("Качество изделий");
            }
            else MaterialQuality = 0;
            if (listBoxSelectedCriteria.Items.Contains("Цены"))
            {
                Price = countOfSelectedCriteria - listBoxSelectedCriteria.Items.IndexOf("Цены");
            }
            else Price = 0;
            if (listBoxSelectedCriteria.Items.Contains("Сроки поставки"))
            {
                TimeOfDelivery = countOfSelectedCriteria - listBoxSelectedCriteria.Items.IndexOf("Сроки поставки");
            }
            else TimeOfDelivery = 0;
            if (listBoxSelectedCriteria.Items.Contains("Географическая удаленность"))
            {
                LocationRemoteness = countOfSelectedCriteria - listBoxSelectedCriteria.Items.IndexOf("Географическая удаленность");
            }
            else LocationRemoteness = 0;
            if (listBoxSelectedCriteria.Items.Contains("Гибкость"))
            {
                Flexibility = countOfSelectedCriteria - listBoxSelectedCriteria.Items.IndexOf("Гибкость");
            }
            else Flexibility = 0;
            if (listBoxSelectedCriteria.Items.Contains("Гарантийная служба"))
            {
                WarrantyService = countOfSelectedCriteria - listBoxSelectedCriteria.Items.IndexOf("Гарантийная служба");
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

        private void SupplierRecordToProject()
        {
            string supplierName = string.Empty;

            if (listBoxSearchingResult.SelectedItem != null || listBoxListOfTheSuppliers.SelectedItem != null)
            {
                if (tabControlSelectionSupplier.SelectedIndex == 0)
                {
                    supplierName = listBoxSearchingResult.SelectedItem.ToString();
                }
                else
                {
                    supplierName = listBoxListOfTheSuppliers.SelectedItem.ToString();
                }

                EditProject editProject = this.Owner as EditProject;
                if (editProject != null)
                {
                    editProject.textBoxProjectSupplier.Text = supplierName;
                }

                this.Close();
            }
            else MessageBox.Show("Выберите поставщика.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
