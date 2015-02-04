using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Store.Models
{
    public class Processor
    {
        public System.Guid Id { get; set; }

        [Display(Name = "Производитель")]
        public int Manufacturer { get; set; }

        [Display(Name = "Тип процессора")]
        public string Type { get; set; }

        [Display(Name = "Тактовая частота")]
        public string ClockSpeed { get; set; }

        [Display(Name = "Количество ядер")]
        public int CountCore { get; set; }
    }
}