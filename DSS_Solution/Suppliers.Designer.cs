namespace DSS
{
    partial class Suppliers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonEditSupplier = new System.Windows.Forms.Button();
            this.buttonDeleteSupplier = new System.Windows.Forms.Button();
            this.buttonAddSupplier = new System.Windows.Forms.Button();
            this.buttonToFormAdminMode = new System.Windows.Forms.Button();
            this.dataGridViewSuppliers = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QMS = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaterialQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeOfDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationRemotness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Flexibility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarrantyService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditSupplier
            // 
            this.buttonEditSupplier.Location = new System.Drawing.Point(1035, 75);
            this.buttonEditSupplier.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEditSupplier.Name = "buttonEditSupplier";
            this.buttonEditSupplier.Size = new System.Drawing.Size(150, 30);
            this.buttonEditSupplier.TabIndex = 3;
            this.buttonEditSupplier.Text = "Изменить данные";
            this.buttonEditSupplier.UseVisualStyleBackColor = true;
            this.buttonEditSupplier.Click += new System.EventHandler(this.buttonEditSupplier_Click);
            // 
            // buttonDeleteSupplier
            // 
            this.buttonDeleteSupplier.Location = new System.Drawing.Point(1035, 45);
            this.buttonDeleteSupplier.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDeleteSupplier.Name = "buttonDeleteSupplier";
            this.buttonDeleteSupplier.Size = new System.Drawing.Size(150, 30);
            this.buttonDeleteSupplier.TabIndex = 2;
            this.buttonDeleteSupplier.Text = "Удалить поставщика";
            this.buttonDeleteSupplier.UseVisualStyleBackColor = true;
            this.buttonDeleteSupplier.Click += new System.EventHandler(this.buttonDeleteSupplier_Click);
            // 
            // buttonAddSupplier
            // 
            this.buttonAddSupplier.Location = new System.Drawing.Point(1035, 15);
            this.buttonAddSupplier.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddSupplier.Name = "buttonAddSupplier";
            this.buttonAddSupplier.Size = new System.Drawing.Size(150, 30);
            this.buttonAddSupplier.TabIndex = 1;
            this.buttonAddSupplier.Text = "Добавить поставщика";
            this.buttonAddSupplier.UseVisualStyleBackColor = true;
            this.buttonAddSupplier.Click += new System.EventHandler(this.buttonAddSupplier_Click);
            // 
            // buttonToFormAdminMode
            // 
            this.buttonToFormAdminMode.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonToFormAdminMode.Location = new System.Drawing.Point(1035, 390);
            this.buttonToFormAdminMode.Margin = new System.Windows.Forms.Padding(0);
            this.buttonToFormAdminMode.Name = "buttonToFormAdminMode";
            this.buttonToFormAdminMode.Size = new System.Drawing.Size(150, 25);
            this.buttonToFormAdminMode.TabIndex = 4;
            this.buttonToFormAdminMode.Text = "Назад";
            this.buttonToFormAdminMode.UseVisualStyleBackColor = true;
            this.buttonToFormAdminMode.Click += new System.EventHandler(this.buttonToFormAdminMode_Click);
            // 
            // dataGridViewSuppliers
            // 
            this.dataGridViewSuppliers.AllowUserToAddRows = false;
            this.dataGridViewSuppliers.AllowUserToDeleteRows = false;
            this.dataGridViewSuppliers.AllowUserToResizeColumns = false;
            this.dataGridViewSuppliers.AllowUserToResizeRows = false;
            this.dataGridViewSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSuppliers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSuppliers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSuppliers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewSuppliers.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewSuppliers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSuppliers.ColumnHeadersHeight = 60;
            this.dataGridViewSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SupplierName,
            this.SupplierType,
            this.QMS,
            this.MaterialQuality,
            this.Price,
            this.TimeOfDelivery,
            this.LocationRemotness,
            this.Flexibility,
            this.WarrantyService});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSuppliers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSuppliers.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewSuppliers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridViewSuppliers.Location = new System.Drawing.Point(15, 15);
            this.dataGridViewSuppliers.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewSuppliers.MultiSelect = false;
            this.dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            this.dataGridViewSuppliers.ReadOnly = true;
            this.dataGridViewSuppliers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSuppliers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSuppliers.RowHeadersWidth = 30;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSuppliers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSuppliers.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewSuppliers.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridViewSuppliers.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSuppliers.RowTemplate.DividerHeight = 1;
            this.dataGridViewSuppliers.RowTemplate.Height = 25;
            this.dataGridViewSuppliers.RowTemplate.ReadOnly = true;
            this.dataGridViewSuppliers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSuppliers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSuppliers.Size = new System.Drawing.Size(1000, 591);
            this.dataGridViewSuppliers.TabIndex = 0;
            this.dataGridViewSuppliers.TabStop = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 30;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // SupplierName
            // 
            this.SupplierName.FillWeight = 24.117F;
            this.SupplierName.HeaderText = "Наименование";
            this.SupplierName.MinimumWidth = 150;
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            // 
            // SupplierType
            // 
            this.SupplierType.FillWeight = 20F;
            this.SupplierType.HeaderText = "Тип";
            this.SupplierType.MinimumWidth = 100;
            this.SupplierType.Name = "SupplierType";
            this.SupplierType.ReadOnly = true;
            this.SupplierType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SupplierType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // QMS
            // 
            this.QMS.FillWeight = 69.3139F;
            this.QMS.HeaderText = "СМК ИСО 9001";
            this.QMS.MinimumWidth = 60;
            this.QMS.Name = "QMS";
            this.QMS.ReadOnly = true;
            this.QMS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MaterialQuality
            // 
            this.MaterialQuality.FillWeight = 51.96128F;
            this.MaterialQuality.HeaderText = "Качество изделий";
            this.MaterialQuality.MinimumWidth = 100;
            this.MaterialQuality.Name = "MaterialQuality";
            this.MaterialQuality.ReadOnly = true;
            this.MaterialQuality.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Price
            // 
            this.Price.FillWeight = 39.01288F;
            this.Price.HeaderText = "Цены";
            this.Price.MinimumWidth = 100;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TimeOfDelivery
            // 
            this.TimeOfDelivery.FillWeight = 29.35087F;
            this.TimeOfDelivery.HeaderText = "Сроки поставки";
            this.TimeOfDelivery.MinimumWidth = 100;
            this.TimeOfDelivery.Name = "TimeOfDelivery";
            this.TimeOfDelivery.ReadOnly = true;
            this.TimeOfDelivery.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LocationRemotness
            // 
            this.LocationRemotness.FillWeight = 22.14116F;
            this.LocationRemotness.HeaderText = "Удаленность";
            this.LocationRemotness.MinimumWidth = 100;
            this.LocationRemotness.Name = "LocationRemotness";
            this.LocationRemotness.ReadOnly = true;
            this.LocationRemotness.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Flexibility
            // 
            this.Flexibility.FillWeight = 21.46923F;
            this.Flexibility.HeaderText = "Гибкость";
            this.Flexibility.MinimumWidth = 100;
            this.Flexibility.Name = "Flexibility";
            this.Flexibility.ReadOnly = true;
            this.Flexibility.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // WarrantyService
            // 
            this.WarrantyService.FillWeight = 14.78586F;
            this.WarrantyService.HeaderText = "Работа гарантийной службы";
            this.WarrantyService.MinimumWidth = 100;
            this.WarrantyService.Name = "WarrantyService";
            this.WarrantyService.ReadOnly = true;
            this.WarrantyService.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.buttonToFormAdminMode;
            this.ClientSize = new System.Drawing.Size(1252, 621);
            this.Controls.Add(this.dataGridViewSuppliers);
            this.Controls.Add(this.buttonEditSupplier);
            this.Controls.Add(this.buttonDeleteSupplier);
            this.Controls.Add(this.buttonAddSupplier);
            this.Controls.Add(this.buttonToFormAdminMode);
            this.MaximizeBox = false;
            this.Name = "Suppliers";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поставщики";
            this.Load += new System.EventHandler(this.Suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEditSupplier;
        private System.Windows.Forms.Button buttonDeleteSupplier;
        private System.Windows.Forms.Button buttonAddSupplier;
        private System.Windows.Forms.Button buttonToFormAdminMode;
        public System.Windows.Forms.DataGridView dataGridViewSuppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn QMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialQuality;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeOfDelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationRemotness;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flexibility;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarrantyService;
    }
}