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
    
    public partial class abuthpayment
    {
        public int Id { get; set; }
        public string TransId { get; set; }
        public string PosId { get; set; }
        public string PatientName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string UserId { get; set; }
        public decimal TotalAmount { get; set; }
        public System.DateTime TransDate { get; set; }
        public bool IsRemitted { get; set; }
        public string RemittanceId { get; set; }
        public System.DateTime Create_At { get; set; }
        public string ItemId { get; set; }
        public string offlineTransId { get; set; }
    }
}
