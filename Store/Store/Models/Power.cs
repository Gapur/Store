using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class Power
    {
        public int Id { get; set; }

        [Display(Name = "Время работы")]
        public string BatteryWork { get; set; }

        [Display(Name = "Тип батареи")]
        public string BatteryType { get; set; }

        [Display(Name = "Время зарядки")]
        public string ChargeTime { get; set; }
    }
}