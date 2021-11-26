using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models{

    public class Car{
        [Key]
        public string CarID  { get; set; }
        public string CarName { get; set; }
       
    }
}