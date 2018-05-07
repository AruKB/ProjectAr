
using System.ComponentModel.DataAnnotations;
namespace project.Models
{
    public class StatusUsers
    {
        [Key] 
        public int StatusUsers_Id{get;set;} 


        [Required] 
        [StringLength(255)] 
        public string Status{get;set;}
    }
}