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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShippingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheifDesigner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectOfficer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddProject = new System.Windows.Forms.Button();
            this.buttonEditProject = new System.Windows.Forms.Button();
            this.buttonDeleteProject = new System.Windows.Forms.Button();
            this.buttonToFormAdminMode = new System.Windows.Forms.Button();
            this.buttonSelectionSupplier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProjects
            // 
            this.dataGridViewProjects.AllowUserToAddRows = false;
            this.dataGridViewProjects.AllowUserToDeleteRows = false;
            this.dataGridViewProjects.AllowUserToResizeColumns = false;
            this.dataGridViewProjects.AllowUserToResizeRows = false;
            this.dataGridViewProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProjects.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewProjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProjects.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewProjects.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewProjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ProjectName,
            this.MainContract,
            this.ShippingDate,
            this.ProjectManager,
            this.CheifDesigner,
            this.Supplier,
            this.ProjectOfficer,
            this.Status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProjects.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.dataGridViewProjects.RowTemplate.DividerHeight = 1;
            this.dataGridViewProjects.RowTemplate.Height = 25;
            this.dataGridViewProjects.RowTemplate.ReadOnly = true;
            this.dataGridViewProjects.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProjects.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProjects.Size = new System.Drawing.Size(958, 297);
            this.dataGridViewProjects.TabIndex = 0;
            this.dataGridViewProjects.TabStop = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ProjectName
            // 
            this.ProjectName.HeaderText = "Наименование";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            // 
            // MainContract
            // 
            this.MainContract.HeaderText = "Головной контракт";
            this.MainContract.Name = "MainContract";
            this.MainContract.ReadOnly = true;
            this.MainContract.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MainContract.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ShippingDate
            // 
            this.ShippingDate.HeaderText = "Дата отгрузки";
            this.ShippingDate.Name = "ShippingDate";
            this.ShippingDate.ReadOnly = true;
            this.ShippingDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ProjectManager
            // 
            this.ProjectManager.HeaderText = "Руководитель проекта";
            this.ProjectManager.Name = "ProjectManager";
            this.ProjectManager.ReadOnly = true;
            this.ProjectManager.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CheifDesigner
            // 
            this.CheifDesigner.HeaderText = "Главный конструктор проекта";
            this.CheifDesigner.Name = "CheifDesigner";
            this.CheifDesigner.ReadOnly = true;
            this.CheifDesigner.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Supplier
            // 
            this.Supplier.HeaderText = "Поставщик";
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            this.Supplier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ProjectOfficer
            // 
            this.ProjectOfficer.HeaderText = "Исполнитель";
            this.ProjectOfficer.Name = "ProjectOfficer";
            this.ProjectOfficer.ReadOnly = true;
            this.ProjectOfficer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // buttonAddProject
            // 
            this.buttonAddProject.Location = new System.Drawing.Point(998, 15);
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
            this.buttonEditProject.Location = new System.Drawing.Point(998, 87);
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
            this.buttonDeleteProject.Location = new System.Drawing.Point(998, 51);
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
            this.buttonToFormAdminMode.Location = new System.Drawing.Point(1008, 287);
            this.buttonToFormAdminMode.Name = "buttonToFormAdminMode";
            this.buttonToFormAdminMode.Size = new System.Drawing.Size(140, 25);
            this.buttonToFormAdminMode.TabIndex = 6;
            this.buttonToFormAdminMode.Text = "Назад";
            this.buttonToFormAdminMode.UseVisualStyleBackColor = true;
            this.buttonToFormAdminMode.Click += new System.EventHandler(this.buttonToFormAdminMode_Click);
            // 
            // buttonSelectionSupplier
            // 
            this.buttonSelectionSupplier.Location = new System.Drawing.Point(1008, 256);
            this.buttonSelectionSupplier.Name = "buttonSelectionSupplier";
            this.buttonSelectionSupplier.Size = new System.Drawing.Size(140, 25);
            this.buttonSelectionSupplier.TabIndex = 7;
            this.buttonSelectionSupplier.Text = "Выбрать поставщика";
            this.buttonSelectionSupplier.UseVisualStyleBackColor = true;
            this.buttonSelectionSupplier.Click += new System.EventHandler(this.buttonSelectionSupplier_Click);
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonToFormAdminMode;
            this.ClientSize = new System.Drawing.Size(1219, 522);
            this.Controls.Add(this.buttonSelectionSupplier);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShippingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheifDesigner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectOfficer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button buttonSelectionSupplier;
    }
}