using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace project.Models
{
    public class Users
    {
        [Key] 
        public int Users_Id{get;set;} 

        [Required] 
        [StringLength(255)] 
        [DisplayName("Name")]
        public string Users_Name{get;set;} 

        [Required] 
        [StringLength(255)] 
        [DisplayName("Login")]
        public string Users_Logins{get;set;} 

        [Required] 
        [StringLength(255)] 
        [DisplayName("Password")]
        public string Users_Password{get;set;} 

        [DataType(DataType.Date)] 
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)] 
        public DateTime RegistrDate{get;set;} = Convert.ToDateTime(DateTime.Now.GetDateTimeFormats()[5]);

        public int StatusUsers_Id{get;set;} = 2;
        public StatusUsers StatusUsers{get;set;} 
    }
}