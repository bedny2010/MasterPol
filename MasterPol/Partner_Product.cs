//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MasterPol
{
    using System;
    using System.Collections.Generic;
    
    public partial class Partner_Product
    {
        public int OrderID { get; set; }
        public int Partner { get; set; }
        public decimal QuantityProduction { get; set; }
        public int Manager { get; set; }
        public string ProductArticle { get; set; }
        public System.DateTime DateOfSale { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Partner Partner1 { get; set; }
        public virtual Product Product { get; set; }
    }
}