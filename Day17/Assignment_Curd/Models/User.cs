using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Assignment_Curd.Models
{
    public class User
    {
        [Required(ErrorMessage = "Enter your User Name")]
        public string UserName { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Enter your Email")]
        public string UserEmail { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter your Password")]
        public string UserPassword { get; set; }
        
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter your Confirm Password")]
        public string UserConfirmPassword { get; set; }
        [Required(ErrorMessage = "Enter your Full Name")]
        [StringLength(25, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string UserFullName { get; set; }
        [MaxLength(10, ErrorMessage = "Your mobNo must be 10 digit")]
        [Required(ErrorMessage = "Enter your Mobile Number")]
        public string UserPhone { get; set; }
        public int CityName { get; set; }
        public IEnumerable<SelectListItem> UserCity { get; set; }

        public bool RememberMe { get; set; }




















    }
}