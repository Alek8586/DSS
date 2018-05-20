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
            this.ClassNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MaterialQualityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TimeOfDeliveryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ReliabilityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxCriteriaOfTheSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialQualityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeOfDeliveryNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReliabilityNumericUpDown)).BeginInit();
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
            // ClassNumericUpDown
            // 
            this.ClassNumericUpDown.Location = new System.Drawing.Point(138, 244);
            this.ClassNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ClassNumericUpDown.Name = "ClassNumericUpDown";
            this.ClassNumericUpDown.Size = new System.Drawing.Size(37, 21);
            this.ClassNumericUpDown.TabIndex = 9;
            // 
            // PriceNumericUpDown
            // 
            this.PriceNumericUpDown.Location = new System.Drawing.Point(138, 298);
            this.PriceNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PriceNumericUpDown.Name = "PriceNumericUpDown";
            this.PriceNumericUpDown.Size = new System.Drawing.Size(37, 21);
            this.PriceNumericUpDown.TabIndex = 10;
            // 
            // MaterialQualityNumericUpDown
            // 
            this.MaterialQualityNumericUpDown.Location = new System.Drawing.Point(138, 271);
            this.MaterialQualityNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MaterialQualityNumericUpDown.Name = "MaterialQualityNumericUpDown";
            this.MaterialQualityNumericUpDown.Size = new System.Drawing.Size(37, 21);
            this.MaterialQualityNumericUpDown.TabIndex = 11;
            // 
            // TimeOfDeliveryNumericUpDown
            // 
            this.TimeOfDeliveryNumericUpDown.Location = new System.Drawing.Point(138, 325);
            this.TimeOfDeliveryNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TimeOfDeliveryNumericUpDown.Name = "TimeOfDeliveryNumericUpDown";
            this.TimeOfDeliveryNumericUpDown.Size = new System.Drawing.Size(37, 21);
            this.TimeOfDeliveryNumericUpDown.TabIndex = 12;
            // 
            // ReliabilityNumericUpDown
            // 
            this.ReliabilityNumericUpDown.Location = new System.Drawing.Point(138, 352);
            this.ReliabilityNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ReliabilityNumericUpDown.Name = "ReliabilityNumericUpDown";
            this.ReliabilityNumericUpDown.Size = new System.Drawing.Size(37, 21);
            this.ReliabilityNumericUpDown.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "MaterialQuality";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "TimeOfDelivery";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Reliability";
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
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReliabilityNumericUpDown);
            this.Controls.Add(this.TimeOfDeliveryNumericUpDown);
            this.Controls.Add(this.MaterialQualityNumericUpDown);
            this.Controls.Add(this.PriceNumericUpDown);
            this.Controls.Add(this.ClassNumericUpDown);
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
            ((System.ComponentModel.ISupportInitialize)(this.ClassNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialQualityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeOfDeliveryNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReliabilityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.NumericUpDown ClassNumericUpDown;
        private System.Windows.Forms.NumericUpDown PriceNumericUpDown;
        private System.Windows.Forms.NumericUpDown MaterialQualityNumericUpDown;
        private System.Windows.Forms.NumericUpDown TimeOfDeliveryNumericUpDown;
        private System.Windows.Forms.NumericUpDown ReliabilityNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}