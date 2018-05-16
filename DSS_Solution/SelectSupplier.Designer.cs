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
            this.listBoxSelectedCriterions = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonAddСriterion
            // 
            this.buttonAddСriterion.Location = new System.Drawing.Point(144, 20);
            this.buttonAddСriterion.Name = "buttonAddСriterion";
            this.buttonAddСriterion.Size = new System.Drawing.Size(120, 23);
            this.buttonAddСriterion.TabIndex = 1;
            this.buttonAddСriterion.Text = "Добавить >>";
            this.buttonAddСriterion.UseVisualStyleBackColor = true;
            this.buttonAddСriterion.Click += new System.EventHandler(this.buttonAddСriterion_Click);
            // 
            // buttonRemoveCriterion
            // 
            this.buttonRemoveCriterion.Location = new System.Drawing.Point(144, 49);
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
            this.listBoxAllCriterions.Location = new System.Drawing.Point(18, 19);
            this.listBoxAllCriterions.Name = "listBoxAllCriterions";
            this.listBoxAllCriterions.Size = new System.Drawing.Size(120, 154);
            this.listBoxAllCriterions.Sorted = true;
            this.listBoxAllCriterions.TabIndex = 0;
            // 
            // listBoxSelectedCriterions
            // 
            this.listBoxSelectedCriterions.FormattingEnabled = true;
            this.listBoxSelectedCriterions.ItemHeight = 15;
            this.listBoxSelectedCriterions.Location = new System.Drawing.Point(270, 19);
            this.listBoxSelectedCriterions.Name = "listBoxSelectedCriterions";
            this.listBoxSelectedCriterions.Size = new System.Drawing.Size(120, 154);
            this.listBoxSelectedCriterions.TabIndex = 3;
            // 
            // SelectSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(994, 686);
            this.Controls.Add(this.listBoxSelectedCriterions);
            this.Controls.Add(this.listBoxAllCriterions);
            this.Controls.Add(this.buttonRemoveCriterion);
            this.Controls.Add(this.buttonAddСriterion);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddСriterion;
        private System.Windows.Forms.Button buttonRemoveCriterion;
        private System.Windows.Forms.ListBox listBoxAllCriterions;
        private System.Windows.Forms.ListBox listBoxSelectedCriterions;
    }
}