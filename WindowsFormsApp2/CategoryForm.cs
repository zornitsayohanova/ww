using ShopApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        public Category FormCategory { get; set; }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            if (FormCategory != null)
            {
                txtCategoryId.Text = FormCategory.CategoryId.ToString();
                txtName.Text = FormCategory.CategoryName;
                txtShopId.Text = FormCategory.ShopId.ToString();
            }
        }

        private void CategoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FormCategory == null)
                FormCategory = new Category();

            FormCategory.CategoryId = txtCategoryId.Text;
            FormCategory.CategoryName = txtName.Text;
            FormCategory.ShopId = txtShopId.Text;
        }

        private void btnAddShop_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void shopIdLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
