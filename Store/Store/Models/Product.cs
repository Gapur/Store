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
        [DataType(DataType.Date)]
        public string Date { get; set; }

        [Display(Name = "Цвет")]
        public string Color { get; set; }

        [Display(Name = "Оперативная память, Гб")]
        public int RAM { get; set; }

        [Display(Name = "Операционная система")]
        public string OperatingSystem { get; set; }

        [Display(Name = "WiFi")]
        public bool WiFi { get; set; }

        [Display(Name = "Производитель")]
        public Manufacturer Manufacturers { get; set; }

        [Display(Name = "Bluetooth")]
        public bool Bluetooth { get; set; }

        [Display(Name = "Объем встроенной памяти, Гб")]
        public string BuildMemory { get; set; }

        [Display(Name = "Процессор")]
        public Processor Processor { get; set; }

        [Display(Name = "Изображение")]
        public IEnumerable<Image> Images { get; set; }

        [Display(Name = "Мощность")]
        public Power Power { get; set; }

        [Display(Name = "Видеокарта, Гб")]
        public VideoCard VideoCard { get; set; }

        [Display(Name = "Жесткий диск, Гб")]
        public HardDisk HadrDisk { get; set; }

        [Display(Name = "Дисплей")]
        public Display Display { get; set; }

        [Display(Name = "Камера(mpx)")]
        public Camera Camera { get; set; }

        [Display(Name = "Тип продукта")]
        public int TypeProduct { get; set; }
    }
}