using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopMoHinh.Models
{ 
    //Bảng giao dịch
    public class Transaction
    {
        //Khóa chính
        public int Id { get; set; }
        //Lưu trạng thái của giao dich để biết giao dịch thành công hay chưa
        public bool Status { get; set; }
        //Id của khách mu hàng
        public int user_id { get; set; }
        //tên khách mua hàng
        public string user_name { get; set; }
        //email khách mua hàng
        public string user_email { get; set; }
        //số điện thoại khách mua
        public int user_phone { get; set; }
        //Tổng số tiền thanh toán
        public double amount { get; set; }
        //tên cổng thanh toán khách hàng chọn để thanh toán
        public string Payment { get; set; }
        //thông tin từ cổng thanh toán gửi về
        public string Payment_Info { get; set; }
        //Nội dung yêu cầu của khách 
        public string Message { get; set; }
        //Mã bảo mật giao dịch
        public string Security { get; set; }
        //thời điểm tạo giao dịch
        public DateTime Created { get; set; }
    }
}
