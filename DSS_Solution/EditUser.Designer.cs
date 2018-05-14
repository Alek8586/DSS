namespace DSS
{
    partial class EditUser
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
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.textBoxUserLogin = new System.Windows.Forms.TextBox();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.labelUserRole = new System.Windows.Forms.Label();
            this.comboBoxUserRole = new System.Windows.Forms.ComboBox();
            this.labelUserPost = new System.Windows.Forms.Label();
            this.textBoxUserPost = new System.Windows.Forms.TextBox();
            this.labelUserFullname = new System.Windows.Forms.Label();
            this.textBoxUserFullname = new System.Windows.Forms.TextBox();
            this.labelUserEtc = new System.Windows.Forms.Label();
            this.textBoxUserEtc = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSaveAndClose = new System.Windows.Forms.Button();
            this.buttonBackToUsersForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.AutoSize = true;
            this.labelUserLogin.Location = new System.Drawing.Point(18, 15);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(118, 15);
            this.labelUserLogin.TabIndex = 0;
            this.labelUserLogin.Text = "Имя пользователя";
            // 
            // textBoxUserLogin
            // 
            this.textBoxUserLogin.Location = new System.Drawing.Point(21, 33);
            this.textBoxUserLogin.Name = "textBoxUserLogin";
            this.textBoxUserLogin.Size = new System.Drawing.Size(100, 21);
            this.textBoxUserLogin.TabIndex = 1;
            this.textBoxUserLogin.WordWrap = false;
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Location = new System.Drawing.Point(18, 57);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(161, 15);
            this.labelUserPassword.TabIndex = 2;
            this.labelUserPassword.Text = "Пароль для пользователя";
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Location = new System.Drawing.Point(21, 75);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(100, 21);
            this.textBoxUserPassword.TabIndex = 3;
            // 
            // labelUserRole
            // 
            this.labelUserRole.AutoSize = true;
            this.labelUserRole.Location = new System.Drawing.Point(18, 99);
            this.labelUserRole.Name = "labelUserRole";
            this.labelUserRole.Size = new System.Drawing.Size(93, 15);
            this.labelUserRole.TabIndex = 4;
            this.labelUserRole.Text = "Права доступа";
            // 
            // comboBoxUserRole
            // 
            this.comboBoxUserRole.FormattingEnabled = true;
            this.comboBoxUserRole.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxUserRole.Location = new System.Drawing.Point(21, 117);
            this.comboBoxUserRole.Name = "comboBoxUserRole";
            this.comboBoxUserRole.Size = new System.Drawing.Size(121, 23);
            this.comboBoxUserRole.TabIndex = 5;
            // 
            // labelUserPost
            // 
            this.labelUserPost.AutoSize = true;
            this.labelUserPost.Location = new System.Drawing.Point(18, 143);
            this.labelUserPost.Name = "labelUserPost";
            this.labelUserPost.Size = new System.Drawing.Size(73, 15);
            this.labelUserPost.TabIndex = 6;
            this.labelUserPost.Text = "Должность";
            // 
            // textBoxUserPost
            // 
            this.textBoxUserPost.Location = new System.Drawing.Point(21, 161);
            this.textBoxUserPost.Name = "textBoxUserPost";
            this.textBoxUserPost.Size = new System.Drawing.Size(100, 21);
            this.textBoxUserPost.TabIndex = 7;
            // 
            // labelUserFullname
            // 
            this.labelUserFullname.AutoSize = true;
            this.labelUserFullname.Location = new System.Drawing.Point(18, 185);
            this.labelUserFullname.Name = "labelUserFullname";
            this.labelUserFullname.Size = new System.Drawing.Size(163, 15);
            this.labelUserFullname.TabIndex = 8;
            this.labelUserFullname.Text = "Полное имя пользователя";
            // 
            // textBoxUserFullname
            // 
            this.textBoxUserFullname.Location = new System.Drawing.Point(21, 203);
            this.textBoxUserFullname.Name = "textBoxUserFullname";
            this.textBoxUserFullname.Size = new System.Drawing.Size(100, 21);
            this.textBoxUserFullname.TabIndex = 9;
            // 
            // labelUserEtc
            // 
            this.labelUserEtc.AutoSize = true;
            this.labelUserEtc.Location = new System.Drawing.Point(18, 227);
            this.labelUserEtc.Name = "labelUserEtc";
            this.labelUserEtc.Size = new System.Drawing.Size(50, 15);
            this.labelUserEtc.TabIndex = 10;
            this.labelUserEtc.Text = "Прочее";
            // 
            // textBoxUserEtc
            // 
            this.textBoxUserEtc.Location = new System.Drawing.Point(21, 245);
            this.textBoxUserEtc.Name = "textBoxUserEtc";
            this.textBoxUserEtc.Size = new System.Drawing.Size(100, 21);
            this.textBoxUserEtc.TabIndex = 11;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(325, 18);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(106, 23);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSaveAndClose
            // 
            this.buttonSaveAndClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSaveAndClose.Location = new System.Drawing.Point(325, 47);
            this.buttonSaveAndClose.Name = "buttonSaveAndClose";
            this.buttonSaveAndClose.Size = new System.Drawing.Size(106, 49);
            this.buttonSaveAndClose.TabIndex = 13;
            this.buttonSaveAndClose.Text = "Сохранить и закрыть";
            this.buttonSaveAndClose.UseVisualStyleBackColor = true;
            this.buttonSaveAndClose.Click += new System.EventHandler(this.buttonSaveAndClose_Click);
            // 
            // buttonBackToUsersForm
            // 
            this.buttonBackToUsersForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonBackToUsersForm.Location = new System.Drawing.Point(325, 102);
            this.buttonBackToUsersForm.Name = "buttonBackToUsersForm";
            this.buttonBackToUsersForm.Size = new System.Drawing.Size(106, 23);
            this.buttonBackToUsersForm.TabIndex = 14;
            this.buttonBackToUsersForm.Text = "Закрыть";
            this.buttonBackToUsersForm.UseVisualStyleBackColor = true;
            this.buttonBackToUsersForm.Click += new System.EventHandler(this.buttonBackToUsersForm_Click);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonBackToUsersForm;
            this.ClientSize = new System.Drawing.Size(449, 287);
            this.Controls.Add(this.buttonBackToUsersForm);
            this.Controls.Add(this.buttonSaveAndClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxUserEtc);
            this.Controls.Add(this.labelUserEtc);
            this.Controls.Add(this.textBoxUserFullname);
            this.Controls.Add(this.labelUserFullname);
            this.Controls.Add(this.textBoxUserPost);
            this.Controls.Add(this.labelUserPost);
            this.Controls.Add(this.comboBoxUserRole);
            this.Controls.Add(this.labelUserRole);
            this.Controls.Add(this.textBoxUserPassword);
            this.Controls.Add(this.labelUserPassword);
            this.Controls.Add(this.textBoxUserLogin);
            this.Controls.Add(this.labelUserLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "EditUser";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные о пользователе";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.TextBox textBoxUserLogin;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.Label labelUserRole;
        private System.Windows.Forms.ComboBox comboBoxUserRole;
        private System.Windows.Forms.Label labelUserPost;
        private System.Windows.Forms.TextBox textBoxUserPost;
        private System.Windows.Forms.Label labelUserFullname;
        private System.Windows.Forms.TextBox textBoxUserFullname;
        private System.Windows.Forms.Label labelUserEtc;
        private System.Windows.Forms.TextBox textBoxUserEtc;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSaveAndClose;
        private System.Windows.Forms.Button buttonBackToUsersForm;
    }
}