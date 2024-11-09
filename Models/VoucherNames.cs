using System.ComponentModel.DataAnnotations;

namespace ERPCloudMaker.Models
{
    public class VoucherNames
    {
        [Key]
        public int Id { get; set; }
        public string? VoucherName { get; set; }
        public string? Active {  get; set; }
        public DateTime? CreatedDate { get; set; }


    }
}
