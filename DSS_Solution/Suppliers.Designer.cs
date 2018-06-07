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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.buttonEditSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditSupplier.Location = new System.Drawing.Point(716, 90);
            this.buttonEditSupplier.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.buttonEditSupplier.Name = "buttonEditSupplier";
            this.buttonEditSupplier.Size = new System.Drawing.Size(150, 30);
            this.buttonEditSupplier.TabIndex = 3;
            this.buttonEditSupplier.Text = "Изменить данные";
            this.buttonEditSupplier.UseVisualStyleBackColor = true;
            this.buttonEditSupplier.Click += new System.EventHandler(this.buttonEditSupplier_Click);
            // 
            // buttonDeleteSupplier
            // 
            this.buttonDeleteSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteSupplier.Location = new System.Drawing.Point(716, 54);
            this.buttonDeleteSupplier.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.buttonDeleteSupplier.Name = "buttonDeleteSupplier";
            this.buttonDeleteSupplier.Size = new System.Drawing.Size(150, 30);
            this.buttonDeleteSupplier.TabIndex = 2;
            this.buttonDeleteSupplier.Text = "Удалить поставщика";
            this.buttonDeleteSupplier.UseVisualStyleBackColor = true;
            this.buttonDeleteSupplier.Click += new System.EventHandler(this.buttonDeleteSupplier_Click);
            // 
            // buttonAddSupplier
            // 
            this.buttonAddSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddSupplier.Location = new System.Drawing.Point(716, 18);
            this.buttonAddSupplier.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.buttonAddSupplier.Name = "buttonAddSupplier";
            this.buttonAddSupplier.Size = new System.Drawing.Size(150, 30);
            this.buttonAddSupplier.TabIndex = 1;
            this.buttonAddSupplier.Text = "Добавить поставщика";
            this.buttonAddSupplier.UseVisualStyleBackColor = true;
            this.buttonAddSupplier.Click += new System.EventHandler(this.buttonAddSupplier_Click);
            // 
            // buttonToFormAdminMode
            // 
            this.buttonToFormAdminMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonToFormAdminMode.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonToFormAdminMode.Location = new System.Drawing.Point(716, 413);
            this.buttonToFormAdminMode.Margin = new System.Windows.Forms.Padding(30, 300, 3, 3);
            this.buttonToFormAdminMode.Name = "buttonToFormAdminMode";
            this.buttonToFormAdminMode.Size = new System.Drawing.Size(150, 30);
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
            this.dataGridViewSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSuppliers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewSuppliers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSuppliers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewSuppliers.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewSuppliers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSuppliers.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewSuppliers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridViewSuppliers.Location = new System.Drawing.Point(18, 18);
            this.dataGridViewSuppliers.MultiSelect = false;
            this.dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            this.dataGridViewSuppliers.ReadOnly = true;
            this.dataGridViewSuppliers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSuppliers.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewSuppliers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSuppliers.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewSuppliers.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewSuppliers.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridViewSuppliers.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSuppliers.RowTemplate.DividerHeight = 1;
            this.dataGridViewSuppliers.RowTemplate.Height = 25;
            this.dataGridViewSuppliers.RowTemplate.ReadOnly = true;
            this.dataGridViewSuppliers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSuppliers.Size = new System.Drawing.Size(668, 425);
            this.dataGridViewSuppliers.TabIndex = 0;
            this.dataGridViewSuppliers.TabStop = false;
            this.dataGridViewSuppliers.DoubleClick += new System.EventHandler(this.dataGridViewSuppliers_DoubleClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.FillWeight = 10F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 30;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Visible = false;
            this.ID.Width = 30;
            // 
            // SupplierName
            // 
            this.SupplierName.FillWeight = 20F;
            this.SupplierName.HeaderText = "Наименование";
            this.SupplierName.MinimumWidth = 180;
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            this.SupplierName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.QMS.FillWeight = 20F;
            this.QMS.HeaderText = "СМК ИСО 9001";
            this.QMS.MinimumWidth = 90;
            this.QMS.Name = "QMS";
            this.QMS.ReadOnly = true;
            this.QMS.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MaterialQuality
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaterialQuality.DefaultCellStyle = dataGridViewCellStyle12;
            this.MaterialQuality.FillWeight = 20F;
            this.MaterialQuality.HeaderText = "Качество изделий";
            this.MaterialQuality.MinimumWidth = 90;
            this.MaterialQuality.Name = "MaterialQuality";
            this.MaterialQuality.ReadOnly = true;
            this.MaterialQuality.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MaterialQuality.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Price
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Price.DefaultCellStyle = dataGridViewCellStyle13;
            this.Price.FillWeight = 20F;
            this.Price.HeaderText = "Цены";
            this.Price.MinimumWidth = 90;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TimeOfDelivery
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TimeOfDelivery.DefaultCellStyle = dataGridViewCellStyle14;
            this.TimeOfDelivery.FillWeight = 20F;
            this.TimeOfDelivery.HeaderText = "Сроки поставки";
            this.TimeOfDelivery.MinimumWidth = 90;
            this.TimeOfDelivery.Name = "TimeOfDelivery";
            this.TimeOfDelivery.ReadOnly = true;
            this.TimeOfDelivery.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TimeOfDelivery.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LocationRemotness
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LocationRemotness.DefaultCellStyle = dataGridViewCellStyle15;
            this.LocationRemotness.FillWeight = 20F;
            this.LocationRemotness.HeaderText = "Удаленность";
            this.LocationRemotness.MinimumWidth = 90;
            this.LocationRemotness.Name = "LocationRemotness";
            this.LocationRemotness.ReadOnly = true;
            this.LocationRemotness.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LocationRemotness.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Flexibility
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Flexibility.DefaultCellStyle = dataGridViewCellStyle16;
            this.Flexibility.FillWeight = 20F;
            this.Flexibility.HeaderText = "Гибкость";
            this.Flexibility.MinimumWidth = 90;
            this.Flexibility.Name = "Flexibility";
            this.Flexibility.ReadOnly = true;
            this.Flexibility.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Flexibility.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // WarrantyService
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.WarrantyService.DefaultCellStyle = dataGridViewCellStyle17;
            this.WarrantyService.FillWeight = 20F;
            this.WarrantyService.HeaderText = "Работа гарантийной службы";
            this.WarrantyService.MinimumWidth = 90;
            this.WarrantyService.Name = "WarrantyService";
            this.WarrantyService.ReadOnly = true;
            this.WarrantyService.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.WarrantyService.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Suppliers
            // 
            this.AcceptButton = this.buttonEditSupplier;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.buttonToFormAdminMode;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.dataGridViewSuppliers);
            this.Controls.Add(this.buttonEditSupplier);
            this.Controls.Add(this.buttonDeleteSupplier);
            this.Controls.Add(this.buttonAddSupplier);
            this.Controls.Add(this.buttonToFormAdminMode);
            this.Name = "Suppliers";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
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