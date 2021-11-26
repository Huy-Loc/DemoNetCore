using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models{

    public class SuperCar:Car{
     
        public string SuperCarID  { get; set; }
        public string SuperCarName { get; set; }
        public string SuperCarPrice { get; set; }
       
    }
}