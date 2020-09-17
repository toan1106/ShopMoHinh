using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopMoHinh.Models
{ 
    //Sản phẩm
    public class Product
    {
        //Khóa chính
        [Key]
        public int Id { get; set; }
        //Id của danh mục sản phẩm
        public int catalog_id { get; set; }
        //Tên sản phẩm
        public string Name { get; set; }
        //Giá sản phẩm
        public double Price { get; set; }
        //Lưu Chiết khấu
        public double Discount { get; set; }
        //Lưu link ảnh sản phẩm
        public string Image_link { get; set; }
        //Lưu list link ảnh sản phẩm đính kèm
        //public List<string> Image_list { get; set; }
        //Thời điểm tạo sản phẩm
        public DateTime Create { get; set; }
        //Lượt xem sản phẩm
        public int View { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
