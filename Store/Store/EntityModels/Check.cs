//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Store.EntityModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class Check
    {
        public int Id { get; set; }
        public decimal Money { get; set; }
        public string Date { get; set; }
        public string CardId { get; set; }
        public string refUser { get; set; }
        public Nullable<System.Guid> refDevice { get; set; }
        public int quentity { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Device Device { get; set; }
    }
}
