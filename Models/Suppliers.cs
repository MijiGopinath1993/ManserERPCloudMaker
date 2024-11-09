using System.ComponentModel.DataAnnotations;

namespace ERPCloudMaker.Models
{
    public class Suppliers
    {
        [Key]
        public int Id { get; set;}
        public string? SupplierCode { get; set;}
        public string? SupplierName { get; set; }
        public string? SupplierGroup { get; set; }
        public string? AccountType { get; set; }         
        public string? Currency { get; set; }         
        public string? Allowcostcentre { get; set; }
        public string? Tin { get; set; }
        public string? VatNumber { get; set; } 
        public string? Aadharnumber { get; set; }
        public string? BillingNoORAddress { get; set; } 
        public string? addressline2 { get; set; }
        public string? addressline3 { get; set; }
        public string? Location { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? Postalcode { get; set; }
        public string? Telnumber { get; set; }
        public string? Faxnumber { get; set; }
        public string? Emailid { get; set; }
        public string? Website { get; set; }

        public string? UploadImageName { get; set; }
        public string? creditlimit { get; set; }
        public string? payterms { get; set; }
        public string? Defaultdiscount { get; set; }
        public string? Pricelevel { get; set; }
        public string? monthlybudget { get; set; }


        public string? ContactpersonName { get; set; }
        public string? Designation { get; set; }
        public string? ConperTelnumber { get; set; }
        public string? MobileNo { get; set; }
        public string? ConperEmailId { get; set; } 
    } 
}
