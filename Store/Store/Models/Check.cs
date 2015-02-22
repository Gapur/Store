using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class Check
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Деньги")]
        public decimal Money { get; set; }

        [Required]
        [Display(Name = "Дата оплаты")]
        public string Date { get; set; }

        [Required]
        [Display(Name = "Номер карточки")]
        public int CardId { get; set; }

        [Required]
        [Display(Name = "Пользователь")]
        public string refUser { get; set; }

        [Required]
        [Display(Name = "Купленный продукт")]
        public System.Guid refDevice { get; set; }

        public string UserInfo { get; set; }

        public Product ProductInfo { get; set; }

        [Required]
        [Display(Name = "Количество продуктов")]
        public int Quentity { get; set; }
    }
}