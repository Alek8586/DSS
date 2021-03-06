﻿namespace DSS
{
    partial class EditProject
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
            this.labelProjectLogin = new System.Windows.Forms.Label();
            this.textBoxProjectName = new System.Windows.Forms.TextBox();
            this.labelProjectPassword = new System.Windows.Forms.Label();
            this.textBoxProjectMainContract = new System.Windows.Forms.TextBox();
            this.labelProjectRole = new System.Windows.Forms.Label();
            this.labelProjectPost = new System.Windows.Forms.Label();
            this.textBoxProjectChiefDesigner = new System.Windows.Forms.TextBox();
            this.labelProjectFullname = new System.Windows.Forms.Label();
            this.textBoxProjectSupplierName = new System.Windows.Forms.TextBox();
            this.labelProjectEtc = new System.Windows.Forms.Label();
            this.textBoxProjectDeliveryTime = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSaveAndClose = new System.Windows.Forms.Button();
            this.buttonBackToProjectsForm = new System.Windows.Forms.Button();
            this.buttonSelectSupplier = new System.Windows.Forms.Button();
            this.textBoxProjectManager = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelProjectLogin
            // 
            this.labelProjectLogin.AutoSize = true;
            this.labelProjectLogin.Location = new System.Drawing.Point(18, 15);
            this.labelProjectLogin.Name = "labelProjectLogin";
            this.labelProjectLogin.Size = new System.Drawing.Size(118, 15);
            this.labelProjectLogin.TabIndex = 0;
            this.labelProjectLogin.Text = "Имя пользователя";
            // 
            // textBoxProjectName
            // 
            this.textBoxProjectName.Location = new System.Drawing.Point(21, 33);
            this.textBoxProjectName.Name = "textBoxProjectName";
            this.textBoxProjectName.Size = new System.Drawing.Size(100, 21);
            this.textBoxProjectName.TabIndex = 1;
            this.textBoxProjectName.WordWrap = false;
            // 
            // labelProjectPassword
            // 
            this.labelProjectPassword.AutoSize = true;
            this.labelProjectPassword.Location = new System.Drawing.Point(18, 57);
            this.labelProjectPassword.Name = "labelProjectPassword";
            this.labelProjectPassword.Size = new System.Drawing.Size(161, 15);
            this.labelProjectPassword.TabIndex = 2;
            this.labelProjectPassword.Text = "Пароль для пользователя";
            // 
            // textBoxProjectMainContract
            // 
            this.textBoxProjectMainContract.Location = new System.Drawing.Point(21, 75);
            this.textBoxProjectMainContract.Name = "textBoxProjectMainContract";
            this.textBoxProjectMainContract.Size = new System.Drawing.Size(100, 21);
            this.textBoxProjectMainContract.TabIndex = 3;
            // 
            // labelProjectRole
            // 
            this.labelProjectRole.AutoSize = true;
            this.labelProjectRole.Location = new System.Drawing.Point(18, 99);
            this.labelProjectRole.Name = "labelProjectRole";
            this.labelProjectRole.Size = new System.Drawing.Size(93, 15);
            this.labelProjectRole.TabIndex = 4;
            this.labelProjectRole.Text = "Права доступа";
            // 
            // labelProjectPost
            // 
            this.labelProjectPost.AutoSize = true;
            this.labelProjectPost.Location = new System.Drawing.Point(18, 143);
            this.labelProjectPost.Name = "labelProjectPost";
            this.labelProjectPost.Size = new System.Drawing.Size(73, 15);
            this.labelProjectPost.TabIndex = 6;
            this.labelProjectPost.Text = "Должность";
            // 
            // textBoxProjectChiefDesigner
            // 
            this.textBoxProjectChiefDesigner.Location = new System.Drawing.Point(21, 161);
            this.textBoxProjectChiefDesigner.Name = "textBoxProjectChiefDesigner";
            this.textBoxProjectChiefDesigner.Size = new System.Drawing.Size(100, 21);
            this.textBoxProjectChiefDesigner.TabIndex = 7;
            // 
            // labelProjectFullname
            // 
            this.labelProjectFullname.AutoSize = true;
            this.labelProjectFullname.Location = new System.Drawing.Point(18, 185);
            this.labelProjectFullname.Name = "labelProjectFullname";
            this.labelProjectFullname.Size = new System.Drawing.Size(163, 15);
            this.labelProjectFullname.TabIndex = 8;
            this.labelProjectFullname.Text = "Полное имя пользователя";
            // 
            // textBoxProjectSupplierName
            // 
            this.textBoxProjectSupplierName.Location = new System.Drawing.Point(21, 203);
            this.textBoxProjectSupplierName.Name = "textBoxProjectSupplierName";
            this.textBoxProjectSupplierName.Size = new System.Drawing.Size(100, 21);
            this.textBoxProjectSupplierName.TabIndex = 9;
            // 
            // labelProjectEtc
            // 
            this.labelProjectEtc.AutoSize = true;
            this.labelProjectEtc.Location = new System.Drawing.Point(18, 227);
            this.labelProjectEtc.Name = "labelProjectEtc";
            this.labelProjectEtc.Size = new System.Drawing.Size(50, 15);
            this.labelProjectEtc.TabIndex = 10;
            this.labelProjectEtc.Text = "Прочее";
            // 
            // textBoxProjectDeliveryTime
            // 
            this.textBoxProjectDeliveryTime.Location = new System.Drawing.Point(21, 245);
            this.textBoxProjectDeliveryTime.Name = "textBoxProjectDeliveryTime";
            this.textBoxProjectDeliveryTime.Size = new System.Drawing.Size(100, 21);
            this.textBoxProjectDeliveryTime.TabIndex = 11;
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
            // buttonBackToProjectsForm
            // 
            this.buttonBackToProjectsForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonBackToProjectsForm.Location = new System.Drawing.Point(325, 102);
            this.buttonBackToProjectsForm.Name = "buttonBackToProjectsForm";
            this.buttonBackToProjectsForm.Size = new System.Drawing.Size(106, 23);
            this.buttonBackToProjectsForm.TabIndex = 14;
            this.buttonBackToProjectsForm.Text = "Закрыть";
            this.buttonBackToProjectsForm.UseVisualStyleBackColor = true;
            this.buttonBackToProjectsForm.Click += new System.EventHandler(this.buttonBackToProjectsForm_Click);
            // 
            // buttonSelectSupplier
            // 
            this.buttonSelectSupplier.Location = new System.Drawing.Point(325, 227);
            this.buttonSelectSupplier.Name = "buttonSelectSupplier";
            this.buttonSelectSupplier.Size = new System.Drawing.Size(105, 42);
            this.buttonSelectSupplier.TabIndex = 15;
            this.buttonSelectSupplier.Text = "Выбрать поставщика";
            this.buttonSelectSupplier.UseVisualStyleBackColor = true;
            this.buttonSelectSupplier.Click += new System.EventHandler(this.buttonSelectSupplier_Click);
            // 
            // textBoxProjectManager
            // 
            this.textBoxProjectManager.Location = new System.Drawing.Point(21, 117);
            this.textBoxProjectManager.Name = "textBoxProjectManager";
            this.textBoxProjectManager.Size = new System.Drawing.Size(100, 21);
            this.textBoxProjectManager.TabIndex = 5;
            // 
            // EditProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonBackToProjectsForm;
            this.ClientSize = new System.Drawing.Size(449, 287);
            this.Controls.Add(this.buttonSelectSupplier);
            this.Controls.Add(this.buttonBackToProjectsForm);
            this.Controls.Add(this.buttonSaveAndClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxProjectDeliveryTime);
            this.Controls.Add(this.labelProjectEtc);
            this.Controls.Add(this.textBoxProjectSupplierName);
            this.Controls.Add(this.labelProjectFullname);
            this.Controls.Add(this.textBoxProjectManager);
            this.Controls.Add(this.textBoxProjectChiefDesigner);
            this.Controls.Add(this.labelProjectPost);
            this.Controls.Add(this.labelProjectRole);
            this.Controls.Add(this.textBoxProjectMainContract);
            this.Controls.Add(this.labelProjectPassword);
            this.Controls.Add(this.textBoxProjectName);
            this.Controls.Add(this.labelProjectLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "EditProject";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные о пользователе";
            this.Load += new System.EventHandler(this.AddProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProjectLogin;
        private System.Windows.Forms.TextBox textBoxProjectName;
        private System.Windows.Forms.Label labelProjectPassword;
        private System.Windows.Forms.TextBox textBoxProjectMainContract;
        private System.Windows.Forms.Label labelProjectRole;
        private System.Windows.Forms.Label labelProjectPost;
        private System.Windows.Forms.TextBox textBoxProjectChiefDesigner;
        private System.Windows.Forms.Label labelProjectFullname;
        private System.Windows.Forms.TextBox textBoxProjectSupplierName;
        private System.Windows.Forms.Label labelProjectEtc;
        private System.Windows.Forms.TextBox textBoxProjectDeliveryTime;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSaveAndClose;
        private System.Windows.Forms.Button buttonBackToProjectsForm;
        private System.Windows.Forms.Button buttonSelectSupplier;
        private System.Windows.Forms.TextBox textBoxProjectManager;
    }
}