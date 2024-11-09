using System.ComponentModel.DataAnnotations;

namespace ERPCloudMaker.Models
{
    public class InvoiceNumberSettings
    {
        [Key]
        public int Id { get; set; }
        public string? Branch { get; set; }
        public string? VoucherName { get; set; }
        public string? printaftersave { get; set; }
        public string? printbarcodeaftersave { get; set; }
        public string? Invnumberingmethod { get; set; }
        public string? Allowduplicateinvno { get; set; }
        public int? Invnumberstart { get; set; }
        public int? MaxNoofdigits { get; set; }
        public string? Invoiceprefix { get; set; }
        public string? Invoicepostfix { get; set; }

    } 
}
