using System.ComponentModel.DataAnnotations;

namespace NMD_BaiThi23_24.Models
{
    public class Person 
    {
        [Key]
        public string HoVaTen { get; set; }
        public string MaSinhVien { get; set; }
        public string TenLop { get; set; }

    }
}