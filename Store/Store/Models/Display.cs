using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class Display
    {
        public int Id { get; set; }

        [Display(Name = "Разрешение экрана")]
        public string ScreenResolution { get; set; }

        [Display(Name = "Ширина")]
        public string Width { get; set; }

        [Display(Name = "Высота")]
        public string Height { get; set; }

        [Display(Name = "Формат экрана")]
        public string FormatScreen { get; set; }
    }
}