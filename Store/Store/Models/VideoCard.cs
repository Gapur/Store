using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class VideoCard
    {
        public int Id { get; set; }

        [Display(Name = "Наименование")]
        public string Name { get; set; }

        [Display(Name = "Объем памяти")]
        public int Memory { get; set; }

        [Display(Name = "Графический контроллер")]
        public string GraphicsController { get; set; }
    }
}