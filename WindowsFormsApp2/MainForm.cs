using ShopApp.Data;
using ShopApp.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadShops();
            LoadCategories();
            LoadItems();
        }

        private void LoadShops()
        {
            using (ShopContext context = new ShopContext())
            {
                dataGridViewShops.DataSource = context.Shops
                                                      .Select(s => new { s.ShopId, s.ShopName, s.ShopAddress, s.Description })
                                                      .ToList();
                context.SaveChanges();
            }
            dataGridViewShops.AutoGenerateColumns = true;
        }

        private void LoadCategories()
        {
            using (ShopContext context = new ShopContext())
            {
                dataGridViewCategories.DataSource = context.Categories
                                                           .Select(c => new { c.ShopId, c.CategoryId, c.CategoryName })
                                                           .ToList();
                context.SaveChanges();
            }
        }

        private void LoadItems()
        {
            using (ShopContext context = new ShopContext())
            {
                dataGridViewItems.DataSource = context.Items
                                                      .Select(i => new { i.CategoryId, i.ShopId, i.ItemId, i.Name, i.Price})
                                                      .ToList();
                context.SaveChanges();
            }
        }

        private void btnAddShop_Click(object sender, EventArgs e)
        {
            ShopForm shop = new ShopForm();

            if (DialogResult.OK == shop.ShowDialog())
            {
                using (ShopContext context = new ShopContext())
                {
                    Shop newShop = new Shop()
                    {
                        ShopId = shop.FormShop.ShopId,
                        ShopName = shop.FormShop.ShopName,
                        ShopAddress = shop.FormShop.ShopAddress,
                        Description = shop.FormShop.Description
                    };
                    context.Shops.Add(newShop);

                    context.SaveChanges();
                }
                LoadShops();
            }
        }

        private void btnEditShop_Click(object sender, EventArgs e)
        {
            if (dataGridViewShops.SelectedRows.Count > 0)
            {
                using (ShopContext context = new ShopContext())
                {
                    string shopID = dataGridViewShops.SelectedRows[0].Cells["ShopId"].Value.ToString();

                    ShopForm shop = new ShopForm();
                    shop.FormShop = context.Shops.First(x => x.ShopId == shopID);
                    if (DialogResult.OK == shop.ShowDialog())
                    {
                        context.SaveChanges();
                    }
                }
                LoadShops();
            }
        }

        private void btnDeleteShop_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo))
            {
                if (dataGridViewShops.SelectedRows.Count > 0)
                {
                    string shopID = dataGridViewShops.SelectedRows[0].Cells["ShopId"].Value.ToString();

                    using (ShopContext context = new ShopContext())
                    {
                        context.Shops.Remove(context.Shops.First(x => x.ShopId == shopID));
                        context.Categories.RemoveRange(context.Categories.Where(x => x.ShopId == shopID));
                        context.Items.RemoveRange(context.Items.Where(x => x.ShopId == shopID));

                        context.SaveChanges();
                    }
                    LoadShops();
                    LoadCategories();
                    LoadItems();
                }
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();

            if (DialogResult.OK == category.ShowDialog())
            {
                using (ShopContext context = new ShopContext())
                {
                    Category newCategory = new Category()
                    {
                        CategoryId = category.FormCategory.CategoryId,
                        CategoryName = category.FormCategory.CategoryName,
                        ShopId = category.FormCategory.ShopId
                    };
                    context.Categories.Add(newCategory);
     
                    context.SaveChanges();             
                }
                LoadCategories();
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategories.SelectedRows.Count > 0)
            {
                using (ShopContext context = new ShopContext())
                {
                    string categoryID = dataGridViewCategories.SelectedRows[0].Cells["CategoryId"].Value.ToString();

                    CategoryForm category = new CategoryForm();
                    category.FormCategory = context.Categories.First(x => x.CategoryId == categoryID);
                    if (DialogResult.OK == category.ShowDialog())
                    {
                        context.SaveChanges();
                    }
                }
                LoadCategories();
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo))
            {
                if (dataGridViewCategories.SelectedRows.Count > 0)
                {
                    string categoryID = dataGridViewCategories.SelectedRows[0].Cells["CategoryId"].Value.ToString();

                    using (ShopContext context = new ShopContext())
                    {
                        context.Categories.Remove(context.Categories.First(x => x.CategoryId == categoryID));
                        context.Items.RemoveRange(context.Items.Where(x => x.CategoryId == categoryID));

                        context.SaveChanges();
                    }
                    LoadCategories();
                    LoadItems();
                }
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ItemForm item = new ItemForm();

            if (DialogResult.OK == item.ShowDialog())
            {
                using (ShopContext context = new ShopContext())
                {
                    Item newItem = new Item()
                    {
                        ItemId = item.FormItem.ItemId,
                        ShopId = item.FormItem.ShopId,
                        CategoryId = item.FormItem.CategoryId,
                        Name = item.FormItem.Name,
                        Price = item.FormItem.Price
                    };
                    context.Items.Add(newItem);

                    context.SaveChanges();
                }
                LoadItems();
            }
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewItems.SelectedRows.Count > 0)
            {
                using (ShopContext context = new ShopContext())
                {
                    string itemID = dataGridViewItems.SelectedRows[0].Cells["ItemId"].Value.ToString();

                    ItemForm item = new ItemForm();
                    item.FormItem = context.Items.First(x => x.ItemId == itemID);
                    if (DialogResult.OK == item.ShowDialog())
                    {
                        context.SaveChanges();
                    }
                }
                LoadItems();
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo))
            {
                if (dataGridViewItems.SelectedRows.Count > 0)
                {
                    string itemID = dataGridViewItems.SelectedRows[0].Cells["ItemId"].Value.ToString();

                    using (ShopContext context = new ShopContext())
                    {
                        context.Items.Remove(context.Items.First(x => x.ItemId == itemID));

                        context.SaveChanges();
                    }
                    LoadItems();
                }
            }
        }

        private void dataGridViewShops_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridViewCategories_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridViewItems_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
