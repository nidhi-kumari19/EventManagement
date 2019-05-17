using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventManagement.Models
{
    public class UserDetails
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string EmailID { get; set; }
        public long Mobile { get; set; }
        public string Category { get; set; }
        public double Cost { get; set; }
    }
}