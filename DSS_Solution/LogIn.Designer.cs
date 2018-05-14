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
            resources.ApplyResources(this.textBoxLogInUsername, "textBoxLogInUsername");
            this.textBoxLogInUsername.Name = "textBoxLogInUsername";
            // 
            // textBoxLogInPassword
            // 
            resources.ApplyResources(this.textBoxLogInPassword, "textBoxLogInPassword");
            this.textBoxLogInPassword.Name = "textBoxLogInPassword";
            this.textBoxLogInPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogIn
            // 
            resources.ApplyResources(this.buttonLogIn, "buttonLogIn");
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.buttonExit, "buttonExit");
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelUsernamePassword
            // 
            resources.ApplyResources(this.labelUsernamePassword, "labelUsernamePassword");
            this.labelUsernamePassword.Name = "labelUsernamePassword";
            // 
            // buttonSetPassword
            // 
            resources.ApplyResources(this.buttonSetPassword, "buttonSetPassword");
            this.buttonSetPassword.Name = "buttonSetPassword";
            this.buttonSetPassword.UseVisualStyleBackColor = true;
            this.buttonSetPassword.Click += new System.EventHandler(this.buttonSetPassword_Click);
            // 
            // buttonHardReset
            // 
            resources.ApplyResources(this.buttonHardReset, "buttonHardReset");
            this.buttonHardReset.Name = "buttonHardReset";
            this.buttonHardReset.UseVisualStyleBackColor = true;
            this.buttonHardReset.Click += new System.EventHandler(this.buttonHardReset_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelConnectionStatus,
            this.toolStripConnectionStatusLabel});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // LabelConnectionStatus
            // 
            this.LabelConnectionStatus.Name = "LabelConnectionStatus";
            resources.ApplyResources(this.LabelConnectionStatus, "LabelConnectionStatus");
            // 
            // toolStripConnectionStatusLabel
            // 
            this.toolStripConnectionStatusLabel.Name = "toolStripConnectionStatusLabel";
            resources.ApplyResources(this.toolStripConnectionStatusLabel, "toolStripConnectionStatusLabel");
            // 
            // FormLogIn
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonSetPassword);
            this.Controls.Add(this.labelUsernamePassword);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.textBoxLogInPassword);
            this.Controls.Add(this.textBoxLogInUsername);
            this.Controls.Add(this.buttonHardReset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLogIn";
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

