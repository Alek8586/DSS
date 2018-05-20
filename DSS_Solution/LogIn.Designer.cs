namespace DSS
{
    partial class FormLogIn
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            this.textBoxLogInUsername = new System.Windows.Forms.TextBox();
            this.textBoxLogInPassword = new System.Windows.Forms.TextBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelUsernamePassword = new System.Windows.Forms.Label();
            this.buttonSetPassword = new System.Windows.Forms.Button();
            this.buttonHardReset = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LabelConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripConnectionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLogInUsername
            // 
            this.textBoxLogInUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxLogInUsername.Location = new System.Drawing.Point(21, 132);
            this.textBoxLogInUsername.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxLogInUsername.Name = "textBoxLogInUsername";
            this.textBoxLogInUsername.Size = new System.Drawing.Size(163, 21);
            this.textBoxLogInUsername.TabIndex = 1;
            // 
            // textBoxLogInPassword
            // 
            this.textBoxLogInPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxLogInPassword.Location = new System.Drawing.Point(196, 132);
            this.textBoxLogInPassword.Margin = new System.Windows.Forms.Padding(6, 23, 6, 6);
            this.textBoxLogInPassword.Name = "textBoxLogInPassword";
            this.textBoxLogInPassword.PasswordChar = '*';
            this.textBoxLogInPassword.Size = new System.Drawing.Size(163, 21);
            this.textBoxLogInPassword.TabIndex = 2;
            this.textBoxLogInPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Location = new System.Drawing.Point(21, 165);
            this.buttonLogIn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 29);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(163, 29);
            this.buttonLogIn.TabIndex = 3;
            this.buttonLogIn.Text = "Вход";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(196, 165);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 29);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(163, 29);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Выход из системы";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelUsernamePassword
            // 
            this.labelUsernamePassword.AutoSize = true;
            this.labelUsernamePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsernamePassword.Location = new System.Drawing.Point(65, 93);
            this.labelUsernamePassword.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.labelUsernamePassword.Name = "labelUsernamePassword";
            this.labelUsernamePassword.Size = new System.Drawing.Size(248, 16);
            this.labelUsernamePassword.TabIndex = 0;
            this.labelUsernamePassword.Text = "Введите имя пользователя и пароль";
            this.labelUsernamePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSetPassword
            // 
            this.buttonSetPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSetPassword.Location = new System.Drawing.Point(21, 264);
            this.buttonSetPassword.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSetPassword.Name = "buttonSetPassword";
            this.buttonSetPassword.Size = new System.Drawing.Size(210, 29);
            this.buttonSetPassword.TabIndex = 5;
            this.buttonSetPassword.Text = "Задать пароль пользователю";
            this.buttonSetPassword.UseVisualStyleBackColor = true;
            this.buttonSetPassword.Click += new System.EventHandler(this.buttonSetPassword_Click);
            // 
            // buttonHardReset
            // 
            this.buttonHardReset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonHardReset.Location = new System.Drawing.Point(272, 264);
            this.buttonHardReset.Margin = new System.Windows.Forms.Padding(6);
            this.buttonHardReset.Name = "buttonHardReset";
            this.buttonHardReset.Size = new System.Drawing.Size(87, 29);
            this.buttonHardReset.TabIndex = 6;
            this.buttonHardReset.Text = "Сброс";
            this.buttonHardReset.UseVisualStyleBackColor = true;
            this.buttonHardReset.Click += new System.EventHandler(this.buttonHardReset_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelConnectionStatus,
            this.toolStripConnectionStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(-1, 299);
            this.statusStrip1.MinimumSize = new System.Drawing.Size(25, 25);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(50, 25);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LabelConnectionStatus
            // 
            this.LabelConnectionStatus.Name = "LabelConnectionStatus";
            this.LabelConnectionStatus.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripConnectionStatusLabel
            // 
            this.toolStripConnectionStatusLabel.Name = "toolStripConnectionStatusLabel";
            this.toolStripConnectionStatusLabel.Size = new System.Drawing.Size(0, 20);
            // 
            // FormLogIn
            // 
            this.AcceptButton = this.buttonLogIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(401, 325);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonSetPassword);
            this.Controls.Add(this.labelUsernamePassword);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.textBoxLogInPassword);
            this.Controls.Add(this.textBoxLogInUsername);
            this.Controls.Add(this.buttonHardReset);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLogIn";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добро пожаловать";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogIn_FormClosed);
            this.Load += new System.EventHandler(this.FormLogIn_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxLogInUsername;
        private System.Windows.Forms.TextBox textBoxLogInPassword;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelUsernamePassword;
        private System.Windows.Forms.Button buttonSetPassword;
        private System.Windows.Forms.Button buttonHardReset;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LabelConnectionStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripConnectionStatusLabel;
    }
}

