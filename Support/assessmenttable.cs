//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Support
{
    using System;
    using System.Collections.Generic;
    
    public partial class assessmenttable
    {
        public int Assessment_ID { get; set; }
        public Nullable<System.DateTime> AssessmentDate { get; set; }
        public Nullable<int> TaxPayer { get; set; }
        public Nullable<bool> Remitted { get; set; }
        public Nullable<System.DateTime> DateRemitted { get; set; }
        public string AssessmentType { get; set; }
        public string State { get; set; }
        public string LGA { get; set; }
        public string AssessmentItem { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> Asset { get; set; }
    
        public virtual asset asset1 { get; set; }
        public virtual mda mda { get; set; }
        public virtual igr igr { get; set; }
        public virtual taxpayer taxpayer1 { get; set; }
    }
}
