//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
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
        [System.ComponentModel.DataAnnotations.DisplayFormat(DataFormatString = "{0:P2}")]
        public double value { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Segment Segment { get; set; }
        public virtual FixedTE_details FixedTE_details { get; set; }
    }
}
