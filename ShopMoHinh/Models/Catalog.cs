using System;
using System.Collections.Generic;
using System.Text;

namespace ShopMoHinh.Models
{
    public class Catalog
    {
        //Khóa chính
        public int Id { get; set; }
        //Tên danh mục
        public string Name { get; set; }
        //Id của danh mục cha
        public int parent_id { get; set; }
        //Vị trí sắp xếp
        public int Sort_order { get; set; }
    }
}
