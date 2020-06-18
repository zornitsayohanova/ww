using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopApp.Models;

namespace WindowsFormsApp2
{
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();
        }

        public Item FormItem { get; set; }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            if (FormItem != null)
            {
                txtItemId.Text = FormItem.ItemId.ToString();
                txtShopId.Text = FormItem.ShopId.ToString();
                txtCategoryId.Text = FormItem.CategoryId.ToString();
                txtName.Text = FormItem.Name;
                txtPrice.Text = FormItem.Price.ToString();
            }
        }

        private void ItemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FormItem == null)
                FormItem = new Item();

            if (decimal.Parse(txtPrice.Text) != 0)
            {
                FormItem.ItemId = txtItemId.Text;
                FormItem.ShopId = txtShopId.Text;
                FormItem.CategoryId = txtCategoryId.Text;
                FormItem.Name = txtName.Text;
                FormItem.Price = decimal.Parse(txtPrice.Text);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
