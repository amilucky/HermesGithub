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
    
    public partial class vPromotionsNIV
    {
        public int customer_id { get; set; }
        public int product_id { get; set; }
        public int volume { get; set; }
        public double gsv_item { get; set; }
        public double discount_on { get; set; }
        public double on_te { get; set; }
        public double niv_item { get; set; }
        public Nullable<double> leaflet_fee_item { get; set; }
        public Nullable<double> secondaryplacement_fee_item { get; set; }
        public double discount_off { get; set; }
        public double off_te { get; set; }
        public double pc { get; set; }
        public double cc { get; set; }
        public int casecount { get; set; }
    }
}
