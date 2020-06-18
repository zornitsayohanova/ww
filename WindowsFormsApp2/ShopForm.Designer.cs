namespace WindowsFormsApp2
{
    partial class ShopForm
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
            System.Windows.Forms.Label shopIdLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label shopsLabel;
            this.txtShopId = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddShop = new System.Windows.Forms.Button();
            shopIdLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            shopsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            shopIdLabel.Location = new System.Drawing.Point(80, 32);
            shopIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            shopIdLabel.Name = "shopIdLabel";
            shopIdLabel.Size = new System.Drawing.Size(308, 41);
            shopIdLabel.TabIndex = 63;
            shopIdLabel.Text = "Shop Id";
            shopIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            shopIdLabel.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AccessibleName = "shopsLabel";
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Limelight", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            label2.Location = new System.Drawing.Point(75, 127);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(308, 41);
            label2.TabIndex = 59;
            label2.Text = "Name";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label2.UseMnemonic = false;
            // 
            // label1
            // 
            label1.AccessibleName = "shopsLabel";
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Limelight", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            label1.Location = new System.Drawing.Point(80, 219);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(303, 41);
            label1.TabIndex = 58;
            label1.Text = "Address";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label1.UseMnemonic = false;
            // 
            // shopsLabel
            // 
            shopsLabel.AccessibleName = "shopsLabel";
            shopsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            shopsLabel.BackColor = System.Drawing.Color.Transparent;
            shopsLabel.Font = new System.Drawing.Font("Limelight", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            shopsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            shopsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            shopsLabel.Location = new System.Drawing.Point(80, 315);
            shopsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            shopsLabel.Name = "shopsLabel";
            shopsLabel.Size = new System.Drawing.Size(308, 41);
            shopsLabel.TabIndex = 57;
            shopsLabel.Text = "Description";
            shopsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            shopsLabel.UseMnemonic = false;
            // 
            // txtShopId
            // 
            this.txtShopId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.txtShopId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtShopId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtShopId.ForeColor = System.Drawing.Color.Black;
            this.txtShopId.Location = new System.Drawing.Point(107, 84);
            this.txtShopId.Margin = new System.Windows.Forms.Padding(2);
            this.txtShopId.Name = "txtShopId";
            this.txtShopId.Size = new System.Drawing.Size(254, 28);
            this.txtShopId.TabIndex = 62;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(107, 367);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(254, 28);
            this.txtDescription.TabIndex = 61;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(107, 271);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(254, 28);
            this.txtAddress.TabIndex = 60;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(107, 179);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(254, 28);
            this.txtName.TabIndex = 56;
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
            this.btnCancel.Location = new System.Drawing.Point(323, 417);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 37);
            this.btnCancel.TabIndex = 55;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAddShop
            // 
            this.btnAddShop.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnAddShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnAddShop.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddShop.FlatAppearance.BorderColor = System.Drawing.Color.DarkSalmon;
            this.btnAddShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddShop.Font = new System.Drawing.Font("Gadugi", 14.25F);
            this.btnAddShop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.btnAddShop.Location = new System.Drawing.Point(26, 417);
            this.btnAddShop.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddShop.Name = "btnAddShop";
            this.btnAddShop.Size = new System.Drawing.Size(116, 37);
            this.btnAddShop.TabIndex = 54;
            this.btnAddShop.Text = "OK";
            this.btnAddShop.UseVisualStyleBackColor = false;
            // 
            // ShopForm
            // 
            this.AccessibleName = "ShopForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(465, 472);
            this.Controls.Add(shopIdLabel);
            this.Controls.Add(this.txtShopId);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(shopsLabel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddShop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShopForm";
            this.Text = "ShopForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShopForm_FormClosing);
            this.Load += new System.EventHandler(this.ShopForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtShopId;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddShop;
    }
}