namespace WindowsFormsApp2
{
    partial class CategoryForm
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
            System.Windows.Forms.Label categoryIdLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label shopIdLabel;
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.txtShopId = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            categoryIdLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            shopIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.txtCategoryId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategoryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCategoryId.ForeColor = System.Drawing.Color.Black;
            this.txtCategoryId.Location = new System.Drawing.Point(103, 77);
            this.txtCategoryId.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(254, 28);
            this.txtCategoryId.TabIndex = 69;
            // 
            // categoryIdLabel
            // 
            categoryIdLabel.AccessibleName = "";
            categoryIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            categoryIdLabel.BackColor = System.Drawing.Color.Transparent;
            categoryIdLabel.Font = new System.Drawing.Font("Limelight", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoryIdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            categoryIdLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            categoryIdLabel.Location = new System.Drawing.Point(82, 24);
            categoryIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            categoryIdLabel.Name = "categoryIdLabel";
            categoryIdLabel.Size = new System.Drawing.Size(303, 42);
            categoryIdLabel.TabIndex = 68;
            categoryIdLabel.Text = "Category Id";
            categoryIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            categoryIdLabel.UseMnemonic = false;
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
            nameLabel.Location = new System.Drawing.Point(82, 119);
            nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(303, 42);
            nameLabel.TabIndex = 67;
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
            this.txtShopId.Location = new System.Drawing.Point(103, 260);
            this.txtShopId.Margin = new System.Windows.Forms.Padding(2);
            this.txtShopId.Name = "txtShopId";
            this.txtShopId.Size = new System.Drawing.Size(254, 28);
            this.txtShopId.TabIndex = 66;
            // 
            // shopIdLabel
            // 
            shopIdLabel.AccessibleName = "shopsLabel";
            shopIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            shopIdLabel.BackColor = System.Drawing.Color.Transparent;
            shopIdLabel.Font = new System.Drawing.Font("Limelight", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            shopIdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            shopIdLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            shopIdLabel.Location = new System.Drawing.Point(82, 216);
            shopIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            shopIdLabel.Name = "shopIdLabel";
            shopIdLabel.Size = new System.Drawing.Size(303, 42);
            shopIdLabel.TabIndex = 65;
            shopIdLabel.Text = "Shop Id";
            shopIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            shopIdLabel.UseMnemonic = false;
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
            this.btnCancel.Location = new System.Drawing.Point(326, 329);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 37);
            this.btnCancel.TabIndex = 64;
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
            this.btnOK.Location = new System.Drawing.Point(21, 329);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(116, 37);
            this.btnOK.TabIndex = 63;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(103, 173);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(254, 28);
            this.txtName.TabIndex = 62;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(464, 386);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(categoryIdLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.txtShopId);
            this.Controls.Add(shopIdLabel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CategoryForm_FormClosing);
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.TextBox txtShopId;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtName;
    }
}