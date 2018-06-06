namespace DSS
{
    partial class EditSupplier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSupplierName = new System.Windows.Forms.Label();
            this.textBoxSupplierName = new System.Windows.Forms.TextBox();
            this.labelSupplierType = new System.Windows.Forms.Label();
            this.labelSupplierMaterialQuality = new System.Windows.Forms.Label();
            this.labelSupplierPrice = new System.Windows.Forms.Label();
            this.labelSupplierTimeOfDelivery = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSaveAndClose = new System.Windows.Forms.Button();
            this.buttonBackToProjectsForm = new System.Windows.Forms.Button();
            this.labelSupplierLocationRemoteness = new System.Windows.Forms.Label();
            this.labelSupplierFlexibility = new System.Windows.Forms.Label();
            this.labelSupplierWarrantyService = new System.Windows.Forms.Label();
            this.comboBoxSupplierType = new System.Windows.Forms.ComboBox();
            this.checkBoxQMS = new System.Windows.Forms.CheckBox();
            this.domainUpDownMaterialQuality = new System.Windows.Forms.DomainUpDown();
            this.domainUpDownPrice = new System.Windows.Forms.DomainUpDown();
            this.domainUpDownTimeOfDelivery = new System.Windows.Forms.DomainUpDown();
            this.domainUpDownLocationRemoteness = new System.Windows.Forms.DomainUpDown();
            this.domainUpDownFlexibility = new System.Windows.Forms.DomainUpDown();
            this.domainUpDownWarrantyService = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // labelSupplierName
            // 
            this.labelSupplierName.AutoSize = true;
            this.labelSupplierName.Location = new System.Drawing.Point(18, 15);
            this.labelSupplierName.Name = "labelSupplierName";
            this.labelSupplierName.Size = new System.Drawing.Size(95, 15);
            this.labelSupplierName.TabIndex = 0;
            this.labelSupplierName.Text = "Наименование";
            // 
            // textBoxSupplierName
            // 
            this.textBoxSupplierName.Location = new System.Drawing.Point(21, 33);
            this.textBoxSupplierName.Name = "textBoxSupplierName";
            this.textBoxSupplierName.Size = new System.Drawing.Size(150, 21);
            this.textBoxSupplierName.TabIndex = 1;
            this.textBoxSupplierName.WordWrap = false;
            // 
            // labelSupplierType
            // 
            this.labelSupplierType.AutoSize = true;
            this.labelSupplierType.Location = new System.Drawing.Point(18, 57);
            this.labelSupplierType.Name = "labelSupplierType";
            this.labelSupplierType.Size = new System.Drawing.Size(101, 15);
            this.labelSupplierType.TabIndex = 2;
            this.labelSupplierType.Text = "Тип поставщика";
            // 
            // labelSupplierMaterialQuality
            // 
            this.labelSupplierMaterialQuality.AutoSize = true;
            this.labelSupplierMaterialQuality.Location = new System.Drawing.Point(18, 143);
            this.labelSupplierMaterialQuality.Name = "labelSupplierMaterialQuality";
            this.labelSupplierMaterialQuality.Size = new System.Drawing.Size(113, 15);
            this.labelSupplierMaterialQuality.TabIndex = 5;
            this.labelSupplierMaterialQuality.Text = "Качество изделий";
            // 
            // labelSupplierPrice
            // 
            this.labelSupplierPrice.AutoSize = true;
            this.labelSupplierPrice.Location = new System.Drawing.Point(18, 185);
            this.labelSupplierPrice.Name = "labelSupplierPrice";
            this.labelSupplierPrice.Size = new System.Drawing.Size(39, 15);
            this.labelSupplierPrice.TabIndex = 7;
            this.labelSupplierPrice.Text = "Цены";
            // 
            // labelSupplierTimeOfDelivery
            // 
            this.labelSupplierTimeOfDelivery.AutoSize = true;
            this.labelSupplierTimeOfDelivery.Location = new System.Drawing.Point(18, 227);
            this.labelSupplierTimeOfDelivery.Name = "labelSupplierTimeOfDelivery";
            this.labelSupplierTimeOfDelivery.Size = new System.Drawing.Size(99, 15);
            this.labelSupplierTimeOfDelivery.TabIndex = 9;
            this.labelSupplierTimeOfDelivery.Text = "Сроки поставки";
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(264, 291);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(90, 3, 3, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(150, 30);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSaveAndClose
            // 
            this.buttonSaveAndClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSaveAndClose.Location = new System.Drawing.Point(264, 327);
            this.buttonSaveAndClose.Margin = new System.Windows.Forms.Padding(90, 3, 3, 3);
            this.buttonSaveAndClose.Name = "buttonSaveAndClose";
            this.buttonSaveAndClose.Size = new System.Drawing.Size(150, 30);
            this.buttonSaveAndClose.TabIndex = 18;
            this.buttonSaveAndClose.Text = "Сохранить и закрыть";
            this.buttonSaveAndClose.UseVisualStyleBackColor = true;
            this.buttonSaveAndClose.Click += new System.EventHandler(this.buttonSaveAndClose_Click);
            // 
            // buttonBackToProjectsForm
            // 
            this.buttonBackToProjectsForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonBackToProjectsForm.Location = new System.Drawing.Point(264, 363);
            this.buttonBackToProjectsForm.Margin = new System.Windows.Forms.Padding(90, 3, 3, 3);
            this.buttonBackToProjectsForm.Name = "buttonBackToProjectsForm";
            this.buttonBackToProjectsForm.Size = new System.Drawing.Size(150, 30);
            this.buttonBackToProjectsForm.TabIndex = 19;
            this.buttonBackToProjectsForm.Text = "Закрыть";
            this.buttonBackToProjectsForm.UseVisualStyleBackColor = true;
            this.buttonBackToProjectsForm.Click += new System.EventHandler(this.buttonBackToSuppliersForm_Click);
            // 
            // labelSupplierLocationRemoteness
            // 
            this.labelSupplierLocationRemoteness.AutoSize = true;
            this.labelSupplierLocationRemoteness.Location = new System.Drawing.Point(18, 269);
            this.labelSupplierLocationRemoteness.Name = "labelSupplierLocationRemoteness";
            this.labelSupplierLocationRemoteness.Size = new System.Drawing.Size(181, 15);
            this.labelSupplierLocationRemoteness.TabIndex = 11;
            this.labelSupplierLocationRemoteness.Text = "Географическая удаленность";
            // 
            // labelSupplierFlexibility
            // 
            this.labelSupplierFlexibility.AutoSize = true;
            this.labelSupplierFlexibility.Location = new System.Drawing.Point(18, 311);
            this.labelSupplierFlexibility.Name = "labelSupplierFlexibility";
            this.labelSupplierFlexibility.Size = new System.Drawing.Size(61, 15);
            this.labelSupplierFlexibility.TabIndex = 13;
            this.labelSupplierFlexibility.Text = "Гибкость";
            // 
            // labelSupplierWarrantyService
            // 
            this.labelSupplierWarrantyService.AutoSize = true;
            this.labelSupplierWarrantyService.Location = new System.Drawing.Point(18, 353);
            this.labelSupplierWarrantyService.Name = "labelSupplierWarrantyService";
            this.labelSupplierWarrantyService.Size = new System.Drawing.Size(174, 15);
            this.labelSupplierWarrantyService.TabIndex = 15;
            this.labelSupplierWarrantyService.Text = "Работа гарантийной службы";
            // 
            // comboBoxSupplierType
            // 
            this.comboBoxSupplierType.FormattingEnabled = true;
            this.comboBoxSupplierType.ItemHeight = 15;
            this.comboBoxSupplierType.Items.AddRange(new object[] {
            "Утвержденный",
            "Неутвержденный"});
            this.comboBoxSupplierType.Location = new System.Drawing.Point(21, 76);
            this.comboBoxSupplierType.Name = "comboBoxSupplierType";
            this.comboBoxSupplierType.Size = new System.Drawing.Size(150, 23);
            this.comboBoxSupplierType.TabIndex = 15;
            // 
            // checkBoxQMS
            // 
            this.checkBoxQMS.AutoSize = true;
            this.checkBoxQMS.Location = new System.Drawing.Point(21, 112);
            this.checkBoxQMS.Name = "checkBoxQMS";
            this.checkBoxQMS.Size = new System.Drawing.Size(166, 19);
            this.checkBoxQMS.TabIndex = 4;
            this.checkBoxQMS.Text = "Наличие СМК ИСО 9001";
            this.checkBoxQMS.UseVisualStyleBackColor = true;
            // 
            // domainUpDownMaterialQuality
            // 
            this.domainUpDownMaterialQuality.Items.Add("3");
            this.domainUpDownMaterialQuality.Items.Add("2");
            this.domainUpDownMaterialQuality.Items.Add("1");
            this.domainUpDownMaterialQuality.Location = new System.Drawing.Point(21, 162);
            this.domainUpDownMaterialQuality.Name = "domainUpDownMaterialQuality";
            this.domainUpDownMaterialQuality.Size = new System.Drawing.Size(150, 21);
            this.domainUpDownMaterialQuality.TabIndex = 6;
            // 
            // domainUpDownPrice
            // 
            this.domainUpDownPrice.Items.Add("3");
            this.domainUpDownPrice.Items.Add("2");
            this.domainUpDownPrice.Items.Add("1");
            this.domainUpDownPrice.Location = new System.Drawing.Point(21, 204);
            this.domainUpDownPrice.Name = "domainUpDownPrice";
            this.domainUpDownPrice.Size = new System.Drawing.Size(150, 21);
            this.domainUpDownPrice.TabIndex = 8;
            // 
            // domainUpDownTimeOfDelivery
            // 
            this.domainUpDownTimeOfDelivery.Items.Add("3");
            this.domainUpDownTimeOfDelivery.Items.Add("2");
            this.domainUpDownTimeOfDelivery.Items.Add("1");
            this.domainUpDownTimeOfDelivery.Location = new System.Drawing.Point(21, 246);
            this.domainUpDownTimeOfDelivery.Name = "domainUpDownTimeOfDelivery";
            this.domainUpDownTimeOfDelivery.Size = new System.Drawing.Size(150, 21);
            this.domainUpDownTimeOfDelivery.TabIndex = 10;
            // 
            // domainUpDownLocationRemoteness
            // 
            this.domainUpDownLocationRemoteness.Items.Add("3");
            this.domainUpDownLocationRemoteness.Items.Add("2");
            this.domainUpDownLocationRemoteness.Items.Add("1");
            this.domainUpDownLocationRemoteness.Location = new System.Drawing.Point(21, 288);
            this.domainUpDownLocationRemoteness.Name = "domainUpDownLocationRemoteness";
            this.domainUpDownLocationRemoteness.Size = new System.Drawing.Size(150, 21);
            this.domainUpDownLocationRemoteness.TabIndex = 12;
            // 
            // domainUpDownFlexibility
            // 
            this.domainUpDownFlexibility.Items.Add("3");
            this.domainUpDownFlexibility.Items.Add("2");
            this.domainUpDownFlexibility.Items.Add("1");
            this.domainUpDownFlexibility.Location = new System.Drawing.Point(21, 330);
            this.domainUpDownFlexibility.Name = "domainUpDownFlexibility";
            this.domainUpDownFlexibility.Size = new System.Drawing.Size(150, 21);
            this.domainUpDownFlexibility.TabIndex = 14;
            // 
            // domainUpDownWarrantyService
            // 
            this.domainUpDownWarrantyService.Items.Add("3");
            this.domainUpDownWarrantyService.Items.Add("2");
            this.domainUpDownWarrantyService.Items.Add("1");
            this.domainUpDownWarrantyService.Location = new System.Drawing.Point(21, 372);
            this.domainUpDownWarrantyService.Name = "domainUpDownWarrantyService";
            this.domainUpDownWarrantyService.Size = new System.Drawing.Size(150, 21);
            this.domainUpDownWarrantyService.TabIndex = 16;
            // 
            // EditSupplier
            // 
            this.AcceptButton = this.buttonSaveAndClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonBackToProjectsForm;
            this.ClientSize = new System.Drawing.Size(653, 506);
            this.Controls.Add(this.domainUpDownWarrantyService);
            this.Controls.Add(this.domainUpDownFlexibility);
            this.Controls.Add(this.domainUpDownLocationRemoteness);
            this.Controls.Add(this.domainUpDownTimeOfDelivery);
            this.Controls.Add(this.domainUpDownPrice);
            this.Controls.Add(this.domainUpDownMaterialQuality);
            this.Controls.Add(this.checkBoxQMS);
            this.Controls.Add(this.comboBoxSupplierType);
            this.Controls.Add(this.buttonBackToProjectsForm);
            this.Controls.Add(this.buttonSaveAndClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelSupplierWarrantyService);
            this.Controls.Add(this.labelSupplierFlexibility);
            this.Controls.Add(this.labelSupplierLocationRemoteness);
            this.Controls.Add(this.labelSupplierTimeOfDelivery);
            this.Controls.Add(this.labelSupplierPrice);
            this.Controls.Add(this.labelSupplierMaterialQuality);
            this.Controls.Add(this.labelSupplierType);
            this.Controls.Add(this.textBoxSupplierName);
            this.Controls.Add(this.labelSupplierName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "EditSupplier";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные о поставщике";
            this.Load += new System.EventHandler(this.AddProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSupplierName;
        private System.Windows.Forms.TextBox textBoxSupplierName;
        private System.Windows.Forms.Label labelSupplierType;
        private System.Windows.Forms.Label labelSupplierMaterialQuality;
        private System.Windows.Forms.Label labelSupplierPrice;
        private System.Windows.Forms.Label labelSupplierTimeOfDelivery;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSaveAndClose;
        private System.Windows.Forms.Button buttonBackToProjectsForm;
        private System.Windows.Forms.Label labelSupplierLocationRemoteness;
        private System.Windows.Forms.Label labelSupplierFlexibility;
        private System.Windows.Forms.Label labelSupplierWarrantyService;
        private System.Windows.Forms.ComboBox comboBoxSupplierType;
        private System.Windows.Forms.CheckBox checkBoxQMS;
        private System.Windows.Forms.DomainUpDown domainUpDownMaterialQuality;
        private System.Windows.Forms.DomainUpDown domainUpDownPrice;
        private System.Windows.Forms.DomainUpDown domainUpDownTimeOfDelivery;
        private System.Windows.Forms.DomainUpDown domainUpDownLocationRemoteness;
        private System.Windows.Forms.DomainUpDown domainUpDownFlexibility;
        private System.Windows.Forms.DomainUpDown domainUpDownWarrantyService;
    }
}