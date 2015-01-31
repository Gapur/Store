using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class Product
    {
        public System.Guid Id { get; set; }

        [Display(Name = "Наименование")]
        public string Name { get; set; }

        [Display(Name = "Цена")]
        public decimal Price { get; set; }

        [Display(Name = "Дата поступление продукта")]
        public string Date { get; set; }

        [Display(Name = "Цвет")]
        public string Color { get; set; }

        [Display(Name = "Оперативная память")]
        public int RAM { get; set; }

        [Display(Name = "WiFi")]
        public bool WiFi { get; set; }

        [Display(Name = "Производитель")]
        public int refManufacturers { get; set; }

        [Display(Name = "Bluetooth")]
        public bool Bluetooth { get; set; }

        [Display(Name = "Тип продукта")]
        public int refDicProdType { get; set; }

        [Display(Name = "Объем встроенной памяти")]
        public string BuildMemory { get; set; }

        [Display(Name = "Процессор")]
        public System.Guid refProcessor { get; set; }

        [Display(Name = "Изображение")]
        public IEnumerable<Image> Images { get; set; }
    }
}