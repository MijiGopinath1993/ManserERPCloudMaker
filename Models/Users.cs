using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCloudMaker.Models
{ 
    public class Users
    {
        [Key] 
        public int Id { get; set; }

       // [Column(TypeName = "NVARCHAR")]
        [StringLength(50)]
        public string? UserName  { get; set; }
         
        public byte[]? UserPassword   { get; set; } 
        public string? UserType { get; set; }

        [StringLength(50)]
        public string? UserEmailId  { get; set; }

        [StringLength(50)]
        public string? UserId  { get; set; }

        [StringLength(125)]
        public string? UserSecurityQ1 { get; set; }

        [StringLength(125)]
        public string? UserSecurityQ2 { get; set; }

        [StringLength(50)]
        public string? UserSecurityA1 { get; set; }

        [StringLength(50)]
        public string? UserSecurityA2 { get; set; }

        [StringLength(50)]
        public string? UserDepartment { get; set; }

        [StringLength(50)]
        public string? StoreName { get; set; }

        [StringLength(50)]
        public string? LocationName { get; set; }

        [StringLength(75)]
        public string? LoginSystemName { get; set; }
        public DateTime? LoginTime { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsLogin { get; set; }
        public DateTime? LogoutTime { get; set; }

        [StringLength(10)]
        public string? RCode { get; set; }

        [StringLength(50)]
        public string? SQLUserID { get; set; }
         
        public byte[]? SQLpwd { get; set; }
        public int? CounterID { get; set; }
 
        public string? UserPasswordHash { get; set; }
    }
}
