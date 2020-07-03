using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Core_Demo.Models
{
    public class Food
    {
        
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public string type { get; set; }
        public int price { get; set; }
        public string decription { get; set; }
    }
}
