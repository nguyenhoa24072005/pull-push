using System;
using System.ComponentModel.DataAnnotations;

namespace ComicRentalSystem.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        // Đảm bảo các thuộc tính FullName và PhoneNumber không được null
        public required string FullName { get; set; }
        public required string PhoneNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }

        // Thêm constructor để khởi tạo các thuộc tính không nullable
        public Customer(string fullName, string phoneNumber)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
            RegistrationDate = DateTime.Now;  // Khởi tạo RegistrationDate nếu cần
        }
    }
}
