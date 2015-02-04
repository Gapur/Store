using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class HardDisk
    {        
        public int Id { get; set; }

        public string HDD { get; set; }

        public string SSD { get; set; }
    }
}