using System.ComponentModel.DataAnnotations;

namespace App.PL.ViewModels
{
	public class ResetPasswordViewModel
	{
		[Required(ErrorMessage = "Password is Required")]
		[MinLength(5, ErrorMessage = "Password is short")]
		public string Password { get; set; }
		[Required(ErrorMessage = "Confirm Password is Required")]
		[Compare("Password", ErrorMessage = "Password Dosen't Match")]
		public string ConfirmPassword { get; set; }
	}
}
