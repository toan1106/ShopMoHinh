using ShopMoHinh.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopMoHinh.Dtos
{
    public class OrderDetailsDto
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int OrderId { get; set; }
        public int Productid { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
