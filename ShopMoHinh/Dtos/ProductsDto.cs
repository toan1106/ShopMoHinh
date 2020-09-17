using ShopMoHinh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopMoHinh.Dtos
{
    public class ProductsDto
    {
        public int Id { get; set; }
        public int catalog_id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public string Image_link { get; set; }
        public DateTime Create { get; set; }
        public int View { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
