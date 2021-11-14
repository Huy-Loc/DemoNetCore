using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models{
    [Table("Person")]
    public class Person{
        [Key]
        public string PersonID  { get; set; }
        public string PersonName { get; set; }
       
    }
}