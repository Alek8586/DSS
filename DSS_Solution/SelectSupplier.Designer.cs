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
            this.buttonAddСriterion = new System.Windows.Forms.Button();
            this.buttonRemoveCriterion = new System.Windows.Forms.Button();
            this.listBoxAllCriteria = new System.Windows.Forms.ListBox();
            this.listBoxSelectedCriteria = new System.Windows.Forms.ListBox();
            this.buttonSelectionOfTheSupplier = new System.Windows.Forms.Button();
            this.buttonBackToFormEditProject = new System.Windows.Forms.Button();
            this.groupBoxCriteriaOfTheSelection = new System.Windows.Forms.GroupBox();
            this.buttonListboxSelectedCriteriaOneStepHigher = new System.Windows.Forms.Button();
            this.buttonListboxSelectedCriteriaOneStepBelow = new System.Windows.Forms.Button();
            this.groupBoxCriteriaOfTheSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddСriterion
            // 
            this.buttonAddСriterion.Location = new System.Drawing.Point(134, 22);
            this.buttonAddСriterion.Name = "buttonAddСriterion";
            this.buttonAddСriterion.Size = new System.Drawing.Size(120, 23);
            this.buttonAddСriterion.TabIndex = 1;
            this.buttonAddСriterion.Text = "Добавить >>";
            this.buttonAddСriterion.UseVisualStyleBackColor = true;
            this.buttonAddСriterion.Click += new System.EventHandler(this.buttonAddСriterion_Click);
            // 
            // buttonRemoveCriterion
            // 
            this.buttonRemoveCriterion.Location = new System.Drawing.Point(134, 49);
            this.buttonRemoveCriterion.Name = "buttonRemoveCriterion";
            this.buttonRemoveCriterion.Size = new System.Drawing.Size(120, 23);
            this.buttonRemoveCriterion.TabIndex = 2;
            this.buttonRemoveCriterion.Text = "<< Удалить";
            this.buttonRemoveCriterion.UseVisualStyleBackColor = true;
            this.buttonRemoveCriterion.Click += new System.EventHandler(this.buttonRemoveCriterion_Click);
            // 
            // listBoxAllCriteria
            // 
            this.listBoxAllCriteria.FormattingEnabled = true;
            this.listBoxAllCriteria.ItemHeight = 15;
            this.listBoxAllCriteria.Location = new System.Drawing.Point(8, 22);
            this.listBoxAllCriteria.Name = "listBoxAllCriteria";
            this.listBoxAllCriteria.Size = new System.Drawing.Size(120, 154);
            this.listBoxAllCriteria.Sorted = true;
            this.listBoxAllCriteria.TabIndex = 0;
            // 
            // listBoxSelectedCriteria
            // 
            this.listBoxSelectedCriteria.FormattingEnabled = true;
            this.listBoxSelectedCriteria.ItemHeight = 15;
            this.listBoxSelectedCriteria.Location = new System.Drawing.Point(258, 22);
            this.listBoxSelectedCriteria.Name = "listBoxSelectedCriteria";
            this.listBoxSelectedCriteria.Size = new System.Drawing.Size(120, 154);
            this.listBoxSelectedCriteria.TabIndex = 3;
            // 
            // buttonSelectionOfTheSupplier
            // 
            this.buttonSelectionOfTheSupplier.Location = new System.Drawing.Point(8, 182);
            this.buttonSelectionOfTheSupplier.Name = "buttonSelectionOfTheSupplier";
            this.buttonSelectionOfTheSupplier.Size = new System.Drawing.Size(370, 23);
            this.buttonSelectionOfTheSupplier.TabIndex = 4;
            this.buttonSelectionOfTheSupplier.Text = "Произвести подбор поставщика";
            this.buttonSelectionOfTheSupplier.UseVisualStyleBackColor = true;
            this.buttonSelectionOfTheSupplier.Click += new System.EventHandler(this.buttonSelectionOfTheSupplier_Click);
            // 
            // buttonBackToFormEditProject
            // 
            this.buttonBackToFormEditProject.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonBackToFormEditProject.Location = new System.Drawing.Point(276, 240);
            this.buttonBackToFormEditProject.Name = "buttonBackToFormEditProject";
            this.buttonBackToFormEditProject.Size = new System.Drawing.Size(120, 25);
            this.buttonBackToFormEditProject.TabIndex = 5;
            this.buttonBackToFormEditProject.Text = "Назад";
            this.buttonBackToFormEditProject.UseVisualStyleBackColor = true;
            this.buttonBackToFormEditProject.Click += new System.EventHandler(this.buttonBackToFormEditProject_Click);
            // 
            // groupBoxCriteriaOfTheSelection
            // 
            this.groupBoxCriteriaOfTheSelection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxCriteriaOfTheSelection.Controls.Add(this.listBoxAllCriteria);
            this.groupBoxCriteriaOfTheSelection.Controls.Add(this.buttonAddСriterion);
            this.groupBoxCriteriaOfTheSelection.Controls.Add(this.buttonSelectionOfTheSupplier);
            this.groupBoxCriteriaOfTheSelection.Controls.Add(this.listBoxSelectedCriteria);
            this.groupBoxCriteriaOfTheSelection.Controls.Add(this.buttonRemoveCriterion);
            this.groupBoxCriteriaOfTheSelection.Location = new System.Drawing.Point(18, 18);
            this.groupBoxCriteriaOfTheSelection.Name = "groupBoxCriteriaOfTheSelection";
            this.groupBoxCriteriaOfTheSelection.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxCriteriaOfTheSelection.Size = new System.Drawing.Size(387, 216);
            this.groupBoxCriteriaOfTheSelection.TabIndex = 6;
            this.groupBoxCriteriaOfTheSelection.TabStop = false;
            this.groupBoxCriteriaOfTheSelection.Text = "Критерии подбора";
            // 
            // buttonListboxSelectedCriteriaOneStepHigher
            // 
            this.buttonListboxSelectedCriteriaOneStepHigher.Location = new System.Drawing.Point(411, 40);
            this.buttonListboxSelectedCriteriaOneStepHigher.Name = "buttonListboxSelectedCriteriaOneStepHigher";
            this.buttonListboxSelectedCriteriaOneStepHigher.Size = new System.Drawing.Size(120, 23);
            this.buttonListboxSelectedCriteriaOneStepHigher.TabIndex = 7;
            this.buttonListboxSelectedCriteriaOneStepHigher.Text = "Выше";
            this.buttonListboxSelectedCriteriaOneStepHigher.UseVisualStyleBackColor = true;
            this.buttonListboxSelectedCriteriaOneStepHigher.Visible = false;
            this.buttonListboxSelectedCriteriaOneStepHigher.Click += new System.EventHandler(this.buttonListboxSelectedCriteriaOneStepHigher_Click);
            // 
            // buttonListboxSelectedCriteriaOneStepBelow
            // 
            this.buttonListboxSelectedCriteriaOneStepBelow.Location = new System.Drawing.Point(411, 67);
            this.buttonListboxSelectedCriteriaOneStepBelow.Name = "buttonListboxSelectedCriteriaOneStepBelow";
            this.buttonListboxSelectedCriteriaOneStepBelow.Size = new System.Drawing.Size(120, 23);
            this.buttonListboxSelectedCriteriaOneStepBelow.TabIndex = 8;
            this.buttonListboxSelectedCriteriaOneStepBelow.Text = "Ниже";
            this.buttonListboxSelectedCriteriaOneStepBelow.UseVisualStyleBackColor = true;
            this.buttonListboxSelectedCriteriaOneStepBelow.Visible = false;
            this.buttonListboxSelectedCriteriaOneStepBelow.Click += new System.EventHandler(this.buttonListboxSelectedCriteriaOneStepBelow_Click);
            // 
            // SelectSupplier
            // 
            this.AcceptButton = this.buttonSelectionOfTheSupplier;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonBackToFormEditProject;
            this.ClientSize = new System.Drawing.Size(682, 686);
            this.Controls.Add(this.buttonListboxSelectedCriteriaOneStepBelow);
            this.Controls.Add(this.buttonBackToFormEditProject);
            this.Controls.Add(this.buttonListboxSelectedCriteriaOneStepHigher);
            this.Controls.Add(this.groupBoxCriteriaOfTheSelection);
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
            this.groupBoxCriteriaOfTheSelection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddСriterion;
        private System.Windows.Forms.Button buttonRemoveCriterion;
        private System.Windows.Forms.ListBox listBoxAllCriteria;
        private System.Windows.Forms.ListBox listBoxSelectedCriteria;
        private System.Windows.Forms.Button buttonSelectionOfTheSupplier;
        private System.Windows.Forms.Button buttonBackToFormEditProject;
        private System.Windows.Forms.GroupBox groupBoxCriteriaOfTheSelection;
        private System.Windows.Forms.Button buttonListboxSelectedCriteriaOneStepBelow;
        private System.Windows.Forms.Button buttonListboxSelectedCriteriaOneStepHigher;
    }
}