using System.ComponentModel.DataAnnotations;

namespace NMD_BaiThi23_24.Models
{
    public class Student
    {
        [Key]
        public string MaSinhVien { get; set; }
        public string TenSinhVien { get; set; }
        public string DiaChi { get; set; }
    }

}