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
    
    public partial class FixedTE
    {
        public int id { get; set; }
        public int customer_id { get; set; }
        public int year { get; set; }
        public int segment_id { get; set; }
        public int fixedte_item_id { get; set; }
        public double value { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Segment Segment { get; set; }
        public virtual FixedTE_details FixedTE_details { get; set; }
    }
}
