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
    
    public partial class Partner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Partner()
        {
            this.Partner_Product = new HashSet<Partner_Product>();
            this.PartnerSaleHistory = new HashSet<PartnerSaleHistory>();
            this.PointSale = new HashSet<PointSale>();
        }
    
        public int ID_Partner { get; set; }
        public int Partner_Type { get; set; }
        public string Partner_Name { get; set; }
        public string Partner_Index { get; set; }
        public string Partner_Region { get; set; }
        public string Partner_City { get; set; }
        public string Partner_Street { get; set; }
        public string Partner_House { get; set; }
        public string Partner_INN { get; set; }
        public string Director_Surname { get; set; }
        public string Director_Firstname { get; set; }
        public string Director_Patronymic { get; set; }
        public string Partner_Phone { get; set; }
        public string Partner_Email { get; set; }
        public string Partner_Logo { get; set; }
        public decimal Partner_Rating { get; set; }
    
        public virtual Partner_type Partner_type1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Partner_Product> Partner_Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartnerSaleHistory> PartnerSaleHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PointSale> PointSale { get; set; }
    }
}
