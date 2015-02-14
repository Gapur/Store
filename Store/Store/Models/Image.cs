using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class Image
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Путь")]
        public string Url { get; set; }
    
        public System.Guid refDevice { get; set; }
    }
}