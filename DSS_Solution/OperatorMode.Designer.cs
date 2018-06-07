namespace DSS
{
    partial class OperatorMode
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonToSuppliersForm = new System.Windows.Forms.Button();
            this.buttonProjects = new System.Windows.Forms.Button();
            this.buttonToLogInForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(251, 172);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(150, 25);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Выход из системы";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonToSuppliersForm
            // 
            this.buttonToSuppliersForm.Location = new System.Drawing.Point(18, 18);
            this.buttonToSuppliersForm.Name = "buttonToSuppliersForm";
            this.buttonToSuppliersForm.Size = new System.Drawing.Size(200, 40);
            this.buttonToSuppliersForm.TabIndex = 2;
            this.buttonToSuppliersForm.Text = "Поставщики";
            this.buttonToSuppliersForm.UseVisualStyleBackColor = true;
            this.buttonToSuppliersForm.Click += new System.EventHandler(this.buttonToSuplliersForm_Click);
            // 
            // buttonProjects
            // 
            this.buttonProjects.Location = new System.Drawing.Point(18, 64);
            this.buttonProjects.Name = "buttonProjects";
            this.buttonProjects.Size = new System.Drawing.Size(200, 40);
            this.buttonProjects.TabIndex = 3;
            this.buttonProjects.Text = "Проекты";
            this.buttonProjects.UseVisualStyleBackColor = true;
            this.buttonProjects.Click += new System.EventHandler(this.buttonProjects_Click);
            // 
            // buttonToLogInForm
            // 
            this.buttonToLogInForm.Location = new System.Drawing.Point(251, 141);
            this.buttonToLogInForm.Name = "buttonToLogInForm";
            this.buttonToLogInForm.Size = new System.Drawing.Size(150, 25);
            this.buttonToLogInForm.TabIndex = 6;
            this.buttonToLogInForm.Text = "Сменить пользователя";
            this.buttonToLogInForm.UseVisualStyleBackColor = true;
            this.buttonToLogInForm.Click += new System.EventHandler(this.buttonToLogInForm_Click);
            // 
            // OperatorMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(475, 215);
            this.Controls.Add(this.buttonToLogInForm);
            this.Controls.Add(this.buttonProjects);
            this.Controls.Add(this.buttonToSuppliersForm);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OperatorMode";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель оператора";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOperatorMode_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonToSuppliersForm;
        private System.Windows.Forms.Button buttonProjects;
        private System.Windows.Forms.Button buttonToLogInForm;
    }
}