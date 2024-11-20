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
    
    public partial class Material
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Material()
        {
            this.MaterialCountHistory = new HashSet<MaterialCountHistory>();
            this.Suplly = new HashSet<Suplly>();
            this.Product = new HashSet<Product>();
        }
    
        public int ID_Material { get; set; }
        public int Material_Type { get; set; }
        public string Material_Name { get; set; }
        public int Material_Supplier { get; set; }
        public decimal Material_Quantity { get; set; }
        public string Material_Unit { get; set; }
        public string Material_Description { get; set; }
        public string Material_Photo { get; set; }
        public decimal Material_Cost { get; set; }
        public decimal Material_QuantityInStock { get; set; }
        public decimal Material_MinAvailableQuantity { get; set; }
    
        public virtual Material_Type Material_Type1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialCountHistory> MaterialCountHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Suplly> Suplly { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Product { get; set; }
    }
}
