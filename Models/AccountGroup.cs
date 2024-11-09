using System.ComponentModel.DataAnnotations;

namespace ERPCloudMaker.Models
{
    public class AccountGroup
    {
        [Key]
        public int Id { get; set; }
        public string? Accountgroup { get; set; }
        public string? Undergroup { get; set; }
        public string? GroupType { get; set; }
        public DateTime? CreatedOn  { get; set; }


    }
}
