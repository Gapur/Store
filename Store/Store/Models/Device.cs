using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class Device
    {
        public System.Guid Id { get; set; }

        [Display(Name = "Оперативная память")]
        public int RAM { get; set; }

        [Display(Name = "WiFi")]
        public bool WiFi { get; set; }

        [Display(Name = "Производитель")]
        public int refManufacturers{get;set;}

        [Display(Name = "Bluetooth")]
        public bool Bluetooth { get; set; }

        [Display(Name = "Тип продукта")]
        public int refDicProdType{get;set;}

        [Display(Name = "Объем встроенной памяти")]
        public int BuildMemory { get; set; }

        [Display(Name = "Процессор")]
        public System.Guid refProcessor { get; set; }
    }
}