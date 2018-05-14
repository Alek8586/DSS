namespace DSS
{
    partial class Projects
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
            this.labelProject = new System.Windows.Forms.Label();
            this.comboBoxSelectProject = new System.Windows.Forms.ComboBox();
            this.labelMailContract = new System.Windows.Forms.Label();
            this.labelProjectManager = new System.Windows.Forms.Label();
            this.labelChiefDesigner = new System.Windows.Forms.Label();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.labelDeliveryTime = new System.Windows.Forms.Label();
            this.textBoxMainContract = new System.Windows.Forms.TextBox();
            this.textBoxProjectManager = new System.Windows.Forms.TextBox();
            this.textBoxChiefDesigner = new System.Windows.Forms.TextBox();
            this.textBoxSupplier = new System.Windows.Forms.TextBox();
            this.textBoxDeliveryTime = new System.Windows.Forms.TextBox();
            this.buttonSelectSupplier = new System.Windows.Forms.Button();
            this.buttonToFormLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelProject
            // 
            this.labelProject.AutoSize = true;
            this.labelProject.Location = new System.Drawing.Point(13, 13);
            this.labelProject.Name = "labelProject";
            this.labelProject.Size = new System.Drawing.Size(44, 13);
            this.labelProject.TabIndex = 0;
            this.labelProject.Text = "Проект";
            // 
            // comboBoxSelectProject
            // 
            this.comboBoxSelectProject.FormattingEnabled = true;
            this.comboBoxSelectProject.Location = new System.Drawing.Point(16, 30);
            this.comboBoxSelectProject.Name = "comboBoxSelectProject";
            this.comboBoxSelectProject.Size = new System.Drawing.Size(250, 21);
            this.comboBoxSelectProject.TabIndex = 1;
            this.comboBoxSelectProject.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSelectProject_SelectionChangeCommitted);
            this.comboBoxSelectProject.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxSelectProject_MouseClick);
            // 
            // labelMailContract
            // 
            this.labelMailContract.AutoSize = true;
            this.labelMailContract.Location = new System.Drawing.Point(13, 59);
            this.labelMailContract.Name = "labelMailContract";
            this.labelMailContract.Size = new System.Drawing.Size(104, 13);
            this.labelMailContract.TabIndex = 2;
            this.labelMailContract.Text = "Головной контракт";
            // 
            // labelProjectManager
            // 
            this.labelProjectManager.AutoSize = true;
            this.labelProjectManager.Location = new System.Drawing.Point(13, 98);
            this.labelProjectManager.Name = "labelProjectManager";
            this.labelProjectManager.Size = new System.Drawing.Size(122, 13);
            this.labelProjectManager.TabIndex = 3;
            this.labelProjectManager.Text = "Руководитель проекта";
            // 
            // labelChiefDesigner
            // 
            this.labelChiefDesigner.AutoSize = true;
            this.labelChiefDesigner.Location = new System.Drawing.Point(13, 137);
            this.labelChiefDesigner.Name = "labelChiefDesigner";
            this.labelChiefDesigner.Size = new System.Drawing.Size(98, 13);
            this.labelChiefDesigner.TabIndex = 4;
            this.labelChiefDesigner.Text = "Главный инженер";
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.Location = new System.Drawing.Point(13, 176);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(65, 13);
            this.labelSupplier.TabIndex = 5;
            this.labelSupplier.Text = "Поставщик";
            // 
            // labelDeliveryTime
            // 
            this.labelDeliveryTime.AutoSize = true;
            this.labelDeliveryTime.Location = new System.Drawing.Point(13, 215);
            this.labelDeliveryTime.Name = "labelDeliveryTime";
            this.labelDeliveryTime.Size = new System.Drawing.Size(88, 13);
            this.labelDeliveryTime.TabIndex = 6;
            this.labelDeliveryTime.Text = "Сроки поставки";
            // 
            // textBoxMainContract
            // 
            this.textBoxMainContract.Location = new System.Drawing.Point(16, 75);
            this.textBoxMainContract.Name = "textBoxMainContract";
            this.textBoxMainContract.Size = new System.Drawing.Size(250, 20);
            this.textBoxMainContract.TabIndex = 9;
            // 
            // textBoxProjectManager
            // 
            this.textBoxProjectManager.Location = new System.Drawing.Point(16, 114);
            this.textBoxProjectManager.Name = "textBoxProjectManager";
            this.textBoxProjectManager.Size = new System.Drawing.Size(250, 20);
            this.textBoxProjectManager.TabIndex = 10;
            // 
            // textBoxChiefDesigner
            // 
            this.textBoxChiefDesigner.Location = new System.Drawing.Point(16, 153);
            this.textBoxChiefDesigner.Name = "textBoxChiefDesigner";
            this.textBoxChiefDesigner.Size = new System.Drawing.Size(250, 20);
            this.textBoxChiefDesigner.TabIndex = 11;
            // 
            // textBoxSupplier
            // 
            this.textBoxSupplier.Location = new System.Drawing.Point(16, 192);
            this.textBoxSupplier.Name = "textBoxSupplier";
            this.textBoxSupplier.Size = new System.Drawing.Size(250, 20);
            this.textBoxSupplier.TabIndex = 12;
            // 
            // textBoxDeliveryTime
            // 
            this.textBoxDeliveryTime.Location = new System.Drawing.Point(16, 231);
            this.textBoxDeliveryTime.Name = "textBoxDeliveryTime";
            this.textBoxDeliveryTime.Size = new System.Drawing.Size(250, 20);
            this.textBoxDeliveryTime.TabIndex = 13;
            // 
            // buttonSelectSupplier
            // 
            this.buttonSelectSupplier.Location = new System.Drawing.Point(292, 199);
            this.buttonSelectSupplier.Name = "buttonSelectSupplier";
            this.buttonSelectSupplier.Size = new System.Drawing.Size(150, 25);
            this.buttonSelectSupplier.TabIndex = 14;
            this.buttonSelectSupplier.Text = "Выбрать поставщика";
            this.buttonSelectSupplier.UseVisualStyleBackColor = true;
            this.buttonSelectSupplier.Click += new System.EventHandler(this.buttonSelectSupplier_Click);
            // 
            // buttonToFormLogIn
            // 
            this.buttonToFormLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToFormLogIn.Location = new System.Drawing.Point(292, 230);
            this.buttonToFormLogIn.Name = "buttonToFormLogIn";
            this.buttonToFormLogIn.Size = new System.Drawing.Size(150, 25);
            this.buttonToFormLogIn.TabIndex = 15;
            this.buttonToFormLogIn.Text = "Назад";
            this.buttonToFormLogIn.UseVisualStyleBackColor = true;
            this.buttonToFormLogIn.Click += new System.EventHandler(this.buttonToFormLogIn_Click);
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 267);
            this.Controls.Add(this.buttonToFormLogIn);
            this.Controls.Add(this.buttonSelectSupplier);
            this.Controls.Add(this.textBoxDeliveryTime);
            this.Controls.Add(this.textBoxSupplier);
            this.Controls.Add(this.textBoxChiefDesigner);
            this.Controls.Add(this.textBoxProjectManager);
            this.Controls.Add(this.textBoxMainContract);
            this.Controls.Add(this.labelDeliveryTime);
            this.Controls.Add(this.labelSupplier);
            this.Controls.Add(this.labelChiefDesigner);
            this.Controls.Add(this.labelProjectManager);
            this.Controls.Add(this.labelMailContract);
            this.Controls.Add(this.comboBoxSelectProject);
            this.Controls.Add(this.labelProject);
            this.MaximizeBox = false;
            this.Name = "Projects";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проекты";
            this.Load += new System.EventHandler(this.Projects_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProject;
        private System.Windows.Forms.ComboBox comboBoxSelectProject;
        private System.Windows.Forms.Label labelMailContract;
        private System.Windows.Forms.Label labelProjectManager;
        private System.Windows.Forms.Label labelChiefDesigner;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.Label labelDeliveryTime;
        private System.Windows.Forms.TextBox textBoxMainContract;
        private System.Windows.Forms.TextBox textBoxProjectManager;
        private System.Windows.Forms.TextBox textBoxChiefDesigner;
        private System.Windows.Forms.TextBox textBoxSupplier;
        private System.Windows.Forms.TextBox textBoxDeliveryTime;
        private System.Windows.Forms.Button buttonSelectSupplier;
        private System.Windows.Forms.Button buttonToFormLogIn;
    }
}