using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventManagement.Models
{
    public class Catering
    {
        [Key]
        public int CateringID { get; set; }
        public string CatererName { get; set; }
        public long CatererContact { get; set; }
        public long Charges { get; set; }
    }
}