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
    public partial class ShopForm : Form
    {
        public Shop FormShop { get; set; }

        public ShopForm()
        {
            InitializeComponent();
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            if (FormShop != null)
            {
                txtShopId.Text = FormShop.ShopId;
                txtName.Text = FormShop.ShopName;
                txtAddress.Text = FormShop.ShopAddress;
                txtDescription.Text = FormShop.Description;
            }
        }

        private void ShopForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FormShop == null) 
                FormShop = new Shop();

            FormShop.ShopId = txtShopId.Text;
            FormShop.ShopName = txtName.Text;
            FormShop.ShopAddress = txtAddress.Text;
            FormShop.Description = txtDescription.Text;
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
