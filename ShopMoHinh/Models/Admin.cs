using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopMoHinh.Models
{
    public class Admin
    {
        //Khóa Chính
        public int Id { get; set; }
        //Họ Tên
        public string Name { get; set; }
        //Tên đăng nhập
        public string Username { get; set; }
        //Mật khẩu
        public string Password { get; set; }
    }
}
