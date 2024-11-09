using System.ComponentModel.DataAnnotations;

namespace ERPCloudMaker.Models
{
    public class CustomerAddress
    {
        [Key]
        public int Id { get; set; } 
        public string? CustomerId { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? NameAr { get; set; }
        public string? ShortAddress { get; set; }
        public string? BuildingNo { get; set; }
        public string? StreetName { get; set; }
        public string? SecondaryNo { get; set; }
        public string? City  { get; set; }
        public string? District { get; set; }
        public string? State { get; set; }
        public string? PostalCode  { get; set; }
        public string? Country { get; set; }
        public string? TelNo  { get; set; } 
    
    }
}
