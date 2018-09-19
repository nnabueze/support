using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Support.Models
{
    public class Utility
    {
    }

    public class TinRequest
    {
        [Required]
        public string name { get; set; }
        public string email { get; set; }
        [Required]
        public string phone { get; set; }

        public string bvn { get; set; }

        public string address { get; set; }
        
        public string biller { get; set; }
    }

    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string SourceData { get; set; }
        public int Ticket_Status { get; set; }
        public string TicketId { get; set; }
        public string TinId { get; set; }
        public DateTime Created_at { get; set; }
    }
}