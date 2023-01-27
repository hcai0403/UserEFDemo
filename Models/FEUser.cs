using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UserEFDemo.Models
{
    public class FEUser
    {
        [Required(ErrorMessage = "Please enter your User Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your Email Address"), EmailAddress(ErrorMessage = "Please provide a valid Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your password"), MinLength(8, ErrorMessage = "Password is too short")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password"), Compare("Password", ErrorMessage = "Passwords don't match")]
        public string ConfirmPassword { get; set; }

        public int UID { get; set; }
    }
}