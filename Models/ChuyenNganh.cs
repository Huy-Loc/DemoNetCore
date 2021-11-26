using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
 
    public class ChuyenNganh
    {
        [Key]
        public int ChuyenNganhId { get; set; }

        [Display(Name ="Tên Chuyen Nganh")]
        public string ChuyenNganhName { get; set; }

        public int KhoaId { get; set; }
        public Khoa Khoa {get; set;}

    }
}