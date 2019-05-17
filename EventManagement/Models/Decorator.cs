using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventManagement.Models
{
    public class Decorator
    {
        [Key]
        public int DecoratorID { get; set; }
        public string DecoratorsName { get; set; }
        public long Charges { get; set; }
    }
}