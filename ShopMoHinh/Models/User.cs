using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopMoHinh.Models
{

    public class User : IdentityUser
    {
        //Họ tên
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Mật Khẩu
        public string Password { get; set; }
        //Địa chỉ
        public string Address { get; set; }
        //Thời điểm đăng kí thành viên
        public DateTime Created { get; set; }
    }
}
