namespace WindowsFormsApp2
{
    partial class ItemForm
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
            System.Windows.Forms.Label itemIdLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label shopIdlabel;
            System.Windows.Forms.Label categoryIdlabel;
            System.Windows.Forms.Label nameLabel;
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.txtShopId = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            itemIdLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            shopIdlabel = new System.Windows.Forms.Label();
            categoryIdlabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemIdLabel
            // 
            itemIdLabel.AccessibleName = "shopsLabel";
            itemIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            itemIdLabel.BackColor = System.Drawing.Color.Transparent;
            itemIdLabel.Font = new System.Drawing.Font("Limelight", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            itemIdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            itemIdLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            itemIdLabel.Location = new System.Drawing.Point(77, 38);
            itemIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            itemIdLabel.Name = "itemIdLabel";
            itemIdLabel.Size = new System.Drawing.Size(308, 38);
            itemIdLabel.TabIndex = 89;
            itemIdLabel.Text = "Item Id";
            itemIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            itemIdLabel.UseMnemonic = false;
            // 
            // txtItemId
            // 
            this.txtItemId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.txtItemId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtItemId.ForeColor = System.Drawing.Color.Black;
            this.txtItemId.Location = new System.Drawing.Point(103, 87);
            this.txtItemId.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(254, 28);
            this.txtItemId.TabIndex = 88;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.Location = new System.Drawing.Point(103, 453);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(254, 28);
            this.txtPrice.TabIndex = 87;
            // 
            // priceLabel
            // 
            priceLabel.AccessibleName = "shopsLabel";
            priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            priceLabel.BackColor = System.Drawing.Color.Transparent;
            priceLabel.Font = new System.Drawing.Font("Limelight", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            priceLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            priceLabel.Location = new System.Drawing.Point(77, 404);
            priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(308, 38);
            priceLabel.TabIndex = 86;
            priceLabel.Text = "Price";
            priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            priceLabel.UseMnemonic = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(103, 364);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(254, 28);
            this.txtName.TabIndex = 85;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.txtCategoryId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategoryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCategoryId.ForeColor = System.Drawing.Color.Black;
            this.txtCategoryId.Location = new System.Drawing.Point(103, 274);
            this.txtCategoryId.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(254, 28);
            this.txtCategoryId.TabIndex = 84;
            // 
            // shopIdlabel
            // 
            shopIdlabel.AccessibleName = "shopsLabel";
            shopIdlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            shopIdlabel.BackColor = System.Drawing.Color.Transparent;
            shopIdlabel.Font = new System.Drawing.Font("Limelight", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            shopIdlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            shopIdlabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            shopIdlabel.Location = new System.Drawing.Point(77, 130);
            shopIdlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            shopIdlabel.Name = "shopIdlabel";
            shopIdlabel.Size = new System.Drawing.Size(308, 38);
            shopIdlabel.TabIndex = 83;
            shopIdlabel.Text = "Shop Id";
            shopIdlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            shopIdlabel.UseMnemonic = false;
            // 
            // categoryIdlabel
            // 
            categoryIdlabel.AccessibleName = "shopsLabel";
            categoryIdlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            categoryIdlabel.BackColor = System.Drawing.Color.Transparent;
            categoryIdlabel.Font = new System.Drawing.Font("Limelight", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoryIdlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            categoryIdlabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            categoryIdlabel.Location = new System.Drawing.Point(77, 224);
            categoryIdlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            categoryIdlabel.Name = "categoryIdlabel";
            categoryIdlabel.Size = new System.Drawing.Size(308, 38);
            categoryIdlabel.TabIndex = 82;
            categoryIdlabel.Text = "Category Id";
            categoryIdlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            categoryIdlabel.UseMnemonic = false;
            // 
            // nameLabel
            // 
            nameLabel.AccessibleName = "shopsLabel";
            nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            nameLabel.BackColor = System.Drawing.Color.Transparent;
            nameLabel.Font = new System.Drawing.Font("Limelight", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            nameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            nameLabel.Location = new System.Drawing.Point(77, 315);
            nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(308, 38);
            nameLabel.TabIndex = 81;
            nameLabel.Text = "Name";
            nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            nameLabel.UseMnemonic = false;
            // 
            // txtShopId
            // 
            this.txtShopId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.txtShopId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtShopId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtShopId.ForeColor = System.Drawing.Color.Black;
            this.txtShopId.Location = new System.Drawing.Point(103, 179);
            this.txtShopId.Margin = new System.Windows.Forms.Padding(2);
            this.txtShopId.Name = "txtShopId";
            this.txtShopId.Size = new System.Drawing.Size(254, 28);
            this.txtShopId.TabIndex = 80;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkSalmon;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Gadugi", 14.25F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.btnCancel.Location = new System.Drawing.Point(324, 507);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 37);
            this.btnCancel.TabIndex = 79;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.DarkSalmon;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Gadugi", 14.25F);
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.btnOK.Location = new System.Drawing.Point(23, 507);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(116, 37);
            this.btnOK.TabIndex = 78;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(464, 564);
            this.Controls.Add(itemIdLabel);
            this.Controls.Add(this.txtItemId);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(shopIdlabel);
            this.Controls.Add(categoryIdlabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.txtShopId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ItemForm_FormClosing);
            this.Load += new System.EventHandler(this.ItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.TextBox txtShopId;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}