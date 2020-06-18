using ShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ShopContext context)
        {
            context.Database.EnsureCreated();

            if (context.Categories.Any())
            {
                return;
            }
            var shops = new Shop[]
            {
              new Shop{ShopId="1", ShopName="Futurstica South", ShopAddress="Doyran Blvd. 22, Beli Brezi, Sofia", Description="Our newest shop"},
              new Shop{ShopId="2", ShopName="Futurstica East", ShopAddress="Shiptchenski prohod Blvd. 18, Geo Milev, Sofia", Description="Our biggest shop with products on sale"},
            };
            foreach (Shop shop in shops)
            {
                context.Shops.Add(shop);
            }
            var categories = new Category[]
            {
              new Category{CategoryId="1", CategoryName="Bracelets", ShopId="1"},
              new Category{CategoryId="2", CategoryName="Wallets", ShopId="1"},
              new Category{CategoryId="3", CategoryName="Bags", ShopId="2"}
            };
            foreach (Category category in categories)
            {
                context.Categories.Add(category);
            }
            var items = new Item[]
            {
             new Item{ItemId="1", Name="Blue bag", Price=10, ShopId="1", CategoryId="3"}
            };
            foreach (Item item in items)
            {
                context.Items.Add(item);
            }
            context.SaveChanges();
        }
    }
}
