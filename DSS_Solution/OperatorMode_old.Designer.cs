namespace DSS
{
    partial class OperatorMode_old
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
            this.buttonOperatorExit = new System.Windows.Forms.Button();
            this.buttonProjects = new System.Windows.Forms.Button();
            this.buttonToSuppliersForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOperatorExit
            // 
            this.buttonOperatorExit.Location = new System.Drawing.Point(69, 144);
            this.buttonOperatorExit.Name = "buttonOperatorExit";
            this.buttonOperatorExit.Size = new System.Drawing.Size(140, 23);
            this.buttonOperatorExit.TabIndex = 4;
            this.buttonOperatorExit.Text = "Выход из системы";
            this.buttonOperatorExit.UseVisualStyleBackColor = true;
            // 
            // buttonProjects
            // 
            this.buttonProjects.Location = new System.Drawing.Point(9, 50);
            this.buttonProjects.Name = "buttonProjects";
            this.buttonProjects.Size = new System.Drawing.Size(200, 30);
            this.buttonProjects.TabIndex = 9;
            this.buttonProjects.Text = "Проекты";
            this.buttonProjects.UseVisualStyleBackColor = true;
            // 
            // buttonToSuppliersForm
            // 
            this.buttonToSuppliersForm.Location = new System.Drawing.Point(9, 11);
            this.buttonToSuppliersForm.Name = "buttonToSuppliersForm";
            this.buttonToSuppliersForm.Size = new System.Drawing.Size(200, 30);
            this.buttonToSuppliersForm.TabIndex = 8;
            this.buttonToSuppliersForm.Text = "Поставщики";
            this.buttonToSuppliersForm.UseVisualStyleBackColor = true;
            // 
            // FormOperatorMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 177);
            this.Controls.Add(this.buttonProjects);
            this.Controls.Add(this.buttonToSuppliersForm);
            this.Controls.Add(this.buttonOperatorExit);
            this.MaximizeBox = false;
            this.Name = "FormOperatorMode";
            this.ShowIcon = false;
            this.Text = "Панель оператора";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonOperatorExit;
        private System.Windows.Forms.Button buttonProjects;
        private System.Windows.Forms.Button buttonToSuppliersForm;
    }
}