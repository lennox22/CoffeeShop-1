using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace CoffeeShop.Models
{
    [Table("product")]
    public class product
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string category { get; set; }

        public override string ToString()
        {
            return $"{id} - {Name} - {Description} - {Price} - {category}";
        }
    }
}
