﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Key]
        public int TicketId { get; set; }
        public string TinId { get; set; }
        public DateTime Created_at { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }

    public class TicketPost
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Message { get; set; }
        public string type { get; set; }
    }

    public class TicketViewModel
    {
        public Ticket ticket { get; set; }
        public List<Comment> Comment { get; set; }

    }

    public class Comment
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public int CommentId { get; set; }
        public string CommenterName { get; set; }
        public string CommentMessage { get; set; }
        public DateTime Created_at { get; set; }

        [ForeignKey(nameof(TicketId))]
        public virtual Ticket Ticket { get; set; }
    }
}