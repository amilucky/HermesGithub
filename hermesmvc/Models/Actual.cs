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
    
    public partial class Actual
    {
        public int id { get; set; }
        public int customer_id { get; set; }
        public int product_id { get; set; }
        public System.DateTime date { get; set; }
        public double value { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
