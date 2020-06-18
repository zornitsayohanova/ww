using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public class Shop
    {
        [Key]
        public string ShopId { get; set; }
        public string ShopName { get; set; }
        public string ShopAddress { get; set; }
        public string Description { get; set; }
        ICollection<Category> Categories { get; set; }
    }
}
