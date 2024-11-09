using System.ComponentModel.DataAnnotations;

namespace ERPCloudMaker.Models
{
    public class CustomerOpenBalance
    {
        [Key]
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? Date { get; set; }
        public string? Location { get; set; }
        public string? RefNo { get; set; }
        public string? VoucherNo  { get; set; }    
        public string? Type  { get; set; }    
        public float? Amount  { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }

    }
}
