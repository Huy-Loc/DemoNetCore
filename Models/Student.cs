using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models{
    [Table("Student")]
    public class Student{
        [Key]
        [Required(ErrorMessage ="Mã sinh viên không được để trống")]
        [Display(Name = "Mã sinh viên")]
        public string StudentID { get; set; }
        [Required(ErrorMessage ="Tên sinh viên không được để trống")]
        [Display(Name = "Tên sinh viên")]
        public string StudentName { get; set; }

        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }
        [RegularExpression(@"[0-9]", ErrorMessage ="xin mời nhập số")]
        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { get; set; }

       
    }
}