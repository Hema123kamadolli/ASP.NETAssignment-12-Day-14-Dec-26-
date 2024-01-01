using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment_12.Models
{
    
    public class Cricket
    {
        [Key]
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public int NOWC { get; set; }
    }
}