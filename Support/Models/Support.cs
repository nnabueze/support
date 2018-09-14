using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Support.Models
{
    public class Support
    {
    }

    public class tin
    {
        public string tin_id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string IGR_Code { get; set; }
        public string tin_no { get; set; }
        public string temporary_tin { get; set; }
        public string phone { get; set; }
        public DateTime created_at { get; set; }
    }
}