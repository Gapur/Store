using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class Camera
    {
        public int Id { get; set; }

        [Display(Name = "Разрешение матрицы")]
        public string ResolutionMatrix { get; set; }

        [Display(Name = "Максимальная разрешение экрана")]
        public string MaxResolution { get; set; }
    }
}