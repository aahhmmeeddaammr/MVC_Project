﻿using System.ComponentModel.DataAnnotations;

namespace App.PL.ViewModels
{
    public class SignUpViewModel
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        [MinLength(5, ErrorMessage = "Password is short")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirm Password is Required")]
        [Compare("Password", ErrorMessage = "Password Dosen't Match")]
        public string ConfirmPassword { get; set; }
        public bool IsAgree { get; set; }
    }
}
