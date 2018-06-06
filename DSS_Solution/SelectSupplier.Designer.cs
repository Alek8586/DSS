namespace DSS
{
    partial class SelectSupplier
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
            this.buttonBackToFormEditProject = new System.Windows.Forms.Button();
            this.tabControlSelectionSupplier = new System.Windows.Forms.TabControl();
            this.tabPageSelectionSupplier = new System.Windows.Forms.TabPage();
            this.groupBoxCriteriaOfTheSelection = new System.Windows.Forms.GroupBox();
            this.buttonListboxSelectedCriteriaOneStepBelow = new System.Windows.Forms.Button();
            this.buttonListboxSelectedCriteriaOneStepHigher = new System.Windows.Forms.Button();
            this.labelQMS = new System.Windows.Forms.Label();
            this.labelSupplierType = new System.Windows.Forms.Label();
            this.comboBoxQMS = new System.Windows.Forms.ComboBox();
            this.comboBoxSupplierType = new System.Windows.Forms.ComboBox();
            this.listBoxAllCriteria = new System.Windows.Forms.ListBox();
            this.buttonAddСriterion = new System.Windows.Forms.Button();
            this.buttonSelectionOfTheSupplier = new System.Windows.Forms.Button();
            this.listBoxSelectedCriteria = new System.Windows.Forms.ListBox();
            this.buttonRemoveCriterion = new System.Windows.Forms.Button();
            this.groupBoxSearchingResult = new System.Windows.Forms.GroupBox();
            this.buttonSelectSupplierToProject = new System.Windows.Forms.Button();
            this.listBoxSearchingResult = new System.Windows.Forms.ListBox();
            this.tabPageMannualySelectionSupplier = new System.Windows.Forms.TabPage();
            this.groupBoxListOfTheSuppliers = new System.Windows.Forms.GroupBox();
            this.buttonMannualySelectionSupplier = new System.Windows.Forms.Button();
            this.listBoxListOfTheSuppliers = new System.Windows.Forms.ListBox();
            this.tabControlSelectionSupplier.SuspendLayout();
            this.tabPageSelectionSupplier.SuspendLayout();
            this.groupBoxCriteriaOfTheSelection.SuspendLayout();
            this.groupBoxSearchingResult.SuspendLayout();
            this.tabPageMannualySelectionSupplier.SuspendLayout();
            this.groupBoxListOfTheSuppliers.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBackToFormEditProject
            // 
            this.buttonBackToFormEditProject.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonBackToFormEditProject.Location = new System.Drawing.Point(412, 604);
            this.buttonBackToFormEditProject.Name = "buttonBackToFormEditProject";
            this.buttonBackToFormEditProject.Size = new System.Drawing.Size(120, 25);
            this.buttonBackToFormEditProject.TabIndex = 5;
            this.buttonBackToFormEditProject.Text = "Назад";
            this.buttonBackToFormEditProject.UseVisualStyleBackColor = true;
            this.buttonBackToFormEditProject.Click += new System.EventHandler(this.buttonBackToFormEditProject_Click);
            // 
            // tabControlSelectionSupplier
            // 
            this.tabControlSelectionSupplier.Controls.Add(this.tabPageSelectionSupplier);
            this.tabControlSelectionSupplier.Controls.Add(this.tabPageMannualySelectionSupplier);
            this.tabControlSelectionSupplier.Location = new System.Drawing.Point(18, 18);
            this.tabControlSelectionSupplier.Multiline = true;
            this.tabControlSelectionSupplier.Name = "tabControlSelectionSupplier";
            this.tabControlSelectionSupplier.SelectedIndex = 0;
            this.tabControlSelectionSupplier.Size = new System.Drawing.Size(532, 580);
            this.tabControlSelectionSupplier.TabIndex = 7;
            // 
            // tabPageSelectionSupplier
            // 
            this.tabPageSelectionSupplier.Controls.Add(this.groupBoxCriteriaOfTheSelection);
            this.tabPageSelectionSupplier.Controls.Add(this.groupBoxSearchingResult);
            this.tabPageSelectionSupplier.Location = new System.Drawing.Point(4, 24);
            this.tabPageSelectionSupplier.Name = "tabPageSelectionSupplier";
            this.tabPageSelectionSupplier.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelectionSupplier.Size = new System.Drawing.Size(524, 552);
            this.tabPageSelectionSupplier.TabIndex = 0;
            this.tabPageSelectionSupplier.Text = "Поиск поставщика";
            this.tabPageSelectionSupplier.UseVisualStyleBackColor = true;
            // 
            // groupBoxCriteriaOfTheSelection
            // 
            this.groupBoxCriteriaOfTheSelection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxCriteriaOfTheSelection.Controls.Add(this.buttonListboxSelectedCriteriaOneStepBelow);
            this.groupBoxCriteriaOfTheSelection.Controls.Add(this.buttonListboxSelectedCriteriaOneStepHigher);
            this.groupBoxCriteriaOfTheSelection.Controls.Add(this.labelQMS);
            this.groupBoxCriteriaOfTheSelection.Controls.Add(this.labelSupplierType);
            this.groupBoxCriteriaOfTheSelection.Controls.Add(this.comboBoxQMS);
            this.groupBoxCriteriaOfTheSelection.Controls.Add(this.comboBoxSupplierType);
            this.groupBoxCriteriaOfTheSelection.Controls.Add(this.listBoxAllCriteria);
            this.groupBoxCriteriaOfTheSelection.Controls.Add(this.buttonAddСriterion);
            this.groupBoxCriteriaOfTheSelection.Controls.Add(this.buttonSelectionOfTheSupplier);
            this.groupBoxCriteriaOfTheSelection.Controls.Add(this.listBoxSelectedCriteria);
            this.groupBoxCriteriaOfTheSelection.Controls.Add(this.buttonRemoveCriterion);
            this.groupBoxCriteriaOfTheSelection.Location = new System.Drawing.Point(6, 6);
            this.groupBoxCriteriaOfTheSelection.Name = "groupBoxCriteriaOfTheSelection";
            this.groupBoxCriteriaOfTheSelection.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxCriteriaOfTheSelection.Size = new System.Drawing.Size(512, 320);
            this.groupBoxCriteriaOfTheSelection.TabIndex = 6;
            this.groupBoxCriteriaOfTheSelection.TabStop = false;
            this.groupBoxCriteriaOfTheSelection.Text = "Критерии подбора";
            // 
            // buttonListboxSelectedCriteriaOneStepBelow
            // 
            this.buttonListboxSelectedCriteriaOneStepBelow.Location = new System.Drawing.Point(384, 157);
            this.buttonListboxSelectedCriteriaOneStepBelow.Name = "buttonListboxSelectedCriteriaOneStepBelow";
            this.buttonListboxSelectedCriteriaOneStepBelow.Size = new System.Drawing.Size(120, 23);
            this.buttonListboxSelectedCriteriaOneStepBelow.TabIndex = 8;
            this.buttonListboxSelectedCriteriaOneStepBelow.Text = "Ниже";
            this.buttonListboxSelectedCriteriaOneStepBelow.UseVisualStyleBackColor = true;
            this.buttonListboxSelectedCriteriaOneStepBelow.Click += new System.EventHandler(this.buttonListboxSelectedCriteriaOneStepBelow_Click);
            // 
            // buttonListboxSelectedCriteriaOneStepHigher
            // 
            this.buttonListboxSelectedCriteriaOneStepHigher.Location = new System.Drawing.Point(384, 128);
            this.buttonListboxSelectedCriteriaOneStepHigher.Name = "buttonListboxSelectedCriteriaOneStepHigher";
            this.buttonListboxSelectedCriteriaOneStepHigher.Size = new System.Drawing.Size(120, 23);
            this.buttonListboxSelectedCriteriaOneStepHigher.TabIndex = 7;
            this.buttonListboxSelectedCriteriaOneStepHigher.Text = "Выше";
            this.buttonListboxSelectedCriteriaOneStepHigher.UseVisualStyleBackColor = true;
            this.buttonListboxSelectedCriteriaOneStepHigher.Click += new System.EventHandler(this.buttonListboxSelectedCriteriaOneStepHigher_Click);
            // 
            // labelQMS
            // 
            this.labelQMS.AutoSize = true;
            this.labelQMS.Location = new System.Drawing.Point(173, 31);
            this.labelQMS.Name = "labelQMS";
            this.labelQMS.Size = new System.Drawing.Size(147, 15);
            this.labelQMS.TabIndex = 6;
            this.labelQMS.Text = "Наличие СМК ИСО 9001";
            // 
            // labelSupplierType
            // 
            this.labelSupplierType.AutoSize = true;
            this.labelSupplierType.Location = new System.Drawing.Point(5, 31);
            this.labelSupplierType.Name = "labelSupplierType";
            this.labelSupplierType.Size = new System.Drawing.Size(101, 15);
            this.labelSupplierType.TabIndex = 6;
            this.labelSupplierType.Text = "Тип поставщика";
            // 
            // comboBoxQMS
            // 
            this.comboBoxQMS.FormattingEnabled = true;
            this.comboBoxQMS.Items.AddRange(new object[] {
            "Все",
            "В наличии",
            "Отсутствует"});
            this.comboBoxQMS.Location = new System.Drawing.Point(176, 49);
            this.comboBoxQMS.Name = "comboBoxQMS";
            this.comboBoxQMS.Size = new System.Drawing.Size(120, 23);
            this.comboBoxQMS.TabIndex = 5;
            this.comboBoxQMS.TabStop = false;
            // 
            // comboBoxSupplierType
            // 
            this.comboBoxSupplierType.FormattingEnabled = true;
            this.comboBoxSupplierType.Items.AddRange(new object[] {
            "Все",
            "Утвержденный",
            "Неутвержденный"});
            this.comboBoxSupplierType.Location = new System.Drawing.Point(8, 49);
            this.comboBoxSupplierType.Name = "comboBoxSupplierType";
            this.comboBoxSupplierType.Size = new System.Drawing.Size(120, 23);
            this.comboBoxSupplierType.TabIndex = 5;
            this.comboBoxSupplierType.TabStop = false;
            // 
            // listBoxAllCriteria
            // 
            this.listBoxAllCriteria.FormattingEnabled = true;
            this.listBoxAllCriteria.ItemHeight = 15;
            this.listBoxAllCriteria.Location = new System.Drawing.Point(8, 129);
            this.listBoxAllCriteria.Name = "listBoxAllCriteria";
            this.listBoxAllCriteria.Size = new System.Drawing.Size(120, 154);
            this.listBoxAllCriteria.TabIndex = 0;
            this.listBoxAllCriteria.DoubleClick += new System.EventHandler(this.listBoxAllCriteria_DoubleClick);
            // 
            // buttonAddСriterion
            // 
            this.buttonAddСriterion.Location = new System.Drawing.Point(134, 128);
            this.buttonAddСriterion.Name = "buttonAddСriterion";
            this.buttonAddСriterion.Size = new System.Drawing.Size(120, 23);
            this.buttonAddСriterion.TabIndex = 1;
            this.buttonAddСriterion.Text = "Добавить >>";
            this.buttonAddСriterion.UseVisualStyleBackColor = true;
            this.buttonAddСriterion.Click += new System.EventHandler(this.buttonAddСriterion_Click);
            // 
            // buttonSelectionOfTheSupplier
            // 
            this.buttonSelectionOfTheSupplier.Location = new System.Drawing.Point(8, 289);
            this.buttonSelectionOfTheSupplier.Name = "buttonSelectionOfTheSupplier";
            this.buttonSelectionOfTheSupplier.Size = new System.Drawing.Size(372, 23);
            this.buttonSelectionOfTheSupplier.TabIndex = 4;
            this.buttonSelectionOfTheSupplier.Text = "Произвести подбор поставщика";
            this.buttonSelectionOfTheSupplier.UseVisualStyleBackColor = true;
            this.buttonSelectionOfTheSupplier.Click += new System.EventHandler(this.buttonSelectionOfTheSupplier_Click);
            // 
            // listBoxSelectedCriteria
            // 
            this.listBoxSelectedCriteria.FormattingEnabled = true;
            this.listBoxSelectedCriteria.ItemHeight = 15;
            this.listBoxSelectedCriteria.Location = new System.Drawing.Point(260, 129);
            this.listBoxSelectedCriteria.Name = "listBoxSelectedCriteria";
            this.listBoxSelectedCriteria.Size = new System.Drawing.Size(120, 154);
            this.listBoxSelectedCriteria.TabIndex = 3;
            this.listBoxSelectedCriteria.DoubleClick += new System.EventHandler(this.listBoxSelectedCriteria_DoubleClick);
            // 
            // buttonRemoveCriterion
            // 
            this.buttonRemoveCriterion.Location = new System.Drawing.Point(134, 157);
            this.buttonRemoveCriterion.Name = "buttonRemoveCriterion";
            this.buttonRemoveCriterion.Size = new System.Drawing.Size(120, 23);
            this.buttonRemoveCriterion.TabIndex = 2;
            this.buttonRemoveCriterion.Text = "<< Удалить";
            this.buttonRemoveCriterion.UseVisualStyleBackColor = true;
            this.buttonRemoveCriterion.Click += new System.EventHandler(this.buttonRemoveCriterion_Click);
            // 
            // groupBoxSearchingResult
            // 
            this.groupBoxSearchingResult.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxSearchingResult.Controls.Add(this.buttonSelectSupplierToProject);
            this.groupBoxSearchingResult.Controls.Add(this.listBoxSearchingResult);
            this.groupBoxSearchingResult.Location = new System.Drawing.Point(6, 332);
            this.groupBoxSearchingResult.Name = "groupBoxSearchingResult";
            this.groupBoxSearchingResult.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxSearchingResult.Size = new System.Drawing.Size(512, 215);
            this.groupBoxSearchingResult.TabIndex = 6;
            this.groupBoxSearchingResult.TabStop = false;
            this.groupBoxSearchingResult.Text = "Результаты поиска";
            // 
            // buttonSelectSupplierToProject
            // 
            this.buttonSelectSupplierToProject.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSelectSupplierToProject.Location = new System.Drawing.Point(8, 182);
            this.buttonSelectSupplierToProject.Name = "buttonSelectSupplierToProject";
            this.buttonSelectSupplierToProject.Size = new System.Drawing.Size(162, 25);
            this.buttonSelectSupplierToProject.TabIndex = 5;
            this.buttonSelectSupplierToProject.Text = "Выбрать поставщика";
            this.buttonSelectSupplierToProject.UseVisualStyleBackColor = true;
            this.buttonSelectSupplierToProject.Click += new System.EventHandler(this.buttonSelectSupplierToProject_Click);
            // 
            // listBoxSearchingResult
            // 
            this.listBoxSearchingResult.FormattingEnabled = true;
            this.listBoxSearchingResult.ItemHeight = 15;
            this.listBoxSearchingResult.Location = new System.Drawing.Point(9, 22);
            this.listBoxSearchingResult.Name = "listBoxSearchingResult";
            this.listBoxSearchingResult.Size = new System.Drawing.Size(496, 154);
            this.listBoxSearchingResult.TabIndex = 0;
            this.listBoxSearchingResult.DoubleClick += new System.EventHandler(this.listBoxSearchingResult_DoubleClick);
            // 
            // tabPageMannualySelectionSupplier
            // 
            this.tabPageMannualySelectionSupplier.Controls.Add(this.groupBoxListOfTheSuppliers);
            this.tabPageMannualySelectionSupplier.Location = new System.Drawing.Point(4, 24);
            this.tabPageMannualySelectionSupplier.Name = "tabPageMannualySelectionSupplier";
            this.tabPageMannualySelectionSupplier.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMannualySelectionSupplier.Size = new System.Drawing.Size(524, 552);
            this.tabPageMannualySelectionSupplier.TabIndex = 1;
            this.tabPageMannualySelectionSupplier.Text = "Ручной выбор поставщика";
            this.tabPageMannualySelectionSupplier.UseVisualStyleBackColor = true;
            // 
            // groupBoxListOfTheSuppliers
            // 
            this.groupBoxListOfTheSuppliers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxListOfTheSuppliers.Controls.Add(this.buttonMannualySelectionSupplier);
            this.groupBoxListOfTheSuppliers.Controls.Add(this.listBoxListOfTheSuppliers);
            this.groupBoxListOfTheSuppliers.Location = new System.Drawing.Point(6, 6);
            this.groupBoxListOfTheSuppliers.Name = "groupBoxListOfTheSuppliers";
            this.groupBoxListOfTheSuppliers.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxListOfTheSuppliers.Size = new System.Drawing.Size(512, 215);
            this.groupBoxListOfTheSuppliers.TabIndex = 7;
            this.groupBoxListOfTheSuppliers.TabStop = false;
            this.groupBoxListOfTheSuppliers.Text = "Список поставщиков";
            // 
            // buttonMannualySelectionSupplier
            // 
            this.buttonMannualySelectionSupplier.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonMannualySelectionSupplier.Location = new System.Drawing.Point(8, 182);
            this.buttonMannualySelectionSupplier.Name = "buttonMannualySelectionSupplier";
            this.buttonMannualySelectionSupplier.Size = new System.Drawing.Size(162, 25);
            this.buttonMannualySelectionSupplier.TabIndex = 5;
            this.buttonMannualySelectionSupplier.Text = "Выбрать поставщика";
            this.buttonMannualySelectionSupplier.UseVisualStyleBackColor = true;
            this.buttonMannualySelectionSupplier.Click += new System.EventHandler(this.buttonMannualySelectionSupplier_Click);
            // 
            // listBoxListOfTheSuppliers
            // 
            this.listBoxListOfTheSuppliers.FormattingEnabled = true;
            this.listBoxListOfTheSuppliers.ItemHeight = 15;
            this.listBoxListOfTheSuppliers.Location = new System.Drawing.Point(9, 22);
            this.listBoxListOfTheSuppliers.Name = "listBoxListOfTheSuppliers";
            this.listBoxListOfTheSuppliers.Size = new System.Drawing.Size(496, 154);
            this.listBoxListOfTheSuppliers.TabIndex = 0;
            this.listBoxListOfTheSuppliers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxListOfTheSuppliers_MouseClick);
            // 
            // SelectSupplier
            // 
            this.AcceptButton = this.buttonSelectionOfTheSupplier;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonBackToFormEditProject;
            this.ClientSize = new System.Drawing.Size(981, 660);
            this.Controls.Add(this.tabControlSelectionSupplier);
            this.Controls.Add(this.buttonBackToFormEditProject);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SelectSupplier";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбор поставщика";
            this.Load += new System.EventHandler(this.SelectSupplier_Load);
            this.tabControlSelectionSupplier.ResumeLayout(false);
            this.tabPageSelectionSupplier.ResumeLayout(false);
            this.groupBoxCriteriaOfTheSelection.ResumeLayout(false);
            this.groupBoxCriteriaOfTheSelection.PerformLayout();
            this.groupBoxSearchingResult.ResumeLayout(false);
            this.tabPageMannualySelectionSupplier.ResumeLayout(false);
            this.groupBoxListOfTheSuppliers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonBackToFormEditProject;
        private System.Windows.Forms.TabControl tabControlSelectionSupplier;
        private System.Windows.Forms.TabPage tabPageSelectionSupplier;
        private System.Windows.Forms.TabPage tabPageMannualySelectionSupplier;
        private System.Windows.Forms.GroupBox groupBoxCriteriaOfTheSelection;
        private System.Windows.Forms.Button buttonListboxSelectedCriteriaOneStepBelow;
        private System.Windows.Forms.Button buttonListboxSelectedCriteriaOneStepHigher;
        private System.Windows.Forms.Label labelQMS;
        private System.Windows.Forms.Label labelSupplierType;
        private System.Windows.Forms.ComboBox comboBoxQMS;
        private System.Windows.Forms.ComboBox comboBoxSupplierType;
        private System.Windows.Forms.ListBox listBoxAllCriteria;
        private System.Windows.Forms.Button buttonAddСriterion;
        private System.Windows.Forms.Button buttonSelectionOfTheSupplier;
        private System.Windows.Forms.ListBox listBoxSelectedCriteria;
        private System.Windows.Forms.Button buttonRemoveCriterion;
        private System.Windows.Forms.GroupBox groupBoxSearchingResult;
        private System.Windows.Forms.Button buttonSelectSupplierToProject;
        private System.Windows.Forms.ListBox listBoxSearchingResult;
        private System.Windows.Forms.GroupBox groupBoxListOfTheSuppliers;
        private System.Windows.Forms.Button buttonMannualySelectionSupplier;
        private System.Windows.Forms.ListBox listBoxListOfTheSuppliers;
    }
}