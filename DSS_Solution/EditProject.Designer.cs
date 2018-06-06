namespace DSS
{
    partial class EditProject
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
            this.labelProjectName = new System.Windows.Forms.Label();
            this.textBoxProjectName = new System.Windows.Forms.TextBox();
            this.labelProjectMainContract = new System.Windows.Forms.Label();
            this.textBoxProjectMainContract = new System.Windows.Forms.TextBox();
            this.labelProjectShippingDate = new System.Windows.Forms.Label();
            this.labelProjectManager = new System.Windows.Forms.Label();
            this.textBoxProjectManager = new System.Windows.Forms.TextBox();
            this.labelProjectChiefDesigner = new System.Windows.Forms.Label();
            this.textBoxProjectChiefDesigner = new System.Windows.Forms.TextBox();
            this.labelProjectSupplier = new System.Windows.Forms.Label();
            this.textBoxProjectSupplier = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSaveAndClose = new System.Windows.Forms.Button();
            this.buttonBackToProjectsForm = new System.Windows.Forms.Button();
            this.buttonSelectSupplier = new System.Windows.Forms.Button();
            this.textBoxProjectShippingDate = new System.Windows.Forms.TextBox();
            this.labelProjectOfficer = new System.Windows.Forms.Label();
            this.labelProjectStatus = new System.Windows.Forms.Label();
            this.comboBoxProjectStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxProjectOfficer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelProjectName
            // 
            this.labelProjectName.AutoSize = true;
            this.labelProjectName.Location = new System.Drawing.Point(18, 15);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(95, 15);
            this.labelProjectName.TabIndex = 0;
            this.labelProjectName.Text = "Наименование";
            // 
            // textBoxProjectName
            // 
            this.textBoxProjectName.Location = new System.Drawing.Point(21, 33);
            this.textBoxProjectName.Name = "textBoxProjectName";
            this.textBoxProjectName.Size = new System.Drawing.Size(150, 21);
            this.textBoxProjectName.TabIndex = 1;
            this.textBoxProjectName.WordWrap = false;
            // 
            // labelProjectMainContract
            // 
            this.labelProjectMainContract.AutoSize = true;
            this.labelProjectMainContract.Location = new System.Drawing.Point(18, 57);
            this.labelProjectMainContract.Name = "labelProjectMainContract";
            this.labelProjectMainContract.Size = new System.Drawing.Size(120, 15);
            this.labelProjectMainContract.TabIndex = 2;
            this.labelProjectMainContract.Text = "Головной контракт";
            // 
            // textBoxProjectMainContract
            // 
            this.textBoxProjectMainContract.Location = new System.Drawing.Point(21, 75);
            this.textBoxProjectMainContract.Name = "textBoxProjectMainContract";
            this.textBoxProjectMainContract.Size = new System.Drawing.Size(150, 21);
            this.textBoxProjectMainContract.TabIndex = 3;
            // 
            // labelProjectShippingDate
            // 
            this.labelProjectShippingDate.AutoSize = true;
            this.labelProjectShippingDate.Location = new System.Drawing.Point(18, 99);
            this.labelProjectShippingDate.Name = "labelProjectShippingDate";
            this.labelProjectShippingDate.Size = new System.Drawing.Size(90, 15);
            this.labelProjectShippingDate.TabIndex = 4;
            this.labelProjectShippingDate.Text = "Дата отгрузки";
            // 
            // labelProjectManager
            // 
            this.labelProjectManager.AutoSize = true;
            this.labelProjectManager.Location = new System.Drawing.Point(18, 143);
            this.labelProjectManager.Name = "labelProjectManager";
            this.labelProjectManager.Size = new System.Drawing.Size(140, 15);
            this.labelProjectManager.TabIndex = 6;
            this.labelProjectManager.Text = "Руководитель проекта";
            // 
            // textBoxProjectManager
            // 
            this.textBoxProjectManager.Location = new System.Drawing.Point(21, 161);
            this.textBoxProjectManager.Name = "textBoxProjectManager";
            this.textBoxProjectManager.Size = new System.Drawing.Size(150, 21);
            this.textBoxProjectManager.TabIndex = 7;
            // 
            // labelProjectChiefDesigner
            // 
            this.labelProjectChiefDesigner.AutoSize = true;
            this.labelProjectChiefDesigner.Location = new System.Drawing.Point(18, 185);
            this.labelProjectChiefDesigner.Name = "labelProjectChiefDesigner";
            this.labelProjectChiefDesigner.Size = new System.Drawing.Size(184, 15);
            this.labelProjectChiefDesigner.TabIndex = 8;
            this.labelProjectChiefDesigner.Text = "Главный конструктор проекта";
            // 
            // textBoxProjectChiefDesigner
            // 
            this.textBoxProjectChiefDesigner.Location = new System.Drawing.Point(21, 203);
            this.textBoxProjectChiefDesigner.Name = "textBoxProjectChiefDesigner";
            this.textBoxProjectChiefDesigner.Size = new System.Drawing.Size(150, 21);
            this.textBoxProjectChiefDesigner.TabIndex = 9;
            // 
            // labelProjectSupplier
            // 
            this.labelProjectSupplier.AutoSize = true;
            this.labelProjectSupplier.Location = new System.Drawing.Point(18, 227);
            this.labelProjectSupplier.Name = "labelProjectSupplier";
            this.labelProjectSupplier.Size = new System.Drawing.Size(72, 15);
            this.labelProjectSupplier.TabIndex = 10;
            this.labelProjectSupplier.Text = "Поставщик";
            // 
            // textBoxProjectSupplier
            // 
            this.textBoxProjectSupplier.Location = new System.Drawing.Point(21, 245);
            this.textBoxProjectSupplier.Name = "textBoxProjectSupplier";
            this.textBoxProjectSupplier.Size = new System.Drawing.Size(150, 21);
            this.textBoxProjectSupplier.TabIndex = 11;
            this.textBoxProjectSupplier.DoubleClick += new System.EventHandler(this.textBoxProjectSupplier_DoubleClick);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(264, 248);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(90, 3, 3, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(150, 30);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSaveAndClose
            // 
            this.buttonSaveAndClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSaveAndClose.Location = new System.Drawing.Point(264, 284);
            this.buttonSaveAndClose.Margin = new System.Windows.Forms.Padding(90, 3, 3, 3);
            this.buttonSaveAndClose.Name = "buttonSaveAndClose";
            this.buttonSaveAndClose.Size = new System.Drawing.Size(150, 30);
            this.buttonSaveAndClose.TabIndex = 13;
            this.buttonSaveAndClose.Text = "Сохранить и закрыть";
            this.buttonSaveAndClose.UseVisualStyleBackColor = true;
            this.buttonSaveAndClose.Click += new System.EventHandler(this.buttonSaveAndClose_Click);
            // 
            // buttonBackToProjectsForm
            // 
            this.buttonBackToProjectsForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonBackToProjectsForm.Location = new System.Drawing.Point(264, 320);
            this.buttonBackToProjectsForm.Margin = new System.Windows.Forms.Padding(90, 3, 3, 3);
            this.buttonBackToProjectsForm.Name = "buttonBackToProjectsForm";
            this.buttonBackToProjectsForm.Size = new System.Drawing.Size(150, 30);
            this.buttonBackToProjectsForm.TabIndex = 14;
            this.buttonBackToProjectsForm.Text = "Закрыть";
            this.buttonBackToProjectsForm.UseVisualStyleBackColor = true;
            this.buttonBackToProjectsForm.Click += new System.EventHandler(this.buttonBackToProjectsForm_Click);
            // 
            // buttonSelectSupplier
            // 
            this.buttonSelectSupplier.Location = new System.Drawing.Point(264, 18);
            this.buttonSelectSupplier.Margin = new System.Windows.Forms.Padding(90, 3, 3, 3);
            this.buttonSelectSupplier.Name = "buttonSelectSupplier";
            this.buttonSelectSupplier.Size = new System.Drawing.Size(150, 30);
            this.buttonSelectSupplier.TabIndex = 15;
            this.buttonSelectSupplier.Text = "Выбрать поставщика";
            this.buttonSelectSupplier.UseVisualStyleBackColor = true;
            this.buttonSelectSupplier.Click += new System.EventHandler(this.buttonSelectSupplier_Click);
            // 
            // textBoxProjectShippingDate
            // 
            this.textBoxProjectShippingDate.Location = new System.Drawing.Point(21, 117);
            this.textBoxProjectShippingDate.Name = "textBoxProjectShippingDate";
            this.textBoxProjectShippingDate.Size = new System.Drawing.Size(150, 21);
            this.textBoxProjectShippingDate.TabIndex = 5;
            // 
            // labelProjectOfficer
            // 
            this.labelProjectOfficer.AutoSize = true;
            this.labelProjectOfficer.Location = new System.Drawing.Point(18, 269);
            this.labelProjectOfficer.Name = "labelProjectOfficer";
            this.labelProjectOfficer.Size = new System.Drawing.Size(163, 15);
            this.labelProjectOfficer.TabIndex = 10;
            this.labelProjectOfficer.Text = "Ответственный сотрудник";
            // 
            // labelProjectStatus
            // 
            this.labelProjectStatus.AutoSize = true;
            this.labelProjectStatus.Location = new System.Drawing.Point(18, 311);
            this.labelProjectStatus.Name = "labelProjectStatus";
            this.labelProjectStatus.Size = new System.Drawing.Size(98, 15);
            this.labelProjectStatus.TabIndex = 10;
            this.labelProjectStatus.Text = "Статус проекта";
            // 
            // comboBoxProjectStatus
            // 
            this.comboBoxProjectStatus.FormattingEnabled = true;
            this.comboBoxProjectStatus.Location = new System.Drawing.Point(21, 329);
            this.comboBoxProjectStatus.Name = "comboBoxProjectStatus";
            this.comboBoxProjectStatus.Size = new System.Drawing.Size(150, 23);
            this.comboBoxProjectStatus.TabIndex = 11;
            // 
            // comboBoxProjectOfficer
            // 
            this.comboBoxProjectOfficer.FormattingEnabled = true;
            this.comboBoxProjectOfficer.Location = new System.Drawing.Point(21, 288);
            this.comboBoxProjectOfficer.Name = "comboBoxProjectOfficer";
            this.comboBoxProjectOfficer.Size = new System.Drawing.Size(150, 23);
            this.comboBoxProjectOfficer.TabIndex = 11;
            // 
            // EditProject
            // 
            this.AcceptButton = this.buttonSaveAndClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonBackToProjectsForm;
            this.ClientSize = new System.Drawing.Size(653, 506);
            this.Controls.Add(this.comboBoxProjectOfficer);
            this.Controls.Add(this.comboBoxProjectStatus);
            this.Controls.Add(this.buttonSelectSupplier);
            this.Controls.Add(this.buttonBackToProjectsForm);
            this.Controls.Add(this.buttonSaveAndClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxProjectSupplier);
            this.Controls.Add(this.labelProjectStatus);
            this.Controls.Add(this.labelProjectOfficer);
            this.Controls.Add(this.labelProjectSupplier);
            this.Controls.Add(this.textBoxProjectChiefDesigner);
            this.Controls.Add(this.labelProjectChiefDesigner);
            this.Controls.Add(this.textBoxProjectShippingDate);
            this.Controls.Add(this.textBoxProjectManager);
            this.Controls.Add(this.labelProjectManager);
            this.Controls.Add(this.labelProjectShippingDate);
            this.Controls.Add(this.textBoxProjectMainContract);
            this.Controls.Add(this.labelProjectMainContract);
            this.Controls.Add(this.textBoxProjectName);
            this.Controls.Add(this.labelProjectName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "EditProject";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные о проекте";
            this.Load += new System.EventHandler(this.EditProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProjectName;
        private System.Windows.Forms.TextBox textBoxProjectName;
        private System.Windows.Forms.Label labelProjectMainContract;
        private System.Windows.Forms.TextBox textBoxProjectMainContract;
        private System.Windows.Forms.Label labelProjectShippingDate;
        private System.Windows.Forms.Label labelProjectManager;
        private System.Windows.Forms.TextBox textBoxProjectManager;
        private System.Windows.Forms.Label labelProjectChiefDesigner;
        private System.Windows.Forms.TextBox textBoxProjectChiefDesigner;
        private System.Windows.Forms.Label labelProjectSupplier;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSaveAndClose;
        private System.Windows.Forms.Button buttonBackToProjectsForm;
        private System.Windows.Forms.Button buttonSelectSupplier;
        private System.Windows.Forms.TextBox textBoxProjectShippingDate;
        private System.Windows.Forms.Label labelProjectOfficer;
        private System.Windows.Forms.Label labelProjectStatus;
        public System.Windows.Forms.TextBox textBoxProjectSupplier;
        private System.Windows.Forms.ComboBox comboBoxProjectStatus;
        private System.Windows.Forms.ComboBox comboBoxProjectOfficer;
    }
}