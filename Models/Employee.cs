using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace ERPCloudMaker.Models
{
    public class Employees
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string? EmpID { get; set; }
        [StringLength(75)]
        public string? EmpName { get; set; }
        [StringLength(10)]
        public string? Gender { get; set; }
        public DateTime? DateofBirth { get; set; }
        [StringLength(50)]
        public string? Nationality { get; set; }
        [StringLength(75)]
        public string? Education { get; set; }
        public DateTime? DateofJoining { get; set; }
        [StringLength(75)]
        public string? Designation { get; set; }
        [StringLength(50)]
        public string? DepName { get; set; }
        [StringLength(75)]
        public string? TeamName { get; set; }
        [StringLength(50)]
        public string? Contracttype { get; set; }
        public DateTime? contractexpirydate { get; set; }
        public DateTime? DisconnectDate { get; set; }
        [StringLength(100)]
        public string? workingfor { get; set; }
        [StringLength(100)]
        public string? VisaFrom { get; set; }
        [StringLength(75)]
        public string? CostCat { get; set; }


        [StringLength(75)]
        public string? Empaddress { get; set; }
        [StringLength(50)]
        public string? EmpCity { get; set; }
        [StringLength(50)]
        public string? Empcontactno { get; set; }
        [StringLength(150)]
        public string? emailid { get; set; }


        [StringLength(75)]
        public string? Peraddress { get; set; }
        [StringLength(50)]
        public string? PerCity { get; set; }
        [StringLength(50)]
        public string? Percontactno1 { get; set; }
        [StringLength(50)]
        public string? Percontactno2 { get; set; }
        [StringLength(150)]
        public string? Peremailid { get; set; }


        [StringLength(100)]
        public string? RefName { get; set; }
        [StringLength(75)]
        public string? RefAddress { get; set; }
        [StringLength(50)]
        public string? RefCity { get; set; }
        [StringLength(50)]
        public string? RefContactNo1 { get; set; }
        [StringLength(50)]
        public string? RefContactNo2 { get; set; }
        [StringLength(150)]
        public string? RefEmailid { get; set; }
        [StringLength(150)]
        public string? RefNotes { get; set; }


        [StringLength(50)]
        public string? EmpPersonalID { get; set; }
        [StringLength(50)]
        public string? bankcode { get; set; }
        [StringLength(50)]
        public string? bankacno { get; set; }
        public Double? Basicsalary { get; set; }
        public Double? rateperhour { get; set; }
        [StringLength(20)]
        public string? SalaryType { get; set; }
        [StringLength(50)]
        public string? empbankname { get; set; }
        [StringLength(50)]
        public string? empbankacno { get; set; }
        [StringLength(50)]
        public string? empbankbranch { get; set; }
        [StringLength(50)]
        public string? bankifsccode { get; set; }
        [StringLength(50)]
        public string? bankmicrcode { get; set; }

        [StringLength(50)]
        public string? barcode { get; set; }
        public bool IsActive { get; set; }

    }
}
 