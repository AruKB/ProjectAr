
using System.ComponentModel.DataAnnotations;
namespace project.Models
{
    public class BlogsStatus
    {
        [Key] 
        public int BlogsStatus_Id{get;set;} 

        [Required] 
        [StringLength(255)] 
        public string Status{get;set;}
        // public ICollection<BLOGS> Blogs
    }
}