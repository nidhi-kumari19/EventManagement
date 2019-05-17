using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventManagement.Models
{
    public class Purohith
    {
       [Key]
        public int PurohithID { get; set; }
        public string PurohithName { get; set; }
        public long Contact { get; set; }
        public string EmailID { get; set; }
        public long Charges { get; set; }
    }
}