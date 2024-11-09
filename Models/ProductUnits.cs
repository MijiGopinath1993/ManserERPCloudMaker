using System.ComponentModel.DataAnnotations;

namespace ERPCloudMaker.Models
{
    public class ProductUnits
    {
        [Key]
        public int Id { get; set; }
        public string? UnitName  { get; set; }
        public string? GSTRUnit  { get; set; }
        public string? UnitType  { get; set; }
        public string? FormalName  { get; set; }
        public DateTime? CreatedOn { get; set; }
        public Int16 Decimals { get; set; }

    }
}  
