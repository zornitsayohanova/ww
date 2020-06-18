using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public class Item
    {
        [Key]
        public string ItemId { get; set; }
        public string ShopId { get; set; }
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Shop Shop { get; set; }
        public Category Category { get; set; }
    }
}
