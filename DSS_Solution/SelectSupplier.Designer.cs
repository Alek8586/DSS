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
            this.listBoxAllCriterions = new System.Windows.Forms.ListBox();
            this.listBoxSelectedCriteria = new System.Windows.Forms.ListBox();
            this.buttonSelectionOfTheSupplier = new System.Windows.Forms.Button();
            this.buttonBackToFormEditProject = new System.Windows.Forms.Button();
            this.groupBoxCriteriaOfTheSelection = new System.Windows.Forms.GroupBox();
            this.groupBoxCriteriaOfTheSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddСriterion
            // 
            this.buttonAddСriterion.Location = new System.Drawing.Point(132, 20);
            this.buttonAddСriterion.Name = "buttonAddСriterion";
            this.buttonAddСriterion.Size = new System.Drawing.Size(120, 23);
            this.buttonAddСriterion.TabIndex = 1;
            this.buttonAddСriterion.Text = "Добавить >>";
            this.buttonAddСriterion.UseVisualStyleBackColor = true;
            this.buttonAddСriterion.Click += new System.EventHandler(this.buttonAddСriterion_Click);
            // 
            // buttonRemoveCriterion
            // 
            this.buttonRemoveCriterion.Location = new System.Drawing.Point(132, 49);
            this.buttonRemoveCriterion.Name = "buttonRemoveCriterion";
            this.buttonRemoveCriterion.Size = new System.Drawing.Size(120, 23);
            this.buttonRemoveCriterion.TabIndex = 2;
            this.buttonRemoveCriterion.Text = "<< Удалить";
            this.buttonRemoveCriterion.UseVisualStyleBackColor = true;
            this.buttonRemoveCriterion.Click += new System.EventHandler(this.buttonRemoveCriterion_Click);
            // 
            // listBoxAllCriterions
            // 
            this.listBoxAllCriterions.FormattingEnabled = true;
            this.listBoxAllCriterions.ItemHeight = 15;
            this.listBoxAllCriterions.Location = new System.Drawing.Point(6, 20);
            this.listBoxAllCriterions.Name = "listBoxAllCriterions";
            this.listBoxAllCriterions.Size = new System.Drawing.Size(120, 154);
            this.listBoxAllCriterions.Sorted = true;
            this.listBoxAllCriterions.TabIndex = 0;
            // 
            // listBoxSelectedCriteria
            // 
            this.listBoxSelectedCriteria.FormattingEnabled = true;
            this.listBoxSelectedCriteria.ItemHeight = 15;
            this.listBoxSelectedCriteria.Location = new System.Drawing.Point(258, 20);
            this.listBoxSelectedCriteria.Name = "listBoxSelectedCriteria";
            this.listBoxSelectedCriteria.Size = new System.Drawing.Size(120, 154);
            this.listBoxSelectedCriteria.TabIndex = 3;
            // 
            // buttonSelectionOfTheSupplier
            // 
            this.buttonSelectionOfTheSupplier.Location = new System.Drawing.Point(6, 180);
            this.buttonSelectionOfTheSupplier.Name = "buttonSelectionOfTheSupplier";
            this.buttonSelectionOfTheSupplier.Size = new System.Drawing.Size(372, 23);
            this.buttonSelectionOfTheSupplier.TabIndex = 4;
            this.buttonSelectionOfTheSupplier.Text = "Произвести подбор поставщика";
            this.buttonSelectionOfTheSupplier.UseVisualStyleBackColor = true;
            this.buttonSelectionOfTheSupplier.Click += new System.EventHandler(this.buttonSelectionOfTheSupplier_Click);
            // 
            // buttonBackToFormEditProject
            // 
            this.buttonBackToFormEditProject.Location = new System.Drawing.Point(276, 234);
            this.buttonBackToFormEditProject.Name = "buttonBackToFormEditProject";
            this.buttonBackToFormEditProject.Size = new System.Drawing.Size(120, 25);
            this.buttonBackToFormEditProject.TabIndex = 5;
            this.buttonBackToFormEditProject.Text = "Назад";
            this.buttonBackToFormEditProject.UseVisualStyleBackColor = true;
            this.buttonBackToFormEditProject.Click += new System.EventHandler(this.buttonBackToFormEditProject_Click);
            // 
            // groupBoxCriteriaOfTheSelection
            // 
            this.groupBoxCriteriaOfTheSelection.Controls.Add(this.listBoxAllCriterions);
            this.groupBoxCriteriaOfTheSelection.Controls.Add(this.buttonAddСriterion);
            this.groupBoxCriteriaOfTheSelection.Controls.Add(this.buttonSelectionOfTheSupplier);
            this.groupBoxCriteriaOfTheSelection.Controls.Add(this.listBoxSelectedCriteria);
            this.groupBoxCriteriaOfTheSelection.Controls.Add(this.buttonRemoveCriterion);
            this.groupBoxCriteriaOfTheSelection.Location = new System.Drawing.Point(18, 18);
            this.groupBoxCriteriaOfTheSelection.Name = "groupBoxCriteriaOfTheSelection";
            this.groupBoxCriteriaOfTheSelection.Size = new System.Drawing.Size(384, 210);
            this.groupBoxCriteriaOfTheSelection.TabIndex = 6;
            this.groupBoxCriteriaOfTheSelection.TabStop = false;
            this.groupBoxCriteriaOfTheSelection.Text = "Критерии подбора";
            // 
            // SelectSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(682, 686);
            this.Controls.Add(this.buttonBackToFormEditProject);
            this.Controls.Add(this.groupBoxCriteriaOfTheSelection);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
        private System.Windows.Forms.ListBox listBoxAllCriterions;
        private System.Windows.Forms.ListBox listBoxSelectedCriteria;
        private System.Windows.Forms.Button buttonSelectionOfTheSupplier;
        private System.Windows.Forms.Button buttonBackToFormEditProject;
        private System.Windows.Forms.GroupBox groupBoxCriteriaOfTheSelection;
    }
}