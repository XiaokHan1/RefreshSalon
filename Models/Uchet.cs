//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RefreshSalon.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Uchet
    {
        public int Id { get; set; }
        public System.DateTime Datelspol { get; set; }
        public int IdSotrudnik { get; set; }
        public int IdMaterial { get; set; }
        public decimal Zena { get; set; }
        public int Kolvo { get; set; }
        public Nullable<decimal> Summa { get; set; }
    
        public virtual Material Material { get; set; }
        public virtual Sotrudnik Sotrudnik { get; set; }
    }
}
