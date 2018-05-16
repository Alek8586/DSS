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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProjects = new System.Windows.Forms.DataGridView();
            this.buttonAddProject = new System.Windows.Forms.Button();
            this.buttonEditProject = new System.Windows.Forms.Button();
            this.buttonDeleteProject = new System.Windows.Forms.Button();
            this.buttonToFormAdminMode = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeOfDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reliability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProjects
            // 
            this.dataGridViewProjects.AllowUserToAddRows = false;
            this.dataGridViewProjects.AllowUserToDeleteRows = false;
            this.dataGridViewProjects.AllowUserToResizeColumns = false;
            this.dataGridViewProjects.AllowUserToResizeRows = false;
            this.dataGridViewProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewProjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProjects.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewProjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProjects.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewProjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProjects.ColumnHeadersHeight = 30;
            this.dataGridViewProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SupplierName,
            this.Class,
            this.MaterialQuality,
            this.Price,
            this.TimeOfDelivery,
            this.Reliability});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProjects.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProjects.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewProjects.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridViewProjects.Location = new System.Drawing.Point(15, 15);
            this.dataGridViewProjects.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.dataGridViewProjects.MultiSelect = false;
            this.dataGridViewProjects.Name = "dataGridViewProjects";
            this.dataGridViewProjects.ReadOnly = true;
            this.dataGridViewProjects.RowHeadersWidth = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProjects.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProjects.RowTemplate.ReadOnly = true;
            this.dataGridViewProjects.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProjects.Size = new System.Drawing.Size(582, 297);
            this.dataGridViewProjects.TabIndex = 0;
            // 
            // buttonAddProject
            // 
            this.buttonAddProject.Location = new System.Drawing.Point(615, 15);
            this.buttonAddProject.Margin = new System.Windows.Forms.Padding(25);
            this.buttonAddProject.Name = "buttonAddProject";
            this.buttonAddProject.Size = new System.Drawing.Size(150, 30);
            this.buttonAddProject.TabIndex = 1;
            this.buttonAddProject.Text = "Новый проект";
            this.buttonAddProject.UseVisualStyleBackColor = true;
            this.buttonAddProject.Click += new System.EventHandler(this.buttonAddProject_Click);
            // 
            // buttonEditProject
            // 
            this.buttonEditProject.Location = new System.Drawing.Point(615, 87);
            this.buttonEditProject.Margin = new System.Windows.Forms.Padding(15);
            this.buttonEditProject.Name = "buttonEditProject";
            this.buttonEditProject.Size = new System.Drawing.Size(150, 30);
            this.buttonEditProject.TabIndex = 3;
            this.buttonEditProject.Text = "Изменить данные";
            this.buttonEditProject.UseVisualStyleBackColor = true;
            this.buttonEditProject.Click += new System.EventHandler(this.buttonEditProject_Click);
            // 
            // buttonDeleteProject
            // 
            this.buttonDeleteProject.Location = new System.Drawing.Point(615, 51);
            this.buttonDeleteProject.Margin = new System.Windows.Forms.Padding(15);
            this.buttonDeleteProject.Name = "buttonDeleteProject";
            this.buttonDeleteProject.Size = new System.Drawing.Size(150, 30);
            this.buttonDeleteProject.TabIndex = 2;
            this.buttonDeleteProject.Text = "Удалить проект";
            this.buttonDeleteProject.UseVisualStyleBackColor = true;
            this.buttonDeleteProject.Click += new System.EventHandler(this.buttonDeleteProject_Click);
            // 
            // buttonToFormAdminMode
            // 
            this.buttonToFormAdminMode.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonToFormAdminMode.Location = new System.Drawing.Point(625, 287);
            this.buttonToFormAdminMode.Name = "buttonToFormAdminMode";
            this.buttonToFormAdminMode.Size = new System.Drawing.Size(140, 25);
            this.buttonToFormAdminMode.TabIndex = 6;
            this.buttonToFormAdminMode.Text = "Назад";
            this.buttonToFormAdminMode.UseVisualStyleBackColor = true;
            this.buttonToFormAdminMode.Click += new System.EventHandler(this.buttonToFormAdminMode_Click);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Visible = false;
            this.ID.Width = 44;
            // 
            // SupplierName
            // 
            this.SupplierName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SupplierName.FillWeight = 3F;
            this.SupplierName.Frozen = true;
            this.SupplierName.HeaderText = "Наименование";
            this.SupplierName.MinimumWidth = 150;
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            this.SupplierName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SupplierName.Width = 150;
            // 
            // Class
            // 
            this.Class.HeaderText = "Утвержденный";
            this.Class.MinimumWidth = 100;
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            this.Class.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Class.Width = 121;
            // 
            // MaterialQuality
            // 
            this.MaterialQuality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaterialQuality.HeaderText = "Качество материала";
            this.MaterialQuality.MinimumWidth = 100;
            this.MaterialQuality.Name = "MaterialQuality";
            this.MaterialQuality.ReadOnly = true;
            this.MaterialQuality.Width = 155;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.MinimumWidth = 100;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // TimeOfDelivery
            // 
            this.TimeOfDelivery.HeaderText = "Сроки поставки";
            this.TimeOfDelivery.MinimumWidth = 100;
            this.TimeOfDelivery.Name = "TimeOfDelivery";
            this.TimeOfDelivery.ReadOnly = true;
            this.TimeOfDelivery.Width = 124;
            // 
            // Reliability
            // 
            this.Reliability.HeaderText = "Надежность";
            this.Reliability.MinimumWidth = 100;
            this.Reliability.Name = "Reliability";
            this.Reliability.ReadOnly = true;
            this.Reliability.Width = 105;
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonToFormAdminMode;
            this.ClientSize = new System.Drawing.Size(780, 327);
            this.Controls.Add(this.buttonEditProject);
            this.Controls.Add(this.buttonDeleteProject);
            this.Controls.Add(this.buttonAddProject);
            this.Controls.Add(this.buttonToFormAdminMode);
            this.Controls.Add(this.dataGridViewProjects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Projects";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проекты";
            this.Load += new System.EventHandler(this.Projects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddProject;
        private System.Windows.Forms.Button buttonDeleteProject;
        private System.Windows.Forms.Button buttonToFormAdminMode;
        public System.Windows.Forms.DataGridView dataGridViewProjects;
        public System.Windows.Forms.Button buttonEditProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialQuality;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeOfDelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reliability;
    }
}