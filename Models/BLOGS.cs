using System;
using System.ComponentModel.DataAnnotations;
namespace project.Models
{
    public class BLOGS
    {
        [Key] 
        public int BLOGS_Id{get;set;} 

        [Required] 
        [StringLength(255)] 
        public string Title{get;set;} 

        [Required] 
        [StringLength(255)] 
        public string Text{get;set;} 


        public int Users_Id{get;set;} 
        public Users Users{get;set;} 

        public int BlogsStatus_Id{get;set;} = 3;
        public BlogsStatus BlogsStatus{get;set;} 

        [DataType(DataType.Date)] 
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)] 
        public DateTime WritingDate{get;set;} = DateTime.Now;
    }
}