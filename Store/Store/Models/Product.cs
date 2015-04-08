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

        [Required]
        [Display(Name = "Name", ResourceType = typeof(Resources.Resource))]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Price", ResourceType = typeof(Resources.Resource))]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Date", ResourceType = typeof(Resources.Resource))]
        [DataType(DataType.Date)]
        public string Date { get; set; }

        [Required]
        [Display(Name = "Color", ResourceType = typeof(Resources.Resource))]
        public string Color { get; set; }

        [Display(Name = "WiFi")]
        public bool WiFi { get; set; }

        [Display(Name = "RAM", ResourceType = typeof(Resources.Resource))]
        public int RAM { get; set; }

        [Display(Name = "OperatingSystem", ResourceType = typeof(Resources.Resource))]
        public string OperatingSystem { get; set; }

        [Required]
        [Display(Name = "Manufacturers", ResourceType = typeof(Resources.Resource))]
        public Manufacturer Manufacturers { get; set; }

        [Display(Name = "Bluetooth")]
        public bool Bluetooth { get; set; }

        [Display(Name = "BuildMemory", ResourceType = typeof(Resources.Resource))]
        public string BuildMemory { get; set; }

        [Display(Name = "Processor", ResourceType = typeof(Resources.Resource))]
        public Processor Processor { get; set; }

        [Display(Name = "Images", ResourceType = typeof(Resources.Resource))]
        public Image Images { get; set; }

        [Display(Name = "Power", ResourceType = typeof(Resources.Resource))]
        public Power Power { get; set; }

        [Display(Name = "VideoCard", ResourceType = typeof(Resources.Resource))]
        public VideoCard VideoCard { get; set; }

        [Display(Name = "HardDisk", ResourceType = typeof(Resources.Resource))]
        public HardDisk HardDisk { get; set; }

        [Display(Name = "Display", ResourceType = typeof(Resources.Resource))]
        public Display Display { get; set; }

        [Display(Name = "Camera", ResourceType = typeof(Resources.Resource))]
        public Camera Camera { get; set; }

        [Required]
        [Display(Name = "TypeProduct", ResourceType = typeof(Resources.Resource))]
        public int TypeProduct { get; set; }
    }
}