using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public class Category
    {
        [Key]
        public string CategoryId { get; set; }
        public string ShopId { get; set; }
        public string CategoryName { get; set; }
        ICollection<Item> Items { get; set; }
    }
}
