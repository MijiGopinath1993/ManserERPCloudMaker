using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace ERPCloudMaker.Models
{
    public class Company
    {

        [Key]
        public int Id { get; set; }
        public string? Companyname { get; set; }
        public string? MailingName  { get; set; }
        public string? LicenseNo { get; set; }  
        public string? GSTNo { get; set; } 
        public string? VATNo { get; set; }  
        public string? Address1 { get; set; }
        public string? Address2  { get; set; } 
        public string? State  { get; set; } 
        public string? Country { get; set; }
        public string? Pincode  { get; set; }
        public string? TelNo  { get; set; }
        public string? FaxNo  { get; set; }
        public string? Emailid  { get; set; } 
        public string? BaseCurrency { get; set;}
        public string? Currencysymbol { get; set; } 
        public string? Decimalsymbol { get; set; }
        public string? DecialPlace  { get; set; }
        public string? ItemSizeColor { get; set; }
        public string? CompBankname { get; set; } 
        public string? CompAccNo  { get; set; }
        public string? CompBranch  { get; set; }


        public string? LogoImageFile { get; set; } 
        public string? DateFormat { get; set; }
        public DateTime? Accperiodfrom { get; set; }
        public DateTime? Accperiodto { get; set; }
        public DateTime? BookPeriodfrom  { get; set; }
        public DateTime? BookPeriodto  { get; set; } 

        public string? AdminUsername { get; set; }
        public string? Adminpassword { get; set; }
        public string? Confpassword { get; set; }
        public string? AdminEmailId { get; set; }
        public string? Imagefolderpath  { get; set; }


    }
}
