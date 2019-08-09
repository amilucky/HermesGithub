//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace hermesmvc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Actuals = new HashSet<Actual>();
            this.ProductsPrices = new HashSet<ProductsPrice>();
            this.PromotionsDetails = new HashSet<PromotionsDetail>();
        }
    
        public int id { get; set; }
        public string internal_code_1 { get; set; }
        public string internal_code_2 { get; set; }
        public string ean { get; set; }
        public bool deactive { get; set; }
        public int promogroup_id { get; set; }
        public string size { get; set; }
        public string name { get; set; }
        public int casecount { get; set; }
        public Nullable<double> gsv { get; set; }
        public Nullable<double> pc { get; set; }
        public Nullable<double> cc { get; set; }

        public bool isChecked { get; set; } = false;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Actual> Actuals { get; set; }
        public virtual PromoGroup PromoGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductsPrice> ProductsPrices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PromotionsDetail> PromotionsDetails { get; set; }
    }
}
