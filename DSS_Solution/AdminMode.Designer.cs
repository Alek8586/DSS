namespace DSS
{
    partial class AdminMode
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
            this.buttonBackupDB = new System.Windows.Forms.Button();
            this.buttonRestoreDB = new System.Windows.Forms.Button();
            this.buttonToUsersForm = new System.Windows.Forms.Button();
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
            // buttonBackupDB
            // 
            this.buttonBackupDB.Location = new System.Drawing.Point(251, 18);
            this.buttonBackupDB.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.buttonBackupDB.Name = "buttonBackupDB";
            this.buttonBackupDB.Size = new System.Drawing.Size(150, 40);
            this.buttonBackupDB.TabIndex = 4;
            this.buttonBackupDB.Text = "Резервное копирование ДБ";
            this.buttonBackupDB.UseVisualStyleBackColor = true;
            this.buttonBackupDB.Click += new System.EventHandler(this.buttonBackupDB_Click);
            // 
            // buttonRestoreDB
            // 
            this.buttonRestoreDB.Location = new System.Drawing.Point(251, 64);
            this.buttonRestoreDB.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.buttonRestoreDB.Name = "buttonRestoreDB";
            this.buttonRestoreDB.Size = new System.Drawing.Size(150, 40);
            this.buttonRestoreDB.TabIndex = 5;
            this.buttonRestoreDB.Text = "Восстановаление ДБ";
            this.buttonRestoreDB.UseVisualStyleBackColor = true;
            this.buttonRestoreDB.Click += new System.EventHandler(this.buttonRestoreDB_Click);
            // 
            // buttonToUsersForm
            // 
            this.buttonToUsersForm.Location = new System.Drawing.Point(18, 18);
            this.buttonToUsersForm.Name = "buttonToUsersForm";
            this.buttonToUsersForm.Size = new System.Drawing.Size(200, 40);
            this.buttonToUsersForm.TabIndex = 0;
            this.buttonToUsersForm.Text = "Пользователи";
            this.buttonToUsersForm.UseVisualStyleBackColor = true;
            this.buttonToUsersForm.Click += new System.EventHandler(this.buttonToUsersForm_Click);
            // 
            // buttonToSuppliersForm
            // 
            this.buttonToSuppliersForm.Location = new System.Drawing.Point(18, 64);
            this.buttonToSuppliersForm.Name = "buttonToSuppliersForm";
            this.buttonToSuppliersForm.Size = new System.Drawing.Size(200, 40);
            this.buttonToSuppliersForm.TabIndex = 2;
            this.buttonToSuppliersForm.Text = "Поставщики";
            this.buttonToSuppliersForm.UseVisualStyleBackColor = true;
            this.buttonToSuppliersForm.Click += new System.EventHandler(this.buttonToSuplliersForm_Click);
            // 
            // buttonProjects
            // 
            this.buttonProjects.Location = new System.Drawing.Point(18, 110);
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
            // AdminMode
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(475, 215);
            this.Controls.Add(this.buttonToLogInForm);
            this.Controls.Add(this.buttonProjects);
            this.Controls.Add(this.buttonToSuppliersForm);
            this.Controls.Add(this.buttonToUsersForm);
            this.Controls.Add(this.buttonRestoreDB);
            this.Controls.Add(this.buttonBackupDB);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminMode";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель администратора";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdminMode_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonBackupDB;
        private System.Windows.Forms.Button buttonRestoreDB;
        private System.Windows.Forms.Button buttonToUsersForm;
        private System.Windows.Forms.Button buttonToSuppliersForm;
        private System.Windows.Forms.Button buttonProjects;
        private System.Windows.Forms.Button buttonToLogInForm;
    }
}