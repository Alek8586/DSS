namespace DSS
{
    partial class SettingUserPassword
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
            this.labelCurrentPassword = new System.Windows.Forms.Label();
            this.textBoxCurrentPassword = new System.Windows.Forms.TextBox();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.labelConfirmNewPassword = new System.Windows.Forms.Label();
            this.textBoxConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.buttonSetNewPassword = new System.Windows.Forms.Button();
            this.buttonCancelSetNewPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCurrentPassword
            // 
            this.labelCurrentPassword.AutoSize = true;
            this.labelCurrentPassword.Location = new System.Drawing.Point(18, 15);
            this.labelCurrentPassword.Name = "labelCurrentPassword";
            this.labelCurrentPassword.Size = new System.Drawing.Size(97, 15);
            this.labelCurrentPassword.TabIndex = 0;
            this.labelCurrentPassword.Text = "Старый пароль";
            // 
            // textBoxCurrentPassword
            // 
            this.textBoxCurrentPassword.Location = new System.Drawing.Point(18, 33);
            this.textBoxCurrentPassword.Name = "textBoxCurrentPassword";
            this.textBoxCurrentPassword.Size = new System.Drawing.Size(150, 21);
            this.textBoxCurrentPassword.TabIndex = 1;
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Location = new System.Drawing.Point(18, 70);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(91, 15);
            this.labelNewPassword.TabIndex = 2;
            this.labelNewPassword.Text = "Новый пароль";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(18, 88);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(150, 21);
            this.textBoxNewPassword.TabIndex = 3;
            // 
            // labelConfirmNewPassword
            // 
            this.labelConfirmNewPassword.AutoSize = true;
            this.labelConfirmNewPassword.Location = new System.Drawing.Point(18, 120);
            this.labelConfirmNewPassword.Name = "labelConfirmNewPassword";
            this.labelConfirmNewPassword.Size = new System.Drawing.Size(190, 15);
            this.labelConfirmNewPassword.TabIndex = 4;
            this.labelConfirmNewPassword.Text = "Подтверждение нового пароля";
            // 
            // textBoxConfirmNewPassword
            // 
            this.textBoxConfirmNewPassword.Location = new System.Drawing.Point(18, 138);
            this.textBoxConfirmNewPassword.Name = "textBoxConfirmNewPassword";
            this.textBoxConfirmNewPassword.Size = new System.Drawing.Size(150, 21);
            this.textBoxConfirmNewPassword.TabIndex = 5;
            // 
            // buttonSetNewPassword
            // 
            this.buttonSetNewPassword.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSetNewPassword.Location = new System.Drawing.Point(18, 165);
            this.buttonSetNewPassword.Name = "buttonSetNewPassword";
            this.buttonSetNewPassword.Size = new System.Drawing.Size(150, 25);
            this.buttonSetNewPassword.TabIndex = 6;
            this.buttonSetNewPassword.Text = "Задать новый пароль";
            this.buttonSetNewPassword.UseVisualStyleBackColor = true;
            this.buttonSetNewPassword.Click += new System.EventHandler(this.buttonSetNewPassword_Click);
            // 
            // buttonCancelSetNewPassword
            // 
            this.buttonCancelSetNewPassword.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelSetNewPassword.Location = new System.Drawing.Point(174, 165);
            this.buttonCancelSetNewPassword.Name = "buttonCancelSetNewPassword";
            this.buttonCancelSetNewPassword.Size = new System.Drawing.Size(150, 25);
            this.buttonCancelSetNewPassword.TabIndex = 7;
            this.buttonCancelSetNewPassword.Text = "Отмена";
            this.buttonCancelSetNewPassword.UseVisualStyleBackColor = true;
            this.buttonCancelSetNewPassword.Click += new System.EventHandler(this.buttonCancelSetNewPassword_Click);
            // 
            // SettingUserPassword
            // 
            this.AcceptButton = this.buttonSetNewPassword;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonCancelSetNewPassword;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancelSetNewPassword);
            this.Controls.Add(this.buttonSetNewPassword);
            this.Controls.Add(this.textBoxConfirmNewPassword);
            this.Controls.Add(this.labelConfirmNewPassword);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.labelNewPassword);
            this.Controls.Add(this.textBoxCurrentPassword);
            this.Controls.Add(this.labelCurrentPassword);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "SettingUserPassword";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Установка пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentPassword;
        private System.Windows.Forms.TextBox textBoxCurrentPassword;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Label labelConfirmNewPassword;
        private System.Windows.Forms.TextBox textBoxConfirmNewPassword;
        private System.Windows.Forms.Button buttonSetNewPassword;
        private System.Windows.Forms.Button buttonCancelSetNewPassword;
    }
}