using System.ComponentModel.DataAnnotations;

namespace ERPCloudMaker.Models
{
    public class ItemMaster
    {
        [Key]
        public int Id { get; set; } 
        public string? Location { get; set; }
        public string? StockCode  { get; set; }
        public string? StockName { get; set; }
        public string? StockGroup  { get; set; }
        public string? BarCode { get; set; } 
        public string? Quantity  { get; set; }
        public string? CostPrice { get; set; } 
        public string? Tax { get; set; }
        public string? RateInc { get; set; }
        public string? MRP  { get; set; }
        public string? Rrate { get; set; }
        public string? Wrate  { get; set; } 
        public string? ItemType  { get; set;}
        public string? HSN  { get; set;}
        public string? Brate { get; set;}
        public string? VATPercentage  { get; set;}
        public string? Packing  { get; set;}
        public string? Weight  { get; set;}
    }
}
