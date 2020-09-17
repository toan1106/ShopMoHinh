using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShopMoHinh.Models
{
    public class Order
    {
        //Khóa chính
        [Key]
        public int Id { get; set; }
        //Id giao dịch
        public int transaction_id { get; set; }
        //Id của sản phẩm
        public int product_id { get; set; }
        public string CreatedBy { get; set; }
        public string Sku { get; set; }
        public DateTime CreatedAt { get; set; }
        //Số lượng sản phẩm
        public int quatity { get; set; }
        //Số tiền tổng đơn hàng
        public double amount { get; set; }
        //trạng thái đơn hàng đã gửi hay chưa
        public bool Status { get; set; }
        [ForeignKey("UserNameId")]
        public virtual User User { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
