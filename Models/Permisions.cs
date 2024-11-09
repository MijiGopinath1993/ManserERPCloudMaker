using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ERPCloudMaker.Models
{
    public class Permisions
    {
        [Key]
        public int Id { get; set; }
         
        public string? Permisionpages { get; set; }

        public string? Pagecode { get; set; }
        public DateTime? Createdon {  get; set; }
        
    }
}
