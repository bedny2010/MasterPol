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
    
    public partial class ProductMinCostHistory
    {
        public int ID { get; set; }
        public string ProductID { get; set; }
        public System.DateTime ChangeDate { get; set; }
        public decimal CostValue { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
