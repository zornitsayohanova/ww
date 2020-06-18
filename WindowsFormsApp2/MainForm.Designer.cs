namespace WindowsFormsApp2
{
    partial class MainForm
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
            System.Windows.Forms.Label shopsLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddShop = new System.Windows.Forms.Button();
            this.btnDeleteShop = new System.Windows.Forms.Button();
            this.btnEditShop = new System.Windows.Forms.Button();
            this.categoriesLabel = new System.Windows.Forms.Label();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.itemsLabel = new System.Windows.Forms.Label();
            this.dataGridViewShops = new System.Windows.Forms.DataGridView();
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            shopsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // shopsLabel
            // 
            shopsLabel.AccessibleName = "shopsLabel";
            shopsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            shopsLabel.BackColor = System.Drawing.Color.Transparent;
            shopsLabel.Font = new System.Drawing.Font("Limelight", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            shopsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            shopsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            shopsLabel.Location = new System.Drawing.Point(445, 40);
            shopsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            shopsLabel.Name = "shopsLabel";
            shopsLabel.Size = new System.Drawing.Size(308, 41);
            shopsLabel.TabIndex = 17;
            shopsLabel.Text = "Shops";
            shopsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            shopsLabel.UseMnemonic = false;
            // 
            // btnAddShop
            // 
            this.btnAddShop.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnAddShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnAddShop.FlatAppearance.BorderColor = System.Drawing.Color.DarkSalmon;
            this.btnAddShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddShop.Font = new System.Drawing.Font("Gadugi", 14.25F);
            this.btnAddShop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.btnAddShop.Location = new System.Drawing.Point(244, 349);
            this.btnAddShop.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddShop.Name = "btnAddShop";
            this.btnAddShop.Size = new System.Drawing.Size(123, 37);
            this.btnAddShop.TabIndex = 18;
            this.btnAddShop.Text = "Add Shop";
            this.btnAddShop.UseVisualStyleBackColor = false;
            this.btnAddShop.Click += new System.EventHandler(this.btnAddShop_Click);
            // 
            // btnDeleteShop
            // 
            this.btnDeleteShop.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnDeleteShop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnDeleteShop.FlatAppearance.BorderColor = System.Drawing.Color.DarkSalmon;
            this.btnDeleteShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteShop.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteShop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.btnDeleteShop.Location = new System.Drawing.Point(809, 349);
            this.btnDeleteShop.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteShop.Name = "btnDeleteShop";
            this.btnDeleteShop.Size = new System.Drawing.Size(124, 37);
            this.btnDeleteShop.TabIndex = 29;
            this.btnDeleteShop.Text = "Delete Shop";
            this.btnDeleteShop.UseVisualStyleBackColor = false;
            this.btnDeleteShop.Click += new System.EventHandler(this.btnDeleteShop_Click);
            // 
            // btnEditShop
            // 
            this.btnEditShop.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnEditShop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnEditShop.FlatAppearance.BorderColor = System.Drawing.Color.DarkSalmon;
            this.btnEditShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditShop.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditShop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.btnEditShop.Location = new System.Drawing.Point(533, 349);
            this.btnEditShop.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditShop.Name = "btnEditShop";
            this.btnEditShop.Size = new System.Drawing.Size(123, 37);
            this.btnEditShop.TabIndex = 30;
            this.btnEditShop.Text = "Edit Shop";
            this.btnEditShop.UseVisualStyleBackColor = false;
            this.btnEditShop.Click += new System.EventHandler(this.btnEditShop_Click);
            // 
            // categoriesLabel
            // 
            this.categoriesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoriesLabel.BackColor = System.Drawing.Color.Black;
            this.categoriesLabel.Font = new System.Drawing.Font("Limelight", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.categoriesLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.categoriesLabel.Location = new System.Drawing.Point(184, 429);
            this.categoriesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoriesLabel.Name = "categoriesLabel";
            this.categoriesLabel.Size = new System.Drawing.Size(247, 41);
            this.categoriesLabel.TabIndex = 31;
            this.categoriesLabel.Text = "Categories";
            this.categoriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnEditCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnEditCategory.FlatAppearance.BorderColor = System.Drawing.Color.DarkSalmon;
            this.btnEditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCategory.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.btnEditCategory.Location = new System.Drawing.Point(223, 743);
            this.btnEditCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(158, 37);
            this.btnEditCategory.TabIndex = 35;
            this.btnEditCategory.Text = "Edit Category";
            this.btnEditCategory.UseVisualStyleBackColor = false;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnDeleteCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnDeleteCategory.FlatAppearance.BorderColor = System.Drawing.Color.DarkSalmon;
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.btnDeleteCategory.Location = new System.Drawing.Point(403, 743);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(158, 37);
            this.btnDeleteCategory.TabIndex = 34;
            this.btnDeleteCategory.Text = "Delete Category";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnAddCategory.FlatAppearance.BorderColor = System.Drawing.Color.DarkSalmon;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Gadugi", 14.25F);
            this.btnAddCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.btnAddCategory.Location = new System.Drawing.Point(43, 743);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(158, 37);
            this.btnAddCategory.TabIndex = 33;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnDeleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnDeleteItem.FlatAppearance.BorderColor = System.Drawing.Color.DarkSalmon;
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteItem.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.btnDeleteItem.Location = new System.Drawing.Point(972, 743);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(124, 37);
            this.btnDeleteItem.TabIndex = 38;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnAddItem.FlatAppearance.BorderColor = System.Drawing.Color.DarkSalmon;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Gadugi", 14.25F);
            this.btnAddItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.btnAddItem.Location = new System.Drawing.Point(644, 743);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(123, 37);
            this.btnAddItem.TabIndex = 37;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnEditItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnEditItem.FlatAppearance.BorderColor = System.Drawing.Color.DarkSalmon;
            this.btnEditItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditItem.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.btnEditItem.Location = new System.Drawing.Point(809, 743);
            this.btnEditItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(123, 37);
            this.btnEditItem.TabIndex = 44;
            this.btnEditItem.Text = "Edit Item";
            this.btnEditItem.UseVisualStyleBackColor = false;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // itemsLabel
            // 
            this.itemsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsLabel.BackColor = System.Drawing.Color.Black;
            this.itemsLabel.Font = new System.Drawing.Font("Limelight", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.itemsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.itemsLabel.Location = new System.Drawing.Point(745, 429);
            this.itemsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(247, 41);
            this.itemsLabel.TabIndex = 49;
            this.itemsLabel.Text = "Items";
            this.itemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewShops
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 13F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            this.dataGridViewShops.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewShops.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewShops.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShops.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.dataGridViewShops.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewShops.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewShops.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShops.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewShops.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gadugi", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewShops.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewShops.EnableHeadersVisualStyles = false;
            this.dataGridViewShops.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.dataGridViewShops.Location = new System.Drawing.Point(23, 83);
            this.dataGridViewShops.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewShops.Name = "dataGridViewShops";
            this.dataGridViewShops.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Gadugi", 13F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShops.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewShops.RowHeadersWidth = 25;
            this.dataGridViewShops.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            this.dataGridViewShops.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewShops.RowTemplate.Height = 24;
            this.dataGridViewShops.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShops.Size = new System.Drawing.Size(1099, 289);
            this.dataGridViewShops.TabIndex = 50;
            this.dataGridViewShops.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShops_CellContentClick);
            // 
            // dataGridViewCategories
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Gadugi", 13F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            this.dataGridViewCategories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCategories.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.dataGridViewCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCategories.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewCategories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewCategories.ColumnHeadersHeight = 50;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Gadugi", 13F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCategories.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewCategories.EnableHeadersVisualStyles = false;
            this.dataGridViewCategories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.dataGridViewCategories.Location = new System.Drawing.Point(23, 472);
            this.dataGridViewCategories.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Gadugi", 13F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCategories.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewCategories.RowHeadersWidth = 25;
            this.dataGridViewCategories.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            this.dataGridViewCategories.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewCategories.RowTemplate.Height = 24;
            this.dataGridViewCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCategories.Size = new System.Drawing.Size(559, 289);
            this.dataGridViewCategories.TabIndex = 51;
            this.dataGridViewCategories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategories_CellContentClick);
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AccessibleName = "dataGridViewItems";
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Gadugi", 13F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            this.dataGridViewItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.dataGridViewItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewItems.ColumnHeadersHeight = 50;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Gadugi", 13F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewItems.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewItems.EnableHeadersVisualStyles = false;
            this.dataGridViewItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.dataGridViewItems.Location = new System.Drawing.Point(612, 472);
            this.dataGridViewItems.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Gadugi", 13F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewItems.RowHeadersWidth = 25;
            this.dataGridViewItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(204)))));
            this.dataGridViewItems.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewItems.RowTemplate.Height = 24;
            this.dataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItems.Size = new System.Drawing.Size(510, 289);
            this.dataGridViewItems.TabIndex = 52;
            this.dataGridViewItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellContentClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1148, 845);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnEditCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnEditItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.dataGridViewCategories);
            this.Controls.Add(this.btnDeleteShop);
            this.Controls.Add(this.btnEditShop);
            this.Controls.Add(this.btnAddShop);
            this.Controls.Add(this.dataGridViewShops);
            this.Controls.Add(this.itemsLabel);
            this.Controls.Add(this.categoriesLabel);
            this.Controls.Add(shopsLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Shop managment application";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddShop;
        private System.Windows.Forms.Button btnDeleteShop;
        private System.Windows.Forms.Button btnEditShop;
        private System.Windows.Forms.Label categoriesLabel;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Label itemsLabel;
        private System.Windows.Forms.DataGridView dataGridViewShops;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.DataGridView dataGridViewItems;
    }
}

