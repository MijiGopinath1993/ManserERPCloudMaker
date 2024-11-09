using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ERPCloudMaker.Models
{ 
    public class Rule
    {
        [Key]
        public int RuleId { get; set; } 
        public int WorkflowId { get; set; }
        public int PropertyID { get; set; }
        public string RuleName { get; set; }
        public string SuccessEvent { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorType { get; set; }
        public string RuleExpressionType { get; set; }
        public string Expression { get; set; }

       
    }
}
