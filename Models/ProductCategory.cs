using System.ComponentModel.DataAnnotations;

namespace ERPCloudMaker.Models
{
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public string? UnderGroup { get; set; } 
        public DateTime? CreatedOn { get; set; }
    }
}
