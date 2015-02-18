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

        [Display(Name = "Деньги")]
        public decimal Money { get; set; }

        [Display(Name = "Дата оплаты")]
        public string Date { get; set; }

        [Display(Name = "Номер карточки")]
        public int CardId { get; set; }

        [Display(Name = "Пользователь")]
        public string refUser { get; set; }

        [Display(Name = "Купленный продукт")]
        public System.Guid refDevice { get; set; }

        public Product ProductInfo { get; set; }

        [Display(Name = "Количество продуктов")]
        public int Quentity { get; set; }
    }
}