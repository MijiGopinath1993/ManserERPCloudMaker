using System.ComponentModel.DataAnnotations;

namespace ERPCloudMaker.Models
{
    public class ProductGroups
    {
        [Key]
        public int Id { get; set; }
        public string? GroupName { get; set; } 
        public string? UnderGroup  { get; set; }
        public string? UnitName  { get; set; } 
        public string? TotalQuantity  { get; set; }
        public string? OrderNumber   { get; set; }
        public DateTime? CreatedOn { get; set; }

    }
}
