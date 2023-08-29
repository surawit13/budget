using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcore.Models
{
    public class User
    {
        public int id { get; set; }
        public required  string first_name { get; set; }
        public required  string last_name { get; set; }
        public DateTime update_date {get;set;}
        public required  string update_by {get;set;}
        
    }
}