using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DSS
{
    public partial class EditSupplier : Form
    {
        private SQLiteConnection dbConnection;

        string supplierID = string.Empty;

        public EditSupplier(string[] supplierData)
        {
            InitializeComponent();

            if (supplierData != null || supplierData.Length != 0)
            {
                //Заполняем поля при изменении данных проекта
                supplierID = supplierData[0];
                textBoxSupplierName.Text = supplierData[1];
                comboBoxSupplierType.SelectedItem = supplierData[2];
                checkBoxQMS.Checked = Convert.ToBoolean(supplierData[3]);
                domainUpDownMaterialQuality.Text = supplierData[4];
                domainUpDownPrice.Text = supplierData[5];
                domainUpDownTimeOfDelivery.Text = supplierData[6];
                domainUpDownLocationRemoteness.Text = supplierData[7];
                domainUpDownFlexibility.Text = supplierData[8];
                domainUpDownWarrantyService.Text = supplierData[9];
            }
            if (supplierID != null) buttonSave.Visible = false;
        }

        private void AddProject_Load(object sender, EventArgs e)
        {
            dbConnection = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\database.db; Version=3");
            dbConnection.Open();            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            setSupplier();
        }

        private void buttonSaveAndClose_Click(object sender, EventArgs e)
        {
            setSupplier();
            this.Close();
        }

        private void buttonBackToSuppliersForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setSupplier()
        {            
            if (textBoxSupplierName.Text != string.Empty)
            {
                try
                {
                    SQLiteCommand setSupplier = dbConnection.CreateCommand();
                    if (supplierID != null)
                    {
                        setSupplier.CommandText = "Update Suppliers set Type = @Type, QMS = @QMS, MaterialQuality = @MaterialQuality, Price = @Price, TimeOfDelivery = @TimeOfDelivery, LocationRemoteness = @LocationRemoteness, Flexibility = @Flexibility, WarrantyService = @WarrantyService where Name = @SupplierName";
                        setSupplier.Parameters.Add("@SupplierName", DbType.String).Value = textBoxSupplierName.Text;
                        setSupplier.Parameters.Add("@Type", DbType.String).Value = comboBoxSupplierType.Text;
                        setSupplier.Parameters.Add("@QMS", DbType.Boolean).Value = checkBoxQMS.Checked;
                        setSupplier.Parameters.Add("@MaterialQuality", DbType.Int32).Value = Convert.ToInt32(domainUpDownMaterialQuality.Text);
                        setSupplier.Parameters.Add("@Price", DbType.Int32).Value = Convert.ToInt32(domainUpDownPrice.Text);
                        setSupplier.Parameters.Add("@TimeOfDelivery", DbType.Int32).Value = Convert.ToInt32(domainUpDownTimeOfDelivery.Text);
                        setSupplier.Parameters.Add("@LocationRemoteness", DbType.Int32).Value = Convert.ToInt32(domainUpDownLocationRemoteness.Text);
                        setSupplier.Parameters.Add("@Flexibility", DbType.Int32).Value = Convert.ToInt32(domainUpDownFlexibility.Text);
                        setSupplier.Parameters.Add("@WarrantyService", DbType.Int32).Value = Convert.ToInt32(domainUpDownWarrantyService.Text);
                    }
                    else
                    {
                        setSupplier.CommandText = "Insert into Suppliers(Name, Type, QMS, MaterialQuality, Price, TimeOfDelivery, LocationRemoteness, Flexibility, WarrantyService) values (@SupplierName, @Type, @QMS, @MaterialQuality, @Price, @TimeOfDelivery, @LocationRemoteness, @Flexibility, @WarrantyService)";
                        setSupplier.Parameters.Add("@SupplierName", DbType.String).Value = textBoxSupplierName.Text;
                        setSupplier.Parameters.Add("@Type", DbType.String).Value = comboBoxSupplierType.Text;
                        setSupplier.Parameters.Add("@QMS", DbType.Boolean).Value = checkBoxQMS.Checked;
                        setSupplier.Parameters.Add("@MaterialQuality", DbType.Int32).Value = Convert.ToInt32(domainUpDownMaterialQuality.Text);
                        setSupplier.Parameters.Add("@Price", DbType.Int32).Value = Convert.ToInt32(domainUpDownPrice.Text);
                        setSupplier.Parameters.Add("@TimeOfDelivery", DbType.Int32).Value = Convert.ToInt32(domainUpDownTimeOfDelivery.Text);
                        setSupplier.Parameters.Add("@LocationRemoteness", DbType.Int32).Value = Convert.ToInt32(domainUpDownLocationRemoteness.Text);
                        setSupplier.Parameters.Add("@Flexibility", DbType.Int32).Value = Convert.ToInt32(domainUpDownFlexibility.Text);
                        setSupplier.Parameters.Add("@WarrantyService", DbType.Int32).Value = Convert.ToInt32(domainUpDownWarrantyService.Text);
                    }
                    setSupplier.ExecuteNonQuery();

                    textBoxSupplierName.ResetText();
                    comboBoxSupplierType.ResetText();
                    checkBoxQMS.ResetText();
                    domainUpDownMaterialQuality.ResetText();
                    domainUpDownPrice.ResetText();
                    domainUpDownTimeOfDelivery.ResetText();
                    domainUpDownLocationRemoteness.ResetText();
                    domainUpDownFlexibility.ResetText();
                    domainUpDownWarrantyService.ResetText();

                    Suppliers main = this.Owner as Suppliers;
                    if (main != null)
                    {
                        //Обновление таблицы с информацией о проектах
                        main.dataGridViewSuppliers.Rows.Clear();
                        main.ListOfSuppliers();
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
